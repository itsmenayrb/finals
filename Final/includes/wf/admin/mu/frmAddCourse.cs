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
    public partial class frmAddCourse : Form
    {
        public string request_from { get; set; }
        classes.Course course;

        public frmAddCourse()
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
            if (string.IsNullOrEmpty(txtCourseName.Text))
            {
                MessageBox.Show("Please indicate the course name.", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourseName.Focus();
                return;
            }
            else
            {
                if (new classes.Configuration().CheckIfExist("course_name", "Course", txtCourseName.Text))
                {
                    MessageBox.Show(txtCourseName.Text + " is already exist.", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCourseName.Focus();
                    txtCourseName.Text = "";
                    return;
                }
                else
                {
                    course = new classes.Course();
                    course.course_name = txtCourseName.Text;
                    course.add_course();
                    MessageBox.Show(txtCourseName.Text + " has been added.", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (request_from == "Add Student")
                    {
                        wf.admin.mu.frmAddStudent.instance.display_course();
                    }
                    else
                    {
                        frmViewCourse.instance.display_course_data();
                    }
                    this.Close();
                }
            }
        }
    }
}
