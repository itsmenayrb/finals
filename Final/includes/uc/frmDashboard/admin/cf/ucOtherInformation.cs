using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmDashboard.admin.cf
{
    public partial class ucOtherInformation : UserControl
    {
        public static ucOtherInformation instance = null;

        private int server_count { get; set; }
        private int client_count { get; set; }
        private DataTable server_table { get; set; }
        private DataTable client_table { get; set; }
        private DataTable computer_count_table { get; set; }
        private DataTable reported_count_table { get; set; }

        classes.Remote remote;

        public ucOtherInformation()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        public void display_other_information_data()
        {
            remote = new classes.Remote();
            server_count = remote.select_server_count();
            client_count = remote.select_client_count();
            server_table = remote.select_server_table();
            client_table = remote.select_client_table();
            computer_count_table = remote.select_computer_count_per_department_table();
            reported_count_table = remote.select_reported_count_per_computer_table();

            lblServerCount.Text = server_count.ToString();
            lblClientCount.Text = client_count.ToString();

            dgvListOfServer.DataSource = server_table;
            dgvListOfServer.AutoGenerateColumns = false;

            dgvListOfClient.DataSource = client_table;
            dgvListOfClient.AutoGenerateColumns = false;

            dgvComputerCount.DataSource = computer_count_table;
            dgvComputerCount.AutoGenerateColumns = false;

            dgvMostReportedComputerUnit.DataSource = reported_count_table;
            dgvMostReportedComputerUnit.AutoGenerateColumns = false;
        }
    }
}
