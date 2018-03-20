﻿using System;
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
    using CozmicFileBackup.Forms;

    using DevExpress.XtraEditors;

    public partial class CIS_ControlPanel : DevExpress.XtraEditors.XtraForm
    {
        public CIS_ControlPanel()
        {
            InitializeComponent();
            ShowLogin();
        }

        private void barButtonLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ShowCreateAccount();


        }

        void ShowCreateAccount()
        {
            var form = new CIS_CreateAccount_Form();
            this.AddControlToMainPanel(form , true);
        }
        void ShowLogin()
        {
            var Login_Form = new CIS_Login_Form();
            if (Login_Form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
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