using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Final.classes
{
    class Register
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public string username { get; set; }
        public string password { get; set; }
        public string user_type { get; set; }
        public int status { get; set; }
        public int is_logged_in { get; set; }

        public Register()
        {
            Database database = new Database();
            this.connectionString = database.dbConnection();
        }

        internal bool checkCharacterLength(string text)
        {
            if (text.Length >= 8 && text.Length <= 32 && text != "New Password")
            {
                return true;
            }
            return false;
        }

        internal bool checkLowercase(string text)
        {
            if (new Regex(@"[a-z]+").IsMatch(text) && text != "New Password")
            {
                return true;
            }
            return false;
        }

        internal bool checkUppercase(string text)
        {
            if (new Regex(@"[A-Z]+").IsMatch(text) && text != "New Password")
            {
                return true;
            }
            return false;
        }

        internal bool checkDigit(string text)
        {
            if (new Regex(@"[0-9]+").IsMatch(text) && text != "New Password")
            {
                return true;
            }
            return false;
        }

        internal bool checkSymbol(string text)
        {
            if (new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]").IsMatch(text) && text != "New Password")
            {
                return true;
            }
            return false;
        }

        internal bool register()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "INSERT INTO Accounts (username, password, user_type, status, is_logged_in) VALUES (@username, @password, @user_type, @status, @is_logged_in)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", Configuration.HashPassword(password));
                        cmd.Parameters.AddWithValue("@user_type", user_type);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@is_logged_in", is_logged_in);
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

        internal bool select_super_administrator()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    this.query = "SELECT user_type FROM Accounts WHERE user_type=@user_type";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@user_type", "Super Administrator");
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

        internal bool activate_account()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE Accounts SET status=@status, password=@password WHERE username=@username)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", Configuration.HashPassword(password));
                        cmd.Parameters.AddWithValue("@status", status);
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
    }
}
