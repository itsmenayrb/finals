using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmDashboard.admin.arc
{
    public partial class ucInventory : UserControl
    {
        public int academic_year_id { get; set; }
        public static ucInventory instance = null;

        private DataTable inventory_archived_table { get; set; }

        classes.Archived arc;

        public ucInventory()
        {
            instance = this;
            InitializeComponent();
        }

        public void display_inventory_archived_data()
        {
            arc = new classes.Archived();
            gbAcademicYear.Text = "Academic Year: " + arc.select_academic_year(academic_year_id);
            inventory_archived_table = arc.select_inventory_archived_table(academic_year_id);
            dgvInventory.DataSource = inventory_archived_table;
            dgvInventory.AutoGenerateColumns = false;
        }
    }
}
