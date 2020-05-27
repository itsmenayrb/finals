namespace Final.includes.uc.frmDashboard.admin.arc
{
    partial class ucInventory
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
            this.gbAcademicYear = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gunaLinePanel6 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.btnGenerateReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvInventory = new Zuby.ADGV.AdvancedDataGridView();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acquired_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expire_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLinePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAcademicYear
            // 
            this.gbAcademicYear.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.gbAcademicYear.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.gbAcademicYear.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gbAcademicYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAcademicYear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcademicYear.ForeColor = System.Drawing.Color.Black;
            this.gbAcademicYear.Location = new System.Drawing.Point(0, 0);
            this.gbAcademicYear.Name = "gbAcademicYear";
            this.gbAcademicYear.ShadowDecoration.Parent = this.gbAcademicYear;
            this.gbAcademicYear.Size = new System.Drawing.Size(723, 27);
            this.gbAcademicYear.TabIndex = 212;
            this.gbAcademicYear.Text = "Academic Year:";
            this.gbAcademicYear.TextOffset = new System.Drawing.Point(5, -7);
            // 
            // gunaLinePanel6
            // 
            this.gunaLinePanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel6.Controls.Add(this.dgvInventory);
            this.gunaLinePanel6.Controls.Add(this.btnGenerateReport);
            this.gunaLinePanel6.Controls.Add(this.gunaLabel11);
            this.gunaLinePanel6.LineBottom = 1;
            this.gunaLinePanel6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.gunaLinePanel6.LineLeft = 1;
            this.gunaLinePanel6.LineRight = 1;
            this.gunaLinePanel6.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel6.LineTop = 1;
            this.gunaLinePanel6.Location = new System.Drawing.Point(0, 33);
            this.gunaLinePanel6.Name = "gunaLinePanel6";
            this.gunaLinePanel6.Size = new System.Drawing.Size(723, 400);
            this.gunaLinePanel6.TabIndex = 213;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel11.Location = new System.Drawing.Point(19, 16);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(63, 16);
            this.gunaLabel11.TabIndex = 2;
            this.gunaLabel11.Text = "Inventory";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateReport.AnimationHoverSpeed = 0.07F;
            this.btnGenerateReport.AnimationSpeed = 0.03F;
            this.btnGenerateReport.BaseColor = System.Drawing.Color.White;
            this.btnGenerateReport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnGenerateReport.BorderSize = 1;
            this.btnGenerateReport.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnGenerateReport.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnGenerateReport.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnGenerateReport.CheckedImage = null;
            this.btnGenerateReport.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnGenerateReport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGenerateReport.FocusedColor = System.Drawing.Color.Empty;
            this.btnGenerateReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnGenerateReport.Image = null;
            this.btnGenerateReport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGenerateReport.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGenerateReport.Location = new System.Drawing.Point(553, 10);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnGenerateReport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerateReport.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnGenerateReport.OnHoverImage = null;
            this.btnGenerateReport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGenerateReport.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerateReport.Size = new System.Drawing.Size(148, 30);
            this.btnGenerateReport.TabIndex = 90;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
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
            this.item_name,
            this.description,
            this.brand,
            this.model,
            this.serial_number,
            this.capacity,
            this.quantity,
            this.propertyNumber,
            this.department_name,
            this.acquired_at,
            this.expire_at,
            this.status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventory.FilterAndSortEnabled = true;
            this.dgvInventory.Location = new System.Drawing.Point(22, 43);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventory.Size = new System.Drawing.Size(679, 332);
            this.dgvInventory.TabIndex = 91;
            // 
            // item_name
            // 
            this.item_name.DataPropertyName = "item_name";
            this.item_name.HeaderText = "Item";
            this.item_name.MinimumWidth = 22;
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            this.item_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.item_name.Width = 57;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 22;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.description.Width = 96;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "Brand";
            this.brand.MinimumWidth = 22;
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.brand.Width = 65;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "Model";
            this.model.MinimumWidth = 22;
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.model.Width = 69;
            // 
            // serial_number
            // 
            this.serial_number.DataPropertyName = "serial_number";
            this.serial_number.HeaderText = "Product Key/Serial Number";
            this.serial_number.MinimumWidth = 22;
            this.serial_number.Name = "serial_number";
            this.serial_number.ReadOnly = true;
            this.serial_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.serial_number.Width = 172;
            // 
            // capacity
            // 
            this.capacity.DataPropertyName = "capacity";
            this.capacity.HeaderText = "Capacity";
            this.capacity.MinimumWidth = 22;
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            this.capacity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.capacity.Width = 85;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 22;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.quantity.Width = 79;
            // 
            // propertyNumber
            // 
            this.propertyNumber.DataPropertyName = "property_number";
            this.propertyNumber.HeaderText = "Property Number";
            this.propertyNumber.MinimumWidth = 22;
            this.propertyNumber.Name = "propertyNumber";
            this.propertyNumber.ReadOnly = true;
            this.propertyNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.propertyNumber.Width = 119;
            // 
            // department_name
            // 
            this.department_name.DataPropertyName = "department_name";
            this.department_name.HeaderText = "Department";
            this.department_name.MinimumWidth = 22;
            this.department_name.Name = "department_name";
            this.department_name.ReadOnly = true;
            this.department_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.department_name.Width = 99;
            // 
            // acquired_at
            // 
            this.acquired_at.DataPropertyName = "acquired_at";
            this.acquired_at.HeaderText = "Date Acquired";
            this.acquired_at.MinimumWidth = 22;
            this.acquired_at.Name = "acquired_at";
            this.acquired_at.ReadOnly = true;
            this.acquired_at.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.acquired_at.Width = 106;
            // 
            // expire_at
            // 
            this.expire_at.DataPropertyName = "expire_at";
            this.expire_at.HeaderText = "End of Subscription";
            this.expire_at.MinimumWidth = 22;
            this.expire_at.Name = "expire_at";
            this.expire_at.ReadOnly = true;
            this.expire_at.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.expire_at.Width = 127;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 22;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.status.Width = 63;
            // 
            // ucInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel6);
            this.Controls.Add(this.gbAcademicYear);
            this.Name = "ucInventory";
            this.Size = new System.Drawing.Size(723, 433);
            this.gunaLinePanel6.ResumeLayout(false);
            this.gunaLinePanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAcademicYear;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaAdvenceButton btnGenerateReport;
        private Zuby.ADGV.AdvancedDataGridView dgvInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn acquired_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn expire_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
