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
    public partial class ucSelectType : UserControl
    {
        public ucSelectType()
        {
            InitializeComponent();
        }

        private void btnHardware_Click(object sender, EventArgs e)
        {
            ucSelectCategory.instance.inventory_type = "Hardware";
            ucSelectCategory.instance.display_category();
            show_category();
        }

        private void btnSoftware_Click(object sender, EventArgs e)
        {
            ucSelectCategory.instance.inventory_type = "Software";
            ucSelectCategory.instance.display_category();
            show_category();
        }

        private void show_category()
        {
            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucSelectType1"].Visible = false;
            ((Form)this.TopLevelControl).Controls["panelContainer"].Controls["ucSelectCategory1"].Visible = true;
        }
    }
}
