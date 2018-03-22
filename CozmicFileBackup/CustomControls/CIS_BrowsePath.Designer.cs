namespace CozmicFileBackup.CustomControls
{
    partial class CIS_BrowsePath
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
            this.components = new System.ComponentModel.Container();
            this.Text = new DevExpress.XtraEditors.TextEdit();
            this.Caption = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControlText = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.Button = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlText)).BeginInit();
            this.panelControlText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text.Location = new System.Drawing.Point(2, 2);
            this.Text.Margin = new System.Windows.Forms.Padding(4);
            this.Text.Name = "Text";
            this.Text.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Text.Properties.Appearance.Options.UseFont = true;
            this.Text.Properties.AutoHeight = false;
            this.Text.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Text.Size = new System.Drawing.Size(545, 17);
            this.Text.TabIndex = 0;
            // 
            // Caption
            // 
            this.Caption.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caption.Appearance.Options.UseFont = true;
            this.Caption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Caption.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Caption.Location = new System.Drawing.Point(2, 2);
            this.Caption.Margin = new System.Windows.Forms.Padding(4);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(45, 17);
            this.Caption.TabIndex = 1;
            this.Caption.Text = "Path";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.panelControlText);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(553, 25);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.Caption);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(49, 21);
            this.panelControl2.TabIndex = 0;
            // 
            // panelControlText
            // 
            this.panelControlText.Controls.Add(this.Text);
            this.panelControlText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlText.Location = new System.Drawing.Point(2, 2);
            this.panelControlText.Name = "panelControlText";
            this.panelControlText.Size = new System.Drawing.Size(549, 21);
            this.panelControlText.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.Button);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(503, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(48, 21);
            this.panelControl3.TabIndex = 1;
            // 
            // Button
            // 
            this.Button.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.Appearance.Options.UseFont = true;
            this.Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button.Location = new System.Drawing.Point(0, 2);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(46, 17);
            this.Button.TabIndex = 2;
            this.Button.Text = "...";
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // CIS_BrowsePath
            // 
            this.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CIS_BrowsePath";
            this.Size = new System.Drawing.Size(553, 25);
            ((System.ComponentModel.ISupportInitialize)(this.Text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlText)).EndInit();
            this.panelControlText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit Text;
        private DevExpress.XtraEditors.LabelControl Caption;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControlText;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton Button;
    }
}
