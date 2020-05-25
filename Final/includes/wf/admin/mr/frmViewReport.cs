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
    public partial class frmViewReport : Form
    {
        public static frmViewReport instance = null;
        public int job_request_id { get; set; }
        public string ticket_id { get; set; }
        public string problem { get; set; }
        public string description { get; set; }
        public string reported_by { get; set; }
        public string department { get; set; }
        public string date_reported { get; set; }
        public string status { get; set; }

        public frmViewReport()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void display_selected_report()
        {
            gbTicketID.Text = "Ticket ID: " + ticket_id;
            lblFullName.Text = reported_by;
            lblDepartment.Text = department;
            txtProblem.Text = problem;
            txtDescription.Text = description;
            txtDateReported.Text = date_reported;
            txtStatus.Text = status;
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            frmSendFeedback send_feedback = new frmSendFeedback();
            send_feedback.ticket_id = ticket_id;
            send_feedback.department = department;
            send_feedback.ShowDialog();
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            frmViewHistory view_history = new frmViewHistory();
            view_history.ticket_id = ticket_id;
            view_history.date_reported = date_reported;
            view_history.status = status;
            view_history.problem = problem;
            view_history.description = description;
            view_history.display_job_request_history();
            view_history.ShowDialog();
        }

        private void linkAttachment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewAttachment view_attachment = new frmViewAttachment();
            view_attachment.ticket_id = ticket_id;
            view_attachment.ShowDialog();
        }
    }
}
