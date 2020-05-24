using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.wf.admin.inv
{
    public partial class frmUpdateStocks : Form
    {
        public string action { get; set; }

        public int inventory_id { get; set; }

        public int productinformation_id { get; set; }
        public int stock_id { get; set; }
        public int current_stock { get; set; }
        public string unit_of_measurement { get; set; }

        classes.Inventory_Stocks stocks;

        public string stock_title
        {
            set { lblStockTitle.Text = value; }
            get { return lblStockTitle.Text; }
        }

        public string new_stock
        {
            set { lblNewStock.Text = value; }
            get { return lblNewStock.Text; }
        }

        public frmUpdateStocks()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        public void display_selected_stock()
        {
            txtCurrentStock.Text = current_stock.ToString();
            cbUnit.SelectedIndex = cbUnit.FindStringExact(unit_of_measurement);
        }

        private void txtNewStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewStock.Text))
            {
                MessageBox.Show("Please select the new category you wish to update to this item.", "Update Item Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewStock.Focus();
                return;
            }
            else
            {
                if (Convert.ToInt32(txtNewStock.Text) < 1)
                {
                    MessageBox.Show("The stock must be 1 and above.", "Update Item Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewStock.Text = "";
                    txtNewStock.Focus();
                    return;
                }
                else
                {
                    if (action == "Update")
                    {
                        update_stocks();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_stocks()
        {
            stocks = new classes.Inventory_Stocks();
            stocks.quantity = Convert.ToInt32(txtNewStock.Text);
            stocks.unit_of_measurement = cbUnit.Text;

            if (stocks.create_stocks())
            {
                if (stocks.update_stock(productinformation_id))
                {
                    MessageBox.Show("Stocks has been updated!", "Update Stocks", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    frmViewItem.instance.display_selected_inventory(inventory_id);
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }
    }
}
