namespace Final.includes.wf.admin.inv
{
    partial class frmGetStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetStocks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblNewStock = new Guna.UI.WinForms.GunaLabel();
            this.txtRemainingStocks = new Guna.UI.WinForms.GunaTextBox();
            this.lblCurrentStock = new Guna.UI.WinForms.GunaLabel();
            this.lblStockTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnBack = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtStocksWillGet = new Guna.UI.WinForms.GunaTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtStocksWillGet);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblNewStock);
            this.panel1.Controls.Add(this.txtRemainingStocks);
            this.panel1.Controls.Add(this.lblCurrentStock);
            this.panel1.Controls.Add(this.lblStockTitle);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 355);
            this.panel1.TabIndex = 1;
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
            this.btnSave.Location = new System.Drawing.Point(74, 227);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(178, 35);
            this.btnSave.TabIndex = 130;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNewStock
            // 
            this.lblNewStock.AutoSize = true;
            this.lblNewStock.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewStock.ForeColor = System.Drawing.Color.Gray;
            this.lblNewStock.Location = new System.Drawing.Point(71, 153);
            this.lblNewStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewStock.Name = "lblNewStock";
            this.lblNewStock.Size = new System.Drawing.Size(182, 17);
            this.lblNewStock.TabIndex = 129;
            this.lblNewStock.Text = "Number of Stocks you will get";
            // 
            // txtRemainingStocks
            // 
            this.txtRemainingStocks.BackColor = System.Drawing.Color.Transparent;
            this.txtRemainingStocks.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtRemainingStocks.BorderColor = System.Drawing.Color.Silver;
            this.txtRemainingStocks.BorderSize = 1;
            this.txtRemainingStocks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemainingStocks.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRemainingStocks.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtRemainingStocks.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRemainingStocks.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainingStocks.Location = new System.Drawing.Point(74, 114);
            this.txtRemainingStocks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemainingStocks.Name = "txtRemainingStocks";
            this.txtRemainingStocks.PasswordChar = '\0';
            this.txtRemainingStocks.ReadOnly = true;
            this.txtRemainingStocks.SelectedText = "";
            this.txtRemainingStocks.Size = new System.Drawing.Size(305, 34);
            this.txtRemainingStocks.TabIndex = 126;
            this.txtRemainingStocks.TextOffsetX = 5;
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStock.ForeColor = System.Drawing.Color.Gray;
            this.lblCurrentStock.Location = new System.Drawing.Point(71, 95);
            this.lblCurrentStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(112, 17);
            this.lblCurrentStock.TabIndex = 127;
            this.lblCurrentStock.Text = "Remaining Stocks";
            // 
            // lblStockTitle
            // 
            this.lblStockTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStockTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockTitle.ForeColor = System.Drawing.Color.Black;
            this.lblStockTitle.Location = new System.Drawing.Point(74, 64);
            this.lblStockTitle.Name = "lblStockTitle";
            this.lblStockTitle.Size = new System.Drawing.Size(81, 21);
            this.lblStockTitle.TabIndex = 125;
            this.lblStockTitle.Text = "Get Stocks";
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
            // txtStocksWillGet
            // 
            this.txtStocksWillGet.BackColor = System.Drawing.Color.Transparent;
            this.txtStocksWillGet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtStocksWillGet.BorderColor = System.Drawing.Color.Silver;
            this.txtStocksWillGet.BorderSize = 1;
            this.txtStocksWillGet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStocksWillGet.FocusedBaseColor = System.Drawing.Color.White;
            this.txtStocksWillGet.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtStocksWillGet.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStocksWillGet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStocksWillGet.Location = new System.Drawing.Point(74, 172);
            this.txtStocksWillGet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStocksWillGet.Name = "txtStocksWillGet";
            this.txtStocksWillGet.PasswordChar = '\0';
            this.txtStocksWillGet.SelectedText = "";
            this.txtStocksWillGet.Size = new System.Drawing.Size(305, 34);
            this.txtStocksWillGet.TabIndex = 131;
            this.txtStocksWillGet.TextOffsetX = 5;
            this.txtStocksWillGet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStocksWillGet_KeyPress);
            // 
            // frmGetStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 355);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGetStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTextBox txtStocksWillGet;
        private Guna.UI.WinForms.GunaAdvenceButton btnSave;
        private Guna.UI.WinForms.GunaLabel lblNewStock;
        private Guna.UI.WinForms.GunaTextBox txtRemainingStocks;
        private Guna.UI.WinForms.GunaLabel lblCurrentStock;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStockTitle;
        private Guna.UI.WinForms.GunaAdvenceButton btnBack;
    }
}