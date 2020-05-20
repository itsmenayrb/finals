using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.classes
{
    class Remote
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public string machine_name { get; set; }

        public string ip_address { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public string current_user { get; set; }
        public string in_lecture { get; set; }

        public Image image_screen { get; set; }

        public Remote()
        {
            Database database = new Database();
            this.connectionString = database.dbConnection();
        }

        internal void select_computer_unit()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT MachineInformation.ip_address, LocalAccountInformation.username, LocalAccountInformation.password " +
                            "FROM MachineInformation " +
                            "INNER JOIN LocalAccountInformation ON MachineInformation.localaccountinformation_id = LocalAccountInformation.id " +
                            "WHERE MachineInformation.machine_name=@machine_name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@machine_name", machine_name);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            ip_address = reader["ipAddress"].ToString();
                            username = reader["username"].ToString();
                            password = reader["password"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading selected remote pc: " + ex.Message, "Remote Management");
            }
        }

        internal Byte[] select_computer_unit_image()
        {
            Byte[] screen_capture = null;
            try
            {
                
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT ComputerUnit.screen_capture " +
                            "FROM ComputerUnit " +
                            "INNER JOIN MachineInformation ON ComputerUnit.machineinformation_id = MachineInformation.id " +
                            "WHERE MachineInformation.machine_name=@machine_name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@machine_name", machine_name);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            screen_capture = (Byte[])reader["screen_capture"];
                        }
                    }
                    conn.Close();
                    return screen_capture;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading selected remote pc: " + ex.Message, "Remote Management");
                return null;
            }
        }

        internal void send_request_to_facilitate_lecture()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "UPDATE ComputerUnit SET in_lecture=@in_lecture WHERE type!=@type AND status=@status";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@in_lecture", "Requesting");
                        cmd.Parameters.AddWithValue("@type", "Server");
                        cmd.Parameters.AddWithValue("@status", "Connected");
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on sending request to facilitate lecture: " + ex.Message, "Remote Management");
            }
        }

        internal void start_lecture()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "UPDATE ComputerUnit SET in_lecture=@in_lecture WHERE type!=@type AND status=@status";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@in_lecture", "Started");
                        cmd.Parameters.AddWithValue("@type", "Server");
                        cmd.Parameters.AddWithValue("@status", "Connected");
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on starting lecture: " + ex.Message, "Remote Management");
            }
        }

        internal void end_lecture()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "UPDATE ComputerUnit SET in_lecture=@in_lecture WHERE type!=@type AND status=@status";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@in_lecture", "Ended");
                        cmd.Parameters.AddWithValue("@type", "Server");
                        cmd.Parameters.AddWithValue("@status", "Connected");
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on starting lecture: " + ex.Message, "Remote Management");
            }
        }

        internal int select_computer_count()
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT COUNT(*) as rc FROM ComputerUnit WHERE type!=@type";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@type", "Server");
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            count = Convert.ToInt32(reader["rc"]);
                        }
                    }
                    conn.Close();
                    return count;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on sending request for lecture mode: " + ex.Message, "Remote Management");
                return 0;
            }
        }

        internal void insert_captured_image()
        {
            byte[] img = Configuration.ConvertScreenCaptureToByte(image_screen);
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "UPDATE ComputerUnit SET ComputerUnit.screen_capture=@screen_capture " +
                            "FROM ComputerUnit " +
                            "INNER JOIN MachineInformation ON ComputerUnit.machineinformation.id = MachineInformation.id " +
                            "WHERE MachineInformation.machine_name=@machine_name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@screen_capture", img);
                        cmd.Parameters.AddWithValue("@machine_name", Session.machine_name);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on starting lecture: " + ex.Message, "Remote Management");
            }
        }

        internal int select_server_count()
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT COUNT(*) as rc FROM ComputerUnit WHERE type!=@type";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@type", "Client");
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            count = Convert.ToInt32(reader["rc"]);
                        }
                    }
                    conn.Close();
                    return count;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on selecting server count: " + ex.Message, "Remote Management");
                return 0;
            }
        }

        internal int select_client_count()
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT COUNT(*) as rc FROM ComputerUnit WHERE type=@type";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@type", "Client");
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            count = Convert.ToInt32(reader["rc"]);
                        }
                    }
                    conn.Close();
                    return count;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on selecting client count: " + ex.Message, "Remote Management");
                return 0;
            }
        }

        internal DataTable select_server_table()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT Department.department_name as sst_department, ComputerUnit.type as sst_type, MachineInformation.machine_name as sst_machine_name " +
                            "FROM ComputerUnit " +
                            "INNER JOIN Department ON ComputerUnit.department_id = Department.id " +
                            "INNER JOIN MachineInformation ON ComputerUnit.machineinformation_id = MachineInformation.id " +
                            "WHERE ComputerUnit.type!=@type";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@type", "Client");
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                        }
                    }
                    conn.Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on selecting server table: " + ex.Message, "Remote Management");
                return null;
            }
        }

        internal DataTable select_client_table()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT Department.department_name as sct_department, MachineInformation.machine_name as sct_machine_name " +
                            "FROM ComputerUnit " +
                            "INNER JOIN Department ON ComputerUnit.department_id = Department.id " +
                            "INNER JOIN MachineInformation ON ComputerUnit.machineinformation_id = MachineInformation.id " +
                            "WHERE ComputerUnit.type=@type " +
                            "ORDER BY Department.department_name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@type", "Client");
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                        }
                    }
                    conn.Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on selecting client table: " + ex.Message, "Remote Management");
                return null;
            }
        }

        internal DataTable select_computer_count_per_department_table()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT Department.department_name as sccpdt_department, COUNT(ComputerUnit.id) as sccpdt_count " +
                            "FROM ComputerUnit " +
                            "INNER JOIN Department ON ComputerUnit.department_id = Department.id " +
                            "GROUP BY Department.department_name " +
                            "ORDER BY sccpdt_count DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                        }
                    }
                    conn.Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on selected computer count: " + ex.Message, "Remote Management");
                return null;
            }
        }

        internal DataTable select_reported_count_per_computer_table()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT MachineInformation.machine_name as srcpct_machine_name, ComputerUnit.report_count as srcpct_count " +
                            "FROM ComputerUnit " +
                            "INNER JOIN MachineInformation ON ComputerUnit.machineinformation_id = MachineInformation.id " +
                            "WHERE ComputerUnit.report_count is not null " +
                            "ORDER BY srcpct_count DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                        }
                    }
                    conn.Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on selected report count: " + ex.Message, "Remote Management");
                return null;
            }
        }
    }
}
