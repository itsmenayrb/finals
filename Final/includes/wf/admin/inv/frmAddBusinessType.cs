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
    public partial class frmAddBusinessType : Form
    {
        public string request_from { get; set; }
        classes.Inventory_BusinessType business_type;

        public frmAddBusinessType()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusinessType_Enter(object sender, EventArgs e)
        {
            if (txtBusinessType.Text == "Business Type")
            {
                txtBusinessType.Text = "";
            }
        }

        private void txtBusinessType_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBusinessType.Text))
            {
                txtBusinessType.Text = "Business Type";
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            pbPreview.Image = classes.Configuration.UploadIcon("Add Business Type");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBusinessType.Text) || txtBusinessType.Text == "Business Type")
            {
                MessageBox.Show("Please indicate the business type.", "Add Business Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBusinessType.Text = "";
                txtBusinessType.Focus();
                return;
            }
            else
            {
                if (new classes.Configuration().CheckIfExist("business_type", "Inventory_BusinessType", txtBusinessType.Text))
                {
                    MessageBox.Show(txtBusinessType.Text + " is already exist", "Add BusinessType", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBusinessType.Text = "";
                    txtBusinessType.Focus();
                    return;
                }
                else
                {
                    business_type = new classes.Inventory_BusinessType();
                    business_type.business_type = txtBusinessType.Text;
                    business_type.icon = classes.Configuration.ConvertScreenCaptureToByte(pbPreview.Image);

                    if (business_type.create_business_type())
                    {
                        if (request_from == "Add Item")
                        {
                            MessageBox.Show(txtBusinessType.Text + " has been added", "Add Business Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmSelectBusinessType.instance.display_business_type();
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
}
