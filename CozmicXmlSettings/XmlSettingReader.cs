namespace CozmicXmlSettings
{
    using System;
    using System.Data;
    using CozmicTaskFactory;

    public static class XmlSettingReader
    {
        #region Public Methods

        /// <summary>
        ///      Load 
        /// </summary>
        /// <param name="yourPath"></param>
        /// <returns></returns>
        public static AutoCopySetting Load(string yourPath)
        {
            var table = new DataTable(StaticString.SettingTableName);
            try
            {
                var lstNode = new DataSet();
                lstNode.ReadXml(yourPath);
                table = lstNode.Tables[StaticString.SettingTableName];
                var setting =
                    new AutoCopySetting
                    {
                        SourcePath = table.Rows[0][StaticString.SourcePath].ToString(),
                        DestinationPath = table.Rows[0][StaticString.DestinationPath].ToString(),
                        ArchivePath = table.Rows[0][StaticString.ArchivePath].ToString(),
                        RepeatEach = table.Rows[0][StaticString.RepeatEach].ToString(),
                        TransferType = table.Rows[0][StaticString.TransferType].ToString(),
                        ArchiveType = table.Rows[0][StaticString.ArchiveType].ToString(),
                    };
                return setting;
            }
            catch (Exception ex)
            {
                return new AutoCopySetting();
            }
        }

        #endregion Public Methods
    }
}