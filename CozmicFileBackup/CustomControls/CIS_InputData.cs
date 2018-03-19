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
    public partial class CIS_InputData : DevExpress.XtraEditors.XtraUserControl
    {
        public object TextValue => this.Text.EditValue;

        public object CaptionValue => this.Caption.Text;

        public CIS_InputData()
        {
            this.InitializeComponent();
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
    }
}
