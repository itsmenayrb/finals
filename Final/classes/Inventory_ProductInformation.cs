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
        public int inventory_id { get; set; }
        public string inventory_type { get; set; }

        public string item_name { get; set; }
        public string description { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string serial_number { get; set; }

        public int capacity_id { get; set; }
        public int capacity { get; set; }
        public string capacity_size { get; set; }
        public string property_number { get; set; }
        public string status { get; set; }

        public DateTime acquired_at { get; set; }
        public DateTime expire_at { get; set; }

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
                        cmd.Parameters.AddWithValue("@expire_at", expire_at);
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

        internal bool update_product_information()
        {
            try
            {
                update_nventory();
                if (inventory_type == "Hardware")
                {
                    if (hasCapacity == true)
                    {
                        update_product_information_capacity();
                        update_product_information_hardware();
                    }
                    else
                    {
                        update_product_information_hardware();
                    }
                }
                else if (inventory_type == "Software")
                {
                    update_product_information_hardware();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory: " + ex.Message, "Inventory");
                return false;
            }
        }

        internal void update_nventory()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "UPDATE Inventory SET acquired_at=@acquired_at, status=@status, property_number=@property_number WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@acquired_at", acquired_at);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@property_number", property_number);
                        cmd.Parameters.AddWithValue("@id", inventory_id);
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

        internal void update_product_information_capacity()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "UPDATE Inventory_Capacity SET capacity=@capacity, size=@size WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@capacity", capacity);
                        cmd.Parameters.AddWithValue("@size", capacity_size);
                        cmd.Parameters.AddWithValue("@id", capacity_id);
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

        internal void update_product_information_hardware()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "UPDATE Inventory_ProductInformation " +
                            "SET Inventory_ProductInformation.item_name=@item_name, Inventory_ProductInformation.description=@description, Inventory_ProductInformation.brand=@brand, Inventory_ProductInformation.model=@model, Inventory_ProductInformation.serial_number=@serial_number " +
                            "FROM Inventory_ProductInformation INNER JOIN Inventory ON Inventory.productinformation_id = Inventory_ProductInformation.id " +
                            "WHERE Inventory.id=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@item_name", item_name);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@brand", brand);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@serial_number", serial_number);
                        cmd.Parameters.AddWithValue("@id", inventory_id);
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

        internal void update_product_information_software()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "UPDATE Inventory_ProductInformation " +
                            "SET Inventory_ProductInformation.item_name=@item_name, Inventory_ProductInformation.description=@description, Inventory_ProductInformation.brand=@brand, Inventory_ProductInformation.model=@model, Inventory_ProductInformation.serial_number=@serial_number, Inventory_ProductInformation.expire_at=@expire_at " +
                            "FROM Inventory_ProductInformation INNER JOIN Inventory ON Inventory.productinformation_id = Inventory_ProductInformation.id " +
                            "WHERE Inventory.id=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@item_name", item_name);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@brand", brand);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@serial_number", serial_number);
                        cmd.Parameters.AddWithValue("@expire_at", expire_at);
                        cmd.Parameters.AddWithValue("@id", inventory_id);
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
