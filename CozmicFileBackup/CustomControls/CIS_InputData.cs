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

    public partial class CIS_InputData : DevExpress.XtraEditors.XtraUserControl
    {
        public object TextValue => this.Text.EditValue;
        public string TextStringValue => this.Text.Text;
        public string CaptionValue => this.Caption.Text;
        public DataValidation Validation { set; get; }
        public Control TextControl => this.Text;

        public Control CaptionControl => this.Caption;

        public CIS_InputData()
        {
            this.InitializeComponent();
            this.Validation=DataValidation.None;
            
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

    }

    public enum DataValidation
    {
        None=0,
        NullOrEmpty=1,
        Custom=2
    }
}
