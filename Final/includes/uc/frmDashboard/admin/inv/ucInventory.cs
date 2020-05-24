using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmDashboard.admin.inv
{
    public partial class ucInventory : UserControl
    {
        public static ucInventory instance = null;

        private DataTable inventory_table { get; set; }
        classes.Inventory inventory;

        public ucInventory()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        public void display_inventory_data()
        {
            inventory = new classes.Inventory();

            string search = cbSearchBy.Text;
            switch (search)
            {
                case "Item":
                    inventory_table = inventory.select_inventory_table("b.item_name", txtSearch.Text);
                    break;
                case "Brand":
                    inventory_table = inventory.select_inventory_table("b.brand", txtSearch.Text);
                    break;
                case "Model":
                    inventory_table = inventory.select_inventory_table("b.model", txtSearch.Text);
                    break;
                case "Department":
                    inventory_table = inventory.select_inventory_table("d.department_name", txtSearch.Text);
                    break;
                case "Propery Number":
                    inventory_table = inventory.select_inventory_table("a.property_number", txtSearch.Text);
                    break;
                case "--Search by--":
                    inventory_table = inventory.select_inventory_table();
                    break;
                default:
                    inventory_table = inventory.select_inventory_table();
                    break;
            }

            dgvInventory.DataSource = inventory_table;
            dgvInventory.AutoGenerateColumns = false;

            if (dgvInventory.Columns.Contains("action") && dgvInventory.Columns["action"].Visible)
            {

            }
            else
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.Name = "action";
                    button.HeaderText = "ACTION";
                    button.Text = "VIEW ITEM";
                    button.UseColumnTextForButtonValue = true;
                    this.dgvInventory.Columns.Add(button);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            display_inventory_data();
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
                display_inventory_data();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearch.Text = string.Empty;
                dgvInventory.Focus();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            new includes.wf.admin.inv.frmAddItem().ShowDialog();
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInventory.Columns["action"].Index)
            {
                int inventory_id = Convert.ToInt32(dgvInventory.Rows[dgvInventory.SelectedCells[0].RowIndex].Cells[0].Value.ToString());

                includes.wf.admin.inv.frmViewItem frmViewItem = new wf.admin.inv.frmViewItem();
                frmViewItem.display_selected_inventory(inventory_id);
                frmViewItem.ShowDialog();
            }
        }
    }
}
