namespace Final.includes.wf.admin.inv
{
    partial class frmAddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSupplier));
            this.btnBack = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMessage = new Guna.UI.WinForms.GunaLabel();
            this.lblBusinessType = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtSupplierID = new Guna.UI.WinForms.GunaTextBox();
            this.txtSupplierName = new Guna.UI.WinForms.GunaTextBox();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtContactNumber = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtTin = new Guna.UI.WinForms.GunaTextBox();
            this.btnSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUpload = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
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
            this.btnBack.TabIndex = 114;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(74, 64);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(104, 21);
            this.guna2HtmlLabel1.TabIndex = 115;
            this.guna2HtmlLabel1.Text = "Add Supplier";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Gray;
            this.lblMessage.Location = new System.Drawing.Point(71, 88);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(296, 23);
            this.lblMessage.TabIndex = 116;
            this.lblMessage.Text = "Please indicate supplier information.";
            // 
            // lblBusinessType
            // 
            this.lblBusinessType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessType.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBusinessType.Location = new System.Drawing.Point(165, 120);
            this.lblBusinessType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusinessType.Name = "lblBusinessType";
            this.lblBusinessType.Size = new System.Drawing.Size(153, 18);
            this.lblBusinessType.TabIndex = 118;
            this.lblBusinessType.Text = "Recommended pixels is 30";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(71, 119);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(90, 16);
            this.gunaLabel1.TabIndex = 117;
            this.gunaLabel1.Text = "Business Type:";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.BackColor = System.Drawing.Color.Transparent;
            this.txtSupplierID.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtSupplierID.BorderColor = System.Drawing.Color.Silver;
            this.txtSupplierID.BorderSize = 1;
            this.txtSupplierID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplierID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSupplierID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtSupplierID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSupplierID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierID.Location = new System.Drawing.Point(74, 140);
            this.txtSupplierID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.PasswordChar = '\0';
            this.txtSupplierID.SelectedText = "";
            this.txtSupplierID.Size = new System.Drawing.Size(305, 34);
            this.txtSupplierID.TabIndex = 0;
            this.txtSupplierID.Text = "Registration/Supplier ID";
            this.txtSupplierID.TextOffsetX = 5;
            this.txtSupplierID.Enter += new System.EventHandler(this.txtSupplierID_Enter);
            this.txtSupplierID.Leave += new System.EventHandler(this.txtSupplierID_Leave);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BackColor = System.Drawing.Color.Transparent;
            this.txtSupplierName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtSupplierName.BorderColor = System.Drawing.Color.Silver;
            this.txtSupplierName.BorderSize = 1;
            this.txtSupplierName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplierName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSupplierName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtSupplierName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSupplierName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(74, 178);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PasswordChar = '\0';
            this.txtSupplierName.SelectedText = "";
            this.txtSupplierName.Size = new System.Drawing.Size(305, 34);
            this.txtSupplierName.TabIndex = 1;
            this.txtSupplierName.Text = "Business Name";
            this.txtSupplierName.TextOffsetX = 5;
            this.txtSupplierName.Enter += new System.EventHandler(this.txtSupplierName_Enter);
            this.txtSupplierName.Leave += new System.EventHandler(this.txtSupplierName_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAddress.BorderSize = 1;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(74, 216);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(305, 63);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Text = "Business Address";
            this.txtAddress.TextOffsetX = 5;
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtContactNumber.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtContactNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtContactNumber.BorderSize = 1;
            this.txtContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtContactNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtContactNumber.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtContactNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(74, 283);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.PasswordChar = '\0';
            this.txtContactNumber.SelectedText = "";
            this.txtContactNumber.Size = new System.Drawing.Size(305, 34);
            this.txtContactNumber.TabIndex = 3;
            this.txtContactNumber.Text = "Business Contact Number (Optional)";
            this.txtContactNumber.TextOffsetX = 5;
            this.txtContactNumber.Enter += new System.EventHandler(this.txtContactNumber_Enter);
            this.txtContactNumber.Leave += new System.EventHandler(this.txtContactNumber_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(74, 321);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(305, 34);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "Business Email (Optional)";
            this.txtEmail.TextOffsetX = 5;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtTin
            // 
            this.txtTin.BackColor = System.Drawing.Color.Transparent;
            this.txtTin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtTin.BorderColor = System.Drawing.Color.Silver;
            this.txtTin.BorderSize = 1;
            this.txtTin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTin.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtTin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTin.Location = new System.Drawing.Point(74, 359);
            this.txtTin.Margin = new System.Windows.Forms.Padding(2);
            this.txtTin.Name = "txtTin";
            this.txtTin.PasswordChar = '\0';
            this.txtTin.SelectedText = "";
            this.txtTin.Size = new System.Drawing.Size(305, 34);
            this.txtTin.TabIndex = 5;
            this.txtTin.Text = "TIN Number (Optional)";
            this.txtTin.TextOffsetX = 5;
            this.txtTin.Enter += new System.EventHandler(this.txtTin_Enter);
            this.txtTin.Leave += new System.EventHandler(this.txtTin_Leave);
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BaseColor = System.Drawing.Color.White;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnSave.BorderSize = 1;
            this.btnSave.Checked = true;
            this.btnSave.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnSave.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSave.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSave.CheckedImage = null;
            this.btnSave.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSave.Location = new System.Drawing.Point(74, 453);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(178, 35);
            this.btnSave.TabIndex = 125;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.AnimationHoverSpeed = 0.07F;
            this.btnUpload.AnimationSpeed = 0.03F;
            this.btnUpload.BaseColor = System.Drawing.Color.White;
            this.btnUpload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnUpload.BorderSize = 1;
            this.btnUpload.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnUpload.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUpload.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnUpload.CheckedImage = null;
            this.btnUpload.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUpload.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpload.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpload.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnUpload.Image = null;
            this.btnUpload.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpload.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpload.Location = new System.Drawing.Point(134, 399);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnUpload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpload.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnUpload.OnHoverImage = null;
            this.btnUpload.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpload.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpload.Size = new System.Drawing.Size(63, 23);
            this.btnUpload.TabIndex = 126;
            this.btnUpload.TabStop = false;
            this.btnUpload.Text = "Upload";
            this.btnUpload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.Image = ((System.Drawing.Image)(resources.GetObject("pbPreview.Image")));
            this.pbPreview.Location = new System.Drawing.Point(344, 395);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(35, 34);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreview.TabIndex = 127;
            this.pbPreview.TabStop = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel3.Location = new System.Drawing.Point(71, 402);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(61, 17);
            this.gunaLabel3.TabIndex = 128;
            this.gunaLabel3.Text = "Set Logo";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.gunaLabel2.Location = new System.Drawing.Point(199, 403);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(140, 18);
            this.gunaLabel2.TabIndex = 129;
            this.gunaLabel2.Text = "Max: 2MB";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // frmAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 538);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.lblBusinessType);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnBack;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI.WinForms.GunaLabel lblMessage;
        private Guna.UI.WinForms.GunaLabel lblBusinessType;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtSupplierID;
        private Guna.UI.WinForms.GunaTextBox txtSupplierName;
        private Guna.UI.WinForms.GunaTextBox txtAddress;
        private Guna.UI.WinForms.GunaTextBox txtContactNumber;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaTextBox txtTin;
        private Guna.UI.WinForms.GunaAdvenceButton btnSave;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpload;
        private System.Windows.Forms.PictureBox pbPreview;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}