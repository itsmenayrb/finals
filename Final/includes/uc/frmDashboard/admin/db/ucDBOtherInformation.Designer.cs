namespace Final.includes.uc.frmDashboard.admin.db
{
    partial class ucDBOtherInformation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLinePanel7 = new Guna.UI.WinForms.GunaLinePanel();
            this.dgvDatabaseLogs = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.action_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_through = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLinePanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel7
            // 
            this.gunaLinePanel7.Controls.Add(this.dgvDatabaseLogs);
            this.gunaLinePanel7.Controls.Add(this.gunaLabel8);
            this.gunaLinePanel7.LineBottom = 1;
            this.gunaLinePanel7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.gunaLinePanel7.LineLeft = 1;
            this.gunaLinePanel7.LineRight = 1;
            this.gunaLinePanel7.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel7.LineTop = 1;
            this.gunaLinePanel7.Location = new System.Drawing.Point(28, 26);
            this.gunaLinePanel7.Name = "gunaLinePanel7";
            this.gunaLinePanel7.Size = new System.Drawing.Size(945, 463);
            this.gunaLinePanel7.TabIndex = 15;
            // 
            // dgvDatabaseLogs
            // 
            this.dgvDatabaseLogs.AllowUserToAddRows = false;
            this.dgvDatabaseLogs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDatabaseLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatabaseLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatabaseLogs.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatabaseLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatabaseLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatabaseLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatabaseLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatabaseLogs.ColumnHeadersHeight = 26;
            this.dgvDatabaseLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.action_at,
            this.action,
            this.action_through});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatabaseLogs.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatabaseLogs.EnableHeadersVisualStyles = false;
            this.dgvDatabaseLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvDatabaseLogs.Location = new System.Drawing.Point(22, 52);
            this.dgvDatabaseLogs.Name = "dgvDatabaseLogs";
            this.dgvDatabaseLogs.ReadOnly = true;
            this.dgvDatabaseLogs.RowHeadersVisible = false;
            this.dgvDatabaseLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatabaseLogs.Size = new System.Drawing.Size(896, 389);
            this.dgvDatabaseLogs.TabIndex = 4;
            this.dgvDatabaseLogs.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid;
            this.dgvDatabaseLogs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatabaseLogs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDatabaseLogs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDatabaseLogs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDatabaseLogs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDatabaseLogs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatabaseLogs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvDatabaseLogs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvDatabaseLogs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDatabaseLogs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatabaseLogs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDatabaseLogs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDatabaseLogs.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvDatabaseLogs.ThemeStyle.ReadOnly = true;
            this.dgvDatabaseLogs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatabaseLogs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatabaseLogs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatabaseLogs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDatabaseLogs.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDatabaseLogs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvDatabaseLogs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(19, 17);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(114, 16);
            this.gunaLabel8.TabIndex = 2;
            this.gunaLabel8.Text = "DATABASE LOGS";
            // 
            // action_at
            // 
            this.action_at.DataPropertyName = "action_at";
            this.action_at.HeaderText = "Date";
            this.action_at.Name = "action_at";
            this.action_at.ReadOnly = true;
            // 
            // action
            // 
            this.action.DataPropertyName = "action";
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            // 
            // action_through
            // 
            this.action_through.DataPropertyName = "action_through";
            this.action_through.HeaderText = "Process";
            this.action_through.Name = "action_through";
            this.action_through.ReadOnly = true;
            // 
            // ucDBOtherInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel7);
            this.Name = "ucDBOtherInformation";
            this.Size = new System.Drawing.Size(1003, 521);
            this.Load += new System.EventHandler(this.ucDBOtherInformation_Load);
            this.gunaLinePanel7.ResumeLayout(false);
            this.gunaLinePanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel7;
        private Guna.UI.WinForms.GunaDataGridView dgvDatabaseLogs;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_through;

    }
}
