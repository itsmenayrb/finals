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
    public partial class ucOtherProductInformation : UserControl
    {
        public static ucOtherProductInformation instance = null;

        public string inventory_type { get; set; }

        public int category_id { get; set; }
        public string category_name { get; set; }

        public int supplier_id { get; set; }
        public string supplier_name { get; set; }

        public string item_name { get; set; }
        public string description { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string serial_number { get; set; }
        public int capacity { get; set; }
        public string capacity_size { get; set; }
        public int quantity { get; set; }
        public string unit_of_measurement { get; set; }

        public bool hasCapacity { get; set; }

        classes.Department department;

        public ucOtherProductInformation()
        {
            instance = this;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucOtherProductInformation1"].Visible = false;
            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucProductInformation1"].Visible = true;
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtPropertyNumber.Text == "Property Number" || string.IsNullOrEmpty(txtPropertyNumber.Text))
            {
                MessageBox.Show("Please indicate the propery number of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropertyNumber.Text = "";
                txtPropertyNumber.Focus();
            }
            else
            {
                if (cbDepartment.Text == "--Select department--" || cbDepartment.SelectedIndex == 0 || cbDepartment.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the department where this item is located.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbDepartment.Text = "";
                    cbDepartment.Focus();
                }
                else
                {

                }
            }
        }

        private void txtPropertyNumber_Enter(object sender, EventArgs e)
        {
            if (txtPropertyNumber.Text == "Property Number")
            {
                txtPropertyNumber.Text = "";
            }
        }

        private void txtPropertyNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPropertyNumber.Text))
            {
                txtPropertyNumber.Text = "Property Number";
            }
        }

        public void display_data()
        {
            if (inventory_type == "Hardware")
            {
                gbDateExpiry.Visible = false;
                dtpDateExpiry.Visible = false;

                rdbWorking.Text = "Working";
                rdbDefective.Text = "Defective";
            }
            else
            {
                gbStatus.Enabled = false;
                gbDateExpiry.Visible = true;
                dtpDateExpiry.Visible = true;

                rdbWorking.Text = "Subscribed";
                rdbDefective.Text = "Expired";
                rdbCondemned.Visible = false;

                rdbDefective.Checked = true;
            }

            dtpDateAcquired.MaxDate = DateTime.Today;
            dtpDateExpiry.Value = DateTime.Today;

            display_department();
        }

        private void display_department()
        {
            department = new classes.Department();
            cbDepartment.DataSource = department.select_all_department();
            cbDepartment.DisplayMember = "department_name";
            cbDepartment.ValueMember = "id";
        }

       
    }
}
