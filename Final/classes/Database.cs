using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.classes
{
    class Database
    {
        protected string connectionString;
        public string dbConnection()
        {
            this.connectionString = null;

            try
            {
                this.connectionString = @"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=final;User ID=sa; Password=p@ssphr@s3";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return this.connectionString;
        }
    }
}
