using System;
using System.Windows.Forms;

namespace CozmicFileBackup.CustomControls
{
    using DevExpress.XtraEditors.DXErrorProvider;

    public enum BrowseType
    {
        File = 1,
        Folder = 2
    }

    public partial class CIS_BrowsePath : DevExpress.XtraEditors.XtraUserControl
    {
        public CIS_BrowsePath()
        {
            this.InitializeComponent();
            this.Validation = DataValidation.None;
            this.BrowseDialogType = BrowseType.File;
        }

        public BrowseType BrowseDialogType { get; set; }

        public Control ButtControl => this.Button;
        public Control CaptionControl => this.Caption;
        public string CaptionValue => this.Caption.Text;
        public Control TextControl => this.Text;
        public string TextStringValue => this.Text.Text;
        public object TextValue => this.Text.EditValue;
        public DataValidation Validation { get; set; }

        /// <summary>
        ///      IsValid 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errType"></param>
        /// <returns></returns>
        public bool IsValid(string message = "", ErrorType errType = ErrorType.Default)
        {
            var valid = true;

            if (this.Validation == DataValidation.None) return valid;

            if (this.Validation == DataValidation.NullOrEmpty)
            {
                if (string.IsNullOrEmpty(this.TextStringValue))
                {
                    this.SetErrorMessage("Value can not be empty");
                    valid = false;
                }
            }
            else if (this.Validation == DataValidation.Custom)
            {
                this.SetErrorMessage(message, errType);
                valid = false;
            }

            if (valid)
            {
                this.ClearErrorMessage();
                valid = true;
            }

            return valid;
        }

        /// <summary>
        ///      / 
        /// </summary>
        /// <param name="type"></param>
        public void SetBrowseType(BrowseType type)
        {
            this.BrowseDialogType = type;
        }

        /// <summary>
        ///      SetCaption 
        /// </summary>
        /// <param name="text"></param>
        public void SetCaption(string text)
        {
            this.Caption.Text = string.Empty;
            this.Caption.Text = text;
        }

        /// <summary>
        ///      SetValidation 
        /// </summary>
        /// <param name="validation"></param>
        public void SetValidation(DataValidation validation)
        {
            this.Validation = validation;
        }

        /// <summary>
        ///      SetValue 
        /// </summary>
        /// <param name="text"></param>
        public void SetValue(string text)
        {
            this.Text.Text = string.Empty;
            this.Text.Text = text;
        }

        /// <summary>
        ///      BrowseFolder 
        /// </summary>
        private void BrowseFile()
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.Text.Text = dialog.FileName;
            }
        }

        /// <summary>
        ///      BrowseFolder 
        /// </summary>
        private void BrowseFolder()
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.Text.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        ///      /Button_Click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void Button_Click(object sender, EventArgs e)
        {
            if (this.BrowseDialogType == BrowseType.File)
            {
                this.BrowseFile();
            }
            else if (this.BrowseDialogType == BrowseType.Folder)
            {
                this.BrowseFolder();
            }
        }

        /// <summary>
        ///      ClearErrorMessage 
        /// </summary>
        private void ClearErrorMessage()
        {
            this.dxErrorProvider.ClearErrors();
        }

        /// <summary>
        ///      SetErrorMessage 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errType"></param>
        private void SetErrorMessage(string message, ErrorType errType = ErrorType.Default)
        {
            this.dxErrorProvider.SetError(this.Text, message, errType);
        }
    }
}