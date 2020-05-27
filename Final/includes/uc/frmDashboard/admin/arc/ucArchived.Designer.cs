namespace Final.includes.uc.frmDashboard.admin.arc
{
    partial class ucArchived
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnArchived = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.gunaLinePanel7 = new Guna.UI.WinForms.GunaLinePanel();
            this.tvArchived = new System.Windows.Forms.TreeView();
            this.ucInventory1 = new Final.includes.uc.frmDashboard.admin.arc.ucInventory();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.gunaLinePanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnArchived);
            this.panelTop.Controls.Add(this.gunaLabel4);
            this.panelTop.Controls.Add(this.guna2HtmlLabel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1003, 104);
            this.panelTop.TabIndex = 2;
            // 
            // btnArchived
            // 
            this.btnArchived.Animated = true;
            this.btnArchived.AnimationHoverSpeed = 0.07F;
            this.btnArchived.AnimationSpeed = 0.03F;
            this.btnArchived.BaseColor = System.Drawing.Color.White;
            this.btnArchived.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnArchived.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnArchived.Checked = true;
            this.btnArchived.CheckedBaseColor = System.Drawing.Color.White;
            this.btnArchived.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnArchived.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnArchived.CheckedImage = null;
            this.btnArchived.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnArchived.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnArchived.FocusedColor = System.Drawing.Color.Empty;
            this.btnArchived.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnArchived.Image = null;
            this.btnArchived.ImageSize = new System.Drawing.Size(30, 30);
            this.btnArchived.LineBottom = 2;
            this.btnArchived.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnArchived.Location = new System.Drawing.Point(28, 74);
            this.btnArchived.Name = "btnArchived";
            this.btnArchived.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnArchived.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnArchived.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnArchived.OnHoverImage = null;
            this.btnArchived.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnArchived.OnPressedColor = System.Drawing.Color.Black;
            this.btnArchived.Size = new System.Drawing.Size(106, 29);
            this.btnArchived.TabIndex = 98;
            this.btnArchived.Text = "Archived";
            this.btnArchived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel4.Location = new System.Drawing.Point(25, 46);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(161, 16);
            this.gunaLabel4.TabIndex = 89;
            this.gunaLabel4.Text = "View past and present data";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(23, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(130, 38);
            this.guna2HtmlLabel1.TabIndex = 87;
            this.guna2HtmlLabel1.Text = "Archived";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaLinePanel1);
            this.panel1.Controls.Add(this.gunaLinePanel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 521);
            this.panel1.TabIndex = 3;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.panelContainer);
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(219, 26);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(750, 463);
            this.gunaLinePanel1.TabIndex = 213;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.ucInventory1);
            this.panelContainer.Location = new System.Drawing.Point(13, 14);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(723, 433);
            this.panelContainer.TabIndex = 0;
            // 
            // gunaLinePanel7
            // 
            this.gunaLinePanel7.Controls.Add(this.tvArchived);
            this.gunaLinePanel7.LineBottom = 1;
            this.gunaLinePanel7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.gunaLinePanel7.LineLeft = 1;
            this.gunaLinePanel7.LineRight = 1;
            this.gunaLinePanel7.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel7.LineTop = 1;
            this.gunaLinePanel7.Location = new System.Drawing.Point(28, 26);
            this.gunaLinePanel7.Name = "gunaLinePanel7";
            this.gunaLinePanel7.Size = new System.Drawing.Size(185, 463);
            this.gunaLinePanel7.TabIndex = 16;
            // 
            // tvArchived
            // 
            this.tvArchived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvArchived.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvArchived.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tvArchived.Location = new System.Drawing.Point(14, 13);
            this.tvArchived.Name = "tvArchived";
            this.tvArchived.Size = new System.Drawing.Size(156, 434);
            this.tvArchived.TabIndex = 17;
            this.tvArchived.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvArchived_AfterSelect);
            // 
            // ucInventory1
            // 
            this.ucInventory1.academic_year_id = 0;
            this.ucInventory1.BackColor = System.Drawing.Color.White;
            this.ucInventory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInventory1.Location = new System.Drawing.Point(0, 0);
            this.ucInventory1.Name = "ucInventory1";
            this.ucInventory1.Size = new System.Drawing.Size(723, 433);
            this.ucInventory1.TabIndex = 0;
            this.ucInventory1.Visible = false;
            // 
            // ucArchived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Name = "ucArchived";
            this.Size = new System.Drawing.Size(1003, 625);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gunaLinePanel1.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.gunaLinePanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Guna.UI.WinForms.GunaAdvenceButton btnArchived;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel7;
        private System.Windows.Forms.TreeView tvArchived;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Panel panelContainer;
        private ucInventory ucInventory1;
    }
}
