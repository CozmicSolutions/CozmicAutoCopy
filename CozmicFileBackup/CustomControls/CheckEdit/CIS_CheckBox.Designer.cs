namespace CozmicFileBackup.CustomControls
{
    partial class CIS_CheckBox
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
            this.Caption = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControlText = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.CheckEdit = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlText)).BeginInit();
            this.panelControlText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.Caption.Size = new System.Drawing.Size(76, 17);
            this.Caption.TabIndex = 1;
            this.Caption.Text = "Caption";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControlText);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(105, 25);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControlText
            // 
            this.panelControlText.Controls.Add(this.CheckEdit);
            this.panelControlText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlText.Location = new System.Drawing.Point(82, 2);
            this.panelControlText.Name = "panelControlText";
            this.panelControlText.Size = new System.Drawing.Size(21, 21);
            this.panelControlText.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.Caption);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(80, 21);
            this.panelControl2.TabIndex = 0;
            // 
            // CheckEdit
            // 
            this.CheckEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckEdit.EditValue = null;
            this.CheckEdit.Location = new System.Drawing.Point(2, 2);
            this.CheckEdit.Margin = new System.Windows.Forms.Padding(4);
            this.CheckEdit.Name = "CheckEdit";
            this.CheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.CheckEdit.Properties.Appearance.Options.UseFont = true;
            this.CheckEdit.Properties.AutoHeight = false;
            this.CheckEdit.Properties.Caption = "";
            this.CheckEdit.Size = new System.Drawing.Size(17, 17);
            this.CheckEdit.TabIndex = 0;
            // 
            // CIS_CheckBox
            // 
            this.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CIS_CheckBox";
            this.Size = new System.Drawing.Size(105, 25);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlText)).EndInit();
            this.panelControlText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl Caption;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControlText;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit CheckEdit;
    }
}
