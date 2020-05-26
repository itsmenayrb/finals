using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace Final.classes
{
    class BackupRestore
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public BackupRestore()
        {
            Database database = new Database();
            this.connectionString = database.dbConnection();
        }

        internal bool apply_settings(string path, string day, DateTime time)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "TRUNCATE TABLE BackupRestore_Settings " +
                            "INSERT INTO BackupRestore_Settings (path, day, time) VALUES (@path, @day, @time)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@path", path);
                        cmd.Parameters.AddWithValue("@day", day);
                        cmd.Parameters.AddWithValue("@time", time);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        internal DataTable select_settings_table()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT path, day, time FROM BackupRestore_Settings";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            conn.Close();
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        internal void insert_logs(bool action, bool action_through)
        {
            int a = (action == true) ? 1 : 0;
            int a_t = (action_through == true) ? 1 : 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO BackupRestore_Logs (action_at, action, action_through) VALUES (@action_at, @action, @action_through)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@action_at", DateTime.Now);
                        cmd.Parameters.AddWithValue("@action", a);
                        cmd.Parameters.AddWithValue("@action_through", a_t);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        internal DataTable select_database_logs_table()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT action_at, CASE WHEN action = 1 THEN 'Backup' ELSE 'Restore' END as action, CASE WHEN action_through = 1 THEN 'Automatic' ELSE 'Manual' END as action_through FROM BackupRestore_Logs ORDER BY action_at DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            conn.Close();
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
    }
}
