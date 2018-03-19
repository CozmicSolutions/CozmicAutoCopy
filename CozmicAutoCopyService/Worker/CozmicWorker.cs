namespace CozmicAutoCopyService
{
    using System;
    using System.ComponentModel;
    using System.Threading;

    public class CozmicWorker
    {
        #region Public Fields

        public int Index = 0;

        #endregion Public Fields

        #region Public Constructors

        public CozmicWorker(int index)
        {
            this.ID = Guid.NewGuid();
            this.Index = index;
            this.Name = "Worker_" + this.ID.ToString().Substring(0, 5);
            this.InitWorker();
        }

        public CozmicWorker(int index, string name = "")
        {
            this.ID = Guid.NewGuid();
            this.Index = index;
            this.Name = name;
            if (string.IsNullOrEmpty(this.Name)) this.Name = "Worker_" + this.ID.ToString().Substring(0, 5);

            this.InitWorker();
        }

        #endregion Public Constructors

        #region Public Events

        public event DoWorkEventHandler DoWork;

        public event ProgressChangedEventHandler ProgressChanged;

        public event RunWorkerCompletedEventHandler RunWorkerCompleted;

        #endregion Public Events

        #region Public Properties

        public Guid ID { get; set; }
        public string Name { get; set; }

        #endregion Public Properties

        #region Private Properties

        private BackgroundWorker Worker { get; set; }

        #endregion Private Properties

        #region Public Methods

        /// <summary>
        ///      ReportProgress 
        /// </summary>
        /// <param name="percentage"></param>
        /// <param name="data">      </param>
        public void ReportProgress(int percentage, object[] data)
        {
            this.Worker.ReportProgress(percentage, data);
        }

        /// <summary>
        ///      ReportProgress 
        /// </summary>
        /// <param name="percentage"></param>
        public void ReportProgress(int percentage)
        {
            this.Worker.ReportProgress(percentage);
        }

        /// <summary>
        ///      Start 
        /// </summary>
        /// <param name="argument"></param>
        public void Start(object argument = null)
        {
            if (this.Worker != null && !this.Worker.IsBusy)
            {
                this.Worker.RunWorkerAsync(argument);
            }
        }

        /// <summary>
        ///      Stop 
        /// </summary>
        public void Stop()
        {
            while (this.Worker.IsBusy)
            {
                if (this.Worker.IsBusy)
                {
                    if (!this.Worker.CancellationPending)
                    {
                        this.Worker.CancelAsync();
                    }

                    Thread.Sleep(TimeSpan.FromSeconds(3));
                }
                else break;
            }
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        ///      CreateWorker 
        /// </summary>
        /// <param name="supportsCancellation"></param>
        /// <param name="reportsProgress">     </param>
        /// <returns></returns>
        private void InitWorker(bool supportsCancellation = true, bool reportsProgress = true)
        {
            this.Worker = null;
            using (BackgroundWorker worker = new BackgroundWorker())
            {
                worker.WorkerReportsProgress = reportsProgress;
                worker.WorkerSupportsCancellation = supportsCancellation;
                worker.DoWork += this.OnDoWork;
                worker.ProgressChanged += this.OnProgressChanged;
                worker.RunWorkerCompleted += this.OnRunWorkerCompleted;
                this.Worker = worker;
            }
        }

        /// <summary>
        ///      OnDoWork 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void OnDoWork(object sender, DoWorkEventArgs e)
        {
            this.DoWork?.Invoke(sender, e);
        }

        /// <summary>
        ///      OnProgressChanged 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void OnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.ProgressChanged?.Invoke(sender, e);
        }

        /// <summary>
        ///      OnRunWorkerCompleted 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void OnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.RunWorkerCompleted?.Invoke(sender, e);
        }

        #endregion Private Methods
    }
}