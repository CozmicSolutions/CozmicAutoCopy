namespace CozmicAutoCopyControlPanel.Task
{
    using System;

    public class TaskEventArgs : EventArgs
    {
        #region Public Properties

        public RepetitiveTask Task { get; set; }

        #endregion Public Properties
    }
}