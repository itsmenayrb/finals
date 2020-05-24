namespace Final.includes.uc.frmDashboard.admin.inv
{
    partial class ucStocks
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
            this.pieChartStocks = new LiveCharts.WinForms.PieChart();
            this.gunaLinePanel6 = new Guna.UI.WinForms.GunaLinePanel();
            this.dgvInventoryStocks = new Guna.UI.WinForms.GunaDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocks_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLinePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryStocks)).BeginInit();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pieChartStocks
            // 
            this.pieChartStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChartStocks.Location = new System.Drawing.Point(3, 50);
            this.pieChartStocks.Name = "pieChartStocks";
            this.pieChartStocks.Size = new System.Drawing.Size(427, 372);
            this.pieChartStocks.TabIndex = 97;
            this.pieChartStocks.Text = "pieChart1";
            // 
            // gunaLinePanel6
            // 
            this.gunaLinePanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel6.Controls.Add(this.dgvInventoryStocks);
            this.gunaLinePanel6.Controls.Add(this.gunaLabel10);
            this.gunaLinePanel6.Controls.Add(this.gunaLabel11);
            this.gunaLinePanel6.LineBottom = 1;
            this.gunaLinePanel6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel6.LineLeft = 1;
            this.gunaLinePanel6.LineRight = 1;
            this.gunaLinePanel6.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel6.LineTop = 1;
            this.gunaLinePanel6.Location = new System.Drawing.Point(467, 21);
            this.gunaLinePanel6.Name = "gunaLinePanel6";
            this.gunaLinePanel6.Size = new System.Drawing.Size(507, 473);
            this.gunaLinePanel6.TabIndex = 98;
            // 
            // dgvInventoryStocks
            // 
            this.dgvInventoryStocks.AllowUserToAddRows = false;
            this.dgvInventoryStocks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvInventoryStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryStocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventoryStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryStocks.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventoryStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventoryStocks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventoryStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventoryStocks.ColumnHeadersHeight = 26;
            this.dgvInventoryStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn3,
            this.quantity,
            this.stocks_unit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryStocks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventoryStocks.EnableHeadersVisualStyles = false;
            this.dgvInventoryStocks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvInventoryStocks.Location = new System.Drawing.Point(22, 61);
            this.dgvInventoryStocks.Name = "dgvInventoryStocks";
            this.dgvInventoryStocks.ReadOnly = true;
            this.dgvInventoryStocks.RowHeadersVisible = false;
            this.dgvInventoryStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryStocks.Size = new System.Drawing.Size(463, 388);
            this.dgvInventoryStocks.TabIndex = 7;
            this.dgvInventoryStocks.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid;
            this.dgvInventoryStocks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInventoryStocks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInventoryStocks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvInventoryStocks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInventoryStocks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInventoryStocks.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvInventoryStocks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvInventoryStocks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvInventoryStocks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInventoryStocks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInventoryStocks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvInventoryStocks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInventoryStocks.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvInventoryStocks.ThemeStyle.ReadOnly = true;
            this.dgvInventoryStocks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInventoryStocks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventoryStocks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInventoryStocks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvInventoryStocks.ThemeStyle.RowsStyle.Height = 22;
            this.dgvInventoryStocks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvInventoryStocks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventoryStocks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryStocks_CellClick);
            this.dgvInventoryStocks.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryStocks_CellValueChanged);
            this.dgvInventoryStocks.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvInventoryStocks_CurrentCellDirtyStateChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "item_name";
            this.dataGridViewTextBoxColumn3.FillWeight = 138.5288F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.FillWeight = 76.14214F;
            this.quantity.HeaderText = "Stocks";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // stocks_unit
            // 
            this.stocks_unit.DataPropertyName = "unit";
            this.stocks_unit.FillWeight = 85.32909F;
            this.stocks_unit.HeaderText = "Unit";
            this.stocks_unit.Name = "stocks_unit";
            this.stocks_unit.ReadOnly = true;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel10.Location = new System.Drawing.Point(19, 32);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(154, 16);
            this.gunaLabel10.TabIndex = 3;
            this.gunaLabel10.Text = "FROM HIGHEST TO LOWEST";
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel11.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(134, 16);
            this.gunaLabel11.TabIndex = 2;
            this.gunaLabel11.Text = "INVENTORY STOCKS";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel1.Controls.Add(this.pieChartStocks);
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(28, 21);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(433, 473);
            this.gunaLinePanel1.TabIndex = 99;
            // 
            // ucStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.gunaLinePanel6);
            this.Name = "ucStocks";
            this.Size = new System.Drawing.Size(1003, 521);
            this.gunaLinePanel6.ResumeLayout(false);
            this.gunaLinePanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryStocks)).EndInit();
            this.gunaLinePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChartStocks;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel6;
        private Guna.UI.WinForms.GunaDataGridView dgvInventoryStocks;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocks_unit;
    }
}
