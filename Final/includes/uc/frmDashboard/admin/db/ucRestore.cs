using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace Final.includes.uc.frmDashboard.admin.db
{
    public partial class ucRestore : UserControl
    {
        public static ucRestore instance = null;
        string directory = string.Empty;

        public ucRestore()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void btnRestoreDatabase_Click(object sender, EventArgs e)
        {
            progressBarBackup.Value = 0;
            try
            {
                DialogResult res = MessageBox.Show("Are you sure you want to restore the database? Lost of data might occur.", "Restore Database", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    Server server = new Server(new ServerConnection(@"HOME-PC\SQLEXPRESS", "sa", "p@ssphr@s3"));
                    Restore restore = new Restore()
                    {
                        Action = RestoreActionType.Database,
                        Database = "final",
                        ReplaceDatabase = true,
                        NoRecovery = false
                    };

                    server.KillAllProcesses(restore.Database);
                    directory = @"D:\Comfama-dbBackup\comfama_dbBackup_" + DateTime.Now.ToShortDateString() + ".bak";
                    restore.Devices.AddDevice(directory, DeviceType.File);
                    restore.PercentComplete += restore_PercentComplete;
                    restore.Complete += restore_Complete;
                    restore.SqlRestoreAsync(server);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Restore Database");
            }
        }

        private void restore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblProgressText.Invoke((MethodInvoker)delegate
                {
                    lblProgressText.Text = e.Error.Message;
                });
            }

            MessageBox.Show("Database restore successful!", "Restore Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void restore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBarBackup.Invoke((MethodInvoker)delegate
            {
                progressBarBackup.Value = e.Percent;
                progressBarBackup.Update();
            });

            lblPercent.Invoke((MethodInvoker)delegate
            {
                lblPercent.Text = e.Percent.ToString() + "%";
            });
        }
    }
}
