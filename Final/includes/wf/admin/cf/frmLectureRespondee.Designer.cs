namespace Final.includes.wf.admin.cf
{
    partial class frmLectureRespondee
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLiveView = new Guna.UI.WinForms.GunaLabel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.clbClient = new System.Windows.Forms.CheckedListBox();
            this.btnStart = new Guna.UI.WinForms.GunaAdvenceButton();
            this.timerWaitingToClientToAccept = new System.Windows.Forms.Timer(this.components);
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.guna2ControlBox1.TabIndex = 55;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 15);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(34, 18);
            this.guna2HtmlLabel1.TabIndex = 54;
            this.guna2HtmlLabel1.Text = "Note:";
            // 
            // lblLiveView
            // 
            this.lblLiveView.AutoSize = true;
            this.lblLiveView.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiveView.ForeColor = System.Drawing.Color.Gray;
            this.lblLiveView.Location = new System.Drawing.Point(51, 16);
            this.lblLiveView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLiveView.Name = "lblLiveView";
            this.lblLiveView.Size = new System.Drawing.Size(350, 17);
            this.lblLiveView.TabIndex = 53;
            this.lblLiveView.Text = "Please wait until all connected user accepts your request.";
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
            this.btnExit.TabIndex = 52;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.clbClient);
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(12, 50);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(676, 386);
            this.gunaLinePanel1.TabIndex = 56;
            // 
            // clbClient
            // 
            this.clbClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbClient.ColumnWidth = 200;
            this.clbClient.Enabled = false;
            this.clbClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbClient.FormattingEnabled = true;
            this.clbClient.Location = new System.Drawing.Point(21, 20);
            this.clbClient.Name = "clbClient";
            this.clbClient.Size = new System.Drawing.Size(635, 342);
            this.clbClient.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.AnimationHoverSpeed = 0.07F;
            this.btnStart.AnimationSpeed = 0.03F;
            this.btnStart.BaseColor = System.Drawing.Color.White;
            this.btnStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnStart.BorderSize = 1;
            this.btnStart.Checked = true;
            this.btnStart.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnStart.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnStart.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnStart.CheckedImage = null;
            this.btnStart.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStart.Enabled = false;
            this.btnStart.FocusedColor = System.Drawing.Color.Empty;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnStart.Image = null;
            this.btnStart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStart.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStart.Location = new System.Drawing.Point(261, 447);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnStart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStart.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnStart.OnHoverImage = null;
            this.btnStart.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStart.OnPressedColor = System.Drawing.Color.Black;
            this.btnStart.Size = new System.Drawing.Size(178, 35);
            this.btnStart.TabIndex = 98;
            this.btnStart.Text = "Start (F5)";
            this.btnStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerWaitingToClientToAccept
            // 
            this.timerWaitingToClientToAccept.Interval = 1000;
            this.timerWaitingToClientToAccept.Tick += new System.EventHandler(this.timerWaitingToClientToAccept_Tick);
            // 
            // frmLectureRespondee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lblLiveView);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLectureRespondee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gunaLinePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI.WinForms.GunaLabel lblLiveView;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.CheckedListBox clbClient;
        private Guna.UI.WinForms.GunaAdvenceButton btnStart;
        private System.Windows.Forms.Timer timerWaitingToClientToAccept;
    }
}