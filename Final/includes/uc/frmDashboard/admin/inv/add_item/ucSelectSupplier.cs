using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Final.includes.uc.frmDashboard.admin.inv.add_item
{
    public partial class ucSelectSupplier : UserControl
    {
        public static ucSelectSupplier instance = null;

        classes.Inventory_Supplier inventory_supplier;
        classes.Inventory inventory;

        public string inventory_type { get; set; }
        public int category_id { get; set; }
        public string category_name { get; set; }

        Guna.UI2.WinForms.Guna2TileButton button;

        public ucSelectSupplier()
        {
            instance = this;
            InitializeComponent();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Final.includes.wf.admin.inv.frmSelectBusinessType select = new wf.admin.inv.frmSelectBusinessType();
            select.request_from = "Add Item";
            select.display_business_type();
            select.ShowDialog();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Search";
                display_supplier();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            display_supplier();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ucSelectCategory.instance.inventory_type = inventory_type;
            ucSelectCategory.instance.display_category();
            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucSelectType1"].Visible = false;
            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucSelectCategory1"].Visible = true;
            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucSelectSupplier1"].Visible = false;
        }

        public void display_supplier()
        {
            flpSupplier.Controls.Clear();

            inventory_supplier = new classes.Inventory_Supplier();
            DataTable dt = (txtSearch.Text == "Search" || string.IsNullOrEmpty(txtSearch.Text)) ? inventory_supplier.select_supplier() :
                            inventory_supplier.select_supplier(txtSearch.Text);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    button = new Guna.UI2.WinForms.Guna2TileButton();
                    button.Name = row["id"].ToString();
                    button.Text = row["supplier_name"].ToString();
                    button.Image = (row["logo"] == null) ? null : Image.FromStream(new MemoryStream((Byte[])row["logo"]));
                    button.HoverState.Image = (row["logo"] == null) ? null : Image.FromStream(new MemoryStream((Byte[])row["logo"]));
                    button.ImageSize = new Size(30, 30);
                    button.BorderColor = Color.FromArgb(47, 97, 72);
                    button.BorderRadius = 5;
                    button.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    button.BorderThickness = 1;
                    button.Font = new Font("Century Gothic", 9, FontStyle.Regular);
                    button.ForeColor = Color.Black;
                    button.BackColor = Color.White;
                    button.FillColor = Color.White;
                    button.Size = new Size(100, 113);
                    button.Click += new EventHandler(this.button_Click);

                    flpSupplier.Controls.Add(button);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TileButton button = (Guna.UI2.WinForms.Guna2TileButton)sender;
            int supplier_id = Convert.ToInt32(button.Name);
            string supplier_name = button.Text;

            ucProductInformation.instance.inventory_type = inventory_type;
            ucProductInformation.instance.category_id = category_id;
            ucProductInformation.instance.category_name = category_name;
            ucProductInformation.instance.supplier_id = supplier_id;
            ucProductInformation.instance.supplier_name = supplier_name;
            ucProductInformation.instance.display_supplier_category();

            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucSelectSupplier1"].Visible = false;
            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucProductInformation1"].Visible = true;
        }
    }
}
