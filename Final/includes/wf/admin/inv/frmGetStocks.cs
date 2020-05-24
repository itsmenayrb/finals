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
    public partial class frmGetStocks : Form
    {
        public int inventory_id { get; set; }
        classes.Inventory_Stocks stocks;

        public string quantity
        {
            set { txtRemainingStocks.Text = value; }
            get { return txtRemainingStocks.Text; }
        }

        public frmGetStocks()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStocksWillGet.Text))
            {
                MessageBox.Show("Please indicate how much stocks you will get.", "Get Item Stocks", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStocksWillGet.Focus();
                return;
            }
            else
            {
                int remaining_stocks = Convert.ToInt32(txtRemainingStocks.Text);
                int get_stocks = Convert.ToInt16(txtStocksWillGet.Text);
                if (get_stocks > remaining_stocks)
                {
                    MessageBox.Show("Insufficient Stocks.", "Get Item Stocks", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStocksWillGet.Text = "";
                    txtStocksWillGet.Focus();
                    return;
                }
                else
                {
                    if (get_stocks < 1)
                    {
                        MessageBox.Show("The stocks you should get must be 1 and above.", "Get Item Stocks", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtStocksWillGet.Text = "";
                        txtStocksWillGet.Focus();
                        return;
                    }
                    else
                    {
                        remaining_stocks = remaining_stocks - get_stocks;
                        stocks = new classes.Inventory_Stocks();
                        if (stocks.update_stock(inventory_id, remaining_stocks))
                        {
                            MessageBox.Show("Success! The new stocks is " + remaining_stocks.ToString(), "Get Item Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            uc.frmDashboard.admin.inv.ucStocks.instance.display_stocks_chart();
                            uc.frmDashboard.admin.inv.ucStocks.instance.display_stocks_table();
                            this.Close();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }

        private void txtStocksWillGet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
