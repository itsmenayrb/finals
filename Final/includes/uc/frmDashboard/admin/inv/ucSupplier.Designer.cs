namespace Final.includes.uc.frmDashboard.admin.inv
{
    partial class ucSupplier
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
            this.btnAddSupplier = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLinePanel6 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.flpBusinessType = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddBusinessType = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvSupplier = new Zuby.ADGV.AdvancedDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.registration_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tin_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLinePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSupplier.AnimationHoverSpeed = 0.07F;
            this.btnAddSupplier.AnimationSpeed = 0.03F;
            this.btnAddSupplier.BaseColor = System.Drawing.Color.White;
            this.btnAddSupplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddSupplier.BorderSize = 1;
            this.btnAddSupplier.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddSupplier.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddSupplier.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddSupplier.CheckedImage = null;
            this.btnAddSupplier.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddSupplier.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddSupplier.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddSupplier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddSupplier.Image = null;
            this.btnAddSupplier.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddSupplier.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddSupplier.Location = new System.Drawing.Point(847, 23);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddSupplier.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddSupplier.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddSupplier.OnHoverImage = null;
            this.btnAddSupplier.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddSupplier.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddSupplier.Size = new System.Drawing.Size(127, 30);
            this.btnAddSupplier.TabIndex = 98;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLinePanel6
            // 
            this.gunaLinePanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel6.Controls.Add(this.gunaAdvenceButton1);
            this.gunaLinePanel6.Controls.Add(this.btnAddBusinessType);
            this.gunaLinePanel6.Controls.Add(this.flpBusinessType);
            this.gunaLinePanel6.Controls.Add(this.gunaLabel11);
            this.gunaLinePanel6.LineBottom = 1;
            this.gunaLinePanel6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel6.LineLeft = 1;
            this.gunaLinePanel6.LineRight = 1;
            this.gunaLinePanel6.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel6.LineTop = 1;
            this.gunaLinePanel6.Location = new System.Drawing.Point(28, 56);
            this.gunaLinePanel6.Name = "gunaLinePanel6";
            this.gunaLinePanel6.Size = new System.Drawing.Size(946, 172);
            this.gunaLinePanel6.TabIndex = 102;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel11.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(145, 16);
            this.gunaLabel11.TabIndex = 2;
            this.gunaLabel11.Text = "SELECT BUSINESS TYPE";
            // 
            // flpBusinessType
            // 
            this.flpBusinessType.AutoScroll = true;
            this.flpBusinessType.Location = new System.Drawing.Point(22, 41);
            this.flpBusinessType.Name = "flpBusinessType";
            this.flpBusinessType.Size = new System.Drawing.Size(901, 113);
            this.flpBusinessType.TabIndex = 113;
            this.flpBusinessType.WrapContents = false;
            // 
            // btnAddBusinessType
            // 
            this.btnAddBusinessType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBusinessType.AnimationHoverSpeed = 0.07F;
            this.btnAddBusinessType.AnimationSpeed = 0.03F;
            this.btnAddBusinessType.BaseColor = System.Drawing.Color.White;
            this.btnAddBusinessType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddBusinessType.BorderSize = 1;
            this.btnAddBusinessType.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddBusinessType.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddBusinessType.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddBusinessType.CheckedImage = null;
            this.btnAddBusinessType.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddBusinessType.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddBusinessType.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddBusinessType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBusinessType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddBusinessType.Image = null;
            this.btnAddBusinessType.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddBusinessType.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddBusinessType.Location = new System.Drawing.Point(167, 15);
            this.btnAddBusinessType.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddBusinessType.Name = "btnAddBusinessType";
            this.btnAddBusinessType.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddBusinessType.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddBusinessType.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddBusinessType.OnHoverImage = null;
            this.btnAddBusinessType.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddBusinessType.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddBusinessType.Size = new System.Drawing.Size(149, 23);
            this.btnAddBusinessType.TabIndex = 114;
            this.btnAddBusinessType.Text = "Add Business Type";
            this.btnAddBusinessType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddBusinessType.Click += new System.EventHandler(this.btnAddBusinessType_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaAdvenceButton1.BorderSize = 1;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.gunaAdvenceButton1.CheckedImage = null;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(315, 15);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(149, 23);
            this.gunaAdvenceButton1.TabIndex = 115;
            this.gunaAdvenceButton1.Text = "Update Business Type";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.logo,
            this.registration_id,
            this.supplier_name,
            this.address,
            this.contact_number,
            this.email,
            this.tin_number});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupplier.FilterAndSortEnabled = true;
            this.dgvSupplier.Location = new System.Drawing.Point(28, 234);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSupplier.Size = new System.Drawing.Size(946, 261);
            this.dgvSupplier.TabIndex = 104;
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
            // logo
            // 
            this.logo.DataPropertyName = "logo";
            this.logo.HeaderText = "";
            this.logo.MinimumWidth = 22;
            this.logo.Name = "logo";
            this.logo.ReadOnly = true;
            this.logo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // registration_id
            // 
            this.registration_id.DataPropertyName = "registration_id";
            this.registration_id.HeaderText = "Registration ID";
            this.registration_id.MinimumWidth = 22;
            this.registration_id.Name = "registration_id";
            this.registration_id.ReadOnly = true;
            this.registration_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // supplier_name
            // 
            this.supplier_name.DataPropertyName = "supplier_name";
            this.supplier_name.HeaderText = "Business Name";
            this.supplier_name.MinimumWidth = 22;
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.ReadOnly = true;
            this.supplier_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Business Address";
            this.address.MinimumWidth = 22;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // tin_number
            // 
            this.tin_number.DataPropertyName = "tin_number";
            this.tin_number.HeaderText = "Tin";
            this.tin_number.MinimumWidth = 22;
            this.tin_number.Name = "tin_number";
            this.tin_number.ReadOnly = true;
            this.tin_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ucSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.gunaLinePanel6);
            this.Controls.Add(this.btnAddSupplier);
            this.Name = "ucSupplier";
            this.Size = new System.Drawing.Size(1003, 521);
            this.gunaLinePanel6.ResumeLayout(false);
            this.gunaLinePanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnAddSupplier;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private System.Windows.Forms.FlowLayoutPanel flpBusinessType;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddBusinessType;
        private Zuby.ADGV.AdvancedDataGridView dgvSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn registration_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn tin_number;
    }
}
