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
    public partial class frmSendFeedback : Form
    {
        public int ticket_id { get; set; }
        public string department = "MIS";
        private string inventory_type = string.Empty;

        classes.JobRequest job_request;

        public frmSendFeedback()
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

        }

        private void rdbHardwareRelated_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHardwareRelated.Checked)
            {
                inventory_type = "Hardware";

                rdbApplicationSoftware.Enabled = false;
                rdbComputerUnit.Enabled = true;
                rdbHardwareItems.Enabled = true;

                rdbWorking.Text = "Working";
                rdbDefective.Text = "Defective";
                rdbCondemned.Visible = true;
            }
            else
            {
                inventory_type = "Software";

                rdbApplicationSoftware.Enabled = true;
                rdbComputerUnit.Enabled = false;
                rdbHardwareItems.Enabled = false;

                rdbWorking.Text = "Subscribed";
                rdbDefective.Text = "Expired";
                rdbCondemned.Visible = false;
            }

            rdbApplicationSoftware.Checked = false;
            rdbComputerUnit.Checked = false;
            rdbHardwareItems.Checked = false;
            rdbOthers.Checked = false;

            gbNewStatus.Enabled = false;
            cbItemHavingIssue.Enabled = false;
            cbItemHavingIssue.SelectedIndex = 0;

            gbFindingSelection.Enabled = true;
        }

        private void rdbComputerUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbComputerUnit.Checked)
            {
                display_computer_unit_having_issue_with();
                cbItemHavingIssue.Enabled = true;
            }
            else
            {
                cbItemHavingIssue.Enabled = false;
                
            }

            gbNewStatus.Enabled = false;
            rdbWorking.Checked = false;
            rdbCondemned.Checked = false;
            rdbDefective.Checked = false;
        }

        private void rdbHardwareItems_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHardwareItems.Checked)
            {
                display_items_having_issue_with();
                cbItemHavingIssue.Enabled = true;
            }
            else
            {
                cbItemHavingIssue.Enabled = false;
            }

            gbNewStatus.Enabled = false;
            rdbWorking.Checked = false;
            rdbCondemned.Checked = false;
            rdbDefective.Checked = false;
        }

        private void rdbApplicationSoftware_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbApplicationSoftware.Checked)
            {
                display_items_having_issue_with();
                cbItemHavingIssue.Enabled = true;
            }
            else
            {
                cbItemHavingIssue.Enabled = false;
            }

            gbNewStatus.Enabled = false;
            rdbWorking.Checked = false;
            rdbCondemned.Checked = false;
            rdbDefective.Checked = false;
        }

        private void rdbOthers_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOthers.Checked)
            {
                cbItemHavingIssue.Enabled = false;
                cbItemHavingIssue.SelectedIndex = 0;
            }
            else
            {
                cbItemHavingIssue.Enabled = true;
            }

            gbNewStatus.Enabled = false;
            rdbWorking.Checked = false;
            rdbCondemned.Checked = false;
            rdbDefective.Checked = false;
        }

        private void cbItemHavingIssue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbItemHavingIssue.SelectedIndex == 0 || cbItemHavingIssue.SelectedIndex == -1)
            {
                gbNewStatus.Enabled = false;
            }
            else
            {
                gbNewStatus.Enabled = true;
            }

            rdbWorking.Checked = false;
            rdbCondemned.Checked = false;
            rdbDefective.Checked = false;
        }

        private void display_computer_unit_having_issue_with()
        {
            job_request = new classes.JobRequest();
            cbItemHavingIssue.DataSource = job_request.select_computer_unit_having_issue_with(department);
            cbItemHavingIssue.DisplayMember = "machine_name";
            cbItemHavingIssue.ValueMember = "id";
            cbItemHavingIssue.SelectedIndex = 0;
        }

        private void display_items_having_issue_with()
        {
            job_request = new classes.JobRequest();
            cbItemHavingIssue.DataSource = job_request.select_items_having_issue_with(inventory_type, department);
            cbItemHavingIssue.DisplayMember = "item_name";
            cbItemHavingIssue.ValueMember = "id";
            cbItemHavingIssue.SelectedIndex = 0;
        }

        

        
    }
}
