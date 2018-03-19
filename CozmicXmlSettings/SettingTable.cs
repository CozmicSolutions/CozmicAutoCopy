namespace CozmicXmlSettings
{
    using System.Data;

    public static class SettingTable
    {
        #region Public Methods

        /// <summary>
        ///      FillAutoCopyTable 
        /// </summary>
        /// <param name="setting"></param>
        /// <param name="name">   </param>
        /// <returns></returns>
        public static DataTable FillAutoCopyTable(AutoCopySetting setting, string name)
        {
            using (var tble = CreateAutoCopyTable(name))
            {
                tble.Rows.Add(
                    setting.SourcePath,
                    setting.DestinationPath,
                    setting.ArchivePath,
                    setting.RepeatEach,
                    setting.TransferType,
                    setting.ArchiveType);
                ;
                return tble;
            }
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        ///      CreateAutoCopyTable 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static DataTable CreateAutoCopyTable(string name)
        {
            var dtSettings = new DataTable(name);
            dtSettings.Columns.Add("SourcePath", typeof(string));
            dtSettings.Columns.Add("DestinationPath", typeof(string));
            dtSettings.Columns.Add("ArchivePath", typeof(string));
            dtSettings.Columns.Add("RepeatEach", typeof(string));
            dtSettings.Columns.Add("TransferType", typeof(string));
            dtSettings.Columns.Add("ArchiveType", typeof(string));
            return dtSettings;
        }

        #endregion Private Methods
    }
}