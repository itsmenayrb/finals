using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace Final.classes
{
    class Inventory_Stocks : Inventory
    {
        public int quantity { get; set; }
        public string unit_of_measurement { get; set; }

        internal bool create_stocks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO Inventory_Stocks (quantity, unit) " +
                            "VALUES (@quantity, @unit)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@unit", unit_of_measurement);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on creating stocks: " + ex.Message, "Inventory");
                return false;
            }
        }

        internal DataTable select_stocks_table()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT a.id, b.item_name, c.quantity, c.unit " +
                            "FROM Inventory a " +
                            "INNER JOIN Inventory_ProductInformation b ON a.productinformation_id = b.id " +
                            "INNER JOIN Inventory_Stocks c ON b.stocks_id = c.id " +
                            "WHERE a.academic_year_id=@academic_year_id " +
                            "ORDER BY c.quantity DESC";
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

        internal Tuple<int, int, int> select_stocks_chart()
        {
            int h = 0, c = 0, l = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT " +
                                "(SELECT COUNT(*) FROM Inventory_Stocks WHERE quantity >= 50) as high, " +
                                "(SELECT COUNT(*) FROM Inventory_Stocks WHERE quantity < 50) as critical, " +
                                "(SELECT COUNT(*) FROM Inventory_Stocks WHERE quantity < 10) as low";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            h = Convert.ToInt32(reader["high"]);
                            c = Convert.ToInt32(reader["critical"]);
                            l = Convert.ToInt32(reader["low"]);
                        }
                    }
                    conn.Close();
                    return Tuple.Create(h, c, l);
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
