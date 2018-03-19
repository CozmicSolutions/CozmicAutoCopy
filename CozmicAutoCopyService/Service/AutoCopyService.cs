namespace CozmicAutoCopyService
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using CozmicAutoCopyControlPanel;

    public class AutoCopyService
    {
        #region Private Fields

        private readonly IAutoCopyDependency _copySettings;

        private int counter = 0;

        private int RepeatTimes = 0;

        private int Seconds = 0;

        #endregion Private Fields

        #region Public Constructors

        public AutoCopyService(IAutoCopyDependency copySettings)
        {
            this._copySettings = copySettings;
            this.RepeatTimes = -1;
            var set = ((AutoCopyDependency)this._copySettings).CopySettings;
            this.Seconds = Int32.Parse(set.RepeatEach);
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        ///      Start 
        /// </summary>
        /// <returns></returns>
        public bool Start()
        {
            int tempRepTime = this.RepeatTimes;
            Console.WriteLine(@"CozmicAutoCopy Service Started.");
            Console.WriteLine(@"Source Path: {0}", ((AutoCopyDependency)this._copySettings).CopySettings.SourcePath);
            Console.WriteLine(@"Target Path: {0}", ((AutoCopyDependency)this._copySettings).CopySettings.DestinationPath);
            var trigTask = new TriggerTask();
            while (true)
            {
                if (tempRepTime == -1)
                    this.RepeatTimes = this.counter + 10;

                try
                {
                    this.counter++;
                    var task = Task.Factory.StartNew(
                        () => trigTask.Start(this.StartCopyAction, this.Seconds, this.RepeatTimes, 1, "Worker1"));
                    if (!task.IsCompleted)
                        task.Wait();
                    Thread.Sleep(TimeSpan.FromSeconds(this.Seconds));
                    if (this.counter >= this.RepeatTimes)
                    {
                        break;
                    }
                }
                catch { break; }
            }
            return this._copySettings != null;
        }

        /// <summary>
        ///      StartCopyAction 
        /// </summary>
        public void StartCopyAction()
        {
            using (var form = new AutoCopyProgress())
            {
                form.ShowDialog();
            }
        }

        public bool Stop()
        {
            return this._copySettings != null;
        }

        #endregion Public Methods
    }
}