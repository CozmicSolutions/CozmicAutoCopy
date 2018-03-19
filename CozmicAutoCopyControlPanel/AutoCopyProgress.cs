using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CozmicAutoCopyControlPanel
{
    using System.Drawing;
    using System.IO;
    using System.Threading;

    using CozmicTaskFactory;

    using CozmicXmlSettings;

    using Ionic.Zip;

    public enum LoadingFormSize
    {
        FullSize = 0,
        CompactSize = 1
    }

    public enum TransferType
    {
        Copy = 1,
        Move = 2,
        CopyArchive = 3,
        MoveArchive = 4
    }

    public partial class AutoCopyProgress : Form
    {
        #region Private Fields

        private bool AddArchive = false;
        private LoadingFormSize CurrentFormSize = LoadingFormSize.FullSize;
        private List<string> DestFolderFiles = new List<string>();
        private AutoCopySetting MainSettings = null;
        private List<string> SourceFolderFiles = new List<string>();

        private BackgroundWorker worker = null;

        #endregion Private Fields

        #region Public Constructors

        public AutoCopyProgress()
        {
            this.InitializeComponent();
            this.ChangFormSize(LoadingFormSize.CompactSize);
            this.MainSettings = LoadSetting();
            this.SourceFolderFiles = GetFolderFileList(this.SourceFolderPath);
            this.progressBar.Maximum = this.SourceFolderFiles.Count;
        }

        public AutoCopyProgress(AutoCopySetting settings)
        {
            this.InitializeComponent();
            this.ChangFormSize(LoadingFormSize.CompactSize);
            this.MainSettings = settings;
            this.SourceFolderFiles = GetFolderFileList(this.SourceFolderPath);
            this.progressBar.Maximum = this.SourceFolderFiles.Count;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// ArchiveFolderPath
        /// </summary>
        public string ArchiveFolderPath
        {
            get
            {
                return this.MainSettings.ArchivePath;
            }
        }

        /// <summary>
        /// DestFolderPath
        /// </summary>
        public string DestFolderPath
        {
            get
            {
                return this.MainSettings.DestinationPath;
            }
        }

        /// <summary>
        /// FileTransferType
        /// </summary>
        public TransferType FileTransferType
        {
            get
            {
                if (this.MainSettings.TransferType == "COPY")
                {
                    this.AddArchive = false;
                    return TransferType.Copy;
                }

                if (this.MainSettings.TransferType == "MOVE")
                {
                    this.AddArchive = false;
                    return TransferType.Move;
                }

                if (this.MainSettings.TransferType == "MOVE/ARCHIVE")
                {
                    this.AddArchive = true;
                    return TransferType.MoveArchive;
                }

                if (this.MainSettings.TransferType == "COPY/ARCHIVE")
                {
                    this.AddArchive = true;
                    return TransferType.CopyArchive;
                }

                return TransferType.Copy;
            }
        }

        /// <summary>
        /// SourceFolderPath
        /// </summary>
        public string SourceFolderPath
        {
            get
            {
                return this.MainSettings.SourcePath;
            }
        }

        #endregion Public Properties

        #region Private Methods

        /// <summary>
        ///      LoadSetting 
        /// </summary>
        private static AutoCopySetting LoadSetting()
        {
            if (!File.Exists(StaticString.SettingFileFullPath)) return new AutoCopySetting();
            return XmlSettingReader.Load(StaticString.SettingFileFullPath);
        }

        #endregion Private Methods

        #region Private Methods

        public void CompressArchiveFiles()
        {
            var fileNameList = Directory.GetFiles(this.ArchiveFolderPath + @"\").ToList();

            if (!fileNameList.Any()) return;

            using (var zip = new ZipFile())
            {
                var newFolderName = DateTime.Today.ToFileTimeUtc().ToString().Replace("0", string.Empty);

                var archiveFolderPath = this.ArchiveFolderPath + @"\" + newFolderName;

                var folderIndex = 1;

                var tempfolderPath = archiveFolderPath;

                while (Directory.Exists(archiveFolderPath))
                {
                    archiveFolderPath = tempfolderPath + "_" + folderIndex;
                    folderIndex++;
                }

                if (!Directory.Exists(archiveFolderPath))
                {
                    Directory.CreateDirectory(archiveFolderPath);
                }

                zip.TempFileFolder = archiveFolderPath;

                zip.Comment =
                    $"This zip archive was created by the CozmicAutoCopy for application on machine '{System.Net.Dns.GetHostName()}'";

                zip.AddFiles(fileNameList);

                //zip.AddDirectory(this.ArchiveFolderPath);

                zip.Save(archiveFolderPath + @"\Archive.zip");
            }

            foreach (var file in fileNameList)
            {
                try
                {
                    var extension = Path.GetExtension(file);

                    if (extension != null && extension.Contains("zip")) continue;

                    File.Delete(file);
                }
                catch { }
            }
        }

        /// <summary>
        ///      GetFolderFileList 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private static List<string> GetFolderFileList(string path)
        {
            if (Directory.Exists(path))
                return Directory.GetFiles(path).ToList();
            return new List<string>();
        }

        /// <summary>
        ///      AutoCopyProgress_Shown 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void AutoCopyProgress_Shown(object sender, EventArgs e)
        {
            this.InitWorkerThread();
            this.worker.RunWorkerAsync();
           // this.WindowState = FormWindowState.Maximized;
            //this.notifyIcon.ShowBalloonTip(15,@"Sync Folders",@"Copying Files Please Wait",ToolTipIcon.Info);
            //this.notifyIcon.Visible = true;
            //this.ShowInTaskbar = true;
            //this.notifyIcon.ShowBalloonTip(1000);
        }

        /// <summary>
        ///      CopyToArchive 
        /// </summary>
        /// <param name="fullPath"></param>
        private void CopyToArchive(string fullPath)
        {
            var archiveFullPath = this.ArchiveFolderPath + @"\" + Path.GetFileName(fullPath);

            if (!File.Exists(archiveFullPath))
            {
                File.Copy(fullPath, archiveFullPath);
            }
        }

        /// <summary>
        ///      InitWorkerThread 
        /// </summary>
        private void InitWorkerThread()
        {
            this.worker = new BackgroundWorker();
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += this.Worker_DoWork;
            this.worker.ProgressChanged += this.Worker_ProgressChanged;
             this.worker.RunWorkerCompleted += this.Worker_RunWorkerCompleted;
        }

        /// <summary>
        ///      StartCopy 
        /// </summary>
        /// <param name="archive"></param>
        private void StartCopy(bool archive)
        {
            if (this.SourceFolderFiles.Any())
            {
                foreach (var sourceFile in this.SourceFolderFiles)
                {
                    if (archive)
                    {
                        this.CopyToArchive(sourceFile);
                    }

                    var destFullPath = this.DestFolderPath + @"\" + Path.GetFileName(sourceFile);

                    if (File.Exists(destFullPath))
                    {
                        this.DestFolderFiles.Add(destFullPath);
                        var arg = new List<object>() { sourceFile, destFullPath };
                        this.worker.ReportProgress(this.DestFolderFiles.Count, arg);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        continue;
                    }

                    File.Copy(sourceFile, destFullPath);

                    if (File.Exists(destFullPath))
                    {
                        this.DestFolderFiles.Add(destFullPath);
                        var arg = new List<object>() { sourceFile, destFullPath };
                        this.worker.ReportProgress(this.DestFolderFiles.Count, arg);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                    }
                }
            }
        }

        /// <summary>
        ///      StartMove 
        /// </summary>
        /// <param name="archive"></param>
        private void StartMove(bool archive)
        {
            if (this.SourceFolderFiles.Any())
            {
                foreach (var sourceFile in this.SourceFolderFiles)
                {
                    if (archive)
                    {
                        this.CopyToArchive(sourceFile);
                    }

                    var destFullPath = this.DestFolderPath + @"\" + Path.GetFileName(sourceFile);

                    if (File.Exists(destFullPath))
                    {
                        this.DestFolderFiles.Add(destFullPath);
                        var arg = new List<object>() { sourceFile, destFullPath };
                        this.worker.ReportProgress(this.DestFolderFiles.Count, arg);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        continue;
                    }

                    File.Move(sourceFile, destFullPath);

                    if (File.Exists(destFullPath))
                    {
                        this.DestFolderFiles.Add(destFullPath);
                        var arg = new List<object>() { sourceFile, destFullPath };
                        this.worker.ReportProgress(this.DestFolderFiles.Count, arg);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                    }
                }
            }
        }

        /// <summary>
        ///      InitProcess 
        /// </summary>
        private void StartProcess()
        {
            switch (this.FileTransferType)
            {
                case TransferType.Copy:
                    this.StartCopy(this.AddArchive);

                    break;

                case TransferType.Move:
                    this.StartMove(this.AddArchive);
                    break;

                case TransferType.CopyArchive:
                    this.StartCopy(this.AddArchive);
                    break;

                case TransferType.MoveArchive:
                    this.StartMove(this.AddArchive);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
            if (this.AddArchive) this.CompressArchiveFiles();
        }

        /// <summary>
        ///      Worker_DoWork 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                this.StartProcess();
            }
            catch { }
               
          
        }

        /// <summary>
        ///      Worker_ProgressChanged 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            List<object> recArgs = null;

            if (this.worker == null) return;

            if (e.UserState != null)
            {
                recArgs = (List<object>)e.UserState;
            }

            this.progressBar.Value = e.ProgressPercentage;
            if (recArgs != null && e.ProgressPercentage != 1000)
            {
                this.lblSourcePath.Text = recArgs[0].ToString();
                this.lblDestPath.Text = recArgs[1].ToString();
                this.lblProgressCount.Text = "[" + e.ProgressPercentage + @"\" + this.SourceFolderFiles.Count() + "]";
            }
            else
            {
                this.lblProgressCount.Text = @"Please Wait Finalizing Process.....";
            }
        }

        /// <summary>
        ///      Worker_RunWorkerCompleted 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled || e.Error != null) this.Close();

                if (this.worker == null) this.Close(); 
             

                while (this.worker.IsBusy)
                {
                    this.worker.ReportProgress(1000);
                }

                if (!this.worker.IsBusy) this.Close();
            }
            catch { }



        }

        #endregion Private Methods

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            if (this.CurrentFormSize == LoadingFormSize.FullSize) this.ChangFormSize(LoadingFormSize.CompactSize);
            else if (this.CurrentFormSize == LoadingFormSize.CompactSize) this.ChangFormSize(LoadingFormSize.FullSize);
        }

        /// <summary>
        /// </summary>
        /// <param name="frmSize"></param>
        private void ChangFormSize(LoadingFormSize frmSize)
        {
            this.CurrentFormSize = frmSize;
            if (frmSize == LoadingFormSize.FullSize)
            {
                this.Size = new Size(656, 222);
                this.grpDetails.Visible = true;
                this.lblProgressCount.Location = new Point(286, 1);
            }
            else if (frmSize == LoadingFormSize.CompactSize)
            {
                this.Size = new Size(353, 99);
                this.grpDetails.Visible = false;
                this.lblProgressCount.Location = new Point(140, 1);
            }
        }
    }
}