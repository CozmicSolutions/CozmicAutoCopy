namespace CozmicAutoCopyControlPanel
{
    partial class AutoCopyProgress
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblSource = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.lblDestPath = new System.Windows.Forms.Label();
            this.lblProgressCount = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtInfoArchive = new System.Windows.Forms.TextBox();
            this.txtInfoTransferType = new System.Windows.Forms.TextBox();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(640, 23);
            this.progressBar.TabIndex = 0;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSource.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSource.Location = new System.Drawing.Point(7, 23);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(59, 18);
            this.lblSource.TabIndex = 3;
            this.lblSource.Text = "Source";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Target";
            // 
            // lblSourcePath
            // 
            this.lblSourcePath.AutoSize = true;
            this.lblSourcePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourcePath.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSourcePath.Location = new System.Drawing.Point(70, 23);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(46, 18);
            this.lblSourcePath.TabIndex = 5;
            this.lblSourcePath.Text = ".........";
            // 
            // lblDestPath
            // 
            this.lblDestPath.AutoSize = true;
            this.lblDestPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDestPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDestPath.ForeColor = System.Drawing.Color.Red;
            this.lblDestPath.Location = new System.Drawing.Point(70, 50);
            this.lblDestPath.Name = "lblDestPath";
            this.lblDestPath.Size = new System.Drawing.Size(46, 18);
            this.lblDestPath.TabIndex = 6;
            this.lblDestPath.Text = ".........";
            // 
            // lblProgressCount
            // 
            this.lblProgressCount.AutoSize = true;
            this.lblProgressCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressCount.ForeColor = System.Drawing.Color.Black;
            this.lblProgressCount.Location = new System.Drawing.Point(116, 1);
            this.lblProgressCount.Name = "lblProgressCount";
            this.lblProgressCount.Size = new System.Drawing.Size(67, 18);
            this.lblProgressCount.TabIndex = 7;
            this.lblProgressCount.Text = "Loading";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtInfoArchive);
            this.grpDetails.Controls.Add(this.txtInfoTransferType);
            this.grpDetails.Controls.Add(this.lblSource);
            this.grpDetails.Controls.Add(this.label1);
            this.grpDetails.Controls.Add(this.lblDestPath);
            this.grpDetails.Controls.Add(this.lblSourcePath);
            this.grpDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpDetails.Location = new System.Drawing.Point(0, 58);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(640, 125);
            this.grpDetails.TabIndex = 8;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details";
            // 
            // txtInfoArchive
            // 
            this.txtInfoArchive.BackColor = System.Drawing.SystemColors.Info;
            this.txtInfoArchive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfoArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoArchive.Location = new System.Drawing.Point(275, 77);
            this.txtInfoArchive.Name = "txtInfoArchive";
            this.txtInfoArchive.ReadOnly = true;
            this.txtInfoArchive.Size = new System.Drawing.Size(383, 20);
            this.txtInfoArchive.TabIndex = 8;
            this.txtInfoArchive.Visible = false;
            // 
            // txtInfoTransferType
            // 
            this.txtInfoTransferType.BackColor = System.Drawing.SystemColors.Info;
            this.txtInfoTransferType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfoTransferType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoTransferType.Location = new System.Drawing.Point(16, 77);
            this.txtInfoTransferType.Name = "txtInfoTransferType";
            this.txtInfoTransferType.ReadOnly = true;
            this.txtInfoTransferType.Size = new System.Drawing.Size(253, 20);
            this.txtInfoTransferType.TabIndex = 7;
            this.txtInfoTransferType.Visible = false;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.Location = new System.Drawing.Point(1, 28);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(62, 23);
            this.btnShowDetails.TabIndex = 9;
            this.btnShowDetails.Text = ">>";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // AutoCopyProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 183);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.lblProgressCount);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AutoCopyProgress";
            this.Text = "Please Wait Synchronizing Folders";
            this.Shown += new System.EventHandler(this.AutoCopyProgress_Shown);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSourcePath;
        private System.Windows.Forms.Label lblDestPath;
        private System.Windows.Forms.Label lblProgressCount;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.TextBox txtInfoArchive;
        private System.Windows.Forms.TextBox txtInfoTransferType;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}