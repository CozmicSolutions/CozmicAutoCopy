namespace CozmicAutoCopyControlPanel
{
    partial class AutoCopyControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoCopyControlPanel));
            this.lblDestinationPath = new System.Windows.Forms.Label();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.lblRepeatEach = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.cmbRepatEach = new System.Windows.Forms.ComboBox();
            this.cmbTransferType = new System.Windows.Forms.ComboBox();
            this.lblTransferType = new System.Windows.Forms.Label();
            this.txtArchiveFolderPath = new System.Windows.Forms.TextBox();
            this.lblArchivePath = new System.Windows.Forms.Label();
            this.cmbArchiveType = new System.Windows.Forms.ComboBox();
            this.lblArchiveType = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBrowseArchivePath = new System.Windows.Forms.Button();
            this.btnBrowseDestPath = new System.Windows.Forms.Button();
            this.btnBrowseSourcePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDestinationPath
            // 
            this.lblDestinationPath.AutoSize = true;
            this.lblDestinationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationPath.Location = new System.Drawing.Point(8, 60);
            this.lblDestinationPath.Name = "lblDestinationPath";
            this.lblDestinationPath.Size = new System.Drawing.Size(129, 16);
            this.lblDestinationPath.TabIndex = 1;
            this.lblDestinationPath.Text = "Destination Path :";
            // 
            // lblSourcePath
            // 
            this.lblSourcePath.AutoSize = true;
            this.lblSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourcePath.Location = new System.Drawing.Point(8, 27);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(100, 16);
            this.lblSourcePath.TabIndex = 2;
            this.lblSourcePath.Text = "Source Path :";
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(140, 58);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(277, 20);
            this.txtDestinationPath.TabIndex = 3;
            this.txtDestinationPath.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(140, 25);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(277, 20);
            this.txtSourcePath.TabIndex = 4;
            this.txtSourcePath.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lblRepeatEach
            // 
            this.lblRepeatEach.AutoSize = true;
            this.lblRepeatEach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatEach.Location = new System.Drawing.Point(8, 201);
            this.lblRepeatEach.Name = "lblRepeatEach";
            this.lblRepeatEach.Size = new System.Drawing.Size(111, 16);
            this.lblRepeatEach.TabIndex = 7;
            this.lblRepeatEach.Text = "Repeat Every :";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMinute.Location = new System.Drawing.Point(211, 201);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(57, 16);
            this.lblMinute.TabIndex = 9;
            this.lblMinute.Text = "Minute.";
            // 
            // cmbRepatEach
            // 
            this.cmbRepatEach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepatEach.FormattingEnabled = true;
            this.cmbRepatEach.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cmbRepatEach.Location = new System.Drawing.Point(140, 199);
            this.cmbRepatEach.Name = "cmbRepatEach";
            this.cmbRepatEach.Size = new System.Drawing.Size(64, 21);
            this.cmbRepatEach.TabIndex = 10;
            this.cmbRepatEach.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // cmbTransferType
            // 
            this.cmbTransferType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransferType.FormattingEnabled = true;
            this.cmbTransferType.Items.AddRange(new object[] {
            "Copy",
            "Move",
            "Copy/Archive",
            "Move/Archive"});
            this.cmbTransferType.Location = new System.Drawing.Point(140, 91);
            this.cmbTransferType.Name = "cmbTransferType";
            this.cmbTransferType.Size = new System.Drawing.Size(190, 21);
            this.cmbTransferType.TabIndex = 13;
            this.cmbTransferType.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lblTransferType
            // 
            this.lblTransferType.AutoSize = true;
            this.lblTransferType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferType.Location = new System.Drawing.Point(8, 93);
            this.lblTransferType.Name = "lblTransferType";
            this.lblTransferType.Size = new System.Drawing.Size(114, 16);
            this.lblTransferType.TabIndex = 12;
            this.lblTransferType.Text = "Transfer Type :";
            // 
            // txtArchiveFolderPath
            // 
            this.txtArchiveFolderPath.Location = new System.Drawing.Point(140, 125);
            this.txtArchiveFolderPath.Name = "txtArchiveFolderPath";
            this.txtArchiveFolderPath.Size = new System.Drawing.Size(277, 20);
            this.txtArchiveFolderPath.TabIndex = 15;
            this.txtArchiveFolderPath.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lblArchivePath
            // 
            this.lblArchivePath.AutoSize = true;
            this.lblArchivePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivePath.Location = new System.Drawing.Point(8, 125);
            this.lblArchivePath.Name = "lblArchivePath";
            this.lblArchivePath.Size = new System.Drawing.Size(103, 16);
            this.lblArchivePath.TabIndex = 14;
            this.lblArchivePath.Text = "Archive Path :";
            // 
            // cmbArchiveType
            // 
            this.cmbArchiveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArchiveType.FormattingEnabled = true;
            this.cmbArchiveType.Items.AddRange(new object[] {
            "None",
            "Zip",
            "Rar"});
            this.cmbArchiveType.Location = new System.Drawing.Point(140, 160);
            this.cmbArchiveType.Name = "cmbArchiveType";
            this.cmbArchiveType.Size = new System.Drawing.Size(110, 21);
            this.cmbArchiveType.TabIndex = 20;
            this.cmbArchiveType.SelectedIndexChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lblArchiveType
            // 
            this.lblArchiveType.AutoSize = true;
            this.lblArchiveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchiveType.Location = new System.Drawing.Point(8, 162);
            this.lblArchiveType.Name = "lblArchiveType";
            this.lblArchiveType.Size = new System.Drawing.Size(108, 16);
            this.lblArchiveType.TabIndex = 19;
            this.lblArchiveType.Text = "Archive Type :";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(11, 228);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 43);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(300, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 43);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Schedule";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowseArchivePath
            // 
            this.btnBrowseArchivePath.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseArchivePath.Image")));
            this.btnBrowseArchivePath.Location = new System.Drawing.Point(417, 125);
            this.btnBrowseArchivePath.Name = "btnBrowseArchivePath";
            this.btnBrowseArchivePath.Size = new System.Drawing.Size(25, 21);
            this.btnBrowseArchivePath.TabIndex = 16;
            this.btnBrowseArchivePath.Text = "...";
            this.btnBrowseArchivePath.UseVisualStyleBackColor = true;
            this.btnBrowseArchivePath.Click += new System.EventHandler(this.btnBrowseArchivePath_Click);
            // 
            // btnBrowseDestPath
            // 
            this.btnBrowseDestPath.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseDestPath.Image")));
            this.btnBrowseDestPath.Location = new System.Drawing.Point(417, 58);
            this.btnBrowseDestPath.Name = "btnBrowseDestPath";
            this.btnBrowseDestPath.Size = new System.Drawing.Size(25, 21);
            this.btnBrowseDestPath.TabIndex = 6;
            this.btnBrowseDestPath.Text = "...";
            this.btnBrowseDestPath.UseVisualStyleBackColor = true;
            this.btnBrowseDestPath.Click += new System.EventHandler(this.btnBrowseDestPath_Click);
            // 
            // btnBrowseSourcePath
            // 
            this.btnBrowseSourcePath.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseSourcePath.Image")));
            this.btnBrowseSourcePath.Location = new System.Drawing.Point(417, 24);
            this.btnBrowseSourcePath.Name = "btnBrowseSourcePath";
            this.btnBrowseSourcePath.Size = new System.Drawing.Size(25, 21);
            this.btnBrowseSourcePath.TabIndex = 5;
            this.btnBrowseSourcePath.Text = "...";
            this.btnBrowseSourcePath.UseVisualStyleBackColor = true;
            this.btnBrowseSourcePath.Click += new System.EventHandler(this.btnBrowseSourcePath_Click);
            // 
            // AutoCopyControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 279);
            this.ControlBox = false;
            this.Controls.Add(this.cmbArchiveType);
            this.Controls.Add(this.lblArchiveType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowseArchivePath);
            this.Controls.Add(this.txtArchiveFolderPath);
            this.Controls.Add(this.lblArchivePath);
            this.Controls.Add(this.cmbTransferType);
            this.Controls.Add(this.lblTransferType);
            this.Controls.Add(this.cmbRepatEach);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblRepeatEach);
            this.Controls.Add(this.btnBrowseDestPath);
            this.Controls.Add(this.btnBrowseSourcePath);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.lblSourcePath);
            this.Controls.Add(this.lblDestinationPath);
            this.Name = "AutoCopyControlPanel";
            this.Text = "Auto Copy Scheduler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDestinationPath;
        private System.Windows.Forms.Label lblSourcePath;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Button btnBrowseSourcePath;
        private System.Windows.Forms.Button btnBrowseDestPath;
        private System.Windows.Forms.Label lblRepeatEach;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.ComboBox cmbRepatEach;
        private System.Windows.Forms.ComboBox cmbTransferType;
        private System.Windows.Forms.Label lblTransferType;
        private System.Windows.Forms.Button btnBrowseArchivePath;
        private System.Windows.Forms.TextBox txtArchiveFolderPath;
        private System.Windows.Forms.Label lblArchivePath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbArchiveType;
        private System.Windows.Forms.Label lblArchiveType;
    }
}

