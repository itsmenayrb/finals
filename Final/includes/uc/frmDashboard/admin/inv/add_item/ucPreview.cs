using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmDashboard.admin.inv.add_item
{
    public partial class ucPreview : UserControl
    {
        public static ucPreview instance = null;

        public string inventory_type { get; set; }

        public int category_id { get; set; }
        public string category_name { get; set; }

        public int supplier_id { get; set; }
        public string supplier_name { get; set; }

        public string item_name { get; set; }
        public string description { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string serial_number { get; set; }
        public int capacity { get; set; }
        public string capacity_size { get; set; }
        public int quantity { get; set; }
        public string unit_of_measurement { get; set; }

        public bool hasCapacity { get; set; }

        public string property_number { get; set; }
        public int department_id { get; set; }
        public string department_name { get; set; }
        public string status { get; set; }
        public DateTime date_acquired { get; set; }
        public DateTime date_expired { get; set; }

        public ucPreview()
        {
            InitializeComponent();
        }

        public void display_preview()
        {

        }
    }
}
