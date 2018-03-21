using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace CozmicFileBackup
{
    using CozmicBackupDataAccess;

    using CozmicFileBackup.Forms;

    using DevExpress.XtraEditors;

    public partial class CIS_ControlPanel : DevExpress.XtraEditors.XtraForm
    {
        private CIS_UserAccount LoginAccount = null;
        public CIS_ControlPanel()
        {
            InitializeComponent();
            ShowLogin();
        }

        /// <summary>
        /// barButtonLogin_ItemClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ShowCreateAccount();


        }

        /// <summary>
        /// ShowCreateAccount
        /// </summary>
        void ShowCreateAccount()
        {
            var form = new CIS_CreateAccount_Form();
            this.AddControlToMainPanel(form , true);
        }

        /// <summary>
        /// ShowLogin
        /// </summary>
        void ShowLogin()
        {
            var Login_Form = new CIS_Login_Form();
            if (Login_Form.ShowDialog() == DialogResult.OK)
            {
                this.LoginAccount = Login_Form.LoginAccount;
            }
        }

        /// <summary>
        /// AddControlToMainPanel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="show"></param>
        public void AddControlToMainPanel(Control sender , bool show = false)
        {
            foreach (Control ctl in this.MainPanel.Controls)
            {
                this.MainPanel.Controls.Remove(ctl);
            }
            ((XtraForm)sender).TopLevel = false;
            this.MainPanel.Controls.Add(sender);
            sender.Dock=DockStyle.Fill;
            if(show)
                ((XtraForm)sender).Show();
            
        }
    }
}