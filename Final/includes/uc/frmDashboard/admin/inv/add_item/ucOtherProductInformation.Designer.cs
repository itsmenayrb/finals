namespace Final.includes.uc.frmDashboard.admin.inv.add_item
{
    partial class ucOtherProductInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOtherProductInformation));
            this.lblMessage = new Guna.UI.WinForms.GunaLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPropertyNumber = new Guna.UI.WinForms.GunaTextBox();
            this.gbStatus = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdbWorking = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbDefective = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbCondemned = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dtpDateAcquired = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gbDateExpiry = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpDateExpiry = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnNext = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBack = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cbDepartment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Gray;
            this.lblMessage.Location = new System.Drawing.Point(259, 24);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(233, 23);
            this.lblMessage.TabIndex = 137;
            this.lblMessage.Text = "Please fill-up necessary fields.";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(249, 7);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(200, 21);
            this.guna2HtmlLabel1.TabIndex = 136;
            this.guna2HtmlLabel1.Text = "Other Product Information";
            // 
            // txtPropertyNumber
            // 
            this.txtPropertyNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtPropertyNumber.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtPropertyNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtPropertyNumber.BorderSize = 1;
            this.txtPropertyNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPropertyNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPropertyNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtPropertyNumber.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPropertyNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyNumber.Location = new System.Drawing.Point(161, 66);
            this.txtPropertyNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPropertyNumber.Name = "txtPropertyNumber";
            this.txtPropertyNumber.PasswordChar = '\0';
            this.txtPropertyNumber.SelectedText = "";
            this.txtPropertyNumber.Size = new System.Drawing.Size(372, 34);
            this.txtPropertyNumber.TabIndex = 0;
            this.txtPropertyNumber.Text = "Property Number";
            this.txtPropertyNumber.TextOffsetX = 5;
            this.txtPropertyNumber.Enter += new System.EventHandler(this.txtPropertyNumber_Enter);
            this.txtPropertyNumber.Leave += new System.EventHandler(this.txtPropertyNumber_Leave);
            // 
            // gbStatus
            // 
            this.gbStatus.BorderColor = System.Drawing.Color.Silver;
            this.gbStatus.Controls.Add(this.rdbCondemned);
            this.gbStatus.Controls.Add(this.rdbDefective);
            this.gbStatus.Controls.Add(this.rdbWorking);
            this.gbStatus.CustomBorderColor = System.Drawing.Color.Silver;
            this.gbStatus.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.gbStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gbStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbStatus.Location = new System.Drawing.Point(161, 145);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.ShadowDecoration.Parent = this.gbStatus;
            this.gbStatus.Size = new System.Drawing.Size(372, 104);
            this.gbStatus.TabIndex = 151;
            this.gbStatus.Text = "Status";
            // 
            // rdbWorking
            // 
            this.rdbWorking.AutoSize = true;
            this.rdbWorking.BackColor = System.Drawing.Color.Transparent;
            this.rdbWorking.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbWorking.CheckedState.BorderThickness = 0;
            this.rdbWorking.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbWorking.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbWorking.CheckedState.InnerOffset = -4;
            this.rdbWorking.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbWorking.Location = new System.Drawing.Point(19, 39);
            this.rdbWorking.Name = "rdbWorking";
            this.rdbWorking.Size = new System.Drawing.Size(146, 21);
            this.rdbWorking.TabIndex = 0;
            this.rdbWorking.Text = "Working/Subscribed";
            this.rdbWorking.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbWorking.UncheckedState.BorderThickness = 1;
            this.rdbWorking.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbWorking.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbWorking.UseVisualStyleBackColor = false;
            // 
            // rdbDefective
            // 
            this.rdbDefective.AutoSize = true;
            this.rdbDefective.BackColor = System.Drawing.Color.Transparent;
            this.rdbDefective.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbDefective.CheckedState.BorderThickness = 0;
            this.rdbDefective.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbDefective.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbDefective.CheckedState.InnerOffset = -4;
            this.rdbDefective.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbDefective.Location = new System.Drawing.Point(19, 66);
            this.rdbDefective.Name = "rdbDefective";
            this.rdbDefective.Size = new System.Drawing.Size(135, 21);
            this.rdbDefective.TabIndex = 1;
            this.rdbDefective.Text = "Expired/Defective";
            this.rdbDefective.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbDefective.UncheckedState.BorderThickness = 1;
            this.rdbDefective.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbDefective.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbDefective.UseVisualStyleBackColor = false;
            // 
            // rdbCondemned
            // 
            this.rdbCondemned.AutoSize = true;
            this.rdbCondemned.BackColor = System.Drawing.Color.Transparent;
            this.rdbCondemned.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbCondemned.CheckedState.BorderThickness = 0;
            this.rdbCondemned.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbCondemned.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbCondemned.CheckedState.InnerOffset = -4;
            this.rdbCondemned.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rdbCondemned.Location = new System.Drawing.Point(190, 39);
            this.rdbCondemned.Name = "rdbCondemned";
            this.rdbCondemned.Size = new System.Drawing.Size(100, 21);
            this.rdbCondemned.TabIndex = 2;
            this.rdbCondemned.Text = "Condemned";
            this.rdbCondemned.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbCondemned.UncheckedState.BorderThickness = 1;
            this.rdbCondemned.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbCondemned.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbCondemned.UseVisualStyleBackColor = false;
            // 
            // dtpDateAcquired
            // 
            this.dtpDateAcquired.BorderColor = System.Drawing.Color.Silver;
            this.dtpDateAcquired.BorderThickness = 1;
            this.dtpDateAcquired.CheckedState.Parent = this.dtpDateAcquired;
            this.dtpDateAcquired.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dtpDateAcquired.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dtpDateAcquired.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateAcquired.HoverState.Parent = this.dtpDateAcquired;
            this.dtpDateAcquired.Location = new System.Drawing.Point(279, 255);
            this.dtpDateAcquired.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateAcquired.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateAcquired.Name = "dtpDateAcquired";
            this.dtpDateAcquired.ShadowDecoration.Parent = this.dtpDateAcquired;
            this.dtpDateAcquired.Size = new System.Drawing.Size(254, 34);
            this.dtpDateAcquired.TabIndex = 152;
            this.dtpDateAcquired.Value = new System.DateTime(2020, 5, 21, 23, 26, 6, 795);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Silver;
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2GroupBox2.Location = new System.Drawing.Point(161, 255);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(112, 34);
            this.guna2GroupBox2.TabIndex = 153;
            this.guna2GroupBox2.Text = "Date Acquired";
            this.guna2GroupBox2.TextOffset = new System.Drawing.Point(0, -3);
            // 
            // gbDateExpiry
            // 
            this.gbDateExpiry.BorderColor = System.Drawing.Color.Silver;
            this.gbDateExpiry.CustomBorderColor = System.Drawing.Color.Silver;
            this.gbDateExpiry.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.gbDateExpiry.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gbDateExpiry.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDateExpiry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbDateExpiry.Location = new System.Drawing.Point(161, 295);
            this.gbDateExpiry.Name = "gbDateExpiry";
            this.gbDateExpiry.ShadowDecoration.Parent = this.gbDateExpiry;
            this.gbDateExpiry.Size = new System.Drawing.Size(112, 34);
            this.gbDateExpiry.TabIndex = 154;
            this.gbDateExpiry.Text = "Date Expiry";
            this.gbDateExpiry.TextOffset = new System.Drawing.Point(0, -3);
            // 
            // dtpDateExpiry
            // 
            this.dtpDateExpiry.BorderColor = System.Drawing.Color.Silver;
            this.dtpDateExpiry.BorderThickness = 1;
            this.dtpDateExpiry.CheckedState.Parent = this.dtpDateExpiry;
            this.dtpDateExpiry.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dtpDateExpiry.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dtpDateExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateExpiry.HoverState.Parent = this.dtpDateExpiry;
            this.dtpDateExpiry.Location = new System.Drawing.Point(279, 295);
            this.dtpDateExpiry.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateExpiry.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateExpiry.Name = "dtpDateExpiry";
            this.dtpDateExpiry.ShadowDecoration.Parent = this.dtpDateExpiry;
            this.dtpDateExpiry.Size = new System.Drawing.Size(254, 34);
            this.dtpDateExpiry.TabIndex = 155;
            this.dtpDateExpiry.Value = new System.DateTime(2020, 5, 21, 23, 26, 6, 795);
            this.dtpDateExpiry.ValueChanged += new System.EventHandler(this.dtpDateExpiry_ValueChanged);
            // 
            // btnNext
            // 
            this.btnNext.AnimationHoverSpeed = 0.07F;
            this.btnNext.AnimationSpeed = 0.03F;
            this.btnNext.BaseColor = System.Drawing.Color.White;
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnNext.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnNext.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNext.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnNext.CheckedImage = null;
            this.btnNext.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.FocusedColor = System.Drawing.Color.Empty;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.ImageOffsetX = 8;
            this.btnNext.ImageSize = new System.Drawing.Size(15, 15);
            this.btnNext.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNext.Location = new System.Drawing.Point(588, 359);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnNext.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNext.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnNext.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnNext.OnHoverImage")));
            this.btnNext.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNext.OnPressedColor = System.Drawing.Color.Black;
            this.btnNext.Size = new System.Drawing.Size(112, 22);
            this.btnNext.TabIndex = 156;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.btnBack.Location = new System.Drawing.Point(0, 359);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnBack.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnBack.OnHoverImage")));
            this.btnBack.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(112, 22);
            this.btnBack.TabIndex = 157;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbDepartment
            // 
            this.cbDepartment.BackColor = System.Drawing.Color.Transparent;
            this.cbDepartment.BorderColor = System.Drawing.Color.Silver;
            this.cbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbDepartment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDepartment.FocusedState.Parent = this.cbDepartment;
            this.cbDepartment.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cbDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDepartment.HoverState.Parent = this.cbDepartment;
            this.cbDepartment.ItemHeight = 28;
            this.cbDepartment.Items.AddRange(new object[] {
            "--Select--",
            "bit",
            "Byte",
            "Kilobyte",
            "Megabyte",
            "Gigabyte",
            "Terabyte",
            "Petabyte",
            "Exabyte",
            "Zettabyte",
            "Yottabyte"});
            this.cbDepartment.ItemsAppearance.Parent = this.cbDepartment;
            this.cbDepartment.Location = new System.Drawing.Point(161, 105);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.ShadowDecoration.Parent = this.cbDepartment;
            this.cbDepartment.Size = new System.Drawing.Size(372, 34);
            this.cbDepartment.StartIndex = 0;
            this.cbDepartment.TabIndex = 1;
            // 
            // ucOtherProductInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dtpDateExpiry);
            this.Controls.Add(this.gbDateExpiry);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.dtpDateAcquired);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.txtPropertyNumber);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "ucOtherProductInformation";
            this.Size = new System.Drawing.Size(700, 407);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblMessage;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI.WinForms.GunaTextBox txtPropertyNumber;
        private Guna.UI2.WinForms.Guna2GroupBox gbStatus;
        private Guna.UI2.WinForms.Guna2RadioButton rdbCondemned;
        private Guna.UI2.WinForms.Guna2RadioButton rdbDefective;
        private Guna.UI2.WinForms.Guna2RadioButton rdbWorking;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateAcquired;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox gbDateExpiry;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateExpiry;
        private Guna.UI.WinForms.GunaAdvenceButton btnNext;
        private Guna.UI.WinForms.GunaAdvenceButton btnBack;
        private Guna.UI2.WinForms.Guna2ComboBox cbDepartment;
    }
}
