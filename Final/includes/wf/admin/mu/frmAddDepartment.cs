using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.wf.admin.mu
{
    public partial class frmAddDepartment : Form
    {
        public string request_from { get; set; }
        classes.Department department;
        public frmAddDepartment()
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
            if (string.IsNullOrEmpty(txtDepartmentName.Text))
            {
                MessageBox.Show("Please indicate the department name.", "Add Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepartmentName.Focus();
                return;
            }
            else
            {
                if (new classes.Configuration().CheckIfExist("department_name", "Department", txtDepartmentName.Text))
                {
                    MessageBox.Show(txtDepartmentName.Text + " is already exist.", "Add Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDepartmentName.Focus();
                    txtDepartmentName.Text = "";
                    return;
                }
                else
                {
                    department = new classes.Department();
                    department.department_name = txtDepartmentName.Text;
                    department.add_department();
                    MessageBox.Show(txtDepartmentName.Text + " has been added.", "Add Department", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (request_from == "Add Employee")
                    {
                        wf.admin.mu.frmAddEmployee.instance.display_data();  
                    }
                    else
                    {
                        frmViewDepartment.instance.display_department_data();
                    }
                    this.Close();
                }
            }
        }
    }
}
