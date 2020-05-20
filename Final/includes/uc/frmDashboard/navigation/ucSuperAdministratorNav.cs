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
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucComputerFacility1"].Visible = false;
        }

        private void btnComputerFacility_Click(object sender, EventArgs e)
        {
            Final.frmDashboard.instance.Controls["panelContainer"].Controls["ucComputerFacility1"].Visible = true;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {

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
