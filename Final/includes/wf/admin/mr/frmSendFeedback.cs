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
        public string ticket_id { get; set; }
        public string department { get; set; }
        private string inventory_type = string.Empty;

        classes.JobRequest job_request;

        private bool hasError = false;

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
            send_feedback();
        }

        private void rdbHardwareRelated_CheckedChanged(object sender, EventArgs e)
        {
            enable_disable_finding_selection();
        }

        private void rdbComputerUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbComputerUnit.Checked)
            {
                display_computer_unit_having_issue_with();
                cbItemHavingIssue.Enabled = true;

                display_items_for_replace();
                rdbTroubleshoot.Enabled = true;
                rdbReplaceWith.Enabled = true;
                rdbReinstall.Enabled = false;
                cbReplaceWith.Enabled = true;

                gbNewStatus.Enabled = false;
            }
            else if (rdbHardwareItems.Checked)
            {
                display_items_having_issue_with();
                cbItemHavingIssue.Enabled = true;

                display_items_for_replace();
                rdbTroubleshoot.Enabled = true;
                rdbReplaceWith.Enabled = true;
                rdbReinstall.Enabled = false;
                cbReplaceWith.Enabled = true;

                gbNewStatus.Enabled = true;
            }
            else if (rdbOthers.Checked)
            {
                cbItemHavingIssue.Enabled = false;
                rdbTroubleshoot.Enabled = true;
                rdbReplaceWith.Enabled = false;
                rdbReinstall.Enabled = true;
                cbReplaceWith.Enabled = false;

                gbNewStatus.Enabled = false;
            }

           
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

                display_items_for_replace();
                rdbTroubleshoot.Enabled = false;
                rdbReplaceWith.Enabled = true;
                rdbReinstall.Enabled = true;
                cbReplaceWith.Enabled = true;

                gbNewStatus.Enabled = true;
            }
            else if (rdbOthers.Checked)
            {
                cbItemHavingIssue.Enabled = false;
                rdbTroubleshoot.Enabled = true;
                rdbReplaceWith.Enabled = false;
                rdbReinstall.Enabled = true;
                cbReplaceWith.Enabled = false;

                gbNewStatus.Enabled = false;
            }

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

        private void display_items_for_replace()
        {
            job_request = new classes.JobRequest();
            cbReplaceWith.DataSource = job_request.select_items_for_replace(inventory_type, Convert.ToInt32(cbItemHavingIssue.SelectedValue));
            cbReplaceWith.DisplayMember = "item_name";
            cbReplaceWith.ValueMember = "id";
            cbReplaceWith.SelectedIndex = 0;
        }

        private void enable_disable_finding_selection()
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

            rdbTroubleshoot.Enabled = false;
            rdbReinstall.Enabled = false;
            rdbReplaceWith.Enabled = false;
            cbReplaceWith.Enabled = false;
        }

        private void send_feedback()
        {
            hasError = false;
            if ((rdbHardwareRelated.Checked || rdbSoftwareRelated.Checked) == false)
            {
                hasError = true;
                MessageBox.Show("Please choose your findings.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (rdbHardwareRelated.Checked)
	            {
		            if ((rdbComputerUnit.Checked || rdbHardwareItems.Checked || rdbOthers.Checked) == false)
                    {
                        hasError = true;
                        MessageBox.Show("Please select your findings on the menu.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (rdbComputerUnit.Checked)
                        {
                            if (cbItemHavingIssue.SelectedIndex == 0 || cbItemHavingIssue.SelectedIndex == -1)
                            {
                                hasError = true;
                                MessageBox.Show("Please select the computer that having issue with.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                if ((rdbTroubleshoot.Checked || rdbReplaceWith.Checked) == false)
                                {
                                    hasError = true;
                                    MessageBox.Show("Please select the action you took to respond to the request.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                else
                                {
                                    if (rdbReplaceWith.Checked)
                                    {
                                        if (cbReplaceWith.SelectedIndex == 0 || cbReplaceWith.SelectedIndex == -1)
                                        {
                                            hasError = true;
                                            MessageBox.Show("Please select the item to replace the item that having issue with .", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                        else if (rdbHardwareItems.Checked)
                        {
                            if (cbItemHavingIssue.SelectedIndex == 0 || cbItemHavingIssue.SelectedIndex == -1)
                            {
                                hasError = true;
                                MessageBox.Show("Please select the item that having issue with.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                if ((rdbWorking.Checked || rdbDefective.Checked || rdbCondemned.Checked) == false)
                                {
                                    hasError = true;
                                    MessageBox.Show("Please select the new status of the item that having issue with.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                else
                                {
                                    if ((rdbTroubleshoot.Checked || rdbReplaceWith.Checked) == false)
                                    {
                                        hasError = true;
                                        MessageBox.Show("Please select the action you took to respond to the request.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    else
                                    {
                                        if (rdbReplaceWith.Checked)
                                        {
                                            if (cbReplaceWith.SelectedIndex == 0 || cbReplaceWith.SelectedIndex == -1)
                                            {
                                                hasError = true;
                                                MessageBox.Show("Please select the item to replace the item that having issue with .", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                return;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (rdbOthers.Checked)
                        {
                            if (rdbTroubleshoot.Checked == false)
                            {
                                hasError = true;
                                MessageBox.Show("Please select the action you took to respond to the request.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
	            }
                else if (rdbSoftwareRelated.Checked)
                {
                    if ((rdbApplicationSoftware.Checked || rdbOthers.Checked) == false)
                    {
                        hasError = true;
                        MessageBox.Show("Please select your findings on the menu.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (rdbApplicationSoftware.Checked)
                        {
                            if (cbItemHavingIssue.SelectedIndex == 0 || cbItemHavingIssue.SelectedIndex == -1)
                            {
                                hasError = true;
                                MessageBox.Show("Please select the application that having issue with.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                if ((rdbWorking.Checked || rdbDefective.Checked) == false)
                                {
                                    hasError = true;
                                    MessageBox.Show("Please select the new status of the application that having issue with.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                else
                                {
                                    if ((rdbReinstall.Checked || rdbReplaceWith.Checked) == false)
                                    {
                                        hasError = true;
                                        MessageBox.Show("Please select the action you took to respond to the request.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    else
                                    {
                                        if (rdbReplaceWith.Checked)
                                        {
                                            if (cbReplaceWith.SelectedIndex == 0 || cbReplaceWith.SelectedIndex == -1)
                                            {
                                                hasError = true;
                                                MessageBox.Show("Please select the item to replace the item that having issue with .", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                return;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (rdbOthers.Checked)
                        {
                            if ((rdbTroubleshoot.Checked || rdbReinstall.Checked) == false)
                            {
                                hasError = true;
                                MessageBox.Show("Please select the action you took to respond to the request.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(txtFeedback.Text))
            {
                hasError = true;
                MessageBox.Show("Please provide a feedback to the request.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if ((rdbCompleted.Checked || rdbOngoing.Checked) == false)
                {
                    hasError = true;
                    MessageBox.Show("Please indicate the status of the request.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (hasError == false)
                    {
                        string findings = (rdbHardwareRelated.Checked) ? rdbHardwareRelated.Text : rdbSoftwareRelated.Text;
                        string findings_selection = (rdbComputerUnit.Checked) ? rdbComputerUnit.Text :
                            (rdbHardwareItems.Checked) ? rdbHardwareItems.Text :
                            (rdbApplicationSoftware.Checked) ? rdbApplicationSoftware.Text : rdbOthers.Text;

                        int computer_unit_having_issue = (rdbComputerUnit.Checked) ? Convert.ToInt32(cbItemHavingIssue.SelectedValue) : 0;
                        int inventory_having_issue = (rdbHardwareItems.Checked || rdbApplicationSoftware.Checked) ? Convert.ToInt32(cbItemHavingIssue.SelectedValue) : 0;
                        string new_status_having_issue = (rdbWorking.Checked) ? rdbWorking.Text : (rdbDefective.Checked) ? rdbDefective.Text : rdbCondemned.Text; 

                        string action_taken = (rdbTroubleshoot.Checked) ? rdbTroubleshoot.Text :
                            (rdbReinstall.Checked) ? rdbReinstall.Text : rdbReplaceWith.Text;

                        int computer_replaced_with = (rdbComputerUnit.Checked && rdbReplaceWith.Checked) ? Convert.ToInt32(cbReplaceWith.SelectedValue) : 0;
                        int inventory_replaced_with = ((rdbHardwareItems.Checked || rdbApplicationSoftware.Checked) && rdbReplaceWith.Checked) ? Convert.ToInt32(cbReplaceWith.SelectedValue) : 0;
                        string feedback = txtFeedback.Text;
                        string status = (rdbCompleted.Checked) ? rdbCompleted.Text : rdbOngoing.Text;

                        job_request = new classes.JobRequest();
                        if (job_request.send_job_request_feedback(ticket_id, findings, findings_selection, computer_unit_having_issue, inventory_having_issue, action_taken,
                            computer_replaced_with, inventory_replaced_with, feedback, status))
                        {
                            MessageBox.Show("Feedback has been sent!", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmViewReport.instance.display_selected_report();
                            this.Close();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
