using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmDashboard.admin.inv
{
    public partial class ucInventory : UserControl
    {
        public static ucInventory instance = null;

        private DataTable inventory_table { get; set; }
        classes.Inventory inventory;

        public ucInventory()
        {
            instance = this;
            InitializeComponent();
        }

        public void load_inventory_data()
        {
            inventory = new classes.Inventory();
            inventory_table = inventory.select_inventory_table();

            dgvInventory.DataSource = inventory_table;
            dgvInventory.AutoGenerateColumns = false;
        }
    }
}
