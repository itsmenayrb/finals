using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Final.classes
{
    class Configuration
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public Configuration()
        {
            Database database = new Database();
            connectionString = database.dbConnection();
        }

        public static string HashPassword(string password)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(password));
                return Convert.ToBase64String(data);
            }
        }

        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        public static byte[] ConvertScreenCaptureToByte(Image img)
        {
            byte[] byteArray = new byte[0];
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                stream.Close();

                byteArray = stream.ToArray();
            }
            return byteArray;
        }

        public static Image UploadIcon(string title)
        {
            Image icon = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose Image File";
                openFileDialog.Filter = "Icon Files (*.ico, *.ICO, *.png, *.PNG|*.ico; *.ICO; *.png; *.PNG";
                openFileDialog.Multiselect = false;
                openFileDialog.ValidateNames = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    long file_size = new FileInfo(openFileDialog.FileName).Length;
                    if (file_size / 1024 > 5)
                    {
                        MessageBox.Show("Max file size exceed.", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return Resource1.full_image_30px;
                    }
                    else
                    {
                        icon = new Bitmap(openFileDialog.FileName);
                    }
                }
                else
                {
                    return Resource1.full_image_30px;
                }
            }
            return icon; 
        }

        public static Image UploadLogo(string title)
        {
            Image icon = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose Image File";
                openFileDialog.Filter = "Image Files (*.ico, *.ICO, *.png, *.PNG, *.jpg, *.JPG, *.jpeg, *.JPEG|*.ico; *.ICO; *.png; *.PNG; *.jpg; *.JPG; *.jpeg; *.JPEG";
                openFileDialog.Multiselect = false;
                openFileDialog.ValidateNames = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    long file_size = new FileInfo(openFileDialog.FileName).Length;
                    if (file_size / 1024 / 1024 > 2)
                    {
                        MessageBox.Show("Max file size exceed.", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return Resource1.full_image_30px;
                    }
                    else
                    {
                        icon = new Bitmap(openFileDialog.FileName);
                    }
                }
                else
                {
                    return Resource1.full_image_30px;
                }
            }
            return icon;
        }

        public bool CheckIfExist(string column, string table, string data)
        {
            int isExist = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    query = "SELECT COUNT(*) FROM " + table + " WHERE " + column + "=@data";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@data", data);
                        isExist = (int)cmd.ExecuteScalar();
                    }
                    conn.Close();
                    return (isExist > 0) ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on check if exist: " + ex.Message);
                return false;
            }
        }
    }
}
