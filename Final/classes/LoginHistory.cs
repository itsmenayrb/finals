using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace Final.classes
{
    class LoginHistory
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public LoginHistory()
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
                    query = "SELECT a.logged_in_at, b.username, CONCAT(c.first_name, ' ', c.last_name) as full_name, a.start_at, a.end_at, " +
                                "a.duration, e.department_name, f.machine_name " +
                            "FROM LoginHistory a " +
                            "INNER JOIN Accounts b ON a.account_id=b.username " +
                            "INNER JOIN PersonalInformation c ON b.id=c.id " +
                            "INNER JOIN ComputerUnit d ON a.computer_unit_id=d.id " +
                            "INNER JOIN Department e ON d.department_id=e.id " +
                            "INNER JOIN MachineInformation f ON d.machineinformation_id=f.id " +
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
                    query = "SELECT a.logged_in_at, b.username, CONCAT(c.first_name, ' ', c.last_name) as full_name, a.start_at, a.end_at, " +
                                "a.duration, e.department_name, f.machine_name " +
                            "FROM LoginHistory a " +
                            "INNER JOIN Accounts b ON a.account_id=b.username " +
                            "INNER JOIN PersonalInformation c ON b.id=c.id " +
                            "INNER JOIN ComputerUnit d ON a.computer_unit_id=d.id " +
                            "INNER JOIN Department e ON d.department_id=e.id " +
                            "INNER JOIN MachineInformation f ON d.machineinformation_id=f.id " +
                            "WHERE a.academic_year_id=@academic_year_id AND " + table_column + " LIKE '" + search + "%' " +
                            "ORDER BY a.logged_in_at DESC, a.start_at DESC";
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
