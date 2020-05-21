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
    public partial class frmSelectBusinessType : Form
    {
        public static frmSelectBusinessType instance = null;
        classes.Inventory_BusinessType business_type;
        Guna.UI2.WinForms.Guna2TileButton button;

        public string request_from { get; set; }

        public frmSelectBusinessType()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnAddBusinessType_Click(object sender, EventArgs e)
        {
            includes.wf.admin.inv.frmAddBusinessType addBusinessType = new wf.admin.inv.frmAddBusinessType();
            addBusinessType.request_from = "Add Item";
            addBusinessType.ShowDialog();
        }

        public void display_business_type()
        {
            flpBusinessType.Controls.Clear();

            business_type = new classes.Inventory_BusinessType();
            DataTable dt = business_type.select_business_type();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    button = new Guna.UI2.WinForms.Guna2TileButton();
                    button.Name = row["id"].ToString();
                    button.Text = row["business_type"].ToString();
                    button.Image = Image.FromStream(new MemoryStream((Byte[])row["icon"]));
                    button.HoverState.Image = Image.FromStream(new MemoryStream((Byte[])row["icon"]));
                    button.ImageSize = new Size(25, 25);
                    button.BorderColor = Color.FromArgb(47, 97, 72);
                    button.BorderRadius = 5;
                    button.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    button.BorderThickness = 1;
                    button.Font = new Font("Century Gothic", 9, FontStyle.Regular);
                    button.ForeColor = Color.Black;
                    button.BackColor = Color.White;
                    button.FillColor = Color.White;
                    button.Size = new Size(92, 64);
                    button.Click += new EventHandler(this.button_Click);

                    flpBusinessType.Controls.Add(button);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TileButton button = (Guna.UI2.WinForms.Guna2TileButton)sender;
            int business_type_id = Convert.ToInt32(button.Name);
            string business_type = button.Text;

            frmAddSupplier addSupplier = new frmAddSupplier();
            addSupplier.business_type_id = business_type_id;
            addSupplier.business_type = business_type;
            addSupplier.request_from = request_from;
            addSupplier.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
