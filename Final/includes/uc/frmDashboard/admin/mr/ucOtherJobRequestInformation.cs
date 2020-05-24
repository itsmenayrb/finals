using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace Final.includes.uc.frmDashboard.admin.mr
{
    public partial class ucOtherJobRequestInformation : UserControl
    {
        public static ucOtherJobRequestInformation instance = null;
        classes.JobRequest job_request;

        private DataTable job_request_employee_count_table { get; set; }
        private DataTable job_request_department_count_table { get; set; }
        private DataTable job_request_most_common_issue_table { get; set; }

        private int total = 0;
        private int completed = 0;
        private int ongoing = 0;
        private int cancelled = 0;

        public ucOtherJobRequestInformation()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        public void display_job_request_information()
        {
            job_request = new classes.JobRequest();
            var result = job_request.select_job_request_count();
            total = result.Item1;
            completed = result.Item2;
            ongoing = result.Item3;
            cancelled = result.Item4;

            job_request_employee_count_table = job_request.select_job_request_per_employee();
            job_request_department_count_table = job_request.select_job_request_per_department();
            job_request_most_common_issue_table = job_request.select_job_request_most_common_issue();

            display_job_request_count();
            display_job_request_per_employee();
            display_job_request_per_department();
            display_job_request_most_common_issue();
            display_mci_chart();
        }

        private void display_job_request_count()
        {
            lblTotal.Text = total.ToString();
            lblCompleted.Text = completed.ToString();
            lblOngoing.Text = ongoing.ToString();
            lblCancelled.Text = cancelled.ToString();
        }

        private void display_job_request_per_employee()
        {
            dgvReportCountByEmployees.DataSource = job_request_employee_count_table;
            dgvReportCountByEmployees.AutoGenerateColumns = false;
        }

        private void display_job_request_per_department()
        {
            dgvReportCountByDepartment.DataSource = job_request_department_count_table;
            dgvReportCountByDepartment.AutoGenerateColumns = false;
        }

        private void display_job_request_most_common_issue()
        {
            dgvMostCommonIssue.DataSource = job_request_most_common_issue_table;
            dgvMostCommonIssue.AutoGenerateColumns = false;
        }

        private void display_mci_chart()
        {
            SeriesCollection s = new SeriesCollection();
            foreach (DataRow row in job_request_most_common_issue_table.Rows)
            {
                s.Add
                (
                    new PieSeries
                    {
                        Title = row["problem"].ToString(),
                        Values = new ChartValues<int> { Convert.ToInt32(row["report_count"]) },
                        DataLabels = true
                    }
                );
            }
            pieChart1.Series = s;
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
    }
}
