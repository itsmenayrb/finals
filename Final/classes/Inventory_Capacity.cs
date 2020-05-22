using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace Final.classes
{
    class Inventory_Capacity : Inventory
    {
        public int capacity { get; set; }
        public string capacity_size { get; set; }
        
        internal bool create_capacity()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO Inventory_Capacity (capacity, size) " +
                            "VALUES (@capacity, @size)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@capacity", capacity);
                        cmd.Parameters.AddWithValue("@size", capacity_size);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
                return false;
            }
        }
    }
}
