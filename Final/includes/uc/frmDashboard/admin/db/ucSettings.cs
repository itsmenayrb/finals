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
    public partial class ucSettings : UserControl
    {
        public static ucSettings instance = null;

        private DataTable settings_table { get; set; }
        private bool hasError = false;
        classes.BackupRestore br;

        public ucSettings()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void switchAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (switchAutoBackup.Checked)
            {
                panelAutoBackup.Enabled = true;
                dtpTime.Format = DateTimePickerFormat.Time;
                dtpTime.ShowUpDown = true;
            }
            else
            {
                panelAutoBackup.Enabled = false;
                dtpTime.Format = DateTimePickerFormat.Custom;
                dtpTime.CustomFormat = " ";
                dtpTime.ShowUpDown = false;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (string.IsNullOrEmpty(txtPath.Text))
            {
                hasError = true;
                MessageBox.Show("Please specify the path you want to save the backup.", "Database Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBrowse.PerformClick();
                return;
            }
            else
            {
                if (switchAutoBackup.Checked)
                {
                    if (cbDay.SelectedIndex == 0 || cbDay.SelectedIndex == -1)
                    {
                        hasError = true;
                        MessageBox.Show("Please select the day you want to perform automatic backup.", "Database Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbDay.Focus();
                        return;
                    }
                }

                if (hasError == false)
                {
                    string path = txtPath.Text;
                    string day = (switchAutoBackup.Checked) ? cbDay.Text : string.Empty;
                    DateTime time = (switchAutoBackup.Checked) ? dtpTime.Value : DateTime.MaxValue;

                    br = new classes.BackupRestore();
                    if (br.apply_settings(path, day, time))
                    {
                        MessageBox.Show("Settings has been saved!", "Database Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        display_settings();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        public void display_settings()
        {
            br = new classes.BackupRestore();
            settings_table = br.select_settings_table();

            if (settings_table.Rows.Count > 0)
            {
                foreach (DataRow row in settings_table.Rows)
                {
                    string path = row["path"].ToString();
                    string day = row["day"].ToString();
                    DateTime time = Convert.ToDateTime(row["time"]);

                    txtPath.Text = path;
                    if (string.IsNullOrEmpty(day) || time == DateTime.MaxValue)
                    {
                        switchAutoBackup.Checked = false;
                    }
                    else
                    {
                        switchAutoBackup.Checked = true;
                        cbDay.SelectedIndex = cbDay.FindStringExact(day);
                        dtpTime.Value = time;
                    }
                }
            }
        }
    }
}
