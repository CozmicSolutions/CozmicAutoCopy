using System;
using System.Windows.Forms;

namespace CozmicFileBackup.CustomControls
{
    public partial class CIS_LogData : DevExpress.XtraEditors.XtraUserControl
    {
        public CIS_LogData()
        {
            this.InitializeComponent();
        }

        public Control CaptionControl => this.Caption;
        public string CaptionValue => this.Caption.Text;
        public Control TextControl => this.Text;
        public string TextStringValue => this.Text.Text;
        public object TextValue => this.Text.EditValue;

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
        ///      SetValue 
        /// </summary>
        /// <param name="text">         </param>
        /// <param name="addToExisting"></param>
        public void SetValue(string text, bool addToExisting = true)
        {
            if (!addToExisting)
                this.Text.Text = string.Empty;

            if (!string.IsNullOrEmpty(this.Text.Text))
            {
                if (!text.EndsWith(Environment.NewLine)) text = text + Environment.NewLine;
            }

            this.Text.Text += text;
        }
    }
}