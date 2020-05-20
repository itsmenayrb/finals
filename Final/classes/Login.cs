using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.classes
{
    class Login
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public Login()
        {
            Database database = new Database();
            this.connectionString = database.dbConnection();
        }

        public string username { get; set; }
        public string password { get; set; }

        internal bool login()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    password = Configuration.HashPassword(password);

                    this.query = "SELECT username, password FROM Accounts WHERE username=@username AND password=@password";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
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
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        internal bool active_account()
        {
            bool active = true;
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    password = Configuration.HashPassword(password);

                    this.query = "SELECT status FROM Accounts WHERE username=@username AND password=@password";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        SqlDataReader reader = cmd.ExecuteReader();
                        active = Convert.ToBoolean(reader["status"]);
                        if (active == false)
                        {
                            conn.Close();
                            return false;
                        }
                        conn.Close();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
