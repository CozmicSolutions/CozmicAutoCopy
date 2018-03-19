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

    public partial class CIS_ControlPanel : DevExpress.XtraEditors.XtraForm
    {
        public CIS_ControlPanel()
        {
            InitializeComponent();
        }

        private void barButtonLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            var Login_Form = new CIS_Login_Form();
            
                this.AddControlToMainPanel(Login_Form);
                Login_Form.Show();
            
        }
      

        public Control AddControlToMainPanel(Control sender)
        {
            foreach (Control ctl in this.MainPanel.Controls)
            {
                this.MainPanel.Controls.Remove(ctl);
            }
            this.MainPanel.Controls.Add(sender);
            sender.Dock=DockStyle.Fill;
            return sender;
        }
    }
}