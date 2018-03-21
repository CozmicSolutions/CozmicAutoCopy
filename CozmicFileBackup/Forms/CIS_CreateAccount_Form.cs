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
            return this.input_Username.IsValid() && this.input_Password.IsValid() && this.input_Password_Retry.IsValid()
                   && this.input_Key.IsValid();
        }

        /// <summary>
        /// btnAccept_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.ValidateControls() && this.CheckPassword())
            {
                
            }
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