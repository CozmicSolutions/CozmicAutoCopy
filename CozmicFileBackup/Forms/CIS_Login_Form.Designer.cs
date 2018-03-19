namespace CozmicFileBackup.Forms
{
    partial class CIS_Login_Form
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIS_Login_Form));
            this.panelControlTop = new DevExpress.XtraEditors.PanelControl();
            this.panelControlButtom = new DevExpress.XtraEditors.PanelControl();
            this.groupControlMain = new DevExpress.XtraEditors.GroupControl();
            this.input_Username = new CozmicFileBackup.CustomControls.CIS_InputData();
            this.input_Password = new CozmicFileBackup.CustomControls.CIS_InputData();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtom)).BeginInit();
            this.panelControlButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).BeginInit();
            this.groupControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControlTop
            // 
            this.panelControlTop.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControlTop.ContentImage")));
            this.panelControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlTop.Location = new System.Drawing.Point(0, 0);
            this.panelControlTop.Name = "panelControlTop";
            this.panelControlTop.Size = new System.Drawing.Size(406, 40);
            this.panelControlTop.TabIndex = 0;
            // 
            // panelControlButtom
            // 
            this.panelControlButtom.Controls.Add(this.btnClose);
            this.panelControlButtom.Controls.Add(this.btnLogin);
            this.panelControlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlButtom.Location = new System.Drawing.Point(0, 137);
            this.panelControlButtom.Name = "panelControlButtom";
            this.panelControlButtom.Size = new System.Drawing.Size(406, 40);
            this.panelControlButtom.TabIndex = 1;
            // 
            // groupControlMain
            // 
            this.groupControlMain.Controls.Add(this.input_Password);
            this.groupControlMain.Controls.Add(this.input_Username);
            this.groupControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlMain.Location = new System.Drawing.Point(0, 40);
            this.groupControlMain.Name = "groupControlMain";
            this.groupControlMain.Size = new System.Drawing.Size(406, 97);
            this.groupControlMain.TabIndex = 2;
            this.groupControlMain.Text = "Log in";
            // 
            // input_Username
            // 
            this.input_Username.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Username.Appearance.Options.UseFont = true;
            this.input_Username.Location = new System.Drawing.Point(6, 26);
            this.input_Username.Margin = new System.Windows.Forms.Padding(4);
            this.input_Username.Name = "input_Username";
            this.input_Username.Size = new System.Drawing.Size(393, 25);
            this.input_Username.TabIndex = 0;
            // 
            // input_Password
            // 
            this.input_Password.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Password.Appearance.Options.UseFont = true;
            this.input_Password.Location = new System.Drawing.Point(6, 59);
            this.input_Password.Margin = new System.Windows.Forms.Padding(4);
            this.input_Password.Name = "input_Password";
            this.input_Password.Size = new System.Drawing.Size(393, 25);
            this.input_Password.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.Location = new System.Drawing.Point(314, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 36);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log in";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            // 
            // CIS_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControlMain);
            this.Controls.Add(this.panelControlButtom);
            this.Controls.Add(this.panelControlTop);
            this.Name = "CIS_Login_Form";
            this.Size = new System.Drawing.Size(406, 177);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtom)).EndInit();
            this.panelControlButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).EndInit();
            this.groupControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlTop;
        private DevExpress.XtraEditors.PanelControl panelControlButtom;
        private DevExpress.XtraEditors.GroupControl groupControlMain;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private CustomControls.CIS_InputData input_Password;
        private CustomControls.CIS_InputData input_Username;
    }
}
