using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace Final.classes
{
    class Student : PersonalInformation
    {
        internal DataTable select_student_table()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT a.id, b.profile_picture, a.student_number, CONCAT(b.first_name, ' ', b.last_name) as full_name, b.contact_number, " +
                                "b.email, a.year_level, c.course_name, a.status " +
                            "FROM Student a " +
                            "INNER JOIN PersonalInformation b ON a.personalinformation_id = b.id " +
                            "INNER JOIN Course c ON a.course_id = c.id";
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
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
                return null;
            }
        }

        internal DataTable select_student_table(string table_column, string search)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT a.id, b.profile_picture, a.student_number, CONCAT(b.first_name, ' ', b.last_name) as full_name, b.contact_number, " +
                                "b.email, a.year_level, c.course_name, a.status " +
                            "FROM Student a " +
                            "INNER JOIN PersonalInformation b ON a.personalinformation_id = b.id " +
                            "INNER JOIN Course c ON a.course_id = c.id " +
                            "WHERE " + table_column + " LIKE '" + search + "%'";
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
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
                return null;
            }
        }

        internal bool insert_student(string student_number, int course_id, string year_level, string status)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO Student (student_number, personalinformation_id, course_id, year_level, status) " +
                                "VALUES (@student_number, (SELECT MAX(id) FROM PersonalInformation), @course_id, @year_level, @status)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@student_number", student_number);
                        cmd.Parameters.AddWithValue("@course_id", course_id);
                        cmd.Parameters.AddWithValue("@year_level", year_level);
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
