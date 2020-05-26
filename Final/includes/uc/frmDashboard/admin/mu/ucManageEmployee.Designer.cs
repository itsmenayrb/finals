namespace Final.includes.uc.frmDashboard.admin.mu
{
    partial class ucManageEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManageEmployee));
            this.dgvManageEmployee = new Zuby.ADGV.AdvancedDataGridView();
            this.cbSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDepartment = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddEmployee = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnViewPosition = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profile_picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManageEmployee
            // 
            this.dgvManageEmployee.AllowUserToAddRows = false;
            this.dgvManageEmployee.AllowUserToDeleteRows = false;
            this.dgvManageEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManageEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvManageEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.profile_picture,
            this.employee_id,
            this.full_name,
            this.contact_number,
            this.email,
            this.department_name,
            this.position});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManageEmployee.FilterAndSortEnabled = true;
            this.dgvManageEmployee.Location = new System.Drawing.Point(28, 94);
            this.dgvManageEmployee.Name = "dgvManageEmployee";
            this.dgvManageEmployee.ReadOnly = true;
            this.dgvManageEmployee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            this.dgvManageEmployee.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvManageEmployee.RowTemplate.Height = 60;
            this.dgvManageEmployee.Size = new System.Drawing.Size(946, 400);
            this.dgvManageEmployee.TabIndex = 139;
            this.dgvManageEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageEmployee_CellClick);
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.cbSearchBy.BorderColor = System.Drawing.Color.Silver;
            this.cbSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbSearchBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchBy.FocusedState.Parent = this.cbSearchBy;
            this.cbSearchBy.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cbSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSearchBy.HoverState.Parent = this.cbSearchBy;
            this.cbSearchBy.ItemHeight = 20;
            this.cbSearchBy.Items.AddRange(new object[] {
            "--Search by--",
            "Employee ID",
            "Full Name",
            "Contact Number",
            "Email",
            "Department",
            "Position"});
            this.cbSearchBy.ItemsAppearance.Parent = this.cbSearchBy;
            this.cbSearchBy.Location = new System.Drawing.Point(28, 62);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.ShadowDecoration.Parent = this.cbSearchBy;
            this.cbSearchBy.Size = new System.Drawing.Size(179, 26);
            this.cbSearchBy.StartIndex = 0;
            this.cbSearchBy.TabIndex = 137;
            // 
            // btnDepartment
            // 
            this.btnDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDepartment.AnimationHoverSpeed = 0.07F;
            this.btnDepartment.AnimationSpeed = 0.03F;
            this.btnDepartment.BaseColor = System.Drawing.Color.White;
            this.btnDepartment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnDepartment.BorderSize = 1;
            this.btnDepartment.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnDepartment.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDepartment.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnDepartment.CheckedImage = null;
            this.btnDepartment.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDepartment.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDepartment.FocusedColor = System.Drawing.Color.Empty;
            this.btnDepartment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnDepartment.Image = null;
            this.btnDepartment.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDepartment.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDepartment.Location = new System.Drawing.Point(826, 21);
            this.btnDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnDepartment.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDepartment.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnDepartment.OnHoverImage = null;
            this.btnDepartment.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDepartment.OnPressedColor = System.Drawing.Color.Black;
            this.btnDepartment.Size = new System.Drawing.Size(148, 30);
            this.btnDepartment.TabIndex = 140;
            this.btnDepartment.Text = "View Department";
            this.btnDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEmployee.AnimationHoverSpeed = 0.07F;
            this.btnAddEmployee.AnimationSpeed = 0.03F;
            this.btnAddEmployee.BaseColor = System.Drawing.Color.White;
            this.btnAddEmployee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddEmployee.BorderSize = 1;
            this.btnAddEmployee.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddEmployee.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddEmployee.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddEmployee.CheckedImage = null;
            this.btnAddEmployee.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddEmployee.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddEmployee.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddEmployee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddEmployee.Image = null;
            this.btnAddEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddEmployee.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddEmployee.Location = new System.Drawing.Point(528, 21);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddEmployee.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddEmployee.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddEmployee.OnHoverImage = null;
            this.btnAddEmployee.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddEmployee.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddEmployee.Size = new System.Drawing.Size(148, 30);
            this.btnAddEmployee.TabIndex = 141;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnViewPosition
            // 
            this.btnViewPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewPosition.AnimationHoverSpeed = 0.07F;
            this.btnViewPosition.AnimationSpeed = 0.03F;
            this.btnViewPosition.BaseColor = System.Drawing.Color.White;
            this.btnViewPosition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnViewPosition.BorderSize = 1;
            this.btnViewPosition.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnViewPosition.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnViewPosition.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewPosition.CheckedImage = null;
            this.btnViewPosition.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnViewPosition.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnViewPosition.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewPosition.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewPosition.Image = null;
            this.btnViewPosition.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewPosition.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewPosition.Location = new System.Drawing.Point(679, 21);
            this.btnViewPosition.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewPosition.Name = "btnViewPosition";
            this.btnViewPosition.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnViewPosition.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewPosition.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewPosition.OnHoverImage = null;
            this.btnViewPosition.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewPosition.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewPosition.Size = new System.Drawing.Size(148, 30);
            this.btnViewPosition.TabIndex = 142;
            this.btnViewPosition.Text = "View Position";
            this.btnViewPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewPosition.Click += new System.EventHandler(this.btnViewPosition_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "Search";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.IconRightSize = new System.Drawing.Size(17, 17);
            this.txtSearch.Location = new System.Drawing.Point(213, 62);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionStart = 6;
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(761, 27);
            this.txtSearch.TabIndex = 138;
            this.txtSearch.TextOffset = new System.Drawing.Point(5, -1);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
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
            // profile_picture
            // 
            this.profile_picture.DataPropertyName = "profile_picture";
            this.profile_picture.HeaderText = "";
            this.profile_picture.MinimumWidth = 22;
            this.profile_picture.Name = "profile_picture";
            this.profile_picture.ReadOnly = true;
            this.profile_picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // employee_id
            // 
            this.employee_id.DataPropertyName = "employee_id";
            this.employee_id.HeaderText = "Employee ID";
            this.employee_id.MinimumWidth = 22;
            this.employee_id.Name = "employee_id";
            this.employee_id.ReadOnly = true;
            this.employee_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "Full Name";
            this.full_name.MinimumWidth = 22;
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            this.full_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // contact_number
            // 
            this.contact_number.DataPropertyName = "contact_number";
            this.contact_number.HeaderText = "Contact Number";
            this.contact_number.MinimumWidth = 22;
            this.contact_number.Name = "contact_number";
            this.contact_number.ReadOnly = true;
            this.contact_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 22;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // department_name
            // 
            this.department_name.DataPropertyName = "department_name";
            this.department_name.HeaderText = "Department";
            this.department_name.MinimumWidth = 22;
            this.department_name.Name = "department_name";
            this.department_name.ReadOnly = true;
            this.department_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // position
            // 
            this.position.DataPropertyName = "position_name";
            this.position.HeaderText = "Position";
            this.position.MinimumWidth = 22;
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ucManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnViewPosition);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.dgvManageEmployee);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbSearchBy);
            this.Name = "ucManageEmployee";
            this.Size = new System.Drawing.Size(1003, 521);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView dgvManageEmployee;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchBy;
        private Guna.UI.WinForms.GunaAdvenceButton btnDepartment;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddEmployee;
        private Guna.UI.WinForms.GunaAdvenceButton btnViewPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn profile_picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
    }
}
