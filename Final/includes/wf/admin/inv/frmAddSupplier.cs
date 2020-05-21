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
    public partial class frmAddSupplier : Form
    {
        public static frmAddSupplier instance = null;
        classes.Inventory_Supplier supplier;

        public int business_type_id { get; set; }
        public string business_type
        {
            set { lblBusinessType.Text = value; }
            get { return lblBusinessType.Text; }
        }

        public string request_from { get; set; }

        public frmAddSupplier()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            pbPreview.Image = classes.Configuration.UploadLogo("Add Supplier");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(request_from);
            if (txtSupplierID.Text == "Registration/Supplier ID" || string.IsNullOrEmpty(txtSupplierID.Text))
            {
                MessageBox.Show("Please indicate the Supplier ID", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplierID.Text = "";
                txtSupplierID.Focus();
                return;
            }
            else
            {
                if (txtSupplierName.Text == "Business Name" || string.IsNullOrEmpty(txtSupplierName.Text))
                {
                    MessageBox.Show("Please indicate the Business Name", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSupplierName.Text = "";
                    txtSupplierName.Focus();
                    return;
                }
                else
                {
                    if (txtAddress.Text == "Business Address" || string.IsNullOrEmpty(txtAddress.Text))
                    {
                        MessageBox.Show("Please indicate the Business Address", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAddress.Text = "";
                        txtAddress.Focus();
                        return;
                    }
                    else
                    {
                        supplier = new classes.Inventory_Supplier();
                        supplier.business_type_id = business_type_id;
                        supplier.registration_id = txtSupplierID.Text;
                        supplier.supplier_name = txtSupplierName.Text;
                        supplier.address = txtAddress.Text;
                        supplier.contact_number = (txtContactNumber.Text == "Business Contact Number (Optional)" || string.IsNullOrEmpty(txtContactNumber.Text)) ?
                            string.Empty : txtContactNumber.Text;
                        supplier.email = (txtEmail.Text == "Business Email (Optional)" || string.IsNullOrEmpty(txtEmail.Text)) ?
                            string.Empty : txtEmail.Text;
                        supplier.tin = (txtTin.Text == "TIN Number (Optional)" || string.IsNullOrEmpty(txtTin.Text)) ?
                            string.Empty : txtTin.Text;
                        supplier.logo = classes.Configuration.ConvertScreenCaptureToByte(pbPreview.Image);

                        if (supplier.create_supplier())
                        {
                            if (request_from == "Add Item")
                            {
                                Final.includes.uc.frmDashboard.admin.inv.add_item.ucSelectSupplier.instance.display_supplier();
                                MessageBox.Show(txtSupplierName.Text + " has been added", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form fc = Application.OpenForms["frmSelectBusinessType"];
                                if (fc != null) fc.Close();
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSupplierID_Enter(object sender, EventArgs e)
        {
            if (txtSupplierID.Text == "Registration/Supplier ID")
            {
                txtSupplierID.Text = "";
            }
        }

        private void txtSupplierID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierID.Text))
            {
                txtSupplierID.Text = "Registration/Supplier ID";
            }
        }

        private void txtSupplierName_Enter(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "Business Name")
            {
                txtSupplierName.Text = "";
            }
        }

        private void txtSupplierName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierName.Text))
            {
                txtSupplierName.Text = "Business Name";
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Business Address")
            {
                txtAddress.Text = "";
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                txtAddress.Text = "Business Address";
            }
        }

        private void txtContactNumber_Enter(object sender, EventArgs e)
        {
            if (txtContactNumber.Text == "Business Contact Number (Optional)")
            {
                txtContactNumber.Text = "";
            }
        }

        private void txtContactNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContactNumber.Text))
            {
                txtContactNumber.Text = "Business Contact Number (Optional)";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Business Email (Optional)")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Text = "Business Email (Optional)";
            }
        }

        private void txtTin_Enter(object sender, EventArgs e)
        {
            if (txtTin.Text == "TIN Number (Optional)")
            {
                txtTin.Text = "";
            }
        }

        private void txtTin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTin.Text))
            {
                txtTin.Text = "TIN Number (Optional)";
            }
        }
    }
}
