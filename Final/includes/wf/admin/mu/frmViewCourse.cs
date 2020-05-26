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
    public partial class frmViewCourse : Form
    {
        public static frmViewCourse instance = null;
        classes.Course crs;

        public frmViewCourse()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmAddCourse add_course = new frmAddCourse();
            add_course.request_from = "View Course";
            add_course.ShowDialog();
        }

        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCourse.Columns["action"].Index)
            {
                int course_id = Convert.ToInt32(dgvCourse.Rows[dgvCourse.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            }
        }

        public void display_course_data()
        {
            crs = new classes.Course();
            dgvCourse.DataSource = crs.select_course_table();
            dgvCourse.AutoGenerateColumns = false;

            if (dgvCourse.Columns.Contains("action") && dgvCourse.Columns["action"].Visible)
            {

            }
            else
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.Name = "action";
                    button.HeaderText = "Action";
                    button.Text = "Update";
                    button.UseColumnTextForButtonValue = true;
                    this.dgvCourse.Columns.Add(button);
                }
            }
        }

        private void frmViewCourse_Load(object sender, EventArgs e)
        {
            display_course_data();
        }
    }
}
