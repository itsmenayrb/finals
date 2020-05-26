using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmDashboard.admin.db
{
    public partial class ucDBOtherInformation : UserControl
    {
        public static ucDBOtherInformation instance = null;
        private DataTable db_logs_table { get; set; }
        classes.BackupRestore br;

        public ucDBOtherInformation()
        {
            instance = this;
            InitializeComponent();
        }

        public void display_db_logs()
        {
            br = new classes.BackupRestore();
            db_logs_table = br.select_database_logs_table();

            dgvDatabaseLogs.DataSource = db_logs_table;
            dgvDatabaseLogs.AutoGenerateColumns = false;
        }

        private void ucDBOtherInformation_Load(object sender, EventArgs e)
        {
            display_db_logs();
        }
    }
}
