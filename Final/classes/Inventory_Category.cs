using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Final.classes
{
    class Inventory_Category : Inventory
    {
        public string inventory_type { get; set; }

        public string categor_id { get; set; }
        public string category_name { get; set; }
        public Byte[] icon { get; set; }

        internal bool create_category()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    this.query = "INSERT INTO Inventory_Category (type_name, category_name, icon) VALUES (@type_name, @category_name, @icon)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@type_name", inventory_type);
                        cmd.Parameters.AddWithValue("@category_name", category_name);
                        cmd.Parameters.AddWithValue("@icon", icon);
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

        internal DataTable select_category()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT id, category_name, icon FROM Inventory_Category WHERE type_name=@type_name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@type_name", inventory_type);
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
                MessageBox.Show("Error on selecting category: " + ex.Message, "Inventory");
                return null;
            }
        }
    }
}
