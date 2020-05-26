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
    public partial class ucManageUser : UserControl
    {
        public ucManageUser()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            ucManageEmployee.instance.display_employee_data();

            btnManageEmployee.LineBottom = 2;
            btnManageStudent.LineBottom = 0;
            btnManageAccount.LineBottom = 0;
            btnOtherInformation.LineBottom = 0;

            ucManageEmployee1.Visible = true;
            ucManageStudent1.Visible = false;
            ucManageAccount1.Visible = false;
        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            ucManageStudent.instance.display_student_data();

            btnManageEmployee.LineBottom = 0;
            btnManageStudent.LineBottom = 2;
            btnManageAccount.LineBottom = 0;
            btnOtherInformation.LineBottom = 0;

            ucManageEmployee1.Visible = false;
            ucManageStudent1.Visible = true;
            ucManageAccount1.Visible = false;
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            ucManageAccount.instance.display_account_data();

            btnManageEmployee.LineBottom = 0;
            btnManageStudent.LineBottom = 0;
            btnManageAccount.LineBottom = 2;
            btnOtherInformation.LineBottom = 0;

            ucManageEmployee1.Visible = false;
            ucManageStudent1.Visible = false;
            ucManageAccount1.Visible = true;
        }

        private void btnOtherInformation_Click(object sender, EventArgs e)
        {
            btnManageEmployee.LineBottom = 0;
            btnManageStudent.LineBottom = 0;
            btnManageAccount.LineBottom = 0;
            btnOtherInformation.LineBottom = 2;
        }
    }
}
