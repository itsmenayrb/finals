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
    public partial class frmUpdateProductInformation : Form
    {
        classes.Inventory_ProductInformation inv_prod_info;

        public int inventory_id { get; set; }

        public string inventory_type { get; set; }

        public string item_name { get; set; }
        public string description { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string serial_number { get; set; }

        public int capacity_id { get; set; }
        public int capacity { get; set; }
        public string capacity_size { get; set; }
        public string property_number { get; set; }
        public string status { get; set; }

        public DateTime acquired_at { get; set; }
        public DateTime expire_at { get; set; }

        public frmUpdateProductInformation()
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
            update_product_information();
        }

        public void display_product_information()
        {
            txtItemName.Text = item_name;
            txtDescription.Text = description;
            txtBrand.Text = brand;
            txtModel.Text = model;
            txtSerialNumber.Text = serial_number;
            txtPropertyNumber.Text = property_number;
            dtpDateAcquired.Value = acquired_at;
            dtpDateAcquired.MaxDate = DateTime.Today;

            if (inventory_type == "Hardware")
            {
                chkCapacity.Enabled = true;
                if (capacity_id == 0)
                {
                    chkCapacity.Checked = false;
                }
                else
                {
                    chkCapacity.Checked = true;
                    txtCapacity.Text = capacity.ToString();
                    cbCapacity.SelectedIndex = cbCapacity.FindStringExact(capacity_size);
                    txtCapacity.Enabled = true;
                    cbCapacity.Enabled = true;
                }

                rdbCondemned.Visible = true;
                rdbWorking.Text = "Working";
                rdbDefective.Text = "Defective";
                rdbWorking.Enabled = true;
                rdbDefective.Enabled = true;

                foreach (Control control in panel1.Controls)
                {
                    if (control.GetType() == typeof(Guna.UI2.WinForms.Guna2RadioButton))
                    {
                        Guna.UI2.WinForms.Guna2RadioButton rdb = control as Guna.UI2.WinForms.Guna2RadioButton;
                        rdb.Checked = (rdb.Text == status) ? true : false;
                    }
                }

                lblDateExpiry.Visible = false;
                dtpDateExpiry.Visible = false;
            }
            else if (inventory_type == "Software")
            {
                chkCapacity.Enabled = false;
                chkCapacity.Checked = false;
                cbCapacity.Enabled = false;
                txtCapacity.Enabled = false;

                rdbCondemned.Visible = false;
                rdbWorking.Text = "Subscribed";
                rdbDefective.Text = "Expired";
                rdbWorking.Enabled = false;
                rdbDefective.Enabled = false;

                foreach (Control control in panel1.Controls)
                {
                    if (control.GetType() == typeof(Guna.UI2.WinForms.Guna2RadioButton))
                    {
                        Guna.UI2.WinForms.Guna2RadioButton rdb = control as Guna.UI2.WinForms.Guna2RadioButton;
                        rdb.Checked = (rdb.Text == status) ? true : false;
                    }
                }

                lblDateExpiry.Visible = true;
                dtpDateExpiry.Visible = true;
                dtpDateExpiry.Value = expire_at;
            }
        }

        private void chkCapacity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCapacity.Checked)
            {
                txtCapacity.Enabled = true;
                cbCapacity.Enabled = true;
            }
            else
            {
                txtCapacity.Enabled = false;
                cbCapacity.Enabled = false;
            }
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dtpDateExpiry_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateExpiry.Value >= DateTime.Now)
            {
                rdbWorking.Checked = true;
            }
            else if (dtpDateExpiry.Value < DateTime.Now)
            {
                rdbDefective.Checked = true;
            }
        }

        private void update_product_information()
        {
            if (string.IsNullOrEmpty(txtItemName.Text))
            {
                MessageBox.Show("Please indicate the item name.", "Update Product Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemName.Text = "";
                txtItemName.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(txtDescription.Text))
                {
                    MessageBox.Show("Please indicate the description of the item.", "Update Product Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Text = "";
                    txtDescription.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtBrand.Text))
                    {
                        MessageBox.Show("Please indicate the brand of the item.", "Update Product Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBrand.Text = "";
                        txtBrand.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtModel.Text))
                        {
                            MessageBox.Show("Please indicate the model of the item.", "Update Product Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtModel.Text = "";
                            txtModel.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtSerialNumber.Text))
                            {
                                MessageBox.Show("Please indicate the serial number of the item.", "Update Product Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSerialNumber.Text = "";
                                txtSerialNumber.Focus();
                            }
                            else
                            {
                                if (chkCapacity.Checked)
                                {
                                    if (string.IsNullOrEmpty(cbCapacity.Text))
                                    {
                                        MessageBox.Show("Please indicate the capacity of the item.", "Update Product Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtSerialNumber.Text = "";
                                        txtSerialNumber.Focus();
                                    }
                                    else
                                    {
                                        if (cbCapacity.Text == "--Select--" || cbCapacity.SelectedIndex == 0 || cbCapacity.SelectedIndex == -1)
                                        {
                                            MessageBox.Show("Please indicate the capacity size of the item.", "Update Product Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            cbCapacity.SelectedIndex = 0;
                                            cbCapacity.Focus();
                                        }
                                    }
                                }

                                if (string.IsNullOrEmpty(txtPropertyNumber.Text))
                                {
                                    MessageBox.Show("Please indicate the propery number of the item.", "Update Product Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtPropertyNumber.Text = "";
                                    txtPropertyNumber.Focus();
                                }
                                else
                                {
                                    inv_prod_info = new classes.Inventory_ProductInformation();

                                    inv_prod_info.inventory_id = inventory_id;
                                    inv_prod_info.inventory_type = inventory_type;

                                    inv_prod_info.item_name = txtItemName.Text;
                                    inv_prod_info.description = txtDescription.Text;
                                    inv_prod_info.brand = txtBrand.Text;
                                    inv_prod_info.model = txtModel.Text;
                                    inv_prod_info.serial_number = txtSerialNumber.Text;

                                    inv_prod_info.hasCapacity = (chkCapacity.Checked) ? true : false;
                                    inv_prod_info.capacity_id = capacity_id;
                                    inv_prod_info.capacity = Convert.ToInt32(txtCapacity.Text);
                                    inv_prod_info.capacity_size = capacity_size;

                                    inv_prod_info.property_number = txtPropertyNumber.Text;

                                    foreach (Control control in panel1.Controls)
                                    {
                                        if (control.GetType() == typeof(Guna.UI2.WinForms.Guna2RadioButton))
                                        {
                                            Guna.UI2.WinForms.Guna2RadioButton rdb = control as Guna.UI2.WinForms.Guna2RadioButton;
                                            if (rdb.Checked)
                                            {
                                                inv_prod_info.status = rdb.Text;
                                            }
                                        }
                                    }

                                    inv_prod_info.acquired_at = dtpDateAcquired.Value;
                                    inv_prod_info.expire_at = dtpDateExpiry.Value;

                                    if (inv_prod_info.update_product_information())
                                    {
                                        MessageBox.Show("Item has been updated!", "Update Product Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                        frmViewItem.instance.display_selected_inventory(inventory_id);
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
                }
            }
        }
    }
}
