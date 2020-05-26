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
    public partial class frmAddStudent : Form
    {
        public static frmAddStudent instance = null;
        classes.Course course;
        classes.Student student;
        classes.PersonalInformation personal_information;
        classes.Accounts account;

        public frmAddStudent()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            pbPreview.Image = classes.Configuration.UploadProfilePicture("Add Student");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStudentNumber.Text == "Student Number" || string.IsNullOrEmpty(txtStudentNumber.Text))
            {
                MessageBox.Show("Please indicate the student number.", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentNumber.Text = "";
                txtStudentNumber.Focus();
                return;
            }
            else
            {
                if (txtFirstName.Text == "First Name" || string.IsNullOrEmpty(txtFirstName.Text))
                {
                    MessageBox.Show("Please indicate the first name.", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Text = "";
                    txtFirstName.Focus();
                    return;
                }
                else
                {
                    if (txtLastName.Text == "Last Name" || string.IsNullOrEmpty(txtLastName.Text))
                    {
                        MessageBox.Show("Please indicate the last name.", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLastName.Text = "";
                        txtLastName.Focus();
                        return;
                    }
                    else
                    {
                        if (txtLastName.Text == "Last Name" || string.IsNullOrEmpty(txtLastName.Text))
                        {
                            MessageBox.Show("Please indicate the last name.", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtLastName.Text = "";
                            txtLastName.Focus();
                            return;
                        }
                        else
                        {
                            if (cbCourse.SelectedIndex == 0 || cbCourse.SelectedIndex == -1)
                            {
                                MessageBox.Show("Please indicate the course.", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cbCourse.Focus();
                                return;
                            }
                            else
                            {
                                if (cbYearLevel.SelectedIndex == 0 || cbYearLevel.SelectedIndex == -1)
                                {
                                    MessageBox.Show("Please indicate the year level.", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cbYearLevel.Focus();
                                    return;
                                }
                                else
	                            {
                                    if (cbStatus.SelectedIndex == 0 || cbStatus.SelectedIndex == -1)
	                                {
		                                MessageBox.Show("Please indicate the status.", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        cbStatus.Focus();
                                        return;
	                                }
                                    else
                                    {
                                        string student_number = txtStudentNumber.Text;
                                        string first_name = txtFirstName.Text;
                                        string middle_name = (txtMiddleName.Text == "Middle Name") ? string.Empty : txtMiddleName.Text;
                                        string last_name = txtLastName.Text;
                                        string contact_number = (txtContactNumber.Text == "Contact Number") ? string.Empty : txtContactNumber.Text;
                                        string email = (txtEmail.Text == "Email") ? string.Empty : txtEmail.Text;
                                        int course_id = Convert.ToInt32(cbCourse.SelectedValue);
                                        string year_level = cbYearLevel.Text;
                                        string status = cbStatus.Text;
                                        Byte[] profile_picture = classes.Configuration.ConvertScreenCaptureToByte(pbPreview.Image);

                                        personal_information = new classes.PersonalInformation();
                                        if (personal_information.insert_personal_information(first_name, middle_name, last_name, contact_number, email, profile_picture))
                                        {
                                            student = new classes.Student();
                                            if (student.insert_student(student_number, course_id, year_level, status))
                                            {
                                                account = new classes.Accounts();
                                                if (account.insert_account(student_number, "Student"))
                                                {
                                                    MessageBox.Show((first_name + " " + last_name).ToUpper() + " has been added!", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    includes.uc.frmDashboard.admin.mu.ucManageStudent.instance.display_student_data();
                                                    this.Close();
                                                }
                                                else
                                                {
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                return;
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
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStudentNumber_Enter(object sender, EventArgs e)
        {
            if (txtStudentNumber.Text == "Student Number")
            {
                txtStudentNumber.Text = "";
            }
        }

        private void txtStudentNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentNumber.Text))
            {
                txtStudentNumber.Text = "Student Number";
            }
            else
            {
                txtStudentNumber.Text = txtStudentNumber.Text.ToUpper();
            }
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First Name")
            {
                txtFirstName.Text = "";
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.Text = "First Name";
            }
        }

        private void txtMiddleName_Enter(object sender, EventArgs e)
        {
            if (txtMiddleName.Text == "Middle Name")
            {
                txtMiddleName.Text = "";
            }
        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMiddleName.Text))
            {
                txtMiddleName.Text = "Middle Name";
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last Name")
            {
                txtLastName.Text = "";
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.Text = "Last Name";
            }
        }

        private void txtContactNumber_Enter(object sender, EventArgs e)
        {
            if (txtContactNumber.Text == "Contact Number")
            {
                txtContactNumber.Text = "";
            }
        }

        private void txtContactNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContactNumber.Text))
            {
                txtContactNumber.Text = "Contact Number";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Text = "Email";
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmAddCourse add_course = new frmAddCourse();
            add_course.request_from = "Add Student";
            add_course.ShowDialog();
        }

        public void display_course()
        {
            course = new classes.Course();
            cbCourse.DataSource = course.select_course_cb();
            cbCourse.DisplayMember = "course_name";
            cbCourse.ValueMember = "id";
            cbCourse.SelectedIndex = 0;
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            display_course();
        }
    }
}
