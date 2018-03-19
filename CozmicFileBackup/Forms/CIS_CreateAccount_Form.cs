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
    public partial class CIS_CreateAccount_Form : XtraForm
    {
        public CIS_CreateAccount_Form()
        {
            InitializeComponent();
            this.SetControlUI();
        }

        public void SetControlUI()
        {
            this.input_Username.SetCaption("Username");
            this.input_Password.SetCaption("Password");
            ((TextEdit)this.input_Password.TextControl).Properties.PasswordChar = '*';

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.input_Username.TextStringValue.Equals("Demo", StringComparison.CurrentCultureIgnoreCase)
                && this.input_Password.TextStringValue.Equals("Pass", StringComparison.CurrentCultureIgnoreCase))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Username/Password.");
            }
        }
    }
}
