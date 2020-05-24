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
            InitializeComponent();
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

        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {

        }

        private void linkAttachment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
