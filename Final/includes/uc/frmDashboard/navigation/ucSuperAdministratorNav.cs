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
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucLoginHistory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucManageUser1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucDatabase1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucArchived1"].Visible = false;
        }

        private void btnComputerFacility_Click(object sender, EventArgs e)
        {
            Final.includes.uc.frmDashboard.admin.cf.ucComputers.instance.start_server();

            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucComputerFacility1"].Visible = true;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucInventory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucMaintenanceReport1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucLoginHistory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucManageUser1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucDatabase1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucArchived1"].Visible = false;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Final.includes.uc.frmDashboard.admin.cf.ucComputers.instance.stop_server();
            Final.includes.uc.frmDashboard.admin.inv.ucInventory.instance.display_inventory_data();

            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucComputerFacility1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucInventory1"].Visible = true;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucMaintenanceReport1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucLoginHistory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucManageUser1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucDatabase1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucArchived1"].Visible = false;
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            Final.includes.uc.frmDashboard.admin.cf.ucComputers.instance.stop_server();
            Final.includes.uc.frmDashboard.admin.mr.ucJobRequest.instance.display_job_request_data();

            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucComputerFacility1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucInventory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucMaintenanceReport1"].Visible = true;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucLoginHistory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucManageUser1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucDatabase1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucArchived1"].Visible = false;
        }

        private void btnLoginHistory_Click(object sender, EventArgs e)
        {
            Final.includes.uc.frmDashboard.admin.cf.ucComputers.instance.stop_server();
            Final.includes.uc.frmDashboard.admin.lh.ucLoginHistory.instance.display_login_history_data();

            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucComputerFacility1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucInventory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucMaintenanceReport1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucLoginHistory1"].Visible = true;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucManageUser1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucDatabase1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucArchived1"].Visible = false;
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            Final.includes.uc.frmDashboard.admin.cf.ucComputers.instance.stop_server();
            Final.includes.uc.frmDashboard.admin.mu.ucManageEmployee.instance.display_employee_data();

            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucComputerFacility1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucInventory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucMaintenanceReport1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucLoginHistory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucManageUser1"].Visible = true;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucDatabase1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucArchived1"].Visible = false;
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            Final.includes.uc.frmDashboard.admin.cf.ucComputers.instance.stop_server();
            Final.includes.uc.frmDashboard.admin.db.ucBackup.instance.display_settings();

            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucComputerFacility1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucInventory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucMaintenanceReport1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucLoginHistory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucManageUser1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucDatabase1"].Visible = true;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucArchived1"].Visible = false;
        }

        private void btnArchived_Click(object sender, EventArgs e)
        {
            Final.includes.uc.frmDashboard.admin.cf.ucComputers.instance.stop_server();
            Final.includes.uc.frmDashboard.admin.arc.ucArchived.instance.display_treeview_data();

            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucComputerFacility1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucInventory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucMaintenanceReport1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucLoginHistory1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucManageUser1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucDatabase1"].Visible = false;
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucArchived1"].Visible = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
