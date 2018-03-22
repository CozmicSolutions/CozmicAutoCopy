namespace CozmicFileBackup.Forms
{
    partial class CIS_AddCopyTask_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIS_AddCopyTask_Form));
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.BrowsePath_Source = new CozmicFileBackup.CustomControls.CIS_BrowsePath();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).BeginInit();
            this.groupControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlTop
            // 
            this.panelControlTop.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControlTop.ContentImage")));
            this.panelControlTop.Size = new System.Drawing.Size(573, 49);
            // 
            // groupControlMain
            // 
            this.groupControlMain.Controls.Add(this.BrowsePath_Source);
            this.groupControlMain.Size = new System.Drawing.Size(573, 219);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Appearance.Options.UseFont = true;
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(451, 2);
            this.btnAccept.Text = "Create";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // BrowsePath_Source
            // 
            this.BrowsePath_Source.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowsePath_Source.Appearance.Options.UseFont = true;
            this.BrowsePath_Source.BrowseDialogType = CozmicFileBackup.CustomControls.BrowseType.File;
            this.BrowsePath_Source.Location = new System.Drawing.Point(13, 25);
            this.BrowsePath_Source.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrowsePath_Source.Name = "BrowsePath_Source";
            this.BrowsePath_Source.Size = new System.Drawing.Size(553, 25);
            this.BrowsePath_Source.TabIndex = 0;
            this.BrowsePath_Source.Validation = CozmicFileBackup.CustomControls.DataValidation.None;
            // 
            // CIS_AddCopyTask_Form
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 309);
            this.Name = "CIS_AddCopyTask_Form";
            this.Text = "Add New Task";
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).EndInit();
            this.groupControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private CustomControls.CIS_BrowsePath BrowsePath_Source;
    }
}