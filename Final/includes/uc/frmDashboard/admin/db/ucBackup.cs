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
using System.IO;
using System.Diagnostics;

namespace Final.includes.uc.frmDashboard.admin.db
{
    public partial class ucBackup : UserControl
    {
        public static ucBackup instance = null;
        string directory = string.Empty;

        private DataTable settings_table { get; set; }
        classes.BackupRestore br;

        private bool is_automatic = false;

        private DateTime time;
        private DateTime r_time;
        private TimeSpan ts;
        private string remainining_time;

        public ucBackup()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void btnBackupDatabase_Click(object sender, EventArgs e)
        {
            progressBarBackup.Value = 0;
            try
            {
                Server server = new Server(new ServerConnection(@"HOME-PC\SQLEXPRESS", "sa", "p@ssphr@s3"));
                Backup backup = new Backup()
                {
                    Action = BackupActionType.Database,
                    Database = "final"
                };

                directory = directory + "comfama_dbBackup_" + DateTime.Now.ToShortDateString() + ".bak";
                backup.Devices.AddDevice(directory, DeviceType.File);
                backup.Initialize = true;
                backup.PercentComplete += backup_PercentComplete;
                backup.Complete += backup_Complete;
                backup.SqlBackupAsync(server);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Backup Database");
            }
        }

        private void backup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblProgressText.Invoke((MethodInvoker)delegate
                {
                    lblProgressText.Text = e.Error.Message;
                });
            }

            MessageBox.Show("Database backup successful!", "Backup Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            br = new classes.BackupRestore();
            br.insert_logs(true, is_automatic);

            if (File.Exists(directory))
            {
                Process.Start("explorer.exe", "/select, " + directory);
            }
        }

        private void backup_PercentComplete(object sender, PercentCompleteEventArgs e)
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

        public void display_settings()
        {
            br = new classes.BackupRestore();
            settings_table = br.select_settings_table();

            if (settings_table.Rows.Count > 0)
            {
                foreach (DataRow row in settings_table.Rows)
                {
                    DateTime d = Convert.ToDateTime(row["time"]);
                    string day = row["day"].ToString();
                    if (string.IsNullOrEmpty(day) || d == DateTime.MaxValue)
                    {
                        lblDateTime.Text = "You haven't set automatic back-up yet. Click database settings to set-up.";
                        lblDirectory.Text = @"Back up will be saved to C:\Desktop";
                    }
                    else
                    {
                        lblDirectory.Text = "Back up will be saved to " + row["path"].ToString();
                        directory = row["path"].ToString();
                        time = d;
                        timerAutoBackup.Start();
                    }
                }
            }
            else
            {
                lblDateTime.Text = "You haven't set automatic back-up yet. Click database settings to set-up.";
            }
        }

        private void timerAutoBackup_Tick(object sender, EventArgs e)
        {
            remainining_time = time.ToString("HH:mm:ss");
            r_time = DateTime.Parse(remainining_time);
            ts = r_time.Subtract(DateTime.Now);

            lblDateTime.Text = ts.ToString("h' hrs 'm' mins 's' secs remaining to perform automatic backup'");
            
            if (Math.Abs(ts.TotalSeconds) < .3)
            {
                is_automatic = true;
                btnBackupDatabase.PerformClick();
            }
        }

        private void ucBackup_Load(object sender, EventArgs e)
        {
            display_settings();
        }
    }
}
