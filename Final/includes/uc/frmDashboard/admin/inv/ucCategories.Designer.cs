namespace Final.includes.uc.frmDashboard.admin.inv
{
    partial class ucCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCategories));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddCategory = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnHardware = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnSoftware = new Guna.UI2.WinForms.Guna2TileButton();
            this.gunaLinePanel6 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.flpCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvInventory = new Zuby.ADGV.AdvancedDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.property_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acquired_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdateCategory = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLinePanel6.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategory.AnimationHoverSpeed = 0.07F;
            this.btnAddCategory.AnimationSpeed = 0.03F;
            this.btnAddCategory.BaseColor = System.Drawing.Color.White;
            this.btnAddCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddCategory.BorderSize = 1;
            this.btnAddCategory.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddCategory.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddCategory.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddCategory.CheckedImage = null;
            this.btnAddCategory.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddCategory.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddCategory.Image = null;
            this.btnAddCategory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddCategory.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddCategory.Location = new System.Drawing.Point(701, 23);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddCategory.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddCategory.OnHoverImage = null;
            this.btnAddCategory.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddCategory.Size = new System.Drawing.Size(127, 30);
            this.btnAddCategory.TabIndex = 97;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
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
            this.btnHardware.Location = new System.Drawing.Point(145, 37);
            this.btnHardware.Name = "btnHardware";
            this.btnHardware.ShadowDecoration.Parent = this.btnHardware;
            this.btnHardware.Size = new System.Drawing.Size(117, 113);
            this.btnHardware.TabIndex = 99;
            this.btnHardware.Text = "Hardware";
            this.btnHardware.Click += new System.EventHandler(this.btnHardware_Click);
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
            this.btnSoftware.Location = new System.Drawing.Point(22, 37);
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.ShadowDecoration.Parent = this.btnSoftware;
            this.btnSoftware.Size = new System.Drawing.Size(117, 113);
            this.btnSoftware.TabIndex = 100;
            this.btnSoftware.Text = "Software";
            this.btnSoftware.Click += new System.EventHandler(this.btnSoftware_Click);
            // 
            // gunaLinePanel6
            // 
            this.gunaLinePanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel6.Controls.Add(this.gunaLabel11);
            this.gunaLinePanel6.Controls.Add(this.btnHardware);
            this.gunaLinePanel6.Controls.Add(this.btnSoftware);
            this.gunaLinePanel6.LineBottom = 1;
            this.gunaLinePanel6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel6.LineLeft = 1;
            this.gunaLinePanel6.LineRight = 1;
            this.gunaLinePanel6.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel6.LineTop = 1;
            this.gunaLinePanel6.Location = new System.Drawing.Point(28, 56);
            this.gunaLinePanel6.Name = "gunaLinePanel6";
            this.gunaLinePanel6.Size = new System.Drawing.Size(285, 172);
            this.gunaLinePanel6.TabIndex = 101;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel11.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(98, 16);
            this.gunaLabel11.TabIndex = 2;
            this.gunaLabel11.Text = "1. SELECT TYPE";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel1.Controls.Add(this.txtSearch);
            this.gunaLinePanel1.Controls.Add(this.flpCategory);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel1);
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(319, 56);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(655, 172);
            this.gunaLinePanel1.TabIndex = 102;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(141, 16);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "2. SELECT CATEGORY";
            // 
            // flpCategory
            // 
            this.flpCategory.AutoScroll = true;
            this.flpCategory.Location = new System.Drawing.Point(22, 38);
            this.flpCategory.Name = "flpCategory";
            this.flpCategory.Size = new System.Drawing.Size(608, 113);
            this.flpCategory.TabIndex = 3;
            this.flpCategory.WrapContents = false;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.status,
            this.item_name,
            this.description,
            this.brand,
            this.model,
            this.quantity,
            this.property_number,
            this.department_name,
            this.acquired_at});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventory.FilterAndSortEnabled = true;
            this.dgvInventory.Location = new System.Drawing.Point(28, 234);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvInventory.Size = new System.Drawing.Size(946, 261);
            this.dgvInventory.TabIndex = 103;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 22;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.id.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 22;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // item_name
            // 
            this.item_name.DataPropertyName = "item_name";
            this.item_name.HeaderText = "Item Name";
            this.item_name.MinimumWidth = 22;
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            this.item_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 22;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "Brand";
            this.brand.MinimumWidth = 22;
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "Model";
            this.model.MinimumWidth = 22;
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "qty";
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 22;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // property_number
            // 
            this.property_number.DataPropertyName = "property_number";
            this.property_number.HeaderText = "Property Number";
            this.property_number.MinimumWidth = 22;
            this.property_number.Name = "property_number";
            this.property_number.ReadOnly = true;
            this.property_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // department_name
            // 
            this.department_name.DataPropertyName = "department_name";
            this.department_name.HeaderText = "Room";
            this.department_name.MinimumWidth = 22;
            this.department_name.Name = "department_name";
            this.department_name.ReadOnly = true;
            this.department_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // acquired_at
            // 
            this.acquired_at.DataPropertyName = "acquired_at";
            this.acquired_at.HeaderText = "Date Acquired";
            this.acquired_at.MinimumWidth = 22;
            this.acquired_at.Name = "acquired_at";
            this.acquired_at.ReadOnly = true;
            this.acquired_at.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "Search";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.IconRightSize = new System.Drawing.Size(15, 15);
            this.txtSearch.Location = new System.Drawing.Point(417, 11);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionStart = 6;
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(213, 23);
            this.txtSearch.TabIndex = 109;
            this.txtSearch.TextOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCategory.AnimationHoverSpeed = 0.07F;
            this.btnUpdateCategory.AnimationSpeed = 0.03F;
            this.btnUpdateCategory.BaseColor = System.Drawing.Color.White;
            this.btnUpdateCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnUpdateCategory.BorderSize = 1;
            this.btnUpdateCategory.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnUpdateCategory.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUpdateCategory.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnUpdateCategory.CheckedImage = null;
            this.btnUpdateCategory.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUpdateCategory.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdateCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnUpdateCategory.Image = null;
            this.btnUpdateCategory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateCategory.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpdateCategory.Location = new System.Drawing.Point(827, 23);
            this.btnUpdateCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnUpdateCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateCategory.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnUpdateCategory.OnHoverImage = null;
            this.btnUpdateCategory.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpdateCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateCategory.Size = new System.Drawing.Size(147, 30);
            this.btnUpdateCategory.TabIndex = 104;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ucCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.gunaLinePanel6);
            this.Controls.Add(this.btnAddCategory);
            this.Name = "ucCategories";
            this.Size = new System.Drawing.Size(1003, 521);
            this.gunaLinePanel6.ResumeLayout(false);
            this.gunaLinePanel6.PerformLayout();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnAddCategory;
        private Guna.UI2.WinForms.Guna2TileButton btnHardware;
        private Guna.UI2.WinForms.Guna2TileButton btnSoftware;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.FlowLayoutPanel flpCategory;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Zuby.ADGV.AdvancedDataGridView dgvInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn property_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn acquired_at;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpdateCategory;
    }
}
