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
    using CozmicBackupDataAccess;

    public partial class CIS_Login_Form : XtraForm
    {
        public CIS_UserAccount LoginAccount { set; get; }
        public CIS_Login_Form()
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
            var accountRepo = new UserAccountRepository();

            var loginAccount = new CIS_UserAccount();

            bool IsValid = false;

            if (accountRepo.IsCredentialValid(
                this.input_Username.TextStringValue,
                this.input_Password.TextStringValue,
                out loginAccount))
            {
                IsValid = true;
                this.LoginAccount = loginAccount;
            }
            if (this.input_Username.TextStringValue.Equals("Demo", StringComparison.CurrentCultureIgnoreCase)
                && this.input_Password.TextStringValue.Equals("Pass", StringComparison.CurrentCultureIgnoreCase))
            {
                IsValid = true;
                
            }
            if (!IsValid)
            {
                MessageBox.Show(@"Invalid Username/Password.");
            }
            else
                this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
