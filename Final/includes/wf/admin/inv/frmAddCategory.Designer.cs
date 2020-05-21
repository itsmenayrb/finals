namespace Final.includes.wf.admin.inv
{
    partial class frmAddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCategory));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnBack = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblMessage = new Guna.UI.WinForms.GunaLabel();
            this.txtInventoryType = new Guna.UI.WinForms.GunaTextBox();
            this.txtCategoryName = new Guna.UI.WinForms.GunaTextBox();
            this.btnSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnUpload = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(74, 64);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(113, 21);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Add Category";
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
            this.btnBack.TabIndex = 95;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Gray;
            this.lblMessage.Location = new System.Drawing.Point(71, 88);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(296, 23);
            this.lblMessage.TabIndex = 100;
            this.lblMessage.Text = "Sort your inventory by categorizing equipment";
            // 
            // txtInventoryType
            // 
            this.txtInventoryType.BackColor = System.Drawing.Color.Transparent;
            this.txtInventoryType.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtInventoryType.BorderColor = System.Drawing.Color.Silver;
            this.txtInventoryType.BorderSize = 1;
            this.txtInventoryType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInventoryType.FocusedBaseColor = System.Drawing.Color.White;
            this.txtInventoryType.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtInventoryType.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtInventoryType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryType.Location = new System.Drawing.Point(74, 129);
            this.txtInventoryType.Margin = new System.Windows.Forms.Padding(2);
            this.txtInventoryType.Name = "txtInventoryType";
            this.txtInventoryType.PasswordChar = '\0';
            this.txtInventoryType.ReadOnly = true;
            this.txtInventoryType.SelectedText = "";
            this.txtInventoryType.Size = new System.Drawing.Size(305, 34);
            this.txtInventoryType.TabIndex = 101;
            this.txtInventoryType.TabStop = false;
            this.txtInventoryType.TextOffsetX = 5;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.txtCategoryName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtCategoryName.BorderColor = System.Drawing.Color.Silver;
            this.txtCategoryName.BorderSize = 1;
            this.txtCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCategoryName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtCategoryName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCategoryName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(74, 167);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.PasswordChar = '\0';
            this.txtCategoryName.SelectedText = "";
            this.txtCategoryName.Size = new System.Drawing.Size(305, 34);
            this.txtCategoryName.TabIndex = 0;
            this.txtCategoryName.Text = "Category Name";
            this.txtCategoryName.TextOffsetX = 5;
            this.txtCategoryName.Enter += new System.EventHandler(this.txtCategoryName_Enter);
            this.txtCategoryName.Leave += new System.EventHandler(this.txtCategoryName_Leave);
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
            this.btnSave.Location = new System.Drawing.Point(74, 263);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(178, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.gunaLabel1.Location = new System.Drawing.Point(193, 205);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(129, 18);
            this.gunaLabel1.TabIndex = 104;
            this.gunaLabel1.Text = "Max: 5KB";
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnUpload.Location = new System.Drawing.Point(128, 208);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnUpload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpload.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnUpload.OnHoverImage = null;
            this.btnUpload.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpload.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpload.Size = new System.Drawing.Size(63, 23);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.TabStop = false;
            this.btnUpload.Text = "Upload";
            this.btnUpload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.gunaLabel2.Location = new System.Drawing.Point(193, 218);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(153, 18);
            this.gunaLabel2.TabIndex = 106;
            this.gunaLabel2.Text = "Recommended pixels is 30";
            // 
            // pbPreview
            // 
            this.pbPreview.Image = ((System.Drawing.Image)(resources.GetObject("pbPreview.Image")));
            this.pbPreview.Location = new System.Drawing.Point(344, 205);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(33, 31);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreview.TabIndex = 107;
            this.pbPreview.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel3.Location = new System.Drawing.Point(71, 211);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(57, 17);
            this.gunaLabel3.TabIndex = 108;
            this.gunaLabel3.Text = "Set Icon";
            // 
            // frmAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 355);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.txtInventoryType);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddCategory";
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnBack;
        private Guna.UI.WinForms.GunaLabel lblMessage;
        private Guna.UI.WinForms.GunaTextBox txtInventoryType;
        private Guna.UI.WinForms.GunaTextBox txtCategoryName;
        private Guna.UI.WinForms.GunaAdvenceButton btnSave;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpload;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.PictureBox pbPreview;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}