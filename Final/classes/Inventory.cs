using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.classes
{
    class Inventory
    {
        public int category_id { get; set; }
        public string category_name { get; set; }

        public int supplier_id { get; set; }
        public string supplier_name { get; set; }

        public string property_number { get; set; }
        public int department_id { get; set; }
        public string department_name { get; set; }
        public string status { get; set; }
        public DateTime date_acquired { get; set; }

        public string connectionString = string.Empty;
        public string query = string.Empty;

        public Inventory()
        {
            Database database = new Database();
            this.connectionString = database.dbConnection();
        }

        internal bool create_inventory()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO Inventory (academic_year_id, category_id, supplier_id, department_id, productinformation_id, acquired_at, status, property_number) " +
                            "VALUES (@academic_year_id, @category_id, @supplier_id, @department_id, (SELECT MAX(id) FROM Inventory_ProductInformation), @acquired_at, @status, @property_number)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@academic_year_id", 1);
                        cmd.Parameters.AddWithValue("@category_id", category_id);
                        cmd.Parameters.AddWithValue("@supplier_id", supplier_id);
                        cmd.Parameters.AddWithValue("@department_id", department_id);
                        cmd.Parameters.AddWithValue("@acquired_at", date_acquired);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@property_number", property_number);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on creating inventory: " + ex.Message, "Inventory");
                return false;
            }
        }

        internal DataTable select_inventory_table()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT a.id, a.acquired_at, a.status, a.property_number, d.department_name, " +
                                "b.item_name, b.description, b.brand, b.model, " +
                                "CONCAT(c.quantity, ' ', c.unit) as qty " +
                            "FROM Inventory a " +
                            "INNER JOIN Inventory_ProductInformation b ON a.productinformation_id = b.id " +
                            "INNER JOIN Inventory_Stocks c ON b.stocks_id = c.id " +
                            "INNER JOIN Department d ON a.department_id = d.id " +
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

        internal DataTable select_inventory_table(string table_column, int table_id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT a.id, a.acquired_at, a.status, a.property_number, d.department_name, " +
                                "b.item_name, b.description, b.brand, b.model, " +
                                "CONCAT(c.quantity, ' ', c.unit) as qty " +
                            "FROM Inventory a " +
                            "INNER JOIN Inventory_ProductInformation b ON a.productinformation_id = b.id " +
                            "INNER JOIN Inventory_Stocks c ON b.stocks_id = c.id " +
                            "INNER JOIN Department d ON a.department_id = d.id " +
                            "WHERE a.academic_year_id=@academic_year_id AND " + table_column + "=@table_id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@academic_year_id", classes.Session.academic_year_id);
                        cmd.Parameters.AddWithValue("@table_id", table_id);
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

        internal DataTable select_inventory_table(string table_column, string search)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT a.id, a.acquired_at, a.status, a.property_number, d.department_name, " +
                                "b.item_name, b.description, b.brand, b.model, " +
                                "CONCAT(c.quantity, ' ', c.unit) as qty " +
                            "FROM Inventory a " +
                            "INNER JOIN Inventory_ProductInformation b ON a.productinformation_id = b.id " +
                            "INNER JOIN Inventory_Stocks c ON b.stocks_id = c.id " +
                            "INNER JOIN Department d ON a.department_id = d.id " +
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
