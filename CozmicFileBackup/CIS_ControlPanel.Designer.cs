namespace CozmicFileBackup
{
    partial class CIS_ControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIS_ControlPanel));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonNewAccount = new DevExpress.XtraBars.BarButtonItem();
            this.mainMenuAccount = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemAccountList = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNewAccount = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonAccountList = new DevExpress.XtraBars.BarButtonItem();
            this.MainPanel = new DevExpress.XtraEditors.PanelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonNewAccount,
            this.barButtonAccountList,
            this.mainMenuAccount,
            this.barButtonItemNewAccount,
            this.barButtonItemAccountList});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 5;
            this.barManager.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mainMenuAccount, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonNewAccount
            // 
            this.barButtonNewAccount.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.barButtonNewAccount.Caption = "Log in";
            this.barButtonNewAccount.Description = "Log in";
            this.barButtonNewAccount.Hint = "Log in";
            this.barButtonNewAccount.Id = 0;
            this.barButtonNewAccount.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.barButtonNewAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonNewAccount.ImageOptions.Image")));
            this.barButtonNewAccount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonNewAccount.ImageOptions.LargeImage")));
            this.barButtonNewAccount.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L));
            this.barButtonNewAccount.Name = "barButtonNewAccount";
            this.barButtonNewAccount.ShortcutKeyDisplayString = "CTL+L";
            this.barButtonNewAccount.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.barButtonNewAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLogin_ItemClick);
            // 
            // mainMenuAccount
            // 
            this.mainMenuAccount.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.mainMenuAccount.Caption = "User Accounts";
            this.mainMenuAccount.Id = 2;
            this.mainMenuAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mainMenuAccount.ImageOptions.Image")));
            this.mainMenuAccount.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemAccountList, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemNewAccount, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.mainMenuAccount.MenuAppearance.AppearanceMenu.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.mainMenuAccount.MenuAppearance.AppearanceMenu.Disabled.Options.UseFont = true;
            this.mainMenuAccount.MenuAppearance.AppearanceMenu.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.mainMenuAccount.MenuAppearance.AppearanceMenu.Hovered.Options.UseFont = true;
            this.mainMenuAccount.MenuAppearance.AppearanceMenu.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuAccount.MenuAppearance.AppearanceMenu.Normal.Options.UseFont = true;
            this.mainMenuAccount.MenuAppearance.AppearanceMenu.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.mainMenuAccount.MenuAppearance.AppearanceMenu.Pressed.Options.UseFont = true;
            this.mainMenuAccount.MenuAppearance.MenuBar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.mainMenuAccount.MenuAppearance.MenuBar.Options.UseFont = true;
            this.mainMenuAccount.MenuAppearance.MenuCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.mainMenuAccount.MenuAppearance.MenuCaption.Options.UseFont = true;
            this.mainMenuAccount.Name = "mainMenuAccount";
            // 
            // barButtonItemAccountList
            // 
            this.barButtonItemAccountList.Caption = "Account List";
            this.barButtonItemAccountList.Id = 4;
            this.barButtonItemAccountList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemAccountList.ImageOptions.Image")));
            this.barButtonItemAccountList.Name = "barButtonItemAccountList";
            this.barButtonItemAccountList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAccountList_ItemClick);
            // 
            // barButtonItemNewAccount
            // 
            this.barButtonItemNewAccount.Caption = "New Account";
            this.barButtonItemNewAccount.Id = 3;
            this.barButtonItemNewAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemNewAccount.ImageOptions.Image")));
            this.barButtonItemNewAccount.Name = "barButtonItemNewAccount";
            this.barButtonItemNewAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewAccount_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1015, 44);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 539);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1015, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 44);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 495);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1015, 44);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 495);
            // 
            // barButtonAccountList
            // 
            this.barButtonAccountList.Caption = "Account(s)";
            this.barButtonAccountList.Id = 1;
            this.barButtonAccountList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonAccountList.ImageOptions.Image")));
            this.barButtonAccountList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonAccountList.ImageOptions.LargeImage")));
            this.barButtonAccountList.Name = "barButtonAccountList";
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 44);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1015, 495);
            this.MainPanel.TabIndex = 4;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // CIS_ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 560);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CIS_ControlPanel";
            this.Text = "CIS_ControlPanel";
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonNewAccount;
        private DevExpress.XtraEditors.PanelControl MainPanel;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barButtonAccountList;
        private DevExpress.XtraBars.BarSubItem mainMenuAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAccountList;
    }
}