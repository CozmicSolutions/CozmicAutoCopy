namespace CozmicXmlSettings
{
    using System.IO;

    using CozmicTaskFactory;

    public static class XmlSettingWriter
    {
        #region Public Methods

        /// <summary>
        ///      Save 
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="path">    </param>
        public static void Save(AutoCopySetting settings, string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            var dtSettings = SettingTable.FillAutoCopyTable(settings, StaticString.SettingTableName);
            using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
            {
                dtSettings.WriteXml(stream);
            }
        }

        #endregion Public Methods
    }
}