using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmDashboard.admin.lh
{
    public partial class ucLoginHistory : UserControl
    {
        public static ucLoginHistory instance = null;
        private DataTable login_history_table { get; set; }
        classes.LoginHistory login_history;

        public ucLoginHistory()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        public void display_login_history_data()
        {
            login_history = new classes.LoginHistory();

            string search = cbSearchBy.Text;
            switch (search)
            {
                case "Full Name":
                    login_history_table = login_history.select_job_request_table("a.ticket_id", txtSearch.Text);
                    break;
                case "Department":
                    login_history_table = login_history.select_job_request_table("a.problem", txtSearch.Text);
                    break;
                case "Computer Unit":
                    login_history_table = login_history.select_job_request_table("c.first_name", txtSearch.Text);
                    break;
                case "--Search by--":
                    login_history_table = login_history.select_job_request_table();
                    break;
                default:
                    login_history_table = login_history.select_job_request_table();
                    break;
            }

            dgvLoginHistory.DataSource = login_history_table;
            dgvLoginHistory.AutoGenerateColumns = false;
        }
    }
}
