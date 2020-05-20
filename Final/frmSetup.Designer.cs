namespace Final
{
    partial class frmSetup
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
            this.ucServer1 = new Final.includes.uc.frmSetup.ucServer();
            this.ucInstallationType1 = new Final.includes.uc.frmSetup.ucInstallationType();
            this.ucSubServer1 = new Final.includes.uc.frmSetup.ucSubServer();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.ucSubServer1);
            this.panelContainer.Controls.Add(this.ucServer1);
            this.panelContainer.Controls.Add(this.ucInstallationType1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(700, 500);
            this.panelContainer.TabIndex = 0;
            // 
            // ucServer1
            // 
            this.ucServer1.BackColor = System.Drawing.Color.White;
            this.ucServer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucServer1.Location = new System.Drawing.Point(0, 0);
            this.ucServer1.Name = "ucServer1";
            this.ucServer1.Size = new System.Drawing.Size(700, 500);
            this.ucServer1.TabIndex = 1;
            this.ucServer1.Visible = false;
            // 
            // ucInstallationType1
            // 
            this.ucInstallationType1.BackColor = System.Drawing.Color.White;
            this.ucInstallationType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInstallationType1.Location = new System.Drawing.Point(0, 0);
            this.ucInstallationType1.Name = "ucInstallationType1";
            this.ucInstallationType1.Size = new System.Drawing.Size(700, 500);
            this.ucInstallationType1.TabIndex = 0;
            // 
            // ucSubServer1
            // 
            this.ucSubServer1.BackColor = System.Drawing.Color.White;
            this.ucSubServer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSubServer1.Location = new System.Drawing.Point(0, 0);
            this.ucSubServer1.Name = "ucSubServer1";
            this.ucSubServer1.Size = new System.Drawing.Size(700, 500);
            this.ucSubServer1.TabIndex = 2;
            this.ucSubServer1.type = null;
            this.ucSubServer1.Visible = false;
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.frmSetup_Load);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private includes.uc.frmSetup.ucInstallationType ucInstallationType1;
        private includes.uc.frmSetup.ucServer ucServer1;
        private includes.uc.frmSetup.ucSubServer ucSubServer1;
    }
}

