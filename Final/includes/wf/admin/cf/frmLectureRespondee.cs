using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.wf.admin.cf
{
    public partial class frmLectureRespondee : Form
    {
        public static frmLectureRespondee instance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        classes.Remote remote;

        public frmLectureRespondee()
        {
            instance = this;
            InitializeComponent();
            classes.Database database = new classes.Database();
            this.connectionString = database.dbConnection();

            remote = new classes.Remote();
        }

        private void timerWaitingToClientToAccept_Tick(object sender, EventArgs e)
        {
            select_requesting_user_to_facilitate_lecture();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            remote.start_lecture();
            frmDashboard.instance.start_lecture();
            this.Hide();
            new frmLecturePlayer().Show();
        }

        public void start_load_client()
        {
            timerWaitingToClientToAccept.Start();
        }

        public void stop_load_client()
        {
            timerWaitingToClientToAccept.Stop();
        }

        public void select_requesting_user_to_facilitate_lecture()
        {
            classes.Configuration.SetDoubleBuffered(clbClient);
            int count = remote.select_computer_count();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT MachineInformation.machine_name, MachineInformation.ip_address, ComputerUnit.in_lecture " +
                            "FROM ComputerUnit " +
                            "INNER JOIN MachineInformation ON ComputerUnit.machineinformation_id = MachineInformation.id " +
                            "WHERE ComputerUnit.type!=@type";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@type", "Server");
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            clbClient.Items.Clear();
                            string machine_name = reader["machine_name"].ToString();
                            string in_lecture = reader["in_lecture"].ToString();

                            clbClient.Items.Add(
                                machine_name,
                                (in_lecture == "Accepted") ? true : false
                            );

                            if (clbClient.CheckedItems.Count == count)
                            {
                                timerWaitingToClientToAccept.Stop();
                                btnStart.Enabled = true;
                                break;
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on sending request to facilitate lecture: " + ex.Message, "Remote Management");
            }
        }

        public void dispose()
        {
            if (!this.Visible)
            {
                this.Close();
            }
        }
    }
}
