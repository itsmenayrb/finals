using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmDashboard.admin.inv.add_item
{
    public partial class ucProductInformation : UserControl
    {
        public static ucProductInformation instance = null;

        public string inventory_type { get; set; }
        public int category_id { get; set; }
        public string category_name { get; set; }
        public int supplier_id { get; set; }
        public string supplier_name { get; set; }

        private bool hasCapacity = false;

        public ucProductInformation()
        {
            instance = this;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "Item Name";
            txtDescription.Text = "Description";
            txtBrand.Text = "Brand";
            txtModel.Text = "Model";
            txtSerialNumber.Text = "Product Key/Serial Number";
            chkCapacity.Checked = false;
            txtCapacity.Enabled = false;
            cbCapacity.Enabled = false;
            cbCapacity.SelectedIndex = 0;
            txtQuantity.Text = "Quantity";
            cbUnit.SelectedIndex = 0;

            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucSelectSupplier1"].Visible = true;
            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucProductInformation1"].Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "Item Name" || string.IsNullOrEmpty(txtItemName.Text))
            {
                MessageBox.Show("Please indicate the item name.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemName.Text = "";
                txtItemName.Focus();
            }
            else
            {
                if (txtDescription.Text == "Description" || string.IsNullOrEmpty(txtDescription.Text))
                {
                    MessageBox.Show("Please indicate the description of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Text = "";
                    txtDescription.Focus();
                }
                else
                {
                    if (txtBrand.Text == "Brand" || string.IsNullOrEmpty(txtBrand.Text))
                    {
                        MessageBox.Show("Please indicate the brand of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBrand.Text = "";
                        txtBrand.Focus();
                    }
                    else
                    {
                        if (txtModel.Text == "Model" || string.IsNullOrEmpty(txtModel.Text))
                        {
                            MessageBox.Show("Please indicate the model of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtModel.Text = "";
                            txtModel.Focus();
                        }
                        else
                        {
                            if (txtSerialNumber.Text == "Product Key/Serial Number" || string.IsNullOrEmpty(txtSerialNumber.Text))
                            {
                                MessageBox.Show("Please indicate the serial number of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSerialNumber.Text = "";
                                txtSerialNumber.Focus();
                            }
                            else
                            {
                                if (chkCapacity.Checked)
                                {
                                    if (cbCapacity.Text == "Capacity" || string.IsNullOrEmpty(cbCapacity.Text))
                                    {
                                        MessageBox.Show("Please indicate the capacity of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtSerialNumber.Text = "";
                                        txtSerialNumber.Focus();
                                    }
                                    else
                                    {
                                        if (cbCapacity.Text == "--Select--" || cbCapacity.SelectedIndex == 0 || cbCapacity.SelectedIndex == -1)
                                        {
                                            MessageBox.Show("Please indicate the capacity size of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            cbCapacity.SelectedIndex = 0;
                                            cbCapacity.Focus();
                                        }
                                    }
                                }

                                if (txtQuantity.Text == "Quantity" || string.IsNullOrEmpty(txtQuantity.Text))
                                {
                                    MessageBox.Show("Please indicate the quantity of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtQuantity.Text = "";
                                    txtQuantity.Focus();
                                }
                                else
                                {
                                    if (cbUnit.Text == "--Select--" || cbUnit.SelectedIndex == 0 || cbUnit.SelectedIndex == -1)
                                    {
                                        MessageBox.Show("Please indicate the unit of measurement of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        cbUnit.SelectedIndex = 0;
                                        cbUnit.Focus();
                                    }
                                    else
                                    {
                                        ucOtherProductInformation.instance.inventory_type = inventory_type;

                                        ucOtherProductInformation.instance.category_id = category_id;
                                        ucOtherProductInformation.instance.category_name = category_name;

                                        ucOtherProductInformation.instance.supplier_id = supplier_id;
                                        ucOtherProductInformation.instance.supplier_name = supplier_name;

                                        ucOtherProductInformation.instance.item_name = txtItemName.Text;
                                        ucOtherProductInformation.instance.description = txtDescription.Text;
                                        ucOtherProductInformation.instance.brand = txtBrand.Text;
                                        ucOtherProductInformation.instance.model = txtModel.Text;
                                        ucOtherProductInformation.instance.serial_number = txtSerialNumber.Text;
                                        ucOtherProductInformation.instance.hasCapacity = hasCapacity;
                                        ucOtherProductInformation.instance.capacity = (chkCapacity.Checked) ? Convert.ToInt32(txtCapacity.Text) : 0;
                                        ucOtherProductInformation.instance.capacity_size = (chkCapacity.Checked) ? cbCapacity.Text : "";
                                        ucOtherProductInformation.instance.quantity = Convert.ToInt32(txtQuantity.Text);
                                        ucOtherProductInformation.instance.unit_of_measurement = cbUnit.Text;

                                        ucOtherProductInformation.instance.display_data();

                                        ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucOtherProductInformation1"].Visible = true;
                                        ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucProductInformation1"].Visible = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void chkCapacity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCapacity.Checked)
            {
                cbCapacity.Enabled = true;
                txtCapacity.Enabled = true;
                hasCapacity = true;
            }
            else
            {
                cbCapacity.Enabled = false;
                txtCapacity.Enabled = false;
                hasCapacity = false;
            }
        }

        public void display_supplier_category()
        {
            lblCategory.Text = category_name;
            lblSupplier.Text = supplier_name;

            chkCapacity.Enabled = (inventory_type == "Hardware") ? true : false;
        }

        private void txtItemName_Enter(object sender, EventArgs e)
        {
            if (txtItemName.Text == "Item Name")
            {
                txtItemName.Text = "";
                
            }
        }

        private void txtItemName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemName.Text))
            {
                txtItemName.Text = "Item Name";
            }
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtDescription.Text == "Description")
            {
                txtDescription.Text = "";
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                txtDescription.Text = "Description";
            }
        }

        private void txtBrand_Enter(object sender, EventArgs e)
        {
            if (txtBrand.Text == "Brand")
            {
                txtBrand.Text = "";
            }
        }

        private void txtBrand_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrand.Text))
            {
                txtBrand.Text = "Brand";
            }
        }

        private void txtModel_Enter(object sender, EventArgs e)
        {
            if (txtModel.Text == "Model")
            {
                txtModel.Text = "";
            }
        }

        private void txtModel_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModel.Text))
            {
                txtModel.Text = "Model";
            }
        }

        private void txtSerialNumber_Enter(object sender, EventArgs e)
        {
            if (txtSerialNumber.Text == "Product Key/Serial Number")
            {
                txtSerialNumber.Text = "";
            }
        }

        private void txtSerialNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModel.Text))
            {
                txtModel.Text = "Product Key/Serial Number";
            }
        }

        private void txtCapacity_Enter(object sender, EventArgs e)
        {
            if (txtCapacity.Text == "Capacity")
            {
                txtCapacity.Text = "";
            }
        }

        private void txtCapacity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCapacity.Text))
            {
                txtCapacity.Text = "Capacity";
            }
            else
            {
                int qty = Convert.ToInt32(txtCapacity.Text);
                if (qty < 1)
                {
                    MessageBox.Show("Invalid capacity. Please try again.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCapacity.Text = "";
                    txtCapacity.Focus();
                }
            }
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "Quantity")
            {
                txtQuantity.Text = "";
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                txtQuantity.Text = "Quantity";
            }
            else
            {
                int qty = Convert.ToInt32(txtQuantity.Text);
                if (qty < 1)
                {
                    MessageBox.Show("Invalid quantity. Please try again.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.Text = "";
                    txtQuantity.Focus();
                }
            }
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
