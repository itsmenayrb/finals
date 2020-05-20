using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmSetup
{
    public partial class ucInstallationType : UserControl
    {
        public ucInstallationType()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Final.frmSetup.instance.Controls["panelContainer"].Controls["ucInstallationType1"].Visible = false;
            Final.frmSetup.instance.Controls["panelContainer"].Controls["ucServer1"].Visible = true;

            ucServer.mainInstance.start_scanning();
        }

        private void btnSubServer_Click(object sender, EventArgs e)
        {
            Final.frmSetup.instance.Controls["panelContainer"].Controls["ucInstallationType1"].Visible = false;
            Final.frmSetup.instance.Controls["panelContainer"].Controls["ucSubServer1"].Visible = true;

            ucSubServer.mainInstance.type = "Sub-server";
            ucSubServer.mainInstance.start_scanning();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Final.frmSetup.instance.Controls["panelContainer"].Controls["ucInstallationType1"].Visible = false;
            Final.frmSetup.instance.Controls["panelContainer"].Controls["ucSubServer1"].Visible = true;

            ucSubServer.mainInstance.type = "Client";
            ucSubServer.mainInstance.start_scanning();
        }
    }
}
