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
    public partial class CIS_CheckBox : DevExpress.XtraEditors.XtraUserControl
    {
        public object TextValue => this.CheckEditControl.EditValue;
        public string TextStringValue => this.CheckEditControl.Text;
        public string CaptionValue => this.Caption.Text;

        public CheckEdit CheckEditControl => this.CheckEditControl;

        public Control CaptionControl => this.Caption;

        public CIS_CheckBox()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// SetValue
        /// </summary>
        /// <param name="text"></param>
        public void SetValue(string text)
        {
            this.CheckEditControl.Text = string.Empty;
            this.CheckEditControl.Text = text;

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
