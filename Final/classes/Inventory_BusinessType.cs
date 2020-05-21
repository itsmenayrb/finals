using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace Final.classes
{
    class Inventory_BusinessType : Inventory
    {
        public string business_type { get; set; }
        public Byte[] icon { get; set; }

        internal bool create_business_type()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    this.query = "INSERT INTO Inventory_BusinessType (business_type, icon) VALUES (@business_type, @icon)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@business_type", business_type);
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

        internal DataTable select_business_type()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT id, business_type, icon FROM Inventory_BusinessType";
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
                MessageBox.Show("Error on selecting category: " + ex.Message, "Inventory");
                return null;
            }
        }
    }
}
