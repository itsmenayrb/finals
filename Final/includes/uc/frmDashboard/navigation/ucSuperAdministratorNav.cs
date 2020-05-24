using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmDashboard.navigation
{
    public partial class ucSuperAdministratorNav : UserControl
    {
        public ucSuperAdministratorNav()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Final.includes.uc.frmDashboard.admin.cf.ucComputers.instance.stop_server();

            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucComputerFacility1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucInventory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucMaintenanceReport1"].Visible = false;
        }

        private void btnComputerFacility_Click(object sender, EventArgs e)
        {
            Final.includes.uc.frmDashboard.admin.cf.ucComputers.instance.start_server();

            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucComputerFacility1"].Visible = true;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucInventory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucMaintenanceReport1"].Visible = false;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Final.includes.uc.frmDashboard.admin.cf.ucComputers.instance.stop_server();
            Final.includes.uc.frmDashboard.admin.inv.ucInventory.instance.display_inventory_data();

            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucComputerFacility1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucInventory1"].Visible = true;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucMaintenanceReport1"].Visible = false;
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            Final.includes.uc.frmDashboard.admin.cf.ucComputers.instance.stop_server();
            Final.includes.uc.frmDashboard.admin.mr.ucJobRequest.instance.display_job_request_data();

            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucComputerFacility1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucInventory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucMaintenanceReport1"].Visible = true;
        }

        private void btnLoginHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {

        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {

        }

        private void btnArchived_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
