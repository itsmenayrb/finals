using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.wf.admin.inv
{
    public partial class frmAddCategory : Form
    {
        public static frmAddCategory instance = null;
        public string request_from { get; set; }

        classes.Inventory_Category inventory_category;

        public string inventory_type
        {
            set { txtInventoryType.Text = value; }
            get { return txtInventoryType.Text; }
        }

        public frmAddCategory()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            upload_icon();
        }

        private void txtCategoryName_Enter(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "Category Name")
            {
                txtCategoryName.Text = "";
            }
        }

        private void txtCategoryName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                txtCategoryName.Text = "Category Name";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text) || txtCategoryName.Text == "Category Name")
            {
                MessageBox.Show("Please indicate the category name.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Text = "";
                txtCategoryName.Focus();
                return;
            }
            else
            {
                inventory_category = new classes.Inventory_Category();
                inventory_category.inventory_type = txtInventoryType.Text;
                inventory_category.category_name = txtCategoryName.Text;
                inventory_category.icon = classes.Configuration.ConvertScreenCaptureToByte(pbPreview.Image);
                if (inventory_category.create_category())
                {
                    if (request_from == "Add Item")
                    {
                        MessageBox.Show(txtCategoryName.Text + " has been added", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        includes.uc.frmDashboard.admin.inv.add_item.ucSelectCategory.instance.display_category();
                        this.Close();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void upload_icon()
        {
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
                        MessageBox.Show("Max file size exceed.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pbPreview.Image = null;
                        return;
                    }
                    else
                    {
                        pbPreview.Image = new Bitmap(openFileDialog.FileName);
                    }
                }
            }
        }
    }
}
