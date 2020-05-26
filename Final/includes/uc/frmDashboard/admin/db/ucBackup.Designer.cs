namespace Final.includes.uc.frmDashboard.admin.db
{
    partial class ucBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBackup));
            this.lblDateTime = new Guna.UI.WinForms.GunaLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.progressBarBackup = new Guna.UI.WinForms.GunaProgressBar();
            this.lblProgressText = new Guna.UI.WinForms.GunaLabel();
            this.lblPercent = new Guna.UI.WinForms.GunaLabel();
            this.lblLastActivity = new Guna.UI.WinForms.GunaLabel();
            this.btnBackupDatabase = new Guna.UI2.WinForms.Guna2TileButton();
            this.timerAutoBackup = new System.Windows.Forms.Timer(this.components);
            this.lblDirectory = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Gray;
            this.lblDateTime.Location = new System.Drawing.Point(276, 86);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(450, 21);
            this.lblDateTime.TabIndex = 90;
            this.lblDateTime.Text = "You haven\'t set automatic back-up yet. Click database settings to set-up.";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(446, 50);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(111, 38);
            this.guna2HtmlLabel1.TabIndex = 91;
            this.guna2HtmlLabel1.Text = "Backup";
            // 
            // progressBarBackup
            // 
            this.progressBarBackup.BackColor = System.Drawing.Color.Transparent;
            this.progressBarBackup.BorderColor = System.Drawing.Color.Black;
            this.progressBarBackup.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.progressBarBackup.IdleColor = System.Drawing.Color.Gainsboro;
            this.progressBarBackup.Location = new System.Drawing.Point(278, 169);
            this.progressBarBackup.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarBackup.Name = "progressBarBackup";
            this.progressBarBackup.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.progressBarBackup.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBarBackup.Size = new System.Drawing.Size(447, 8);
            this.progressBarBackup.TabIndex = 92;
            // 
            // lblProgressText
            // 
            this.lblProgressText.BackColor = System.Drawing.Color.Transparent;
            this.lblProgressText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProgressText.Location = new System.Drawing.Point(195, 179);
            this.lblProgressText.Name = "lblProgressText";
            this.lblProgressText.Size = new System.Drawing.Size(612, 21);
            this.lblProgressText.TabIndex = 94;
            this.lblProgressText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPercent
            // 
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPercent.Location = new System.Drawing.Point(195, 146);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(612, 21);
            this.lblPercent.TabIndex = 95;
            this.lblPercent.Text = "0%";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastActivity
            // 
            this.lblLastActivity.BackColor = System.Drawing.Color.Transparent;
            this.lblLastActivity.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastActivity.ForeColor = System.Drawing.Color.Gray;
            this.lblLastActivity.Location = new System.Drawing.Point(276, 415);
            this.lblLastActivity.Name = "lblLastActivity";
            this.lblLastActivity.Size = new System.Drawing.Size(450, 21);
            this.lblLastActivity.TabIndex = 96;
            this.lblLastActivity.Text = "Last Activity: ";
            this.lblLastActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBackupDatabase
            // 
            this.btnBackupDatabase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnBackupDatabase.BorderRadius = 5;
            this.btnBackupDatabase.BorderThickness = 1;
            this.btnBackupDatabase.CheckedState.Parent = this.btnBackupDatabase;
            this.btnBackupDatabase.CustomImages.Parent = this.btnBackupDatabase;
            this.btnBackupDatabase.FillColor = System.Drawing.Color.White;
            this.btnBackupDatabase.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnBackupDatabase.ForeColor = System.Drawing.Color.Black;
            this.btnBackupDatabase.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnBackupDatabase.HoverState.Image")));
            this.btnBackupDatabase.HoverState.Parent = this.btnBackupDatabase;
            this.btnBackupDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btnBackupDatabase.Image")));
            this.btnBackupDatabase.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBackupDatabase.Location = new System.Drawing.Point(419, 283);
            this.btnBackupDatabase.Name = "btnBackupDatabase";
            this.btnBackupDatabase.ShadowDecoration.Parent = this.btnBackupDatabase;
            this.btnBackupDatabase.Size = new System.Drawing.Size(164, 80);
            this.btnBackupDatabase.TabIndex = 93;
            this.btnBackupDatabase.Text = "Backup Database";
            this.btnBackupDatabase.Click += new System.EventHandler(this.btnBackupDatabase_Click);
            // 
            // timerAutoBackup
            // 
            this.timerAutoBackup.Interval = 1000;
            this.timerAutoBackup.Tick += new System.EventHandler(this.timerAutoBackup_Tick);
            // 
            // lblDirectory
            // 
            this.lblDirectory.BackColor = System.Drawing.Color.Transparent;
            this.lblDirectory.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectory.ForeColor = System.Drawing.Color.Gray;
            this.lblDirectory.Location = new System.Drawing.Point(276, 107);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(450, 21);
            this.lblDirectory.TabIndex = 97;
            this.lblDirectory.Text = "Directory: ";
            this.lblDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.lblLastActivity);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblProgressText);
            this.Controls.Add(this.btnBackupDatabase);
            this.Controls.Add(this.progressBarBackup);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lblDateTime);
            this.Name = "ucBackup";
            this.Size = new System.Drawing.Size(1003, 521);
            this.Load += new System.EventHandler(this.ucBackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblDateTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI.WinForms.GunaProgressBar progressBarBackup;
        private Guna.UI2.WinForms.Guna2TileButton btnBackupDatabase;
        private Guna.UI.WinForms.GunaLabel lblProgressText;
        private Guna.UI.WinForms.GunaLabel lblPercent;
        private Guna.UI.WinForms.GunaLabel lblLastActivity;
        private System.Windows.Forms.Timer timerAutoBackup;
        private Guna.UI.WinForms.GunaLabel lblDirectory;
    }
}
