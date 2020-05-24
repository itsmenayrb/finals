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
    public partial class frmUpdateDepartment : Form
    {
        public int inventory_id { get; set; }
        public int department_id { get; set; }
        public string department_name { get; set; }

        classes.Department department;

        public frmUpdateDepartment()
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
            if (string.IsNullOrEmpty(cbDepartment.Text) || cbDepartment.SelectedIndex == 0 || cbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the new department you wish to update to this item.", "Update Item Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentDepartment.Focus();
                return;
            }
            else
            {
                update_department();
            }
        }

        public void display_selected_department()
        {
            txtCurrentDepartment.Text = department_name.ToString();

            department = new classes.Department();
            cbDepartment.DataSource = department.select_inventory_department_except_this(department_id);
            cbDepartment.DisplayMember = "department_name";
            cbDepartment.ValueMember = "id";
            cbDepartment.SelectedIndex = 0;
        }

        private void update_department()
        {
            department = new classes.Department();
            if (department.update_inventory_department(inventory_id, Convert.ToInt32(cbDepartment.SelectedValue)))
            {
                 MessageBox.Show("Department has been updated!", "Update Department", MessageBoxButtons.OK, MessageBoxIcon.Question);
                frmViewItem.instance.display_selected_inventory(inventory_id);
                this.Close();
            }
        }
    }
}
