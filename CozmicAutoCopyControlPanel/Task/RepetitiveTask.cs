namespace CozmicAutoCopyControlPanel.Task
{
    using System;

    using Microsoft.Win32.TaskScheduler;

    public class RepetitiveTask
    {
        #region Public Properties

        public int DayOfMonth { get; set; }
        public DaysOfTheWeek DaysOfWeek { get; set; }
        public string Description { get; set; }
        public TimeSpan Interval { get; set; }
        public string Name { get; set; }
        public string Parameters { get; set; }
        public string Path { get; set; }
        public DateTime? StartAt { get; set; }
        public RepetitiveTaskType Type { get; set; }

        #endregion Public Properties
    }
}