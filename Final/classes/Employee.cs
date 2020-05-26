using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace Final.classes
{
    class Employee : PersonalInformation
    {
        internal DataTable select_employee_table()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT a.id, b.profile_picture, a.employee_id, CONCAT(b.first_name, ' ', b.last_name) as full_name, b.contact_number, " +
                                "b.email, c.department_name, d.position_name " +
                            "FROM Employee a " +
                            "INNER JOIN PersonalInformation b ON a.personalinformation_id = b.id " +
                            "INNER JOIN Department c ON a.department_id = c.id " +
                            "INNER JOIN Position d ON a.position_id = d.id";
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

        internal DataTable select_employee_table(string table_column, string search)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT a.id, b.profile_picture, a.employee_id, CONCAT(b.first_name, ' ', b.last_name) as full_name, b.contact_number, " +
                                "b.email, c.department_name, d.position_name " +
                            "FROM Employee a " +
                            "INNER JOIN PersonalInformation b ON a.personalinformation_id = b.id " +
                            "INNER JOIN Department c ON a.department_id = c.id " +
                            "INNER JOIN Position d ON a.position_id = d.id " +
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

        internal bool insert_employee(string employee_id, int department_id, int position_id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO Employee (employee_id, personalinformation_id, department_id, position_id) " +
                                "VALUES (@employee_id, (SELECT MAX(id) FROM PersonalInformation), @department_id, @position_id)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@employee_id", employee_id);
                        cmd.Parameters.AddWithValue("@department_id", department_id);
                        cmd.Parameters.AddWithValue("@position_id", position_id);
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

        internal DataTable select_employee_cb()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT a.id, CONCAT(b.last_name, ', ', b.first_name) as full_name " +
                            "FROM Employee a " +
                            "INNER JOIN PersonalInformation b ON a.personalinformation_id = b.id " +
                            "WHERE a.user_type=@user_type";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@user_type", "Employee");
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);

                            DataRow row = dt.NewRow();
                            row[0] = 0;
                            row[1] = "--Select employee--*";
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
