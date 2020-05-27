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
    public partial class ucArchived : UserControl
    {
        public static ucArchived instance = null;
        private DataTable archived_parent_table { get; set; }
        private DataTable archived_child_table { get; set; }
        classes.Archived arc;

        public ucArchived()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panel1, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        public void display_treeview_data()
        {
            tvArchived.Nodes.Clear();
            TreeNode root = new TreeNode("Comfama");
            string academic_year = string.Empty;

            arc = new classes.Archived();
            archived_parent_table = arc.select_parent_table();

            foreach (DataRow row_p in archived_parent_table.Rows)
            {
                academic_year = row_p["acad_year"].ToString();
                TreeNode parent = new TreeNode(academic_year);
                root.Nodes.Add(parent);

                archived_child_table = arc.select_child_table(academic_year);

                foreach (DataRow row_c in archived_child_table.Rows)
                {
                    TreeNode child = new TreeNode
                    {
                        Text = row_c["semester"].ToString(),
                        Tag = row_c["id"].ToString()
                    };

                    parent.Nodes.Add(child);

                    child.Nodes.Add("Inventory");
                    child.Nodes.Add("Job Requests");
                    child.Nodes.Add("Login History");
                }
            }

            tvArchived.Nodes.Add(root);
            tvArchived.ExpandAll();
        }

        private void tvArchived_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selected_node = tvArchived.SelectedNode.Text;
            int id = 0;

            if (selected_node == "Inventory")
            {
                id = Convert.ToInt32(tvArchived.SelectedNode.Parent.Tag);
                ucInventory.instance.academic_year_id = id;
                ucInventory.instance.display_inventory_archived_data();

                ucInventory1.Visible = true;
            }
            else if (selected_node == "Job Requests")
            {
                
            }
            else if (selected_node == "Login History")
            {

            }
        }
    }
}
