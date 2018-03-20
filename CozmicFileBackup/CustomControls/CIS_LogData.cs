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
    public partial class CIS_LogData : DevExpress.XtraEditors.XtraUserControl
    {
        public object TextValue => this.Text.EditValue;
        public string TextStringValue => this.Text.Text;
        public string CaptionValue => this.Caption.Text;

        public Control TextControl => this.Text;

        public Control CaptionControl => this.Caption;

        public CIS_LogData()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// SetValue
        /// </summary>
        /// <param name="text"></param>
        /// <param name="addToExisting"></param>
        public void SetValue(string text ,bool addToExisting = true)
        {
            if(!addToExisting)
                this.Text.Text = string.Empty;
        
                if (!string.IsNullOrEmpty(this.Text.Text))
                {
                    if (!text.EndsWith(Environment.NewLine)) text = text + Environment.NewLine;
                }
                    this.Text.Text += text;
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
    }
}
