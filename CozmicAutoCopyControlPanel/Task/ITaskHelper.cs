namespace CozmicAutoCopyControlPanel.Task
{
    using System.Collections.Generic;

    public interface ITaskHelper
    {
        #region Public Methods

        void Disable(IEnumerable<RepetitiveTask> tasks);

        void Install(IEnumerable<RepetitiveTask> tasks);

        #endregion Public Methods
    }
}