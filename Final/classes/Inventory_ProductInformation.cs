using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace Final.classes
{
    class Inventory_ProductInformation : Inventory
    {
        public string inventory_type { get; set; }
        public string item_name { get; set; }
        public string description { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string serial_number { get; set; }
        public DateTime date_expired { get; set; }
        public bool hasCapacity { get; set; }

        internal bool create_product_information()
        {
            try
            {
                if (inventory_type == "Hardware")
                {
                    if (hasCapacity == true)
                    {
                        create_product_information_hardware_with_capacity();
                    }
                    else
                    {
                        create_product_information_hardware_without_capacity();
                    }
                }
                else if (inventory_type == "Software")
                {
                    create_product_information_software();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
                return false;
            }
        }

        internal void create_product_information_hardware_without_capacity()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO Inventory_ProductInformation (item_name, description, brand, model, serial_number, stocks_id) " +
                            "VALUES (@item_name, @description, @brand, @model, @serial_number, (SELECT MAX(id) FROM Inventory_Stocks))";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@item_name", item_name);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@brand", brand);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@serial_number", serial_number);
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
        
        internal void create_product_information_hardware_with_capacity()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO Inventory_ProductInformation (item_name, description, brand, model, serial_number, capacity_id, stocks_id) " +
                            "VALUES (@item_name, @description, @brand, @model, @serial_number, (SELECT MAX(id) FROM Inventory_Capacity), (SELECT MAX(id) FROM Inventory_Stocks))";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@item_name", item_name);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@brand", brand);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@serial_number", serial_number);
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

        internal void create_product_information_software()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO Inventory_ProductInformation (item_name, description, brand, model, serial_number, stocks_id, expire_at) " +
                            "VALUES (@item_name, @description, @brand, @model, @serial_number, (SELECT MAX(id) FROM Inventory_Stocks), @expire_at)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@item_name", item_name);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@brand", brand);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@serial_number", serial_number);
                        cmd.Parameters.AddWithValue("@expire_at", date_expired);
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
    }
}
