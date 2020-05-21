namespace Final.includes.uc.frmDashboard.admin.inv.add_item
{
    partial class ucSelectType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSelectType));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSoftware = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnHardware = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(272, 50);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(162, 21);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Select inventory type";
            // 
            // btnSoftware
            // 
            this.btnSoftware.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSoftware.BorderRadius = 5;
            this.btnSoftware.BorderThickness = 1;
            this.btnSoftware.CheckedState.Parent = this.btnSoftware;
            this.btnSoftware.CustomImages.Parent = this.btnSoftware;
            this.btnSoftware.FillColor = System.Drawing.Color.White;
            this.btnSoftware.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftware.ForeColor = System.Drawing.Color.Black;
            this.btnSoftware.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnSoftware.HoverState.Image")));
            this.btnSoftware.HoverState.Parent = this.btnSoftware;
            this.btnSoftware.Image = ((System.Drawing.Image)(resources.GetObject("btnSoftware.Image")));
            this.btnSoftware.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSoftware.Location = new System.Drawing.Point(379, 108);
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.ShadowDecoration.Parent = this.btnSoftware;
            this.btnSoftware.Size = new System.Drawing.Size(117, 113);
            this.btnSoftware.TabIndex = 4;
            this.btnSoftware.Text = "Software";
            this.btnSoftware.Click += new System.EventHandler(this.btnSoftware_Click);
            // 
            // btnHardware
            // 
            this.btnHardware.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnHardware.BorderRadius = 5;
            this.btnHardware.BorderThickness = 1;
            this.btnHardware.CheckedState.Parent = this.btnHardware;
            this.btnHardware.CustomImages.Parent = this.btnHardware;
            this.btnHardware.FillColor = System.Drawing.Color.White;
            this.btnHardware.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnHardware.ForeColor = System.Drawing.Color.Black;
            this.btnHardware.HoverState.Parent = this.btnHardware;
            this.btnHardware.Image = ((System.Drawing.Image)(resources.GetObject("btnHardware.Image")));
            this.btnHardware.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHardware.Location = new System.Drawing.Point(208, 108);
            this.btnHardware.Name = "btnHardware";
            this.btnHardware.ShadowDecoration.Parent = this.btnHardware;
            this.btnHardware.Size = new System.Drawing.Size(117, 113);
            this.btnHardware.TabIndex = 3;
            this.btnHardware.Text = "Hardware";
            this.btnHardware.Click += new System.EventHandler(this.btnHardware_Click);
            // 
            // ucSelectType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSoftware);
            this.Controls.Add(this.btnHardware);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "ucSelectType";
            this.Size = new System.Drawing.Size(700, 407);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TileButton btnSoftware;
        private Guna.UI2.WinForms.Guna2TileButton btnHardware;
    }
}
