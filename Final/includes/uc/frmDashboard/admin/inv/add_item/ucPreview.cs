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
            instance = this;
            InitializeComponent();
        }

        public void display_preview()
        {
            lblCategory.Text = category_name;
            lblSupplier.Text = supplier_name;
            lblItemName.Text = item_name;
            lblDescription.Text = description;
            lblBrand.Text = brand;
            lblModel.Text = model;
            lblSerialNumber.Text = serial_number;
            lblCapacity.Text = (hasCapacity == true) ? capacity.ToString() + " " + capacity_size : "N/A";
            lblQuantity.Text = quantity.ToString() + " " + unit_of_measurement;
            lblPropertyNumber.Text = property_number;
            lblDepartment.Text = department_name;
            lblStatus.Text = status;
            lblDateAcquired.Text = date_acquired.ToLongDateString();
            lblDateExpiry.Text = (inventory_type == "Software") ? date_expired.ToLongDateString() : "N/A";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(quantity.ToString() + " " + unit_of_measurement);
            
            classes.Inventory_Stocks stocks = new classes.Inventory_Stocks();
            stocks.quantity = quantity;
            stocks.unit_of_measurement = unit_of_measurement;

            if (stocks.create_stocks())
            {
                if (hasCapacity == true)
                {
                    classes.Inventory_Capacity cp = new classes.Inventory_Capacity();
                    cp.capacity = capacity;
                    cp.capacity_size = capacity_size;
                    cp.create_capacity();
                }

                classes.Inventory_ProductInformation pi = new classes.Inventory_ProductInformation();
                pi.inventory_type = inventory_type;
                pi.item_name = item_name;
                pi.description = description;
                pi.brand = brand;
                pi.model = model;
                pi.serial_number = serial_number;
                pi.hasCapacity = hasCapacity;
                pi.date_expired = date_expired;

                if (pi.create_product_information())
                {
                    classes.Inventory inv = new classes.Inventory();
                    inv.category_id = category_id;
                    inv.category_name = category_name;
                    inv.supplier_id = supplier_id;
                    inv.supplier_name = supplier_name;
                    inv.property_number = property_number;
                    inv.department_id = department_id;
                    inv.department_name = department_name;
                    inv.status = status;
                    inv.date_acquired = date_acquired;
            
                    if (inv.create_inventory())
                    {
                        MessageBox.Show(item_name + " has been added", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ucInventory.instance.load_inventory_data();
                        ((Form)this.TopLevelControl).Close();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucOtherProductInformation1"].Visible = true;
            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucPreview1"].Visible = false;
        }
    }
}
