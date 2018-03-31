using System.Windows.Forms;

namespace CozmicFileBackup.CustomControls
{
    using System.Collections.Generic;

    using DevExpress.Data.Helpers;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.DXErrorProvider;


    public partial class CIS_ComboBoxData : DevExpress.XtraEditors.XtraUserControl
    {
        public CIS_ComboBoxData()
        {
            this.InitializeComponent();
            this.Validation = DataValidation.None;
        }

        public Control CaptionControl => this.Caption;

        public string CaptionValue => this.Caption.Text;

        public ComboBoxEdit ComboBoxControl => this.ComboListBox;

        public List<string> TextStringValue
        {
            set { }
            get
            {
                return this.GetValue();
            }
        }
      
       
        public object TextValue => this.ComboListBox.EditValue;
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
            this.ComboListBox.Text = string.Empty;
            this.ComboListBox.Text = text;
        }

        public List<string> GetValue()
        {
            var values = this.ComboListBox.Properties.Items;
            var contListValues = new List<string>();
            foreach (var v  in values)
            {
                contListValues.Add(v.ToString());
            }
            return contListValues;
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
            this.dxErrorProvider.SetError(this.ComboListBox, message, errType);
        }

    
    }
}