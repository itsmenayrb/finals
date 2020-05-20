using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.classes
{
    class Setup
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public Setup()
        {
            Database database = new Database();
            this.connectionString = database.dbConnection();
        }

        public int department_id { get; set; }

        public string username { get; set; }
        public string password { get; set; }

        public string machine_name { get; set; }
        public string ip_address { get; set; }
        public int port { get; set; }
        public string mac_address { get; set; }
        

        public string status { get; set; }
        public string type { get; set; }


        internal bool select_machine_name()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT machine_name FROM MachineInformation WHERE machine_name=@machine_name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@machine_name", machine_name);
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                conn.Close();
                                return true;
                            }

                            conn.Close();
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on selecting machine name: " + ex.Message);
                return false;
            }
        }

        internal bool select_ip_address()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT ip_address FROM MachineInformation WHERE ip_address=@ip_address";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ip_address", ip_address);
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                conn.Close();
                                return true;
                            }

                            conn.Close();
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on selecting ip address: " + ex.Message);
                return false;
            }
        }

        internal void add_local_account_information()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO LocalAccountInformation (username, password) VALUES (@username, @password)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on adding local account information: " + ex.Message);
            }
        }

        internal void add_machine_information()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO MachineInformation (localaccountinformation_id, machine_name, ip_address, port, mac_address) VALUES ((SELECT MAX(id) FROM LocalAccountInformation), @machine_name, @ip_address, @port, @mac_address)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@machine_name", machine_name);
                        cmd.Parameters.AddWithValue("@ip_address", ip_address);
                        cmd.Parameters.AddWithValue("@port", port);
                        cmd.Parameters.AddWithValue("@mac_address", mac_address);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on adding machine information: " + ex.Message);
            }
        }

        internal void add_computer_unit()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO ComputerUnit (type, department_id, machineinformation_id, status) VALUES (@type, @department_id, (SELECT MAX(id) FROM MachineInformation), @status)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@department_id", department_id);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on adding computer unit: " + ex.Message);
            }
        }

        internal void add_directory()
        {
            string directory = @"C:\Comfama";
            Directory.CreateDirectory(directory);

            File.Create(directory + "\\Unlock.bat").Close();
            using (StreamWriter s = File.AppendText(directory + "\\Unlock.bat"))
            {
                s.WriteLine("tscon 1 /dest:console");
            }
        }
    }
}
