namespace CozmicAutoCopyControlPanel.Task
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Threading;

    using Microsoft.Win32.TaskScheduler;

    public class TaskHelper : ITaskHelper
    {
        #region Public Events

        public event EventHandler<TaskEventArgs> TaskDeletedEvent;

        public event EventHandler<TaskEventArgs> TaskDisabledEvent;

        public event EventHandler<TaskEventArgs> TaskInstalledEvent;

        public event EventHandler<TaskEventArgs> WaitingForTaskToCompleteEvent;

        #endregion Public Events

        #region Public Methods

        public void Delete(IEnumerable<RepetitiveTask> tasks)
        {
            using (var ts = new TaskService())
            {
                foreach (var t in tasks)
                {
                    var task = ts.GetTask(t.Name);
                    if (task != null)
                    {
                        this.WaitForTaskToComplete(task, t);

                        ts.RootFolder.DeleteTask(t.Name);

                        this.OnTaskDeletedEvent(new TaskEventArgs { Task = t });
                    }
                }
            }
        }

        public void Disable(IEnumerable<RepetitiveTask> tasks)
        {
            using (var ts = new TaskService())
            {
                foreach (var t in tasks)
                {
                    var task = ts.GetTask(t.Name);
                    if (task != null)
                    {
                        this.WaitForTaskToComplete(task, t);

                        task.Enabled = false;
                        task.RegisterChanges();

                        this.OnTaskDisabledEvent(new TaskEventArgs { Task = t });
                    }
                }
            }
        }

        public void Install(IEnumerable<RepetitiveTask> tasks)
        {
            tasks = tasks.ToList();

            using (var ts = new TaskService())
            {
                var path = Assembly.GetEntryAssembly().Location;

                foreach (var t in tasks)
                {
                    var definition = ts.NewTask();
                    definition.Settings.Enabled = true;
                    definition.RegistrationInfo.Description = t.Description;

                    this.AddTrigger(definition, t);

                    definition.Actions.Add(new ExecAction(t.Path ?? path, t.Parameters, Path.GetDirectoryName(path)));

                    ts.RootFolder.RegisterTaskDefinition(
                        t.Name,
                        definition,
                        TaskCreation.CreateOrUpdate,
                        "SYSTEM",
                        null,
                        TaskLogonType.ServiceAccount);

                    this.OnTaskInstalledEvent(new TaskEventArgs { Task = t });
                }
            }
        }

        #endregion Public Methods

        #region Private Methods

        private void AddTrigger(TaskDefinition definition, RepetitiveTask task)
        {
            switch (task.Type)
            {
                case RepetitiveTaskType.Daily:
                    {
                        var trigger = (DailyTrigger)definition.Triggers.Add(new DailyTrigger());
                        trigger.StartBoundary = task.StartAt.HasValue ? task.StartAt.Value : DateTime.Now;
                    }
                    break;

                case RepetitiveTaskType.Weekly:
                    {
                        var trigger = (WeeklyTrigger)definition.Triggers.Add(new WeeklyTrigger(task.DaysOfWeek));
                        trigger.StartBoundary = task.StartAt.HasValue ? task.StartAt.Value : DateTime.Now;
                    }
                    break;

                case RepetitiveTaskType.Monthly:
                    {
                        var trigger = (MonthlyTrigger)definition.Triggers.Add(new MonthlyTrigger(task.DayOfMonth));
                        trigger.StartBoundary = task.StartAt.HasValue ? task.StartAt.Value : DateTime.Now;
                    }
                    break;

                case RepetitiveTaskType.Interval:
                    {
                        var trigger = (TimeTrigger)definition.Triggers.Add(new TimeTrigger());
                        trigger.StartBoundary = task.StartAt.HasValue ? task.StartAt.Value : DateTime.Now;
                        trigger.Repetition.Interval = task.Interval;
                    }
                    break;

                default:
                    throw new NotSupportedException("The task type is not supported.");
            }

            definition.Settings.StopIfGoingOnBatteries = false;
            definition.Settings.DisallowStartIfOnBatteries = false;
        }

        private void OnTaskDeletedEvent(TaskEventArgs e)
        {
            var handler = this.TaskDeletedEvent;
            if (handler != null) handler(this, e);
        }

        private void OnTaskDisabledEvent(TaskEventArgs e)
        {
            var handler = this.TaskDisabledEvent;
            if (handler != null) handler(this, e);
        }

        private void OnTaskInstalledEvent(TaskEventArgs e)
        {
            var handler = this.TaskInstalledEvent;
            if (handler != null) handler(this, e);
        }

        private void OnWaitingForTaskToCompleteEvent(TaskEventArgs e)
        {
            var handler = this.WaitingForTaskToCompleteEvent;
            if (handler != null) handler(this, e);
        }

        private void WaitForTaskToComplete(Task task, RepetitiveTask t)
        {
            while (task.State == TaskState.Running)
            {
                this.OnWaitingForTaskToCompleteEvent(new TaskEventArgs { Task = t });
                Thread.Sleep(500);
            }
        }

        #endregion Private Methods
    }
}