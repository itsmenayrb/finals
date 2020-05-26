using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace Final.classes
{
    class PersonalInformation
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public PersonalInformation()
        {
            Database database = new Database();
            connectionString = database.dbConnection();
        }

        internal bool insert_personal_information(string first_name, string middle_name, string last_name, string contact_number, string email, Byte[] profile_picture)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO PersonalInformation (first_name, middle_name, last_name, contact_number, email, profile_picture) " +
                                "VALUES (@first_name, @middle_name, @last_name, @contact_number, @email, @profile_picture)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@middle_name", middle_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@contact_number", contact_number);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@profile_picture", profile_picture);
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
