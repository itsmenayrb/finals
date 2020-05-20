namespace Final
{
    partial class frmLogin
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.ucRegister1 = new Final.includes.uc.frmLogin.ucRegister();
            this.ucLogin1 = new Final.includes.uc.frmLogin.ucLogin();
            this.ucActivateAccount1 = new Final.includes.uc.frmLogin.ucActivateAccount();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.ucActivateAccount1);
            this.panelContainer.Controls.Add(this.ucRegister1);
            this.panelContainer.Controls.Add(this.ucLogin1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(700, 500);
            this.panelContainer.TabIndex = 0;
            // 
            // ucRegister1
            // 
            this.ucRegister1.BackColor = System.Drawing.Color.White;
            this.ucRegister1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRegister1.Location = new System.Drawing.Point(0, 0);
            this.ucRegister1.Name = "ucRegister1";
            this.ucRegister1.Size = new System.Drawing.Size(700, 500);
            this.ucRegister1.TabIndex = 1;
            this.ucRegister1.Visible = false;
            // 
            // ucLogin1
            // 
            this.ucLogin1.BackColor = System.Drawing.Color.White;
            this.ucLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLogin1.Location = new System.Drawing.Point(0, 0);
            this.ucLogin1.Name = "ucLogin1";
            this.ucLogin1.Size = new System.Drawing.Size(700, 500);
            this.ucLogin1.TabIndex = 0;
            // 
            // ucActivateAccount1
            // 
            this.ucActivateAccount1.BackColor = System.Drawing.Color.White;
            this.ucActivateAccount1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucActivateAccount1.Location = new System.Drawing.Point(0, 0);
            this.ucActivateAccount1.Name = "ucActivateAccount1";
            this.ucActivateAccount1.Size = new System.Drawing.Size(700, 500);
            this.ucActivateAccount1.TabIndex = 2;
            this.ucActivateAccount1.username = null;
            this.ucActivateAccount1.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private includes.uc.frmLogin.ucRegister ucRegister1;
        private includes.uc.frmLogin.ucLogin ucLogin1;
        private includes.uc.frmLogin.ucActivateAccount ucActivateAccount1;

    }
}