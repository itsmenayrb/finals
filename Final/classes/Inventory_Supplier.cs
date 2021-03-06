﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace Final.classes
{
    class Inventory_Supplier : Inventory
    {
        public int business_type_id { get; set; }
        public string registration_id { get; set; }
        public string supplier_name { get; set; }
        public string address { get; set; }
        public string contact_number { get; set; }
        public string email { get; set; }
        public string tin { get; set; }
        public Byte[] logo { get; set; }

        internal bool create_supplier()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    this.query = "INSERT INTO Inventory_Supplier (business_type_id, registration_id, supplier_name, address, contact_number, email, tin_number, logo) VALUES (@business_type_id, @registration_id, @supplier_name, @address, @contact_number, @email, @tin_number, @logo)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@business_type_id", business_type_id);
                        cmd.Parameters.AddWithValue("@registration_id", registration_id);
                        cmd.Parameters.AddWithValue("@supplier_name", supplier_name);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@contact_number", contact_number);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@tin_number", tin);
                        cmd.Parameters.AddWithValue("@logo", logo);
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

        internal DataTable select_supplier()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT id, supplier_name, logo FROM Inventory_Supplier";
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
                MessageBox.Show("Error on selecting supplier: " + ex.Message, "Inventory");
                return null;
            }
        }

        internal DataTable select_supplier_table()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT id, registration_id, supplier_name, address, contact_number, email, tin_number, logo FROM Inventory_Supplier WHERE business_type_id=@business_type_id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@business_type_id", business_type_id);
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
                MessageBox.Show("Error on selecting supplier: " + ex.Message, "Inventory");
                return null;
            }
        }

        internal DataTable select_supplier(string search)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT id, supplier_name, logo FROM Inventory_Supplier WHERE supplier_name LIKE '" + search + "%'";
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
                MessageBox.Show("Error on selecting supplier: " + ex.Message, "Inventory");
                return null;
            }
        }

        internal object select_inventory_supplier_except_this(int supplier_id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT id, supplier_name FROM Inventory_Supplier WHERE id!=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", supplier_id);
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);

                            DataRow row = dt.NewRow();
                            row[0] = 0;
                            row[1] = "--Select supplier--";
                            dt.Rows.InsertAt(row, 0);
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

        internal bool update_inventory_supplier(int inventory_id, int p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "UPDATE Inventory SET supplier_id=@supplier_id WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@supplier_id", p);
                        cmd.Parameters.AddWithValue("@id", inventory_id);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on selecting category: " + ex.Message, "Inventory");
                return false;
            }
        }
    }
}
