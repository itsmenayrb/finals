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
        public ucInventory()
        {
            InitializeComponent();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            btnInventory.LineBottom = 2;
            btnStock.LineBottom = 0;
            btnCategory.LineBottom = 0;
            btnSupplier.LineBottom = 0;
            btnOtherInformation.LineBottom = 0;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            btnInventory.LineBottom = 0;
            btnStock.LineBottom = 2;
            btnCategory.LineBottom = 0;
            btnSupplier.LineBottom = 0;
            btnOtherInformation.LineBottom = 0;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            btnInventory.LineBottom = 0;
            btnStock.LineBottom = 0;
            btnCategory.LineBottom = 2;
            btnSupplier.LineBottom = 0;
            btnOtherInformation.LineBottom = 0;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            btnInventory.LineBottom = 0;
            btnStock.LineBottom = 0;
            btnCategory.LineBottom = 0;
            btnSupplier.LineBottom = 2;
            btnOtherInformation.LineBottom = 0;
        }

        private void btnOtherInformation_Click(object sender, EventArgs e)
        {
            btnInventory.LineBottom = 0;
            btnStock.LineBottom = 0;
            btnCategory.LineBottom = 0;
            btnSupplier.LineBottom = 0;
            btnOtherInformation.LineBottom = 2;
        }
    }
}
