namespace CozmicFileBackup.Forms
{
    partial class CIS_AccountList_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIS_AccountList_Form));
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.CIS_DataList = new CozmicFileBackup.CustomControls.CIS_DataList();
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
            this.groupControlMain.Controls.Add(this.CIS_DataList);
            this.groupControlMain.Size = new System.Drawing.Size(406, 254);
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
            this.btnAccept.Location = new System.Drawing.Point(284, 2);
            this.btnAccept.Text = "Create";
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // CIS_DataList
            // 
            this.CIS_DataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CIS_DataList.Location = new System.Drawing.Point(2, 21);
            this.CIS_DataList.Name = "CIS_DataList";
            this.CIS_DataList.Size = new System.Drawing.Size(402, 231);
            this.CIS_DataList.TabIndex = 0;
            // 
            // CIS_AccountList_Form
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 344);
            this.Name = "CIS_AccountList_Form";
            this.Text = "User Account(s)";
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).EndInit();
            this.groupControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private CustomControls.CIS_DataGrid CIS_DataList;
    }
}