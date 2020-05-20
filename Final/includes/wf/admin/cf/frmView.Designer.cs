namespace Final.includes.wf.admin.cf
{
    partial class frmView
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
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblLiveView = new Guna.UI.WinForms.GunaLabel();
            this.pbLiveView = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timerDisplayScreenCapture = new System.Windows.Forms.Timer(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btnScreenshot = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLiveView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FillColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnExit.Location = new System.Drawing.Point(653, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(45, 42);
            this.btnExit.TabIndex = 30;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLiveView
            // 
            this.lblLiveView.AutoSize = true;
            this.lblLiveView.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiveView.ForeColor = System.Drawing.Color.Gray;
            this.lblLiveView.Location = new System.Drawing.Point(78, 16);
            this.lblLiveView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLiveView.Name = "lblLiveView";
            this.lblLiveView.Size = new System.Drawing.Size(69, 17);
            this.lblLiveView.TabIndex = 32;
            this.lblLiveView.Text = "Live View:";
            // 
            // pbLiveView
            // 
            this.pbLiveView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbLiveView.Location = new System.Drawing.Point(0, 50);
            this.pbLiveView.Name = "pbLiveView";
            this.pbLiveView.Size = new System.Drawing.Size(700, 450);
            this.pbLiveView.TabIndex = 33;
            this.pbLiveView.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 15);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(61, 18);
            this.guna2HtmlLabel1.TabIndex = 34;
            this.guna2HtmlLabel1.Text = "Live View:";
            // 
            // timerDisplayScreenCapture
            // 
            this.timerDisplayScreenCapture.Interval = 1000;
            this.timerDisplayScreenCapture.Tick += new System.EventHandler(this.timerDisplayScreenCapture_Tick);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScreenshot.AnimationHoverSpeed = 0.07F;
            this.btnScreenshot.AnimationSpeed = 0.03F;
            this.btnScreenshot.BaseColor = System.Drawing.Color.White;
            this.btnScreenshot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnScreenshot.BorderSize = 1;
            this.btnScreenshot.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnScreenshot.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnScreenshot.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnScreenshot.CheckedImage = null;
            this.btnScreenshot.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnScreenshot.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnScreenshot.FocusedColor = System.Drawing.Color.Empty;
            this.btnScreenshot.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenshot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnScreenshot.Image = null;
            this.btnScreenshot.ImageSize = new System.Drawing.Size(30, 30);
            this.btnScreenshot.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnScreenshot.Location = new System.Drawing.Point(416, 9);
            this.btnScreenshot.Margin = new System.Windows.Forms.Padding(0);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnScreenshot.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnScreenshot.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnScreenshot.OnHoverImage = null;
            this.btnScreenshot.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnScreenshot.OnPressedColor = System.Drawing.Color.Black;
            this.btnScreenshot.Size = new System.Drawing.Size(146, 29);
            this.btnScreenshot.TabIndex = 46;
            this.btnScreenshot.Text = "Screenshot";
            this.btnScreenshot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(602, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 42);
            this.guna2ControlBox1.TabIndex = 47;
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnScreenshot);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pbLiveView);
            this.Controls.Add(this.lblLiveView);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmView";
            ((System.ComponentModel.ISupportInitialize)(this.pbLiveView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI.WinForms.GunaLabel lblLiveView;
        private System.Windows.Forms.PictureBox pbLiveView;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Timer timerDisplayScreenCapture;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaAdvenceButton btnScreenshot;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

    }
}