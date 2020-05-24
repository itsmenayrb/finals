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
    public partial class frmUpdateCategory : Form
    {
        classes.Inventory inventory;
        classes.Inventory_Category category;
        public int inventory_id { get; set; }
        public string inventory_type { get; set; }
        public int category_id { get; set; }
        public string category_name { get; set; }

        public frmUpdateCategory()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbCategory.Text) || cbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the new category you wish to update to this item.", "Update Item Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbCategory.Focus();
                return;
            }
            else
            {
                update_category(Convert.ToInt32(cbCategory.SelectedValue));
            }
        }

        public void display_selected_category()
        {
            category = new classes.Inventory_Category();

            cbCategory.DataSource = category.select_category_except_this(inventory_type, category_id);
            cbCategory.DisplayMember = "category_name";
            cbCategory.ValueMember = "id";

            txtCurrentCategory.Text = category_name;
            cbCategory.SelectedIndex = cbCategory.FindStringExact(category_name);
        }

        private void update_category(int new_category_id)
        {
            category = new classes.Inventory_Category();
            if (category.update_inventory_category(inventory_id, new_category_id))
            {
                MessageBox.Show("Category has been updated!", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Question);
                frmViewItem.instance.display_selected_inventory(inventory_id);
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
