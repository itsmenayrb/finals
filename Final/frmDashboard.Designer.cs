namespace Final
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelNav = new System.Windows.Forms.Panel();
            this.ucSuperAdministratorNav1 = new Final.includes.uc.frmDashboard.navigation.ucSuperAdministratorNav();
            this.ucStudentNav1 = new Final.includes.uc.frmDashboard.navigation.ucStudentNav();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lblFullName = new Guna.UI.WinForms.GunaLabel();
            this.pbProfilePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MaximizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.ucDatabase1 = new Final.includes.uc.frmDashboard.admin.db.ucDatabase();
            this.ucManageUser1 = new Final.includes.uc.frmDashboard.admin.mu.ucManageUser();
            this.ucLoginHistory1 = new Final.includes.uc.frmDashboard.admin.lh.ucLoginHistory();
            this.ucMaintenanceReport1 = new Final.includes.uc.frmDashboard.admin.mr.ucMaintenanceReport();
            this.ucInventory1 = new Final.includes.uc.frmDashboard.admin.inv.ucInventoryManagement();
            this.ucComputerFacility1 = new Final.includes.uc.frmDashboard.admin.cf.ucComputerFacility();
            this.timerLectureSession = new System.Windows.Forms.Timer(this.components);
            this.panelSidebar.SuspendLayout();
            this.panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackgroundImage = global::Final.Resource1.sidebar;
            this.panelSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSidebar.Controls.Add(this.panelNav);
            this.panelSidebar.Controls.Add(this.gunaLabel3);
            this.panelSidebar.Controls.Add(this.lblFullName);
            this.panelSidebar.Controls.Add(this.pbProfilePicture);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(197, 700);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelNav
            // 
            this.panelNav.Controls.Add(this.ucSuperAdministratorNav1);
            this.panelNav.Controls.Add(this.ucStudentNav1);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNav.Location = new System.Drawing.Point(0, 160);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(197, 540);
            this.panelNav.TabIndex = 0;
            // 
            // ucSuperAdministratorNav1
            // 
            this.ucSuperAdministratorNav1.BackColor = System.Drawing.Color.White;
            this.ucSuperAdministratorNav1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSuperAdministratorNav1.Location = new System.Drawing.Point(0, 0);
            this.ucSuperAdministratorNav1.Name = "ucSuperAdministratorNav1";
            this.ucSuperAdministratorNav1.Size = new System.Drawing.Size(197, 540);
            this.ucSuperAdministratorNav1.TabIndex = 0;
            // 
            // ucStudentNav1
            // 
            this.ucStudentNav1.BackColor = System.Drawing.Color.White;
            this.ucStudentNav1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStudentNav1.Location = new System.Drawing.Point(0, 0);
            this.ucStudentNav1.Name = "ucStudentNav1";
            this.ucStudentNav1.Size = new System.Drawing.Size(197, 540);
            this.ucStudentNav1.TabIndex = 0;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(16, 95);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(67, 17);
            this.gunaLabel3.TabIndex = 26;
            this.gunaLabel3.Text = "Username";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(16, 79);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(107, 16);
            this.lblFullName.TabIndex = 25;
            this.lblFullName.Text = "Welcome, Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.pbProfilePicture.Image = global::Final.Resource1.Portrait_Placeholder;
            this.pbProfilePicture.Location = new System.Drawing.Point(17, 13);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbProfilePicture.ShadowDecoration.Parent = this.pbProfilePicture;
            this.pbProfilePicture.Size = new System.Drawing.Size(60, 60);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 0;
            this.pbProfilePicture.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTop.BackgroundImage")));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.MinimizeButton);
            this.panelTop.Controls.Add(this.MaximizeButton);
            this.panelTop.Controls.Add(this.ExitButton);
            this.panelTop.Controls.Add(this.gunaLabel2);
            this.panelTop.Controls.Add(this.gunaLabel1);
            this.panelTop.Controls.Add(this.gunaPictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(197, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1003, 75);
            this.panelTop.TabIndex = 1;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeButton.FillColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.HoverState.Parent = this.MinimizeButton;
            this.MinimizeButton.IconColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(856, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.ShadowDecoration.Parent = this.MinimizeButton;
            this.MinimizeButton.Size = new System.Drawing.Size(45, 42);
            this.MinimizeButton.TabIndex = 32;
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.MaximizeButton.FillColor = System.Drawing.Color.Transparent;
            this.MaximizeButton.HoverState.Parent = this.MaximizeButton;
            this.MaximizeButton.IconColor = System.Drawing.Color.White;
            this.MaximizeButton.Location = new System.Drawing.Point(907, 0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.ShadowDecoration.Parent = this.MaximizeButton;
            this.MaximizeButton.Size = new System.Drawing.Size(45, 42);
            this.MaximizeButton.TabIndex = 31;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FillColor = System.Drawing.Color.Transparent;
            this.ExitButton.HoverState.Parent = this.ExitButton;
            this.ExitButton.IconColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(958, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(45, 42);
            this.ExitButton.TabIndex = 30;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(11, 34);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(143, 28);
            this.gunaLabel2.TabIndex = 25;
            this.gunaLabel2.Text = "COMFAMA";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(16, 60);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(722, 16);
            this.gunaLabel1.TabIndex = 24;
            this.gunaLabel1.Text = "Computer Facilities and Inventory Management with Decision Support System for Cav" +
    "ite State University - Imus";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.Image = global::Final.Resource1.kuya_logo_1_2_white;
            this.gunaPictureBox1.Location = new System.Drawing.Point(103, 10);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(132, 99);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 23;
            this.gunaPictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.ucDatabase1);
            this.panelContainer.Controls.Add(this.ucManageUser1);
            this.panelContainer.Controls.Add(this.ucLoginHistory1);
            this.panelContainer.Controls.Add(this.ucMaintenanceReport1);
            this.panelContainer.Controls.Add(this.ucInventory1);
            this.panelContainer.Controls.Add(this.ucComputerFacility1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(197, 75);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1003, 625);
            this.panelContainer.TabIndex = 2;
            // 
            // ucDatabase1
            // 
            this.ucDatabase1.BackColor = System.Drawing.Color.White;
            this.ucDatabase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDatabase1.Location = new System.Drawing.Point(0, 0);
            this.ucDatabase1.Name = "ucDatabase1";
            this.ucDatabase1.Size = new System.Drawing.Size(1003, 625);
            this.ucDatabase1.TabIndex = 5;
            this.ucDatabase1.Visible = false;
            // 
            // ucManageUser1
            // 
            this.ucManageUser1.BackColor = System.Drawing.Color.White;
            this.ucManageUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManageUser1.Location = new System.Drawing.Point(0, 0);
            this.ucManageUser1.Name = "ucManageUser1";
            this.ucManageUser1.Size = new System.Drawing.Size(1003, 625);
            this.ucManageUser1.TabIndex = 4;
            this.ucManageUser1.Visible = false;
            // 
            // ucLoginHistory1
            // 
            this.ucLoginHistory1.BackColor = System.Drawing.Color.White;
            this.ucLoginHistory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLoginHistory1.Location = new System.Drawing.Point(0, 0);
            this.ucLoginHistory1.Name = "ucLoginHistory1";
            this.ucLoginHistory1.Size = new System.Drawing.Size(1003, 625);
            this.ucLoginHistory1.TabIndex = 3;
            this.ucLoginHistory1.Visible = false;
            // 
            // ucMaintenanceReport1
            // 
            this.ucMaintenanceReport1.BackColor = System.Drawing.Color.White;
            this.ucMaintenanceReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMaintenanceReport1.Location = new System.Drawing.Point(0, 0);
            this.ucMaintenanceReport1.Name = "ucMaintenanceReport1";
            this.ucMaintenanceReport1.Size = new System.Drawing.Size(1003, 625);
            this.ucMaintenanceReport1.TabIndex = 2;
            this.ucMaintenanceReport1.Visible = false;
            // 
            // ucInventory1
            // 
            this.ucInventory1.BackColor = System.Drawing.Color.White;
            this.ucInventory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInventory1.Location = new System.Drawing.Point(0, 0);
            this.ucInventory1.Name = "ucInventory1";
            this.ucInventory1.Size = new System.Drawing.Size(1003, 625);
            this.ucInventory1.TabIndex = 1;
            this.ucInventory1.Visible = false;
            // 
            // ucComputerFacility1
            // 
            this.ucComputerFacility1.BackColor = System.Drawing.Color.White;
            this.ucComputerFacility1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucComputerFacility1.Location = new System.Drawing.Point(0, 0);
            this.ucComputerFacility1.Name = "ucComputerFacility1";
            this.ucComputerFacility1.Size = new System.Drawing.Size(1003, 625);
            this.ucComputerFacility1.TabIndex = 0;
            this.ucComputerFacility1.Visible = false;
            // 
            // timerLectureSession
            // 
            this.timerLectureSession.Interval = 1000;
            this.timerLectureSession.Tick += new System.EventHandler(this.timerLectureSession_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comfama";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox MaximizeButton;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbProfilePicture;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lblFullName;
        private System.Windows.Forms.Panel panelNav;
        private includes.uc.frmDashboard.navigation.ucStudentNav ucStudentNav1;
        private includes.uc.frmDashboard.navigation.ucSuperAdministratorNav ucSuperAdministratorNav1;
        private includes.uc.frmDashboard.admin.cf.ucComputerFacility ucComputerFacility1;
        private System.Windows.Forms.Timer timerLectureSession;
        private includes.uc.frmDashboard.admin.inv.ucInventoryManagement ucInventory1;
        private includes.uc.frmDashboard.admin.mr.ucMaintenanceReport ucMaintenanceReport1;
        private includes.uc.frmDashboard.admin.lh.ucLoginHistory ucLoginHistory1;
        private includes.uc.frmDashboard.admin.mu.ucManageUser ucManageUser1;
        private includes.uc.frmDashboard.admin.db.ucDatabase ucDatabase1;
    }
}