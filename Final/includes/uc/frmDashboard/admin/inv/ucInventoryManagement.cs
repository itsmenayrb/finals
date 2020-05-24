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
    public partial class ucInventoryManagement : UserControl
    {
        public static ucInventoryManagement instance = null;
        public ucInventoryManagement()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelContainer, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            btnInventory.LineBottom = 2;
            btnStock.LineBottom = 0;
            btnCategory.LineBottom = 0;
            btnSupplier.LineBottom = 0;
            btnOtherInformation.LineBottom = 0;

            ucInventory.instance.display_inventory_data();
            ucInventory1.Visible = true;
            ucStocks1.Visible = false;
            ucCategories1.Visible = false;
            ucSupplier1.Visible = false;
            ucOtherInventoryInformation1.Visible = false;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            btnInventory.LineBottom = 0;
            btnStock.LineBottom = 2;
            btnCategory.LineBottom = 0;
            btnSupplier.LineBottom = 0;
            btnOtherInformation.LineBottom = 0;

            ucStocks.instance.display_stocks_chart();
            ucStocks.instance.display_stocks_table();
            ucInventory1.Visible = false;
            ucStocks1.Visible = true;
            ucCategories1.Visible = false;
            ucSupplier1.Visible = false;
            ucOtherInventoryInformation1.Visible = false;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            btnInventory.LineBottom = 0;
            btnStock.LineBottom = 0;
            btnCategory.LineBottom = 2;
            btnSupplier.LineBottom = 0;
            btnOtherInformation.LineBottom = 0;

            ucCategories.instance.display_category();
            ucInventory1.Visible = false;
            ucStocks1.Visible = false;
            ucCategories1.Visible = true;
            ucSupplier1.Visible = false;
            ucOtherInventoryInformation1.Visible = false;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            btnInventory.LineBottom = 0;
            btnStock.LineBottom = 0;
            btnCategory.LineBottom = 0;
            btnSupplier.LineBottom = 2;
            btnOtherInformation.LineBottom = 0;

            ucSupplier.instance.display_business_type();
            ucInventory1.Visible = false;
            ucStocks1.Visible = false;
            ucCategories1.Visible = false;
            ucSupplier1.Visible = true;
            ucOtherInventoryInformation1.Visible = false;
        }

        private void btnOtherInformation_Click(object sender, EventArgs e)
        {
            btnInventory.LineBottom = 0;
            btnStock.LineBottom = 0;
            btnCategory.LineBottom = 0;
            btnSupplier.LineBottom = 0;
            btnOtherInformation.LineBottom = 2;

            ucOtherInventoryInformation.instance.display_inventory_information();
            ucInventory1.Visible = false;
            ucStocks1.Visible = false;
            ucCategories1.Visible = false;
            ucSupplier1.Visible = false;
            ucOtherInventoryInformation1.Visible = true;
        }
    }
}
