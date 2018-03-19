namespace CozmicAutoCopyService
{
    using System;

    using CozmicTaskFactory;

    using CozmicXmlSettings;

    /// <summary>
    ///      AutoCopyDependency 
    /// </summary>
    public class AutoCopyDependency : IAutoCopyDependency
    {
        #region Public Constructors

        public AutoCopyDependency()
        {
            this.RepeatCount = -1;
            this.CopySettings = XmlSettingReader.Load(StaticString.SettingFileFullPath);
            this.Secounds = Int32.Parse(this.CopySettings.RepeatEach);
        }

        #endregion Public Constructors

        #region Public Properties

        public AutoCopySetting CopySettings { get; set; }

        #endregion Public Properties

        #region Private Properties

        private int RepeatCount { get; set; }
        private int Secounds { get; set; }

        #endregion Private Properties
    }
}