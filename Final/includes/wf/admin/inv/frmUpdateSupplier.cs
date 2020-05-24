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
    public partial class frmUpdateSupplier : Form
    {
        public int inventory_id { get; set; }
        public int supplier_id { get; set; }
        public string supplier_name { get; set; }

        classes.Inventory_Supplier supplier;

        public frmUpdateSupplier()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbSupplier.Text) || cbSupplier.SelectedIndex == 0 || cbSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the new supplier you wish to update to this item.", "Update Item Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentSupplier.Focus();
                return;
            }
            else
            {
                update_supplier();
            }
        }

        private void update_supplier()
        {
            supplier = new classes.Inventory_Supplier();
            if (supplier.update_inventory_supplier(inventory_id, Convert.ToInt32(cbSupplier.SelectedValue)))
            {
                MessageBox.Show("Supplier has been updated!", "Update Supplier", MessageBoxButtons.OK, MessageBoxIcon.Question);
                frmViewItem.instance.display_selected_inventory(inventory_id);
                this.Close();
            }
        }

        public void display_selected_supplier()
        {
            txtCurrentSupplier.Text = supplier_name;

            supplier = new classes.Inventory_Supplier();
            cbSupplier.DataSource = supplier.select_inventory_supplier_except_this(supplier_id);
            cbSupplier.DisplayMember = "supplier_name";
            cbSupplier.ValueMember = "id";
            cbSupplier.SelectedIndex = 0;
        }
    }
}
