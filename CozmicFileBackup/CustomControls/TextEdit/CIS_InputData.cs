using System.Windows.Forms;

namespace CozmicFileBackup.CustomControls
{
    using DevExpress.XtraEditors.DXErrorProvider;

    public enum DataValidation
    {
        None = 0,
        NullOrEmpty = 1,
        Custom = 2
    }

    public partial class CIS_InputData : DevExpress.XtraEditors.XtraUserControl
    {
        public CIS_InputData()
        {
            this.InitializeComponent();
            this.Validation = DataValidation.None;
        }

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