using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmDashboard.admin.db
{
    public partial class ucDatabase : UserControl
    {
        public ucDatabase()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            ucBackup.instance.display_settings();
            
            btnBackup.LineBottom = 2;
            btnRestore.LineBottom = 0;
            btnSettings.LineBottom = 0;
            btnOtherInformation.LineBottom = 0;

            ucBackup1.Visible = true;
            ucRestore1.Visible = false;
            ucSettings1.Visible = false;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            btnBackup.LineBottom = 0;
            btnRestore.LineBottom = 2;
            btnSettings.LineBottom = 0;
            btnOtherInformation.LineBottom = 0;

            ucBackup1.Visible = false;
            ucRestore1.Visible = true;
            ucSettings1.Visible = false;
        }

        private void btnOtherInformation_Click(object sender, EventArgs e)
        {
            btnBackup.LineBottom = 0;
            btnRestore.LineBottom = 0;
            btnSettings.LineBottom = 0;
            btnOtherInformation.LineBottom = 2;

            ucDBOtherInformation.instance.display_db_logs();

            ucBackup1.Visible = false;
            ucRestore1.Visible = false;
            ucSettings1.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnBackup.LineBottom = 0;
            btnRestore.LineBottom = 0;
            btnSettings.LineBottom = 2;
            btnOtherInformation.LineBottom = 0;

            ucSettings.instance.display_settings();

            ucBackup1.Visible = false;
            ucRestore1.Visible = false;
            ucSettings1.Visible = true;
        }
    }
}
