namespace Final.includes.uc.frmDashboard.admin.mu
{
    partial class ucManageAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManageAccount));
            this.dgvManageAccount = new Zuby.ADGV.AdvancedDataGridView();
            this.cbSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddAdministrator = new Guna.UI.WinForms.GunaAdvenceButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_logged_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_logged_in_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManageAccount
            // 
            this.dgvManageAccount.AllowUserToAddRows = false;
            this.dgvManageAccount.AllowUserToDeleteRows = false;
            this.dgvManageAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManageAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvManageAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.user_type,
            this.status,
            this.is_logged_in,
            this.last_logged_in_at});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageAccount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManageAccount.FilterAndSortEnabled = true;
            this.dgvManageAccount.Location = new System.Drawing.Point(28, 94);
            this.dgvManageAccount.Name = "dgvManageAccount";
            this.dgvManageAccount.ReadOnly = true;
            this.dgvManageAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvManageAccount.Size = new System.Drawing.Size(946, 400);
            this.dgvManageAccount.TabIndex = 142;
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
            "Username",
            "User Type"});
            this.cbSearchBy.ItemsAppearance.Parent = this.cbSearchBy;
            this.cbSearchBy.Location = new System.Drawing.Point(28, 62);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.ShadowDecoration.Parent = this.cbSearchBy;
            this.cbSearchBy.Size = new System.Drawing.Size(179, 26);
            this.cbSearchBy.StartIndex = 0;
            this.cbSearchBy.TabIndex = 140;
            // 
            // btnAddAdministrator
            // 
            this.btnAddAdministrator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAdministrator.AnimationHoverSpeed = 0.07F;
            this.btnAddAdministrator.AnimationSpeed = 0.03F;
            this.btnAddAdministrator.BaseColor = System.Drawing.Color.White;
            this.btnAddAdministrator.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddAdministrator.BorderSize = 1;
            this.btnAddAdministrator.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddAdministrator.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddAdministrator.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddAdministrator.CheckedImage = null;
            this.btnAddAdministrator.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddAdministrator.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddAdministrator.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddAdministrator.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdministrator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddAdministrator.Image = null;
            this.btnAddAdministrator.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddAdministrator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddAdministrator.Location = new System.Drawing.Point(826, 21);
            this.btnAddAdministrator.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddAdministrator.Name = "btnAddAdministrator";
            this.btnAddAdministrator.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddAdministrator.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddAdministrator.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddAdministrator.OnHoverImage = null;
            this.btnAddAdministrator.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddAdministrator.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddAdministrator.Size = new System.Drawing.Size(148, 30);
            this.btnAddAdministrator.TabIndex = 143;
            this.btnAddAdministrator.Text = "Add Administrator";
            this.btnAddAdministrator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddAdministrator.Click += new System.EventHandler(this.btnAddAdministrator_Click);
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
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 22;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // user_type
            // 
            this.user_type.DataPropertyName = "user_type";
            this.user_type.HeaderText = "User Type";
            this.user_type.MinimumWidth = 22;
            this.user_type.Name = "user_type";
            this.user_type.ReadOnly = true;
            this.user_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // is_logged_in
            // 
            this.is_logged_in.DataPropertyName = "is_logged_in";
            this.is_logged_in.HeaderText = "Logged In?";
            this.is_logged_in.MinimumWidth = 22;
            this.is_logged_in.Name = "is_logged_in";
            this.is_logged_in.ReadOnly = true;
            this.is_logged_in.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // last_logged_in_at
            // 
            this.last_logged_in_at.DataPropertyName = "last_logged_in_at";
            this.last_logged_in_at.HeaderText = "Last Logged In Date";
            this.last_logged_in_at.MinimumWidth = 22;
            this.last_logged_in_at.Name = "last_logged_in_at";
            this.last_logged_in_at.ReadOnly = true;
            this.last_logged_in_at.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            this.txtSearch.TabIndex = 141;
            this.txtSearch.TextOffset = new System.Drawing.Point(5, -1);
            // 
            // ucManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddAdministrator);
            this.Controls.Add(this.dgvManageAccount);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbSearchBy);
            this.Name = "ucManageAccount";
            this.Size = new System.Drawing.Size(1003, 521);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView dgvManageAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchBy;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddAdministrator;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_logged_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_logged_in_at;

    }
}
