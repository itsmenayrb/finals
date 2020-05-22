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
    public partial class ucSelectCategory : UserControl
    {
        public static ucSelectCategory instance = null;
        classes.Inventory_Category inventory_category;

        Guna.UI2.WinForms.Guna2TileButton button;

        public string inventory_type
        {
            set { lblInventoryType.Text = value; }
            get { return lblInventoryType.Text; }
        }

        public ucSelectCategory()
        {
            instance = this;
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            includes.wf.admin.inv.frmAddCategory frmCategory = new wf.admin.inv.frmAddCategory();
            frmCategory.inventory_type = inventory_type;
            frmCategory.request_from = "Add Item";
            frmCategory.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.inventory_type = "";
            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucSelectType1"].Visible = true;
            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucSelectCategory1"].Visible = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TileButton button = (Guna.UI2.WinForms.Guna2TileButton)sender;
            int category_id = Convert.ToInt32(button.Name);
            string category_name = button.Text;

            ucSelectSupplier.instance.category_id = category_id;
            ucSelectSupplier.instance.category_name = category_name;
            ucSelectSupplier.instance.inventory_type = inventory_type;
            ucSelectSupplier.instance.display_supplier();

            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucSelectSupplier1"].Visible = true;
            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucSelectCategory1"].Visible = false;
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
                display_category();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            display_category();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearch.Text = string.Empty;
                flpCategory.Focus();
            }
        }

        public void display_category()
        {
            flpCategory.Controls.Clear();

            inventory_category = new classes.Inventory_Category();
            inventory_category.inventory_type = inventory_type;
            DataTable dt = (txtSearch.Text == "Search" || string.IsNullOrEmpty(txtSearch.Text)) ? inventory_category.select_category() :
                            inventory_category.select_category(txtSearch.Text);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    button = new Guna.UI2.WinForms.Guna2TileButton();
                    button.Name = row["id"].ToString();
                    button.Text = row["category_name"].ToString();
                    button.Image = (row["icon"] == null) ? null : Image.FromStream(new MemoryStream((Byte[])row["icon"]));
                    button.HoverState.Image = (row["icon"] == null) ? null : Image.FromStream(new MemoryStream((Byte[])row["icon"]));
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

                    flpCategory.Controls.Add(button);
                }
            }
        }
    }
}
