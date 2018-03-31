using System.Windows.Forms;

namespace CozmicFileBackup.CustomControls
{
    using System;
    using System.Collections.Generic;

    using DevExpress.Data.Helpers;
    using DevExpress.XtraEditors.DXErrorProvider;


    public partial class CIS_DateTimeData : DevExpress.XtraEditors.XtraUserControl
    {
        public CIS_DateTimeData()
        {
            this.InitializeComponent();
            this.Validation = DataValidation.None;
        }

        public Control CaptionControl => this.Caption;

        public string CaptionValue => this.Caption.Text;

        public Control DateTimeControl => this.DateTimeBox;

        public string TextStringValue
        {
            set { }
            get
            {
                return this.DateTimeBox.DateTime.ToLongDateString();
            }
        }
      
       
        public object TextValue => this.DateTimeBox.EditValue;
        public DataValidation Validation { get; set; }

      

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
            this.DateTimeBox.Text = string.Empty;
            this.DateTimeBox.Text = text;
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
            this.dxErrorProvider.SetError(this.DateTimeBox, message, errType);
        }
    }
}