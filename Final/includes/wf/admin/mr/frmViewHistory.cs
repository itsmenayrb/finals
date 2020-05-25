using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.wf.admin.mr
{
    public partial class frmViewHistory : Form
    {
        classes.JobRequest job_request;
        public string ticket_id { get; set; }
        public string date_reported { get; set; }
        public string status { get; set; }
        public string problem { get; set; }
        public string description { get; set; }

        includes.uc.frmDashboard.admin.mr.ucJobRequestFeedback uc_feedback;

        private DataTable job_request_history_table { get; set; }

        public frmViewHistory()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void display_job_request_history()
        {
            gbTicketID.Text = "Ticket ID: " + ticket_id;
            lblDateReported.Text = date_reported;
            lblStatus.Text = status;

            job_request = new classes.JobRequest();
            job_request_history_table = job_request.select_job_request_history(ticket_id);

            if (job_request_history_table.Rows.Count > 0)
            {
                foreach (DataRow row in job_request_history_table.Rows)
                {
                    uc_feedback = new uc.frmDashboard.admin.mr.ucJobRequestFeedback();
                    uc_feedback.date_responded = Convert.ToDateTime(row["responded_at"]).ToLongDateString();
                    uc_feedback.findings = row["findings"].ToString();
                    uc_feedback.findings_selection = row["findings_selection"].ToString();
                    uc_feedback.action_taken = row["action_taken"].ToString();
                    uc_feedback.feedback = row["feedback"].ToString();

                    flpFeedbackHistory.Controls.Add(uc_feedback);
                }
            }
        }
    }
}
