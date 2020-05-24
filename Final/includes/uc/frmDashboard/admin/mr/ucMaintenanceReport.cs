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
    public partial class ucMaintenanceReport : UserControl
    {
        public ucMaintenanceReport()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void btnJobRequest_Click(object sender, EventArgs e)
        {
            btnJobRequest.LineBottom = 2;
            btnOtherInformation.LineBottom = 0;

            ucJobRequest.instance.display_job_request_data();
            ucJobRequest1.Visible = true;
            ucOtherJobRequestInformation1.Visible = false;
        }

        private void btnOtherInformation_Click(object sender, EventArgs e)
        {
            btnJobRequest.LineBottom = 0;
            btnOtherInformation.LineBottom = 2;

            ucOtherJobRequestInformation.instance.display_job_request_information();
            ucJobRequest1.Visible = false;
            ucOtherJobRequestInformation1.Visible = true;
        }
    }
}
