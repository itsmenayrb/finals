using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace Final.classes
{
    class JobRequest
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public JobRequest()
        {
            Database database = new Database();
            this.connectionString = database.dbConnection();
        }

        internal DataTable select_job_request_table()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT a.id, a.ticket_id, a.problem, a.description, CONCAT(c.first_name, ' ', c.last_name) as reported_by, d.department_name, a.requested_at, a.status " +
                            "FROM JobRequest a " +
                            "INNER JOIN Employee b ON a.employee_id = b.employee_id " +
                            "INNER JOIN PersonalInformation c ON b.personalinformation_id = c.id " +
                            "INNER JOIN Department d ON b.department_id = d.id " +
                            "WHERE a.academic_year_id=@academic_year_id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@academic_year_id", classes.Session.academic_year_id);
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

        internal DataTable select_job_request_table(string table_column, string search)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT a.id, a.ticket_id, a.problem, a.description, CONCAT(c.first_name, ' ', c.last_name) as reported_by, a.requested_at, a.status " +
                            "FROM JobRequest a " +
                            "INNER JOIN Employee b ON a.employee_id = b.employee_id " +
                            "INNER JOIN PersonalInformation c ON b.personalinformation_id = c.id " +
                            "WHERE a.academic_year_id=@academic_year_id AND " + table_column + " LIKE '" + search + "%'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@academic_year_id", classes.Session.academic_year_id);

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
    }
}
