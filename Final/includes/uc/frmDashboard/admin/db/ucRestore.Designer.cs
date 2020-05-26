namespace Final.includes.uc.frmDashboard.admin.db
{
    partial class ucRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRestore));
            this.lblPercent = new Guna.UI.WinForms.GunaLabel();
            this.lblProgressText = new Guna.UI.WinForms.GunaLabel();
            this.progressBarBackup = new Guna.UI.WinForms.GunaProgressBar();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDateTime = new Guna.UI.WinForms.GunaLabel();
            this.btnRestoreDatabase = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // lblPercent
            // 
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPercent.Location = new System.Drawing.Point(195, 146);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(612, 21);
            this.lblPercent.TabIndex = 101;
            this.lblPercent.Text = "0%";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProgressText
            // 
            this.lblProgressText.BackColor = System.Drawing.Color.Transparent;
            this.lblProgressText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProgressText.Location = new System.Drawing.Point(195, 179);
            this.lblProgressText.Name = "lblProgressText";
            this.lblProgressText.Size = new System.Drawing.Size(612, 21);
            this.lblProgressText.TabIndex = 100;
            this.lblProgressText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.progressBarBackup.TabIndex = 98;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(447, 50);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 38);
            this.guna2HtmlLabel1.TabIndex = 97;
            this.guna2HtmlLabel1.Text = "Restore";
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Gray;
            this.lblDateTime.Location = new System.Drawing.Point(276, 86);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(450, 21);
            this.lblDateTime.TabIndex = 96;
            this.lblDateTime.Text = "Please proceed with caution when restoring database.";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestoreDatabase
            // 
            this.btnRestoreDatabase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnRestoreDatabase.BorderRadius = 5;
            this.btnRestoreDatabase.BorderThickness = 1;
            this.btnRestoreDatabase.CheckedState.Parent = this.btnRestoreDatabase;
            this.btnRestoreDatabase.CustomImages.Parent = this.btnRestoreDatabase;
            this.btnRestoreDatabase.FillColor = System.Drawing.Color.White;
            this.btnRestoreDatabase.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnRestoreDatabase.ForeColor = System.Drawing.Color.Black;
            this.btnRestoreDatabase.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoreDatabase.HoverState.Image")));
            this.btnRestoreDatabase.HoverState.Parent = this.btnRestoreDatabase;
            this.btnRestoreDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoreDatabase.Image")));
            this.btnRestoreDatabase.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRestoreDatabase.Location = new System.Drawing.Point(419, 283);
            this.btnRestoreDatabase.Name = "btnRestoreDatabase";
            this.btnRestoreDatabase.ShadowDecoration.Parent = this.btnRestoreDatabase;
            this.btnRestoreDatabase.Size = new System.Drawing.Size(164, 80);
            this.btnRestoreDatabase.TabIndex = 99;
            this.btnRestoreDatabase.Text = "Restore Database";
            this.btnRestoreDatabase.Click += new System.EventHandler(this.btnRestoreDatabase_Click);
            // 
            // ucRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblProgressText);
            this.Controls.Add(this.btnRestoreDatabase);
            this.Controls.Add(this.progressBarBackup);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lblDateTime);
            this.Name = "ucRestore";
            this.Size = new System.Drawing.Size(1003, 521);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblPercent;
        private Guna.UI.WinForms.GunaLabel lblProgressText;
        private Guna.UI2.WinForms.Guna2TileButton btnRestoreDatabase;
        private Guna.UI.WinForms.GunaProgressBar progressBarBackup;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI.WinForms.GunaLabel lblDateTime;
    }
}
