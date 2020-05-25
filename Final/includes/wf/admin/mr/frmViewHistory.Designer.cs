namespace Final.includes.wf.admin.mr
{
    partial class frmViewHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewHistory));
            this.btnBack = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gbTicketID = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblStatus = new Guna.UI.WinForms.GunaLabel();
            this.lblDateReported = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtDescription = new Guna.UI.WinForms.GunaTextBox();
            this.txtProblem = new Guna.UI.WinForms.GunaTextBox();
            this.gbFeedback = new Guna.UI2.WinForms.Guna2GroupBox();
            this.flpFeedbackHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
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
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageOffsetX = 8;
            this.btnBack.ImageSize = new System.Drawing.Size(15, 15);
            this.btnBack.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBack.Location = new System.Drawing.Point(-1, 12);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnBack.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnBack.OnHoverImage")));
            this.btnBack.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(112, 22);
            this.btnBack.TabIndex = 211;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbTicketID
            // 
            this.gbTicketID.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.gbTicketID.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gbTicketID.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gbTicketID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTicketID.ForeColor = System.Drawing.Color.Black;
            this.gbTicketID.Location = new System.Drawing.Point(66, 43);
            this.gbTicketID.Name = "gbTicketID";
            this.gbTicketID.ShadowDecoration.Parent = this.gbTicketID;
            this.gbTicketID.Size = new System.Drawing.Size(567, 27);
            this.gbTicketID.TabIndex = 214;
            this.gbTicketID.Text = "Ticket ID:";
            this.gbTicketID.TextOffset = new System.Drawing.Point(5, -7);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGray;
            this.lblStatus.Location = new System.Drawing.Point(133, 95);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(363, 18);
            this.lblStatus.TabIndex = 232;
            this.lblStatus.Text = "Recommended pixels is 30";
            // 
            // lblDateReported
            // 
            this.lblDateReported.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReported.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDateReported.Location = new System.Drawing.Point(185, 76);
            this.lblDateReported.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateReported.Name = "lblDateReported";
            this.lblDateReported.Size = new System.Drawing.Size(363, 18);
            this.lblDateReported.TabIndex = 231;
            this.lblDateReported.Text = "Recommended pixels is 30";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel2.Location = new System.Drawing.Point(86, 94);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(43, 16);
            this.gunaLabel2.TabIndex = 230;
            this.gunaLabel2.Text = "Status:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(86, 75);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(95, 16);
            this.gunaLabel1.TabIndex = 229;
            this.gunaLabel1.Text = "Date Reported:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtDescription.BorderColor = System.Drawing.Color.Silver;
            this.txtDescription.BorderSize = 1;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescription.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtDescription.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(89, 156);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ReadOnly = true;
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(522, 86);
            this.txtDescription.TabIndex = 228;
            this.txtDescription.TextOffsetX = 5;
            // 
            // txtProblem
            // 
            this.txtProblem.BackColor = System.Drawing.Color.Transparent;
            this.txtProblem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtProblem.BorderColor = System.Drawing.Color.Silver;
            this.txtProblem.BorderSize = 1;
            this.txtProblem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProblem.FocusedBaseColor = System.Drawing.Color.White;
            this.txtProblem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtProblem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProblem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProblem.Location = new System.Drawing.Point(89, 118);
            this.txtProblem.Margin = new System.Windows.Forms.Padding(2);
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.PasswordChar = '\0';
            this.txtProblem.ReadOnly = true;
            this.txtProblem.SelectedText = "";
            this.txtProblem.Size = new System.Drawing.Size(522, 34);
            this.txtProblem.TabIndex = 227;
            this.txtProblem.TextOffsetX = 5;
            // 
            // gbFeedback
            // 
            this.gbFeedback.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.gbFeedback.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.gbFeedback.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gbFeedback.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFeedback.ForeColor = System.Drawing.Color.Black;
            this.gbFeedback.Location = new System.Drawing.Point(66, 250);
            this.gbFeedback.Name = "gbFeedback";
            this.gbFeedback.ShadowDecoration.Parent = this.gbFeedback;
            this.gbFeedback.Size = new System.Drawing.Size(567, 27);
            this.gbFeedback.TabIndex = 233;
            this.gbFeedback.Text = "Feedback:";
            this.gbFeedback.TextOffset = new System.Drawing.Point(5, -7);
            // 
            // flpFeedbackHistory
            // 
            this.flpFeedbackHistory.AutoScroll = true;
            this.flpFeedbackHistory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFeedbackHistory.Location = new System.Drawing.Point(89, 286);
            this.flpFeedbackHistory.Name = "flpFeedbackHistory";
            this.flpFeedbackHistory.Size = new System.Drawing.Size(544, 263);
            this.flpFeedbackHistory.TabIndex = 234;
            // 
            // frmViewHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.flpFeedbackHistory);
            this.Controls.Add(this.gbFeedback);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDateReported);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtProblem);
            this.Controls.Add(this.gbTicketID);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnBack;
        private Guna.UI2.WinForms.Guna2GroupBox gbTicketID;
        private Guna.UI.WinForms.GunaLabel lblStatus;
        private Guna.UI.WinForms.GunaLabel lblDateReported;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtDescription;
        private Guna.UI.WinForms.GunaTextBox txtProblem;
        private Guna.UI2.WinForms.Guna2GroupBox gbFeedback;
        private System.Windows.Forms.FlowLayoutPanel flpFeedbackHistory;
    }
}