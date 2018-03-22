using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CozmicFileBackup.CustomControls
{
    using DevExpress.XtraEditors.DXErrorProvider;

    public partial class CIS_BrowsePath : DevExpress.XtraEditors.XtraUserControl
    {
        public object TextValue => this.Text.EditValue;
        public string TextStringValue => this.Text.Text;
        public string CaptionValue => this.Caption.Text;
        public DataValidation Validation { set; get; }
        public BrowseType BrowseDialogType { set; get; }
        public Control TextControl => this.Text;
        public Control ButtControl => this.Button;
        public Control CaptionControl => this.Caption;

        public CIS_BrowsePath()
        {
            this.InitializeComponent();
            this.Validation=DataValidation.None;
            this.BrowseDialogType = BrowseType.File;
        }

        /// <summary>
        /// SetValidation
        /// </summary>
        /// <param name="validation"></param>
        public void SetValidation(DataValidation validation)
        {
            this.Validation = validation;
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="type"></param>
        public void SetBrowseType(BrowseType type)
        {
            this.BrowseDialogType = type;

        }

        /// <summary>
        /// SetValue
        /// </summary>
        /// <param name="text"></param>
        public void SetValue(string text)
        {
            this.Text.Text = string.Empty;
            this.Text.Text = text;

        }

        /// <summary>
        /// SetCaption
        /// </summary>
        /// <param name="text"></param>
        public void SetCaption(string text)
        {
            this.Caption.Text = string.Empty;
            this.Caption.Text = text;

        }

        /// <summary>
        /// IsValid
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errType"></param>
        /// <returns></returns>
        public bool IsValid(string message = "" , ErrorType errType = ErrorType.Default)
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
        /// SetErrorMessage
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errType"></param>
        private void SetErrorMessage(string message , ErrorType errType = ErrorType.Default)
        {
            this.dxErrorProvider.SetError(this.Text, message , errType);
        }

        /// <summary>
        /// ClearErrorMessage
        /// </summary>
        private void ClearErrorMessage()
        {
            this.dxErrorProvider.ClearErrors();
        }

        /// <summary>
        /// BrowseFolder
        /// </summary>
        void BrowseFolder()
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.Text.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// BrowseFolder
        /// </summary>
        void BrowseFile()
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.Text.Text = dialog.FileName;
            }
        }

        /// <summary>
        /// /Button_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
    }

    public enum BrowseType

    {
        File=1,
        Folder=2
    }
  
}
