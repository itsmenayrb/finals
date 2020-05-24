namespace Final.includes.wf.admin.inv
{
    partial class frmUpdateProductInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateProductInformation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNewStock = new Guna.UI.WinForms.GunaLabel();
            this.txtItemName = new Guna.UI.WinForms.GunaTextBox();
            this.lblCurrentStock = new Guna.UI.WinForms.GunaLabel();
            this.lblStockTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnBack = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtDescription = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtBrand = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtModel = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtSerialNumber = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.chkCapacity = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.txtCapacity = new Guna.UI.WinForms.GunaTextBox();
            this.cbCapacity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtPropertyNumber = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.rdbCondemned = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbDefective = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbWorking = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dtpDateAcquired = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.lblDateExpiry = new Guna.UI.WinForms.GunaLabel();
            this.dtpDateExpiry = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dtpDateExpiry);
            this.panel1.Controls.Add(this.lblDateExpiry);
            this.panel1.Controls.Add(this.gunaLabel7);
            this.panel1.Controls.Add(this.dtpDateAcquired);
            this.panel1.Controls.Add(this.rdbCondemned);
            this.panel1.Controls.Add(this.rdbDefective);
            this.panel1.Controls.Add(this.rdbWorking);
            this.panel1.Controls.Add(this.gunaLabel6);
            this.panel1.Controls.Add(this.txtPropertyNumber);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.cbCapacity);
            this.panel1.Controls.Add(this.txtCapacity);
            this.panel1.Controls.Add(this.chkCapacity);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.txtSerialNumber);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.txtModel);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.txtBrand);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lblNewStock);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.lblCurrentStock);
            this.panel1.Controls.Add(this.lblStockTitle);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 482);
            this.panel1.TabIndex = 1;
            // 
            // lblNewStock
            // 
            this.lblNewStock.AutoSize = true;
            this.lblNewStock.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewStock.ForeColor = System.Drawing.Color.Gray;
            this.lblNewStock.Location = new System.Drawing.Point(71, 130);
            this.lblNewStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewStock.Name = "lblNewStock";
            this.lblNewStock.Size = new System.Drawing.Size(76, 17);
            this.lblNewStock.TabIndex = 129;
            this.lblNewStock.Text = "Description";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.Transparent;
            this.txtItemName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtItemName.BorderColor = System.Drawing.Color.Silver;
            this.txtItemName.BorderSize = 1;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtItemName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtItemName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItemName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(74, 91);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.SelectedText = "";
            this.txtItemName.Size = new System.Drawing.Size(305, 34);
            this.txtItemName.TabIndex = 126;
            this.txtItemName.TextOffsetX = 5;
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStock.ForeColor = System.Drawing.Color.Gray;
            this.lblCurrentStock.Location = new System.Drawing.Point(71, 72);
            this.lblCurrentStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(74, 17);
            this.lblCurrentStock.TabIndex = 127;
            this.lblCurrentStock.Text = "Item Name";
            // 
            // lblStockTitle
            // 
            this.lblStockTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStockTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockTitle.ForeColor = System.Drawing.Color.Black;
            this.lblStockTitle.Location = new System.Drawing.Point(74, 41);
            this.lblStockTitle.Name = "lblStockTitle";
            this.lblStockTitle.Size = new System.Drawing.Size(215, 21);
            this.lblStockTitle.TabIndex = 125;
            this.lblStockTitle.Text = "Update Product Information";
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
            this.btnBack.TabIndex = 116;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.txtDescription.Location = new System.Drawing.Point(74, 149);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(305, 55);
            this.txtDescription.TabIndex = 130;
            this.txtDescription.TextOffsetX = 5;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(71, 209);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(42, 17);
            this.gunaLabel1.TabIndex = 131;
            this.gunaLabel1.Text = "Brand";
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.Transparent;
            this.txtBrand.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtBrand.BorderColor = System.Drawing.Color.Silver;
            this.txtBrand.BorderSize = 1;
            this.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrand.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBrand.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtBrand.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBrand.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(74, 228);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.PasswordChar = '\0';
            this.txtBrand.SelectedText = "";
            this.txtBrand.Size = new System.Drawing.Size(164, 34);
            this.txtBrand.TabIndex = 132;
            this.txtBrand.TextOffsetX = 5;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel2.Location = new System.Drawing.Point(239, 209);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(46, 17);
            this.gunaLabel2.TabIndex = 133;
            this.gunaLabel2.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.Transparent;
            this.txtModel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtModel.BorderColor = System.Drawing.Color.Silver;
            this.txtModel.BorderSize = 1;
            this.txtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModel.FocusedBaseColor = System.Drawing.Color.White;
            this.txtModel.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtModel.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtModel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(242, 228);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.PasswordChar = '\0';
            this.txtModel.SelectedText = "";
            this.txtModel.Size = new System.Drawing.Size(137, 34);
            this.txtModel.TabIndex = 134;
            this.txtModel.TextOffsetX = 5;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel3.Location = new System.Drawing.Point(71, 267);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(167, 17);
            this.gunaLabel3.TabIndex = 135;
            this.gunaLabel3.Text = "Product Key/Serial Number";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtSerialNumber.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtSerialNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtSerialNumber.BorderSize = 1;
            this.txtSerialNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerialNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSerialNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtSerialNumber.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSerialNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumber.Location = new System.Drawing.Point(74, 286);
            this.txtSerialNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.PasswordChar = '\0';
            this.txtSerialNumber.SelectedText = "";
            this.txtSerialNumber.Size = new System.Drawing.Size(305, 34);
            this.txtSerialNumber.TabIndex = 136;
            this.txtSerialNumber.TextOffsetX = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel4.Location = new System.Drawing.Point(71, 325);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(63, 17);
            this.gunaLabel4.TabIndex = 137;
            this.gunaLabel4.Text = "Capacity";
            // 
            // chkCapacity
            // 
            this.chkCapacity.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkCapacity.CheckedState.BorderRadius = 2;
            this.chkCapacity.CheckedState.BorderThickness = 1;
            this.chkCapacity.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkCapacity.CheckedState.Parent = this.chkCapacity;
            this.chkCapacity.Enabled = false;
            this.chkCapacity.Location = new System.Drawing.Point(74, 352);
            this.chkCapacity.Name = "chkCapacity";
            this.chkCapacity.ShadowDecoration.Parent = this.chkCapacity;
            this.chkCapacity.Size = new System.Drawing.Size(20, 20);
            this.chkCapacity.TabIndex = 138;
            this.chkCapacity.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.chkCapacity.UncheckedState.BorderRadius = 2;
            this.chkCapacity.UncheckedState.BorderThickness = 1;
            this.chkCapacity.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.chkCapacity.UncheckedState.Parent = this.chkCapacity;
            this.chkCapacity.CheckedChanged += new System.EventHandler(this.chkCapacity_CheckedChanged);
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.Transparent;
            this.txtCapacity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtCapacity.BorderColor = System.Drawing.Color.Silver;
            this.txtCapacity.BorderSize = 1;
            this.txtCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapacity.Enabled = false;
            this.txtCapacity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCapacity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtCapacity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCapacity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(99, 344);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.PasswordChar = '\0';
            this.txtCapacity.SelectedText = "";
            this.txtCapacity.Size = new System.Drawing.Size(139, 34);
            this.txtCapacity.TabIndex = 139;
            this.txtCapacity.TextOffsetX = 5;
            this.txtCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacity_KeyPress);
            // 
            // cbCapacity
            // 
            this.cbCapacity.BackColor = System.Drawing.Color.Transparent;
            this.cbCapacity.BorderColor = System.Drawing.Color.Silver;
            this.cbCapacity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCapacity.Enabled = false;
            this.cbCapacity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbCapacity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCapacity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCapacity.FocusedState.Parent = this.cbCapacity;
            this.cbCapacity.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cbCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCapacity.HoverState.Parent = this.cbCapacity;
            this.cbCapacity.ItemHeight = 28;
            this.cbCapacity.Items.AddRange(new object[] {
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
            this.cbCapacity.ItemsAppearance.Parent = this.cbCapacity;
            this.cbCapacity.Location = new System.Drawing.Point(243, 344);
            this.cbCapacity.Name = "cbCapacity";
            this.cbCapacity.ShadowDecoration.Parent = this.cbCapacity;
            this.cbCapacity.Size = new System.Drawing.Size(136, 34);
            this.cbCapacity.StartIndex = 0;
            this.cbCapacity.TabIndex = 140;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel5.Location = new System.Drawing.Point(397, 72);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(108, 17);
            this.gunaLabel5.TabIndex = 141;
            this.gunaLabel5.Text = "Property Number";
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
            this.txtPropertyNumber.Location = new System.Drawing.Point(400, 91);
            this.txtPropertyNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPropertyNumber.Name = "txtPropertyNumber";
            this.txtPropertyNumber.PasswordChar = '\0';
            this.txtPropertyNumber.SelectedText = "";
            this.txtPropertyNumber.Size = new System.Drawing.Size(305, 34);
            this.txtPropertyNumber.TabIndex = 142;
            this.txtPropertyNumber.TextOffsetX = 5;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel6.Location = new System.Drawing.Point(397, 130);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(45, 17);
            this.gunaLabel6.TabIndex = 143;
            this.gunaLabel6.Text = "Status";
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
            this.rdbCondemned.Location = new System.Drawing.Point(571, 153);
            this.rdbCondemned.Name = "rdbCondemned";
            this.rdbCondemned.Size = new System.Drawing.Size(100, 21);
            this.rdbCondemned.TabIndex = 146;
            this.rdbCondemned.Text = "Condemned";
            this.rdbCondemned.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbCondemned.UncheckedState.BorderThickness = 1;
            this.rdbCondemned.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbCondemned.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbCondemned.UseVisualStyleBackColor = false;
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
            this.rdbDefective.Location = new System.Drawing.Point(400, 180);
            this.rdbDefective.Name = "rdbDefective";
            this.rdbDefective.Size = new System.Drawing.Size(135, 21);
            this.rdbDefective.TabIndex = 145;
            this.rdbDefective.Text = "Expired/Defective";
            this.rdbDefective.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbDefective.UncheckedState.BorderThickness = 1;
            this.rdbDefective.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbDefective.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbDefective.UseVisualStyleBackColor = false;
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
            this.rdbWorking.Location = new System.Drawing.Point(400, 153);
            this.rdbWorking.Name = "rdbWorking";
            this.rdbWorking.Size = new System.Drawing.Size(146, 21);
            this.rdbWorking.TabIndex = 144;
            this.rdbWorking.Text = "Working/Subscribed";
            this.rdbWorking.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.rdbWorking.UncheckedState.BorderThickness = 1;
            this.rdbWorking.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rdbWorking.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbWorking.UseVisualStyleBackColor = false;
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
            this.dtpDateAcquired.Location = new System.Drawing.Point(400, 228);
            this.dtpDateAcquired.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateAcquired.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateAcquired.Name = "dtpDateAcquired";
            this.dtpDateAcquired.ShadowDecoration.Parent = this.dtpDateAcquired;
            this.dtpDateAcquired.Size = new System.Drawing.Size(305, 34);
            this.dtpDateAcquired.TabIndex = 153;
            this.dtpDateAcquired.Value = new System.DateTime(2020, 5, 21, 23, 26, 6, 795);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel7.Location = new System.Drawing.Point(397, 209);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(96, 17);
            this.gunaLabel7.TabIndex = 154;
            this.gunaLabel7.Text = "Date Acquired";
            // 
            // lblDateExpiry
            // 
            this.lblDateExpiry.AutoSize = true;
            this.lblDateExpiry.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateExpiry.ForeColor = System.Drawing.Color.Gray;
            this.lblDateExpiry.Location = new System.Drawing.Point(397, 267);
            this.lblDateExpiry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateExpiry.Name = "lblDateExpiry";
            this.lblDateExpiry.Size = new System.Drawing.Size(74, 17);
            this.lblDateExpiry.TabIndex = 155;
            this.lblDateExpiry.Text = "Date Expiry";
            this.lblDateExpiry.Visible = false;
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
            this.dtpDateExpiry.Location = new System.Drawing.Point(400, 287);
            this.dtpDateExpiry.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateExpiry.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateExpiry.Name = "dtpDateExpiry";
            this.dtpDateExpiry.ShadowDecoration.Parent = this.dtpDateExpiry;
            this.dtpDateExpiry.Size = new System.Drawing.Size(305, 34);
            this.dtpDateExpiry.TabIndex = 156;
            this.dtpDateExpiry.Value = new System.DateTime(2020, 5, 21, 23, 26, 6, 795);
            this.dtpDateExpiry.Visible = false;
            this.dtpDateExpiry.ValueChanged += new System.EventHandler(this.dtpDateExpiry_ValueChanged);
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
            this.btnSave.Location = new System.Drawing.Point(307, 411);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(178, 35);
            this.btnSave.TabIndex = 157;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmUpdateProductInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 482);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateProductInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel lblNewStock;
        private Guna.UI.WinForms.GunaTextBox txtItemName;
        private Guna.UI.WinForms.GunaLabel lblCurrentStock;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStockTitle;
        private Guna.UI.WinForms.GunaAdvenceButton btnBack;
        private Guna.UI.WinForms.GunaTextBox txtDescription;
        private Guna.UI.WinForms.GunaTextBox txtBrand;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtModel;
        private Guna.UI.WinForms.GunaTextBox txtSerialNumber;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkCapacity;
        private Guna.UI.WinForms.GunaTextBox txtCapacity;
        private Guna.UI2.WinForms.Guna2ComboBox cbCapacity;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtPropertyNumber;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2RadioButton rdbCondemned;
        private Guna.UI2.WinForms.Guna2RadioButton rdbDefective;
        private Guna.UI2.WinForms.Guna2RadioButton rdbWorking;
        private Guna.UI.WinForms.GunaLabel lblDateExpiry;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateAcquired;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateExpiry;
        private Guna.UI.WinForms.GunaAdvenceButton btnSave;
    }
}