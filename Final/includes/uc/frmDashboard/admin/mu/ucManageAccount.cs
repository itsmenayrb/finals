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
    public partial class ucManageAccount : UserControl
    {
        public static ucManageAccount instance = null;
        private DataTable account_table { get; set; }
        classes.Accounts accnts;

        public ucManageAccount()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        public void display_account_data()
        {
            accnts = new classes.Accounts();

            string search = cbSearchBy.Text;
            switch (search)
            {
                case "Username":
                    account_table = accnts.select_account_table("username", txtSearch.Text);
                    break;
                case "User Type":
                    account_table = accnts.select_account_table("user_type", txtSearch.Text);
                    break;
                case "--Search by--":
                    account_table = accnts.select_account_table();
                    break;
                default:
                    account_table = accnts.select_account_table();
                    break;
            }

            dgvManageAccount.DataSource = account_table;
            dgvManageAccount.AutoGenerateColumns = false;

            if (dgvManageAccount.Columns.Contains("action") && dgvManageAccount.Columns["action"].Visible)
            {

            }
            else
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.Name = "action";
                    button.HeaderText = "Action";
                    button.Text = "Update Account";
                    button.UseColumnTextForButtonValue = true;
                    this.dgvManageAccount.Columns.Add(button);
                }
            }
        }

        private void btnAddAdministrator_Click(object sender, EventArgs e)
        {
            new wf.admin.mu.frmAddAdministrator().ShowDialog();
        }
    }
}
