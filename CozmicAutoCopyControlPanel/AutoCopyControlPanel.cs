using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CozmicAutoCopyControlPanel
{
    using System.IO;
    using CozmicAutoCopyControlPanel.Task;
    using CozmicTaskFactory;
    using CozmicXmlSettings;

    public partial class AutoCopyControlPanel : Form
    {
        #region Private Fields

        private DataTable dtSettings = null;

        private AutoCopySetting MainSettings = null;

        #endregion Private Fields

        #region Public Constructors

        public AutoCopyControlPanel()
        {
            this.InitializeComponent();
            ValidateFolder(StaticString.SettingFolderPath);
            this.MainSettings = this.LoadSetting();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        ///      OnBrowse 
        /// </summary>
        /// <returns></returns>
        private static string OnBrowse()
        {
            using (var browse = new FolderBrowserDialog())
            {
                if (browse.ShowDialog() == DialogResult.OK)
                {
                    return browse.SelectedPath;
                }

                return string.Empty;
            }
        }

        /// <summary>
        ///      ValidateFolder 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private static bool ValidateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + Environment.NewLine + e.HelpLink);
                }
            }
            return Directory.Exists(path);
        }

        /// <summary>
        ///      btnBrowseArchivePath_Click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void btnBrowseArchivePath_Click(object sender, EventArgs e)
        {
            this.txtArchiveFolderPath.Text = OnBrowse();
        }

        /// <summary>
        ///      btnBrowseDestPath_Click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void btnBrowseDestPath_Click(object sender, EventArgs e)
        {
            this.txtDestinationPath.Text = OnBrowse();
        }

        /// <summary>
        ///      btnBrowseSourcePath_Click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void btnBrowseSourcePath_Click(object sender, EventArgs e)
        {
            this.txtSourcePath.Text = OnBrowse();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///      btnSave_Click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.OnSave();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        ///      CreateTask 
        /// </summary>
        private void CreateTask()
        {
            var helper = new TaskHelper();
            helper.Install(this.InitializeTask());
        }

        /// <summary>
        ///      DeleteTask 
        /// </summary>
        private void DeleteTask()
        {
            var helper = new TaskHelper();
            helper.Disable(this.InitializeTask());
        }

        /// <summary>
        ///      GetSettings 
        /// </summary>
        /// <returns></returns>
        private AutoCopySetting GetSettings()
        {
            return new AutoCopySetting()
            {
                SourcePath = this.txtSourcePath.Text,
                DestinationPath = this.txtDestinationPath.Text,
                ArchivePath = this.txtArchiveFolderPath.Text,
                RepeatEach = this.cmbRepatEach.Text,
                TransferType = this.cmbTransferType.Text,
                ArchiveType = this.cmbArchiveType.Text,
            };
        }

        /// <summary>
        ///      InitializeTask 
        /// </summary>
        /// <returns></returns>
        private List<RepetitiveTask> InitializeTask()
        {
            return
                new List<RepetitiveTask>
                      {
                          new RepetitiveTask
                              {
                                  Name = "CozmicAutoCopy",
                                  Description = "Copying Files From Source To Destination.",
                                  Path = Environment.CurrentDirectory+@"\CozmicAutoCopyControlPanel.exe",
                                  StartAt = DateTime.Now.AddSeconds(30),
                                  Interval =  TimeSpan.Parse(this.cmbRepatEach.Text),
                                  Parameters = @"--execute=true"
                              }
                      };
        }

        /// <summary>
        ///      LoadSetting 
        /// </summary>
        private AutoCopySetting LoadSetting()
        {
            if (!File.Exists(StaticString.SettingFileFullPath)) return new AutoCopySetting();
            var sett = XmlSettingReader.Load(StaticString.SettingFileFullPath);
            this.txtSourcePath.Text = sett.SourcePath;
            this.txtDestinationPath.Text = sett.DestinationPath;
            this.txtArchiveFolderPath.Text = sett.ArchivePath;
            this.cmbRepatEach.Text = sett.RepeatEach;
            this.cmbTransferType.Text = sett.TransferType;
            this.cmbArchiveType.Text = sett.ArchivePath;
            return sett;
        }

        /// <summary>
        ///      OnSave 
        /// </summary>
        private void OnSave()
        {
            if (ValidateFolder(this.GetSettings().DestinationPath)
                && ValidateFolder(this.GetSettings().ArchivePath))
            {
                this.SaveSettings();
                this.btnSave.Enabled = false;
                //this.CreateTask();
                MessageBox.Show(@"Setting has been saved successfully.", @"Saved");
            }
        }

        /// <summary>
        ///      OnTextChanged 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void OnTextChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
        }

        /// <summary>
        ///      SaveSettingsXml 
        /// </summary>
        private void SaveSettings()
        {
            XmlSettingWriter.Save(this.GetSettings(), StaticString.SettingFileFullPath);
        }

        #endregion Private Methods
    }
}