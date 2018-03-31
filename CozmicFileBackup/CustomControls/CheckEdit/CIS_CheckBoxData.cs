using System.Windows.Forms;

namespace CozmicFileBackup.CustomControls
{
    using System;
    using System.Collections.Generic;

    using DevExpress.Data.Helpers;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Controls;
    using DevExpress.XtraEditors.DXErrorProvider;


    public partial class CIS_CheckBoxData : DevExpress.XtraEditors.XtraUserControl
    {
        public CIS_CheckBoxData()
        {
            this.InitializeComponent();
            this.Validation = DataValidation.None;
        }

        public Control CaptionControl => this.Caption;

        public string CaptionValue => this.Caption.Text;

        public CheckedComboBoxEdit CheckBoxControl => this.CheckedComboBox;

        public string TextStringValue
        {
            set { }
            get
            {
                return this.CheckedComboBox.Text;
            }
        }
      
       
        public object TextValue => this.CheckedComboBox.EditValue;
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
        public void SetValue(List<CheckEditValue> values)
        {
            this.CheckBoxControl.Properties.Items.Clear();
            foreach (CheckEditValue v in values)
            {
                this.CheckBoxControl.Properties.Items.Add(v.Index, v.Caption, v.State, !v.IsReadOnly);
            }
        }

        /// <summary>
        /// <returns></returns>
        /// GetValue
        /// </summary>
        /// <returns></returns>
        public List<CheckEditValue> GetValue()
        {
            var values = this.CheckBoxControl.Properties.Items;
            var contListValues = new List<CheckEditValue>();
            int index = 0;
            foreach (CheckedListBoxItem v in values)
            {
                contListValues.Add(new CheckEditValue(index, v.Description, v.CheckState,v.Enabled));
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
            this.dxErrorProvider.SetError(this.CheckedComboBox, message, errType);
        }
    }

    public class CheckEditValue
    {
        public int Index { set; get; }
        public string Caption { set; get; }
        public CheckState State { set; get; }
        public bool IsReadOnly { set; get; }

        public CheckEditValue(int index , string caption , CheckState chState,bool readOnly)
        {
            Index = index;
            Caption = caption;
            State = chState;
            IsReadOnly = readOnly;
        }

    }
}