using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmDashboard.admin.mu
{
    public partial class ucManageEmployee : UserControl
    {
        public static ucManageEmployee instance = null;
        private DataTable employee_table { get; set; }
        classes.Employee employee;

        public ucManageEmployee()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        public void display_employee_data()
        {
            employee = new classes.Employee();
            
            string search = cbSearchBy.Text;
            switch (search)
            {
                case "Employee ID":
                    employee_table = employee.select_employee_table("a.employee_id", txtSearch.Text);
                    break;
                case "Full Name":
                    employee_table = employee.select_employee_table("b.first_name", txtSearch.Text);
                    break;
                case "Contact Number":
                    employee_table = employee.select_employee_table("b.contact_number", txtSearch.Text);
                    break;
                case "Email":
                    employee_table = employee.select_employee_table("b.email", txtSearch.Text);
                    break;
                case "Department":
                    employee_table = employee.select_employee_table("c.department_name", txtSearch.Text);
                    break;
                case "Position":
                    employee_table = employee.select_employee_table("d.position_name", txtSearch.Text);
                    break;
                case "--Search by--":
                    employee_table = employee.select_employee_table();
                    break;
                default:
                    employee_table = employee.select_employee_table();
                    break;
            }

            dgvManageEmployee.DataSource = employee_table;
            dgvManageEmployee.AutoGenerateColumns = false;

            if (dgvManageEmployee.Columns.Contains("action") && dgvManageEmployee.Columns["action"].Visible)
            {

            }
            else
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.Name = "action";
                    button.HeaderText = "Action";
                    button.Text = "Update Employee";
                    button.UseColumnTextForButtonValue = true;
                    this.dgvManageEmployee.Columns.Add(button);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            display_employee_data();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Search";
                display_employee_data();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearch.Text = string.Empty;
                dgvManageEmployee.Focus();
            }
        }

        private void dgvManageEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvManageEmployee.Columns["action"].Index)
            {
                int employee_id = Convert.ToInt32(dgvManageEmployee.Rows[dgvManageEmployee.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            wf.admin.mu.frmAddEmployee add_employee = new wf.admin.mu.frmAddEmployee();
            add_employee.ShowDialog();
        }

        private void btnViewPosition_Click(object sender, EventArgs e)
        {
            wf.admin.mu.frmViewPosition view_position = new wf.admin.mu.frmViewPosition();
            view_position.display_position_data();
            view_position.ShowDialog();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            wf.admin.mu.frmViewDepartment view_department = new wf.admin.mu.frmViewDepartment();
            view_department.display_department_data();
            view_department.ShowDialog();
        }
    }
}
