namespace Final.includes.uc.frmSetup
{
    partial class ucServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucServer));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblProgressBarText = new Guna.UI.WinForms.GunaLabel();
            this.progressBarSetup = new Guna.UI.WinForms.GunaProgressBar();
            this.btnFinish = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtMachineName = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtIPAddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.txtMACAddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtLocation = new Guna.UI.WinForms.GunaTextBox();
            this.btnBack = new Guna.UI.WinForms.GunaAdvenceButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(135, 42);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(136, 21);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Server Installation";
            // 
            // lblProgressBarText
            // 
            this.lblProgressBarText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressBarText.ForeColor = System.Drawing.Color.Gray;
            this.lblProgressBarText.Location = new System.Drawing.Point(132, 66);
            this.lblProgressBarText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgressBarText.Name = "lblProgressBarText";
            this.lblProgressBarText.Size = new System.Drawing.Size(404, 42);
            this.lblProgressBarText.TabIndex = 18;
            this.lblProgressBarText.Text = "Please wait while we prepare to scan your machine.";
            // 
            // progressBarSetup
            // 
            this.progressBarSetup.BackColor = System.Drawing.Color.Transparent;
            this.progressBarSetup.BorderColor = System.Drawing.Color.Black;
            this.progressBarSetup.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.progressBarSetup.IdleColor = System.Drawing.Color.Gainsboro;
            this.progressBarSetup.Location = new System.Drawing.Point(135, 110);
            this.progressBarSetup.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarSetup.Name = "progressBarSetup";
            this.progressBarSetup.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.progressBarSetup.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBarSetup.Size = new System.Drawing.Size(177, 8);
            this.progressBarSetup.TabIndex = 33;
            // 
            // btnFinish
            // 
            this.btnFinish.AnimationHoverSpeed = 0.07F;
            this.btnFinish.AnimationSpeed = 0.03F;
            this.btnFinish.BaseColor = System.Drawing.Color.White;
            this.btnFinish.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnFinish.BorderSize = 1;
            this.btnFinish.Checked = true;
            this.btnFinish.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnFinish.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnFinish.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnFinish.CheckedImage = null;
            this.btnFinish.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnFinish.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFinish.FocusedColor = System.Drawing.Color.Empty;
            this.btnFinish.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnFinish.Image = null;
            this.btnFinish.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFinish.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFinish.Location = new System.Drawing.Point(134, 412);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnFinish.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFinish.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnFinish.OnHoverImage = null;
            this.btnFinish.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFinish.OnPressedColor = System.Drawing.Color.Black;
            this.btnFinish.Size = new System.Drawing.Size(178, 35);
            this.btnFinish.TabIndex = 83;
            this.btnFinish.Text = "Finish";
            this.btnFinish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtMachineName
            // 
            this.txtMachineName.BackColor = System.Drawing.Color.Transparent;
            this.txtMachineName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtMachineName.BorderColor = System.Drawing.Color.Silver;
            this.txtMachineName.BorderSize = 1;
            this.txtMachineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMachineName.Enabled = false;
            this.txtMachineName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMachineName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtMachineName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMachineName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineName.Location = new System.Drawing.Point(135, 132);
            this.txtMachineName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.PasswordChar = '\0';
            this.txtMachineName.SelectedText = "";
            this.txtMachineName.Size = new System.Drawing.Size(305, 34);
            this.txtMachineName.TabIndex = 74;
            this.txtMachineName.Text = "Machine Name";
            this.txtMachineName.TextOffsetX = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Enabled = false;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(135, 352);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(305, 34);
            this.txtPassword.TabIndex = 73;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextOffsetX = 5;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtIPAddress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtIPAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtIPAddress.BorderSize = 1;
            this.txtIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIPAddress.Enabled = false;
            this.txtIPAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIPAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtIPAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIPAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAddress.Location = new System.Drawing.Point(135, 171);
            this.txtIPAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.PasswordChar = '\0';
            this.txtIPAddress.SelectedText = "";
            this.txtIPAddress.Size = new System.Drawing.Size(305, 34);
            this.txtIPAddress.TabIndex = 75;
            this.txtIPAddress.Text = "IP Address";
            this.txtIPAddress.TextOffsetX = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.BorderSize = 1;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Enabled = false;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(135, 313);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(305, 34);
            this.txtUsername.TabIndex = 72;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextOffsetX = 5;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtMACAddress
            // 
            this.txtMACAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtMACAddress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtMACAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtMACAddress.BorderSize = 1;
            this.txtMACAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMACAddress.Enabled = false;
            this.txtMACAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMACAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtMACAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMACAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMACAddress.Location = new System.Drawing.Point(135, 210);
            this.txtMACAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtMACAddress.Name = "txtMACAddress";
            this.txtMACAddress.PasswordChar = '\0';
            this.txtMACAddress.SelectedText = "";
            this.txtMACAddress.Size = new System.Drawing.Size(305, 34);
            this.txtMACAddress.TabIndex = 76;
            this.txtMACAddress.Text = "MAC Address";
            this.txtMACAddress.TextOffsetX = 5;
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.Transparent;
            this.txtLocation.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtLocation.BorderColor = System.Drawing.Color.Silver;
            this.txtLocation.BorderSize = 1;
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.Enabled = false;
            this.txtLocation.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLocation.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtLocation.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLocation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(135, 274);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.SelectedText = "";
            this.txtLocation.Size = new System.Drawing.Size(305, 34);
            this.txtLocation.TabIndex = 71;
            this.txtLocation.Text = "Location";
            this.txtLocation.TextOffsetX = 5;
            this.txtLocation.Enter += new System.EventHandler(this.txtLocation_Enter);
            this.txtLocation.Leave += new System.EventHandler(this.txtLocation_Leave);
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BaseColor = System.Drawing.Color.White;
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnBack.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnBack.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBack.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnBack.CheckedImage = null;
            this.btnBack.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.No;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.Enabled = false;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageOffsetX = 8;
            this.btnBack.ImageSize = new System.Drawing.Size(15, 15);
            this.btnBack.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBack.Location = new System.Drawing.Point(0, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnBack.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnBack.OnHoverImage")));
            this.btnBack.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(112, 22);
            this.btnBack.TabIndex = 84;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // ucServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.txtMachineName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtMACAddress);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.progressBarSetup);
            this.Controls.Add(this.lblProgressBarText);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "ucServer";
            this.Size = new System.Drawing.Size(700, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI.WinForms.GunaLabel lblProgressBarText;
        private Guna.UI.WinForms.GunaProgressBar progressBarSetup;
        private Guna.UI.WinForms.GunaAdvenceButton btnFinish;
        private Guna.UI.WinForms.GunaTextBox txtMachineName;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtIPAddress;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI.WinForms.GunaTextBox txtMACAddress;
        private Guna.UI.WinForms.GunaTextBox txtLocation;
        private Guna.UI.WinForms.GunaAdvenceButton btnBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
