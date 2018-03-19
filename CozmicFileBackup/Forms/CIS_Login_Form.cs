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

namespace CozmicFileBackup.Forms
{
    public partial class CIS_Login_Form : DevExpress.XtraEditors.XtraUserControl
    {
        public CIS_Login_Form()
        {
            InitializeComponent();
            this.SetControlUI();
        }

        public void SetControlUI()
        {
            this.input_Username.SetCaption("Username");
            this.input_Password.SetCaption("UserName");
        }
    }
}
