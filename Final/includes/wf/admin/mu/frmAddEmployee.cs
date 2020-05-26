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
    public partial class frmAddEmployee : Form
    {
        public static frmAddEmployee instance = null;
        classes.Department department;
        classes.Position position;
        classes.Employee employee;
        classes.PersonalInformation personal_information;
        classes.Accounts account;

        public frmAddEmployee()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            pbPreview.Image = classes.Configuration.UploadProfilePicture("Add Employee");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == "Employee ID" || string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("Please indicate the employee id.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Text = "";
                txtEmployeeID.Focus();
                return;
            }
            else
            {
                if (txtFirstName.Text == "First Name" || string.IsNullOrEmpty(txtFirstName.Text))
                {
                    MessageBox.Show("Please indicate the first name.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Text = "";
                    txtFirstName.Focus();
                    return;
                }
                else
                {
                    if (txtLastName.Text == "Last Name" || string.IsNullOrEmpty(txtLastName.Text))
                    {
                        MessageBox.Show("Please indicate the last name.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLastName.Text = "";
                        txtLastName.Focus();
                        return;
                    }
                    else
                    {
                        if (txtLastName.Text == "Last Name" || string.IsNullOrEmpty(txtLastName.Text))
                        {
                            MessageBox.Show("Please indicate the last name.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtLastName.Text = "";
                            txtLastName.Focus();
                            return;
                        }
                        else
                        {
                            if (cbDepartment.SelectedIndex == 0 || cbDepartment.SelectedIndex == -1)
                            {
                                MessageBox.Show("Please indicate the department.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cbDepartment.Focus();
                                return;
                            }
                            else
                            {
                                if (cbPosition.SelectedIndex == 0 || cbPosition.SelectedIndex == -1)
                                {
                                    MessageBox.Show("Please indicate the position.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cbPosition.Focus();
                                    return;
                                }
                                else
                                {
                                    string employee_id = txtEmployeeID.Text;
                                    string first_name = txtFirstName.Text;
                                    string middle_name = (txtMiddleName.Text == "Middle Name") ? string.Empty : txtMiddleName.Text;
                                    string last_name = txtLastName.Text;
                                    string contact_number = (txtContactNumber.Text == "Contact Number") ? string.Empty : txtContactNumber.Text;
                                    string email = (txtEmail.Text == "Email") ? string.Empty : txtEmail.Text;
                                    int department_id = Convert.ToInt32(cbDepartment.SelectedValue);
                                    int position_id = Convert.ToInt32(cbPosition.SelectedValue);
                                    Byte[] profile_picture = classes.Configuration.ConvertScreenCaptureToByte(pbPreview.Image);

                                    personal_information = new classes.PersonalInformation();
                                    if (personal_information.insert_personal_information(first_name, middle_name, last_name, contact_number, email, profile_picture))
                                    {
                                        employee = new classes.Employee();
                                        if (employee.insert_employee(employee_id, department_id, position_id))
                                        {
                                            account = new classes.Accounts();
                                            if (account.insert_account(employee_id, "Employee"))
                                            {
                                                MessageBox.Show((first_name + " " + last_name).ToUpper() + " has been added!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                includes.uc.frmDashboard.admin.mu.ucManageEmployee.instance.display_employee_data();
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

        private void txtEmployeeID_Enter(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == "Employee ID")
            {
                txtEmployeeID.Text = "";
            }
        }

        private void txtEmployeeID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                txtEmployeeID.Text = "Employee ID";
            }
            else
            {
                txtEmployeeID.Text = txtEmployeeID.Text.ToUpper();
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

        private void display_department()
        {
            department = new classes.Department();
            cbDepartment.DataSource = department.select_all_department();
            cbDepartment.DisplayMember = "department_name";
            cbDepartment.ValueMember = "id";
            cbDepartment.SelectedIndex = 0;
        }

        private void display_position()
        {
            position = new classes.Position();
            cbPosition.DataSource = position.select_position_table();
            cbPosition.DisplayMember = "position_name";
            cbPosition.ValueMember = "id";
            cbPosition.SelectedIndex = 0;
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            display_data();
        }

        public void display_data()
        {
            display_department();
            display_position();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            frmAddDepartment add_department = new frmAddDepartment();
            add_department.request_from = "Add Employee";
            add_department.ShowDialog();
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            frmAddPosition add_position = new frmAddPosition();
            add_position.request_from = "Add Employee";
            add_position.ShowDialog();
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
