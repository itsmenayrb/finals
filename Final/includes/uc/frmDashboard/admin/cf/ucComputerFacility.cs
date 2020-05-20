using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmDashboard.admin.cf
{
    public partial class ucComputerFacility : UserControl
    {
        public ucComputerFacility()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelContainer, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void btnComputers_Click(object sender, EventArgs e)
        {
            btnComputers.LineBottom = 2;
            btnOtherInformation.LineBottom = 0;

            ucComputers1.Visible = true;
            ucOtherInformation1.Visible = false;

            ucComputers.instance.start_server();
        }

        private void btnOtherInformation_Click(object sender, EventArgs e)
        {
            btnComputers.LineBottom = 0;
            btnOtherInformation.LineBottom = 2;

            ucComputers1.Visible = false;
            ucOtherInformation1.Visible = true;

            ucOtherInformation.instance.display_other_information_data();
            ucComputers.instance.stop_server();
        }
    }
}
