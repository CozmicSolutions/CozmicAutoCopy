namespace CozmicAutoCopyService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Threading;

    public class TriggerTask
    {
        #region Private Fields

        private int counter = 0;
        private int RepeatTimes = 0;
        private int Seconds = 0;
        private Action TaskToExecute = null;
        private CozmicWorker threadWorker = null;

        #endregion Private Fields

        #region Private Properties

        private bool IsBusy { get; set; }

        #endregion Private Properties

        #region Public Methods

        /// <summary>
        ///      Start 
        /// </summary>
        /// <param name="action">     </param>
        /// <param name="seconds">    </param>
        /// <param name="repeatTimes"></param>
        /// <param name="index">      </param>
        /// <param name="name">       </param>
        public void Start(Action action, int seconds, int repeatTimes, int index = 1, string name = "")
        {
            try
            {
                Console.WriteLine(@"STARTING TASK....");
                this.TaskToExecute = action;
                this.InternalStart(seconds, repeatTimes, name, index);
                this.threadWorker.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        ///      Stop 
        /// </summary>
        public void Stop()
        {
            try
            {
                Console.WriteLine(@"STOPPING TASK....");
                this.threadWorker.Stop();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        ///      PrepareSender 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static object[] PrepareSender(params string[] values)
        {
            var dataList = new List<object>();

            foreach (var v in values)
            {
                dataList.Add(v);
            }

            return dataList.ToArray();
        }

        /// <summary>
        ///      ThreadWorker_ProgressChanged 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private static void ThreadWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var textToWrite = string.Empty;
            if (e.UserState != null)
            {
                try
                {
                    var data = ((object[])e.UserState)[0];
                    if (data != null)
                    {
                        textToWrite = data.ToString();
                    }
                }
                catch { }
            }

            Console.WriteLine(e.ProgressPercentage + @"%" + @"  " + textToWrite);
        }

        /// <summary>
        ///      ThreadWorker_RunWorkerCompleted 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private static void ThreadWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Console.WriteLine($@"WORKER WITH ID [{((BackgroundWorker)sender).ToString()}] CANCELED");
            }
            else if (e.Error != null)
            {
                Console.WriteLine(@"WORKER WITH ID [{0}] COMPLETED WITH ERRORS : " + Environment.NewLine + "{1}", ((BackgroundWorker)sender).ToString(), e.Error.Message);
            }
            else
                Console.WriteLine($@"WORKER WITH ID [{((BackgroundWorker)sender).ToString()}] COMPLETED");
        }

        /// <summary>
        ///      InternalStart 
        /// </summary>
        /// <param name="seconds">    </param>
        /// <param name="repeatTimes"></param>
        /// <param name="name">       </param>
        /// <param name="index">      </param>
        private void InternalStart(int seconds, int repeatTimes, string name, int index)
        {
            this.threadWorker = new CozmicWorker(index, name);
            this.Seconds = seconds;
            this.RepeatTimes = repeatTimes;
            this.threadWorker.DoWork += this.ThreadWorker_DoWork;
            this.threadWorker.ProgressChanged += ThreadWorker_ProgressChanged;
            this.threadWorker.RunWorkerCompleted += ThreadWorker_RunWorkerCompleted;
            this.ResetCounter();

            this.IsBusy = false;
        }

        /// <summary>
        ///      ResetCounter 
        /// </summary>
        private void ResetCounter()
        {
            this.counter = 0;
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void ThreadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine(@"WORK EXECUTED");

            this.IsBusy = true;
            if (((BackgroundWorker)sender).IsBusy)
            {
                try
                {
                    this.counter++;
                    ((BackgroundWorker)sender).ReportProgress(
                        this.counter,
                        PrepareSender(
                            string.Format(
                                "[{0}/{1}] -- Worker [{4}] WIth ID [{2}] -- Executed at [{3}]",
                                this.counter,
                                this.RepeatTimes,
                                this.threadWorker.ID,
                                DateTime.Now.ToUniversalTime().ToLocalTime(),
                                this.threadWorker.Name)));
                    this.TaskToExecute.Invoke();
                }
                catch (Exception exception)
                {
                    ((BackgroundWorker)sender).ReportProgress(this.counter, String.Format(
                        "ERROR : " + exception.Message + Environment.NewLine + exception.HelpLink));
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void ThreadWorker_DoWork1(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine(@"WORK EXECUTED");
            while (true)
            {
                this.IsBusy = true;

                try
                {
                    this.counter++;
                    ((BackgroundWorker)sender).ReportProgress(
                        this.counter,
                        PrepareSender(
                            string.Format(
                                "[{0}/{1}] -- Worker [{4}] WIth ID [{2}] -- Executed at [{3}]",
                                this.counter,
                                this.RepeatTimes,
                                this.threadWorker.ID,
                                DateTime.Now.ToUniversalTime().ToLocalTime(),
                                this.threadWorker.Name)));
                    this.TaskToExecute.Invoke();
                    Thread.Sleep(TimeSpan.FromSeconds(this.Seconds));
                    if (this.counter >= this.RepeatTimes)
                    {
                        break;
                    }
                }
                catch (Exception exception)
                {
                    ((BackgroundWorker)sender).ReportProgress(this.counter, String.Format(
                        "ERROR : " + exception.Message + Environment.NewLine + exception.HelpLink));
                    break;
                }
            }
        }

        #endregion Private Methods
    }
}