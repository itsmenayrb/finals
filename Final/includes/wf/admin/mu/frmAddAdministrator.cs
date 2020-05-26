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
    public partial class frmAddAdministrator : Form
    {
        classes.Employee emp;
        classes.Accounts acts;

        public frmAddAdministrator()
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
            if (cbEmployee.SelectedIndex == 0 || cbEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the employee.", "Add Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbEmployee.Focus();
                return;
            }
            else
            {
                acts = new classes.Accounts();
                int employee_id = Convert.ToInt32(cbEmployee.SelectedValue);
                if (acts.add_administrator(employee_id))
                {
                    MessageBox.Show(cbEmployee.Text.ToUpper() + " has been set as administrator.", "Add Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uc.frmDashboard.admin.mu.ucManageAccount.instance.display_account_data();
                    this.Close();
                }
                else
                {
                    return;
                }
            }
        }

        private void frmAddAdministrator_Load(object sender, EventArgs e)
        {
            display_employee();
        }

        public void display_employee()
        {
            emp = new classes.Employee();
            cbEmployee.DataSource = emp.select_employee_cb();
            cbEmployee.DisplayMember = "full_name";
            cbEmployee.ValueMember = "id";
            cbEmployee.SelectedIndex = 0;
        }
    }
}
