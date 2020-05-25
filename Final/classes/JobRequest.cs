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

        internal DataTable select_items_for_replace(string inventory_type, int inventory_id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT a.id, c.item_name " +
                            "FROM Inventory a " +
                            "INNER JOIN Inventory_Category b ON a.category_id = b.id " +
                            "INNER JOIN Inventory_ProductInformation c ON a.productinformation_id = c.id " +
                            "WHERE b.type_name=@type_name AND a.category_id=(SELECT category_id FROM Inventory WHERE id=@inventory_id) " +
                                "AND a.id!=@inventory_id AND a.status=@status";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@inventory_id", inventory_id);
                        cmd.Parameters.AddWithValue("@type_name", inventory_type);
                        cmd.Parameters.AddWithValue("@status", "Working");
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);

                            DataRow row = dt.NewRow();
                            row[0] = 0;
                            row[1] = "--Select new computer unit or item--";
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

        internal bool send_job_request_feedback(string ticket_id, string findings, string findings_selection, int computer_unit_having_issue, int inventory_having_issue, 
            string action_taken, int computer_replaced_with, int inventory_replaced_with, string feedback, string status)
        {
            try
            {
                if (findings_selection == "Computer Unit")
                {
                    if (action_taken == "Replace with")
	                {
                        insert_feedback_for_computer_unit_with_replace(ticket_id, findings, findings_selection, computer_unit_having_issue, action_taken, computer_replaced_with, feedback);
                        update_job_request(ticket_id, status);
                        update_computer_unit_report_count(computer_unit_having_issue);
	                }
                    else if (action_taken == "Troubleshoot")
                    {
                        insert_feedback_for_computer_unit_troubleshoot(ticket_id, findings, findings_selection, computer_unit_having_issue, action_taken, feedback);
                        update_job_request(ticket_id, status);
                        update_computer_unit_report_count(computer_unit_having_issue);
                    }
                }
                else if (findings_selection == "Hardware-items" || findings_selection == "Application/Software")
                {
                    if (action_taken == "Replace with")
                    {
                        insert_feedback_for_inventory_with_replace(ticket_id, findings, findings_selection, inventory_having_issue, action_taken, inventory_replaced_with, feedback);
                        update_job_request(ticket_id, status);
                        update_inventory_report_count(inventory_having_issue);
                    }
                    else if (action_taken == "Troubleshoot")
                    {
                        insert_feedback_for_inventory_troubleshoot(ticket_id, findings, findings_selection, inventory_having_issue, action_taken, feedback);
                        update_job_request(ticket_id, status);
                        update_inventory_report_count(inventory_having_issue);
                    }
                }
                else if (findings_selection == "Others")
                {
                    insert_feedback_for_others(ticket_id, findings, findings_selection, action_taken, feedback);
                    update_job_request(ticket_id, status);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
                return false;
            }
        }

        internal void update_job_request(string ticket_id, string status)
        {
            try
            {
                Guid tix = Guid.Parse(ticket_id);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "UPDATE JobRequest SET status=@status WHERE ticket_id=@ticket_id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticket_id", tix);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
            }
        }

        internal void update_computer_unit_report_count(int computer_unit_having_issue)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "UPDATE ComputerUnit SET report_count = (SELECT CASE WHEN report_count IS NULL THEN 0 ELSE report_count END FROM ComputerUnit WHERE id=@computer_unit_id) + 1";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@computer_unit_id", computer_unit_having_issue);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
            }
        }

        internal void insert_feedback_for_computer_unit_with_replace(string ticket_id, string findings, string findings_selection, int computer_unit_having_issue, string action_taken,
            int computer_replaced_with, string feedback)
        {
            try
            {
                Guid tix = Guid.Parse(ticket_id);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO JobRequest_Feedback (ticket_id, findings, findings_selection, computer_unit_issue, computer_unit_replaced, action_taken, feedback, responded_at) " +
                        "VALUES (@ticket_id, @findings, @findings_selection, @computer_unit_issue, @computer_unit_replaced, @action_taken, @feedback, @responded_at)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticket_id", tix);
                        cmd.Parameters.AddWithValue("@findings", findings);
                        cmd.Parameters.AddWithValue("@findings_selection", findings_selection);
                        cmd.Parameters.AddWithValue("@computer_unit_issue", computer_unit_having_issue);
                        cmd.Parameters.AddWithValue("@computer_unit_replaced", computer_replaced_with);
                        cmd.Parameters.AddWithValue("@action_taken", action_taken);
                        cmd.Parameters.AddWithValue("@feedback", feedback);
                        cmd.Parameters.AddWithValue("@responded_at", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
            }
        }

        internal void insert_feedback_for_computer_unit_troubleshoot(string ticket_id, string findings, string findings_selection, int computer_unit_having_issue, string action_taken, string feedback)
        {
            try
            {
                Guid tix = Guid.Parse(ticket_id);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO JobRequest_Feedback (ticket_id, findings, findings_selection, computer_unit_issue, action_taken, feedback, responded_at) " +
                        "VALUES (@ticket_id, @findings, @findings_selection, @computer_unit_issue, @action_taken, @feedback, @responded_at)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticket_id", tix);
                        cmd.Parameters.AddWithValue("@findings", findings);
                        cmd.Parameters.AddWithValue("@findings_selection", findings_selection);
                        cmd.Parameters.AddWithValue("@computer_unit_issue", computer_unit_having_issue);
                        cmd.Parameters.AddWithValue("@action_taken", action_taken);
                        cmd.Parameters.AddWithValue("@feedback", feedback);
                        cmd.Parameters.AddWithValue("@responded_at", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
            }
        }

        internal void insert_feedback_for_inventory_with_replace(string ticket_id, string findings, string findings_selection, int inventory_having_issue, string action_taken,
            int inventory_replaced_with, string feedback)
        {
            try
            {
                Guid tix = Guid.Parse(ticket_id);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO JobRequest_Feedback (ticket_id, findings, findings_selection, inventory_issue, inventory_replaced, action_taken, feedback, responded_at) " +
                        "VALUES (@ticket_id, @findings, @findings_selection, @inventory_issue, @inventory_replaced, @action_taken, @feedback, @responded_at)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticket_id", tix);
                        cmd.Parameters.AddWithValue("@findings", findings);
                        cmd.Parameters.AddWithValue("@findings_selection", findings_selection);
                        cmd.Parameters.AddWithValue("@inventory_issue", inventory_having_issue);
                        cmd.Parameters.AddWithValue("@inventory_replaced", inventory_replaced_with);
                        cmd.Parameters.AddWithValue("@action_taken", action_taken);
                        cmd.Parameters.AddWithValue("@feedback", feedback);
                        cmd.Parameters.AddWithValue("@responded_at", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
            }
        }

        internal void update_inventory_report_count(int inventory_having_issue)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "UPDATE Inventory SET report_count = (SELECT CASE WHEN report_count IS NULL THEN 0 ELSE report_count END FROM Inventory WHERE id=@inventory_id) + 1";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@inventory_id", inventory_having_issue);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
            }
        }

        internal void insert_feedback_for_inventory_troubleshoot(string ticket_id, string findings, string findings_selection, int inventory_having_issue, string action_taken, string feedback)
        {
            try
            {
                Guid tix = Guid.Parse(ticket_id);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO JobRequest_Feedback (ticket_id, findings, findings_selection, inventory_issue, action_taken, feedback, responded_at) " +
                        "VALUES (@ticket_id, @findings, @findings_selection, @inventory_issue, @action_taken, @feedback, @responded_at)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticket_id", tix);
                        cmd.Parameters.AddWithValue("@findings", findings);
                        cmd.Parameters.AddWithValue("@findings_selection", findings_selection);
                        cmd.Parameters.AddWithValue("@inventory_issue", inventory_having_issue);
                        cmd.Parameters.AddWithValue("@action_taken", action_taken);
                        cmd.Parameters.AddWithValue("@feedback", feedback);
                        cmd.Parameters.AddWithValue("@responded_at", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
            }
        }

        internal void insert_feedback_for_others(string ticket_id, string findings, string findings_selection, string action_taken, string feedback)
        {
            try
            {
                Guid tix = Guid.Parse(ticket_id);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO JobRequest_Feedback (ticket_id, findings, findings_selection, action_taken, feedback, responded_at) " +
                        "VALUES (@ticket_id, @findings, @findings_selection, @action_taken, @feedback, @responded_at)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticket_id", tix);
                        cmd.Parameters.AddWithValue("@findings", findings);
                        cmd.Parameters.AddWithValue("@findings_selection", findings_selection);
                        cmd.Parameters.AddWithValue("@action_taken", action_taken);
                        cmd.Parameters.AddWithValue("@feedback", feedback);
                        cmd.Parameters.AddWithValue("@responded_at", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
            }
        }

        internal DataTable select_job_request_attachment(string ticket_id)
        {
            DataTable dt = new DataTable();
            try
            {
                Guid tix = Guid.Parse(ticket_id);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT id, image FROM JobRequest_Attachment WHERE ticket_id=@ticket_id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticket_id", tix);
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

        internal DataTable select_job_request_history(string ticket_id)
        {
            DataTable dt = new DataTable();
            try
            {
                Guid tix = Guid.Parse(ticket_id);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT findings, findings_selection, action_taken, feedback, responded_at FROM JobRequest_Feedback WHERE ticket_id=@ticket_id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticket_id", tix);
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
