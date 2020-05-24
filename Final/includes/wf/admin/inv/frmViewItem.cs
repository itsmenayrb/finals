using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.wf.admin.inv
{
    public partial class frmViewItem : Form
    {
        public static frmViewItem instance = null;

        classes.Inventory inventory;
        public DataTable selected_inventory_table { get; set; }

        public int category_id { get; set; }
        public int supplier_id { get; set; }
        public int department_id { get; set; }
        public int productinformation_id { get; set; }
        public DateTime acquired_at { get; set; }
        public string status { get; set; }
        public string property_number { get; set; }

        public string inventory_type { get; set; }
        public string category_name { get; set; }

        public int business_type_id { get; set; }
        public string supplier_name { get; set; }

        public string department_name { get; set; }

        public string item_name { get; set; }
        public string description { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string serial_number { get; set; }
        public int capacity_id { get; set; }
        public int stocks_id { get; set; }
        public DateTime expire_at { get; set; }

        public string business_type { get; set; }

        public int quantity { get; set; }
        public string unit_of_measurement { get; set; }
        public int capacity { get; set; }
        public string capacity_size { get; set; }

        private int inventory_id = 0;

        public frmViewItem()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        public void display_selected_inventory(int inventory_id)
        {
            this.inventory_id = inventory_id;
            inventory = new classes.Inventory();
            selected_inventory_table = inventory.select_selected_inventory(inventory_id);

            foreach (DataRow row in selected_inventory_table.Rows)
            {
                category_id = Convert.ToInt32(row["category_id"]);
                supplier_id = Convert.ToInt32(row["supplier_id"]);
                department_id = Convert.ToInt32(row["department_id"]);
                productinformation_id = Convert.ToInt32(row["productinformation_id"]);
                acquired_at = Convert.ToDateTime(row["acquired_at"]);
                status = row["status"].ToString();
                property_number = row["property_number"].ToString();

                inventory_type = row["type_name"].ToString();
                category_name = row["category_name"].ToString();

                business_type_id = Convert.ToInt32(row["business_type_id"]);
                supplier_name = row["supplier_name"].ToString();

                department_name = row["department_name"].ToString();

                item_name = row["item_name"].ToString();
                description = row["description"].ToString();
                brand = row["brand"].ToString();
                model = row["model"].ToString();
                serial_number = row["serial_number"].ToString();
                capacity_id = (row["capacity_id"] == DBNull.Value) ? 0 : Convert.ToInt32(row["capacity_id"]);
                stocks_id = Convert.ToInt32(row["stocks_id"]);
                expire_at = (row["expire_at"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(row["expire_at"]);

                business_type = row["business_type"].ToString();

                quantity = Convert.ToInt32(row["quantity"]);
                unit_of_measurement = row["unit"].ToString();
                capacity = (row["capacity"] == DBNull.Value) ? 0 : Convert.ToInt32(row["capacity"]);
                capacity_size = (row["size"] == DBNull.Value) ? "" : row["size"].ToString();
            }

            set_preview();
        }

        private void set_preview()
        {
            lblItemName.Text = item_name;
            lblCategory.Text = category_name;
            lblSupplier.Text = supplier_name;
            lblDescription.Text = description;
            lblBrand.Text = brand;
            lblModel.Text = model;
            lblSerialNumber.Text = serial_number;
            lblCapacity.Text = (capacity_id == 0) ? "N/A" : capacity.ToString() + " " + capacity_size;
            lblQuantity.Text = quantity.ToString() + " " + unit_of_measurement;
            lblPropertyNumber.Text = property_number;
            lblDepartment.Text = department_name;
            lblStatus.Text = status;
            lblDateAcquired.Text = acquired_at.ToLongDateString();
            lblDateExpiry.Text = (expire_at == DateTime.MinValue) ? "N/A" : expire_at.ToLongDateString();
        }

        private void btnUpdateStocks_Click(object sender, EventArgs e)
        {
            frmUpdateStocks us = new frmUpdateStocks();
            us.inventory_id = this.inventory_id;
            us.action = "Update";
            us.stock_id = stocks_id;
            us.productinformation_id = productinformation_id;
            us.current_stock = quantity;
            us.unit_of_measurement = unit_of_measurement;
            us.stock_title = "Update Stock";
            us.new_stock = "Update stock to";
            us.display_selected_stock();
            us.ShowDialog();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            frmUpdateCategory uc = new frmUpdateCategory();
            uc.inventory_id = this.inventory_id;
            uc.inventory_type = inventory_type;
            uc.category_id = category_id;
            uc.category_name = category_name;
            uc.display_selected_category();
            uc.ShowDialog();
        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            frmUpdateDepartment ud = new frmUpdateDepartment();
            ud.inventory_id = this.inventory_id;
            ud.department_id = department_id;
            ud.department_name = department_name;
            ud.display_selected_department();
            ud.ShowDialog();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            frmUpdateProductInformation upi = new frmUpdateProductInformation();
            upi.inventory_id = this.inventory_id;

            upi.inventory_type = inventory_type;

            upi.item_name = item_name;
            upi.description = description;
            upi.brand = brand;
            upi.model = model;
            upi.serial_number = serial_number;

            upi.capacity_id = capacity_id;
            upi.capacity = capacity;
            upi.capacity_size = capacity_size;

            upi.property_number = property_number;
            upi.status = status;

            upi.acquired_at = acquired_at;
            upi.expire_at = expire_at;
            upi.display_product_information();
            upi.ShowDialog();
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            frmUpdateSupplier up = new frmUpdateSupplier();
            up.inventory_id = this.inventory_id;
            up.supplier_id = supplier_id;
            up.supplier_name = supplier_name;
            up.display_selected_supplier();
            up.ShowDialog();
        }

        private void frmViewItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Final.includes.uc.frmDashboard.admin.inv.ucInventory.instance.display_inventory_data();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete this item?", "Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                inventory = new classes.Inventory();
                if (inventory.delete_inventory(this.inventory_id))
                {
                    MessageBox.Show("Item has been deleted!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
            }
        }
    }
}
