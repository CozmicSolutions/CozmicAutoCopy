using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CozmicFileBackup.Forms
{
    using CozmicBackupDataAccess;

    using CozmicFileBackup.CustomControls;

    using DevExpress.XtraEditors.DXErrorProvider;

    public partial class CIS_CreateAccount_Form : CIS_Base_Form
    {
        public CIS_CreateAccount_Form()
        {
            this.InitializeComponent();
            this.SetControlUI();
        }

        void SetControlUI()
        {
            this.input_Username.SetValidation(DataValidation.NullOrEmpty);
            this.input_Username.SetCaption("Username");
            //======================================
            this.input_Password.SetValidation(DataValidation.NullOrEmpty);
            this.input_Password.SetCaption("Password");
            //======================================
            this.input_Password_Retry.SetValidation(DataValidation.NullOrEmpty);
            this.input_Password_Retry.SetCaption("Retype Password");
            //======================================
            this.input_Key.SetValidation(DataValidation.NullOrEmpty);
            this.input_Key.SetCaption("Activation Key");
            //======================================
        }

        /// <summary>
        /// ValidateControls
        /// </summary>
        /// <returns></returns>
        bool ValidateControls()
        {
            return this.input_Username.IsValid() && this.input_Password.IsValid() && this.input_Password_Retry.IsValid();
        }

        /// <summary>
        /// btnAccept_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            var repo = new UserAccountRepository();
            if (this.ValidateControls() && this.CheckPassword() && this.CheckUsername() && this.CheckKey())
            {
               
              var account =  repo.RegisterAccount(
                    this.input_Username.TextStringValue,
                    this.input_Password.TextStringValue,
                    new Guid(this.input_Key.TextStringValue));
                if(account!=null)
                this.btnAccept.Enabled =this.input_Username.Enabled = this.input_Password.Enabled =
                                                  this.input_Password_Retry.Enabled = this.input_Key.Enabled = false;

            }
        }

        /// <summary>
        /// CheckPassword
        /// </summary>
        /// <returns></returns>
        bool CheckUsername()
        {
            var repo = new UserAccountRepository();
            if (!repo.IsUsernameValid(this.input_Username.TextStringValue))
            {
                this.input_Key.SetValidation(DataValidation.Custom);
                this.input_Key.IsValid("Username already exist.", ErrorType.Critical);
                return false;
            }
            return true;
        }

        /// <summary>
        /// CheckPassword
        /// </summary>
        /// <returns></returns>
        bool CheckKey()
        {
            var repo = new UserAccountRepository();
            var system = new CIS_System();
            try
            {
                if (!repo.IsKeyValid(new Guid(this.input_Key.TextStringValue), out system))
                {
                    this.input_Key.SetValidation(DataValidation.Custom);
                    this.input_Key.IsValid("Invalid Key.", ErrorType.Critical);
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
       
            return true;
        }

        /// <summary>
        /// CheckPassword
        /// </summary>
        /// <returns></returns>
        bool CheckPassword()
        {
            if (!this.input_Password.TextStringValue.Equals(this.input_Password_Retry.TextStringValue))
            {
                this.input_Password_Retry.SetValidation(DataValidation.Custom);
                this.input_Password_Retry.IsValid("Password dose not match", ErrorType.User1);
                return false;
            }
            return true;
        }

        /// <summary>
        ///       btnClose_Click  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}