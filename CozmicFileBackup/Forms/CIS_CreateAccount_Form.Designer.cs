namespace CozmicFileBackup.Forms
{
    partial class CIS_CreateAccount_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIS_CreateAccount_Form));
            this.input_Password = new CozmicFileBackup.CustomControls.CIS_InputData();
            this.input_Username = new CozmicFileBackup.CustomControls.CIS_InputData();
            this.input_Password_Retry = new CozmicFileBackup.CustomControls.CIS_InputData();
            this.input_Key = new CozmicFileBackup.CustomControls.CIS_InputData();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).BeginInit();
            this.groupControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlTop
            // 
            this.panelControlTop.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControlTop.ContentImage")));
            this.panelControlTop.Size = new System.Drawing.Size(406, 49);
            // 
            // groupControlMain
            // 
            this.groupControlMain.Controls.Add(this.input_Key);
            this.groupControlMain.Controls.Add(this.input_Password_Retry);
            this.groupControlMain.Controls.Add(this.input_Password);
            this.groupControlMain.Controls.Add(this.input_Username);
            this.groupControlMain.Size = new System.Drawing.Size(406, 254);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            // 
            // btnAccept
            // 
            this.btnAccept.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Appearance.Options.UseFont = true;
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(284, 2);
            this.btnAccept.Text = "Create";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // input_Password
            // 
            this.input_Password.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Password.Appearance.Options.UseFont = true;
            this.input_Password.Location = new System.Drawing.Point(14, 67);
            this.input_Password.Margin = new System.Windows.Forms.Padding(5);
            this.input_Password.Name = "input_Password";
            this.input_Password.Size = new System.Drawing.Size(384, 31);
            this.input_Password.TabIndex = 3;
            // 
            // input_Username
            // 
            this.input_Username.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Username.Appearance.Options.UseFont = true;
            this.input_Username.Location = new System.Drawing.Point(14, 26);
            this.input_Username.Margin = new System.Windows.Forms.Padding(5);
            this.input_Username.Name = "input_Username";
            this.input_Username.Size = new System.Drawing.Size(384, 31);
            this.input_Username.TabIndex = 2;
            // 
            // input_Password_Retry
            // 
            this.input_Password_Retry.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Password_Retry.Appearance.Options.UseFont = true;
            this.input_Password_Retry.Location = new System.Drawing.Point(14, 108);
            this.input_Password_Retry.Margin = new System.Windows.Forms.Padding(5);
            this.input_Password_Retry.Name = "input_Password_Retry";
            this.input_Password_Retry.Size = new System.Drawing.Size(384, 31);
            this.input_Password_Retry.TabIndex = 4;
            // 
            // input_Key
            // 
            this.input_Key.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Key.Appearance.Options.UseFont = true;
            this.input_Key.Location = new System.Drawing.Point(14, 149);
            this.input_Key.Margin = new System.Windows.Forms.Padding(5);
            this.input_Key.Name = "input_Key";
            this.input_Key.Size = new System.Drawing.Size(384, 31);
            this.input_Key.TabIndex = 5;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // CIS_CreateAccount_Form
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 344);
            this.Name = "CIS_CreateAccount_Form";
            this.Text = "Create New Account";
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).EndInit();
            this.groupControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.CIS_InputData input_Key;
        private CustomControls.CIS_InputData input_Password_Retry;
        private CustomControls.CIS_InputData input_Password;
        private CustomControls.CIS_InputData input_Username;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}