using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final.includes.uc.frmDashboard.admin.cf
{
    public partial class ucDetailedView : UserControl
    {
        public static ucDetailedView instance = null;

        public string connectionString = string.Empty;
        public string query = string.Empty;

        classes.Remote remote;

        public ucDetailedView()
        {
            instance = this;
            InitializeComponent();
            classes.Database database = new classes.Database();
            this.connectionString = database.dbConnection();
        }

        private void listViewDetailedView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (listViewDetailedView.FocusedItem.Bounds.Contains(e.Location))
                {
                    cmsRemoteManagement.Show(Cursor.Position);
                    remote = new classes.Remote();
                    remote.machine_name = listViewDetailedView.SelectedItems[0].SubItems[1].Text;
                    remote.select_computer_unit();
                }
            }
        }

        private void viewOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucComputers.instance.perform_live_view();
        }

        private void fullControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucComputers.instance.perform_remote_session();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucComputers.instance.perform_restart();
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucComputers.instance.perform_shutdown();
        }

        private void pingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucComputers.instance.perform_ping();
        }

        public void select_detailed_view()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT ComputerUnit.id as ID, ComputerUnit.user_fullname as 'CURRENT USER', MachineInformation.machine_name as 'MACHINE NAME', Department.department_name as 'ROOM/OFFICE/DEPARTMENT', MachineInformation.ip_address as 'IP ADDRESS', MachineInformation.port as 'PORT NUMBER', MachineInformation.mac_address as 'MAC ADDRESS', ComputerUnit.status as 'STATUS' " +
                            "FROM ComputerUnit " +
                            "INNER JOIN MachineInformation ON ComputerUnit.machineinformation_id = MachineInformation.id " +
                            "INNER JOIN Department ON ComputerUnit.department_id = Department.id " +
                            "WHERE MachineInformation.machine_name!=@machine_name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@machine_name", Environment.MachineName.ToString());
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                DataRow row = dt.Rows[i];
                                ListViewItem item = new ListViewItem(row["ID"].ToString());
                                item.Font = new Font("Century Gothic", 9, FontStyle.Regular);
                                item.SubItems.Add(row["CURRENT USER"].ToString());
                                item.SubItems.Add(row["MACHINE NAME"].ToString());
                                item.SubItems.Add(row["ROOM/OFFICE/DEPARTMENT"].ToString());
                                item.SubItems.Add(row["IP ADDRESS"].ToString());
                                item.SubItems.Add(row["PORT NUMBER"].ToString());
                                item.SubItems.Add(row["MAC ADDRESS"].ToString());
                                item.SubItems.Add(row["STATUS"].ToString());
                                listViewDetailedView.Items.Add(item);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading remote pc on detailed view: " + ex.Message, "Remote Management");
            }
        }

    }
}
