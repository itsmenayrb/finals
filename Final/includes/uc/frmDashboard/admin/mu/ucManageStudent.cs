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
    public partial class ucManageStudent : UserControl
    {
        public static ucManageStudent instance = null;
        private DataTable student_table { get; set; }
        classes.Student stdnt;

        public ucManageStudent()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            wf.admin.mu.frmAddStudent add_student = new wf.admin.mu.frmAddStudent();
            add_student.ShowDialog();
        }

        private void btnViewCourse_Click(object sender, EventArgs e)
        {
            new wf.admin.mu.frmViewCourse().ShowDialog();
        }

        public void display_student_data()
        {
            stdnt = new classes.Student();

            string search = cbSearchBy.Text;
            switch (search)
            {
                case "Student Number":
                    student_table = stdnt.select_student_table("a.student_number", txtSearch.Text);
                    break;
                case "Full Name":
                    student_table = stdnt.select_student_table("b.first_name", txtSearch.Text);
                    break;
                case "Contact Number":
                    student_table = stdnt.select_student_table("b.contact_number", txtSearch.Text);
                    break;
                case "Email":
                    student_table = stdnt.select_student_table("b.email", txtSearch.Text);
                    break;
                case "Course":
                    student_table = stdnt.select_student_table("c.course_name", txtSearch.Text);
                    break;
                case "Year Level":
                    student_table = stdnt.select_student_table("a.year_level", txtSearch.Text);
                    break;
                case "Status":
                    student_table = stdnt.select_student_table("a.status", txtSearch.Text);
                    break;
                case "--Search by--":
                    student_table = stdnt.select_student_table();
                    break;
                default:
                    student_table = stdnt.select_student_table();
                    break;
            }

            dgvManageStudent.DataSource = student_table;
            dgvManageStudent.AutoGenerateColumns = false;

            if (dgvManageStudent.Columns.Contains("action") && dgvManageStudent.Columns["action"].Visible)
            {

            }
            else
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.Name = "action";
                    button.HeaderText = "Action";
                    button.Text = "Update Student";
                    button.UseColumnTextForButtonValue = true;
                    this.dgvManageStudent.Columns.Add(button);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            display_student_data();
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
                display_student_data();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearch.Text = string.Empty;
                dgvManageStudent.Focus();
            }
        }

        private void dgvManageStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvManageStudent.Columns["action"].Index)
            {
                int student_id = Convert.ToInt32(dgvManageStudent.Rows[dgvManageStudent.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}
