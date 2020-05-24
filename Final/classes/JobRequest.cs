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

        internal Tuple<int, int, int, int> select_job_request_count()
        {
            int total = 0, completed = 0, ongoing = 0, cancelled = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT " +
                                "(SELECT COUNT(*) FROM JobRequest WHERE academic_year_id=@academic_year_id) as total, " +
                                "(SELECT COUNT(*) FROM JobRequest WHERE academic_year_id=@academic_year_id AND status=@completed) as completed, " +
                                "(SELECT COUNT(*) FROM JobRequest WHERE academic_year_id=@academic_year_id AND status=@ongoing) as ongoing, " +
                                "(SELECT COUNT(*) FROM JobRequest WHERE academic_year_id=@academic_year_id AND status=@cancelled) as cancelled";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@academic_year_id", classes.Session.academic_year_id);
                        cmd.Parameters.AddWithValue("@completed", "Completed");
                        cmd.Parameters.AddWithValue("@ongoing", "Ongoing");
                        cmd.Parameters.AddWithValue("@cancelled", "Cancellled");
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            total = Convert.ToInt32(reader["total"]);
                            completed = Convert.ToInt32(reader["completed"]);
                            ongoing = Convert.ToInt32(reader["ongoing"]);
                            cancelled = Convert.ToInt32(reader["cancelled"]);
                        }
                    }
                    conn.Close();
                    return Tuple.Create(total, completed, ongoing, cancelled);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
                return null;
            }
        }

        internal DataTable select_job_request_per_employee()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT CONCAT(c.first_name, ' ', c.last_name) as full_name, COUNT(*) as report_count " +
                            "FROM JobRequest a " +
                            "INNER JOIN Employee b ON a.employee_id = b.employee_id " +
                            "INNER JOIN PersonalInformation c ON b.personalinformation_id = c.id " +
                            "WHERE a.academic_year_id=@academic_year_id " +
                            "GROUP BY c.first_name, c.last_name " +
                            "ORDER BY report_count DESC";
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

        internal DataTable select_job_request_per_department()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT b.department_name, COUNT(*) as report_count " +
                            "FROM JobRequest a " +
                            "INNER JOIN Department b ON a.department_id = b.id " +
                            "WHERE a.academic_year_id=@academic_year_id " +
                            "GROUP BY b.department_name " +
                            "ORDER BY report_count DESC";
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

        internal DataTable select_job_request_most_common_issue()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT problem, COUNT(*) as report_count " +
                            "FROM JobRequest " +
                            "WHERE academic_year_id=@academic_year_id " +
                            "GROUP BY problem " +
                            "ORDER BY report_count DESC";
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

        internal DataTable select_computer_unit_having_issue_with(string department_name)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT a.id, c.machine_name " +
                            "FROM ComputerUnit a " +
                            "INNER JOIN Department b ON a.department_id = b.id " +
                            "INNER JOIN MachineInformation c ON a.machineinformation_id = c.id " +
                            "WHERE b.department_name=@department_name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@department_name", department_name);
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);

                            DataRow row = dt.NewRow();
                            row[0] = 0;
                            row[1] = "--Select the computer unit or item that having issue with--";
                            dt.Rows.InsertAt(row, 0);
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


        internal DataTable select_items_having_issue_with(string inventory_type, string department_name)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT a.id, d.item_name " +
                            "FROM Inventory a " +
                            "INNER JOIN Department b ON a.department_id = b.id " +
                            "INNER JOIN Inventory_Category c ON a.category_id = c.id " +
                            "INNER JOIN Inventory_ProductInformation d ON a.productinformation_id = d.id " +
                            "WHERE c.type_name=@type_name AND b.department_name=@department_name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@department_name", department_name);
                        cmd.Parameters.AddWithValue("@type_name", inventory_type);
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);

                            DataRow row = dt.NewRow();
                            row[0] = 0;
                            row[1] = "--Select the computer unit or item that having issue with--";
                            dt.Rows.InsertAt(row, 0);
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
