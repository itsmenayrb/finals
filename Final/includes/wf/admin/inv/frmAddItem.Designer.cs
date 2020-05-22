namespace Final.includes.wf.admin.inv
{
    partial class frmAddItem
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
            this.lblInstallationType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblProgressBarText = new Guna.UI.WinForms.GunaLabel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ucOtherProductInformation1 = new Final.includes.uc.frmDashboard.admin.inv.add_item.ucOtherProductInformation();
            this.ucProductInformation1 = new Final.includes.uc.frmDashboard.admin.inv.add_item.ucProductInformation();
            this.ucSelectSupplier1 = new Final.includes.uc.frmDashboard.admin.inv.add_item.ucSelectSupplier();
            this.ucSelectCategory1 = new Final.includes.uc.frmDashboard.admin.inv.add_item.ucSelectCategory();
            this.ucSelectType1 = new Final.includes.uc.frmDashboard.admin.inv.add_item.ucSelectType();
            this.ucPreview1 = new Final.includes.uc.frmDashboard.admin.inv.add_item.ucPreview();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstallationType
            // 
            this.lblInstallationType.BackColor = System.Drawing.Color.Transparent;
            this.lblInstallationType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallationType.ForeColor = System.Drawing.Color.Black;
            this.lblInstallationType.Location = new System.Drawing.Point(65, 43);
            this.lblInstallationType.Name = "lblInstallationType";
            this.lblInstallationType.Size = new System.Drawing.Size(74, 21);
            this.lblInstallationType.TabIndex = 97;
            this.lblInstallationType.Text = "Inventory";
            // 
            // lblProgressBarText
            // 
            this.lblProgressBarText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressBarText.ForeColor = System.Drawing.Color.Gray;
            this.lblProgressBarText.Location = new System.Drawing.Point(62, 61);
            this.lblProgressBarText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgressBarText.Name = "lblProgressBarText";
            this.lblProgressBarText.Size = new System.Drawing.Size(404, 23);
            this.lblProgressBarText.TabIndex = 98;
            this.lblProgressBarText.Text = "Add inventory item";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.ucPreview1);
            this.panelContainer.Controls.Add(this.ucOtherProductInformation1);
            this.panelContainer.Controls.Add(this.ucProductInformation1);
            this.panelContainer.Controls.Add(this.ucSelectSupplier1);
            this.panelContainer.Controls.Add(this.ucSelectCategory1);
            this.panelContainer.Controls.Add(this.ucSelectType1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(0, 93);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(700, 407);
            this.panelContainer.TabIndex = 99;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(655, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 42);
            this.guna2ControlBox1.TabIndex = 100;
            // 
            // ucOtherProductInformation1
            // 
            this.ucOtherProductInformation1.BackColor = System.Drawing.Color.White;
            this.ucOtherProductInformation1.brand = null;
            this.ucOtherProductInformation1.capacity = 0;
            this.ucOtherProductInformation1.capacity_size = null;
            this.ucOtherProductInformation1.category_id = 0;
            this.ucOtherProductInformation1.category_name = null;
            this.ucOtherProductInformation1.description = null;
            this.ucOtherProductInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOtherProductInformation1.hasCapacity = false;
            this.ucOtherProductInformation1.inventory_type = null;
            this.ucOtherProductInformation1.item_name = null;
            this.ucOtherProductInformation1.Location = new System.Drawing.Point(0, 0);
            this.ucOtherProductInformation1.model = null;
            this.ucOtherProductInformation1.Name = "ucOtherProductInformation1";
            this.ucOtherProductInformation1.quantity = 0;
            this.ucOtherProductInformation1.serial_number = null;
            this.ucOtherProductInformation1.Size = new System.Drawing.Size(700, 407);
            this.ucOtherProductInformation1.supplier_id = 0;
            this.ucOtherProductInformation1.supplier_name = null;
            this.ucOtherProductInformation1.TabIndex = 4;
            this.ucOtherProductInformation1.unit_of_measurement = null;
            this.ucOtherProductInformation1.Visible = false;
            // 
            // ucProductInformation1
            // 
            this.ucProductInformation1.BackColor = System.Drawing.Color.White;
            this.ucProductInformation1.category_id = 0;
            this.ucProductInformation1.category_name = null;
            this.ucProductInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProductInformation1.inventory_type = null;
            this.ucProductInformation1.Location = new System.Drawing.Point(0, 0);
            this.ucProductInformation1.Name = "ucProductInformation1";
            this.ucProductInformation1.Size = new System.Drawing.Size(700, 407);
            this.ucProductInformation1.supplier_id = 0;
            this.ucProductInformation1.supplier_name = null;
            this.ucProductInformation1.TabIndex = 3;
            this.ucProductInformation1.Visible = false;
            // 
            // ucSelectSupplier1
            // 
            this.ucSelectSupplier1.BackColor = System.Drawing.Color.White;
            this.ucSelectSupplier1.category_id = 0;
            this.ucSelectSupplier1.category_name = null;
            this.ucSelectSupplier1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSelectSupplier1.inventory_type = null;
            this.ucSelectSupplier1.Location = new System.Drawing.Point(0, 0);
            this.ucSelectSupplier1.Name = "ucSelectSupplier1";
            this.ucSelectSupplier1.Size = new System.Drawing.Size(700, 407);
            this.ucSelectSupplier1.TabIndex = 2;
            this.ucSelectSupplier1.Visible = false;
            // 
            // ucSelectCategory1
            // 
            this.ucSelectCategory1.BackColor = System.Drawing.Color.White;
            this.ucSelectCategory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSelectCategory1.inventory_type = "Recommended pixels is 30";
            this.ucSelectCategory1.Location = new System.Drawing.Point(0, 0);
            this.ucSelectCategory1.Name = "ucSelectCategory1";
            this.ucSelectCategory1.Size = new System.Drawing.Size(700, 407);
            this.ucSelectCategory1.TabIndex = 1;
            this.ucSelectCategory1.Visible = false;
            // 
            // ucSelectType1
            // 
            this.ucSelectType1.BackColor = System.Drawing.Color.White;
            this.ucSelectType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSelectType1.Location = new System.Drawing.Point(0, 0);
            this.ucSelectType1.Name = "ucSelectType1";
            this.ucSelectType1.Size = new System.Drawing.Size(700, 407);
            this.ucSelectType1.TabIndex = 0;
            // 
            // ucPreview1
            // 
            this.ucPreview1.BackColor = System.Drawing.Color.White;
            this.ucPreview1.brand = null;
            this.ucPreview1.capacity = 0;
            this.ucPreview1.capacity_size = null;
            this.ucPreview1.category_id = 0;
            this.ucPreview1.category_name = null;
            this.ucPreview1.date_acquired = new System.DateTime(((long)(0)));
            this.ucPreview1.date_expired = new System.DateTime(((long)(0)));
            this.ucPreview1.department_id = 0;
            this.ucPreview1.department_name = null;
            this.ucPreview1.description = null;
            this.ucPreview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPreview1.hasCapacity = false;
            this.ucPreview1.inventory_type = null;
            this.ucPreview1.item_name = null;
            this.ucPreview1.Location = new System.Drawing.Point(0, 0);
            this.ucPreview1.model = null;
            this.ucPreview1.Name = "ucPreview1";
            this.ucPreview1.property_number = null;
            this.ucPreview1.quantity = 0;
            this.ucPreview1.serial_number = null;
            this.ucPreview1.Size = new System.Drawing.Size(700, 407);
            this.ucPreview1.status = null;
            this.ucPreview1.supplier_id = 0;
            this.ucPreview1.supplier_name = null;
            this.ucPreview1.TabIndex = 5;
            this.ucPreview1.unit_of_measurement = null;
            this.ucPreview1.Visible = false;
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.lblProgressBarText);
            this.Controls.Add(this.lblInstallationType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddItem";
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblInstallationType;
        private Guna.UI.WinForms.GunaLabel lblProgressBarText;
        private System.Windows.Forms.Panel panelContainer;
        private uc.frmDashboard.admin.inv.add_item.ucSelectType ucSelectType1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private uc.frmDashboard.admin.inv.add_item.ucSelectCategory ucSelectCategory1;
        private uc.frmDashboard.admin.inv.add_item.ucSelectSupplier ucSelectSupplier1;
        private uc.frmDashboard.admin.inv.add_item.ucProductInformation ucProductInformation1;
        private uc.frmDashboard.admin.inv.add_item.ucOtherProductInformation ucOtherProductInformation1;
        private uc.frmDashboard.admin.inv.add_item.ucPreview ucPreview1;
    }
}