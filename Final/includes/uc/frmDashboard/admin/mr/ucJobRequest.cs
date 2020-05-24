using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmDashboard.admin.mr
{
    public partial class ucJobRequest : UserControl
    {
        public static ucJobRequest instance = null;
        private DataTable job_request_table { get; set; }
        classes.JobRequest job_request;

        public ucJobRequest()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        public void display_job_request_data()
        {
            job_request = new classes.JobRequest();

            string search = cbSearchBy.Text;
            switch (search)
            {
                case "Ticket ID":
                    job_request_table = job_request.select_job_request_table("a.ticket_id", txtSearch.Text);
                    break;
                case "Problem":
                    job_request_table = job_request.select_job_request_table("a.problem", txtSearch.Text);
                    break;
                case "Employee":
                    job_request_table = job_request.select_job_request_table("c.first_name", txtSearch.Text);
                    break;
                case "Department":
                    job_request_table = job_request.select_job_request_table("d.department_name", txtSearch.Text);
                    break;
                case "Status":
                    job_request_table = job_request.select_job_request_table("a.status", txtSearch.Text);
                    break;
                case "--Search by--":
                    job_request_table = job_request.select_job_request_table();
                    break;
                default:
                    job_request_table = job_request.select_job_request_table();
                    break;
            }

            dgvJobRequest.DataSource = job_request_table;
            dgvJobRequest.AutoGenerateColumns = false;

            if (dgvJobRequest.Columns.Contains("action") && dgvJobRequest.Columns["action"].Visible)
            {

            }
            else
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.Name = "action";
                    button.HeaderText = "Action";
                    button.Text = "View Request";
                    button.UseColumnTextForButtonValue = true;
                    this.dgvJobRequest.Columns.Add(button);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            display_job_request_data();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Search";
                display_job_request_data();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearch.Text = string.Empty;
                dgvJobRequest.Focus();
            }
        }

        private void dgvJobRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvJobRequest.Columns["action"].Index)
            {
                int job_request_id = Convert.ToInt32(dgvJobRequest.Rows[dgvJobRequest.SelectedCells[0].RowIndex].Cells[0].Value.ToString());

                //includes.wf.admin.inv.frmViewItem frmViewItem = new wf.admin.inv.frmViewItem();
                //frmViewItem.display_selected_inventory(inventory_id);
                //frmViewItem.ShowDialog();
            }
        }
    }
}
