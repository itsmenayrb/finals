using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Final.includes.uc.frmDashboard.admin.inv
{
    public partial class ucCategories : UserControl
    {
        public static ucCategories instance = null;
        classes.Inventory_Category inventory_category;

        Guna.UI2.WinForms.Guna2TileButton button;
        private string inventory_type = string.Empty;
        private DataTable inventory_table { get; set; }

        public ucCategories()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            includes.wf.admin.inv.frmAddCategory addCategory = new wf.admin.inv.frmAddCategory();
            addCategory.request_from = "Inventory";
            addCategory.ShowDialog();
        }

        private void btnSoftware_Click(object sender, EventArgs e)
        {
            inventory_type = "Software";
            display_category();
        }

        private void btnHardware_Click(object sender, EventArgs e)
        {
            inventory_type = "Hardware";
            display_category();
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
                    button.Size = new Size(117, 107);
                    button.Click += new EventHandler(this.button_Click);

                    flpCategory.Controls.Add(button);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TileButton button = (Guna.UI2.WinForms.Guna2TileButton)sender;
            int category_id = Convert.ToInt32(button.Name);

            inventory_table = new classes.Inventory().select_inventory_table("a.category_id", category_id);

            dgvInventory.DataSource = inventory_table;
            dgvInventory.AutoGenerateColumns = false;
            if (dgvInventory.Columns.Contains("action") && dgvInventory.Columns["action"].Visible)
            {

            }
            else
            {
                DataGridViewButtonColumn col_button = new DataGridViewButtonColumn();
                {
                    col_button.Name = "action";
                    col_button.HeaderText = "ACTION";
                    col_button.Text = "VIEW ITEM";
                    col_button.UseColumnTextForButtonValue = true;
                    this.dgvInventory.Columns.Add(col_button);
                }
            }
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
    }
}
