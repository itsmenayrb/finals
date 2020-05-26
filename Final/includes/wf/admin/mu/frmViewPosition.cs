using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.wf.admin.mu
{
    public partial class frmViewPosition : Form
    {
        public static frmViewPosition instance = null;
        classes.Position ps;

        public frmViewPosition()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        public void display_position_data()
        {
            ps = new classes.Position();
            dgvPosition.DataSource = ps.select_all_position();
            dgvPosition.AutoGenerateColumns = false;

            if (dgvPosition.Columns.Contains("action") && dgvPosition.Columns["action"].Visible)
            {

            }
            else
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.Name = "action";
                    button.HeaderText = "Action";
                    button.Text = "Update";
                    button.UseColumnTextForButtonValue = true;
                    this.dgvPosition.Columns.Add(button);
                }
            }
        }

        private void dgvPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPosition.Columns["action"].Index)
            {
                int position_id = Convert.ToInt32(dgvPosition.Rows[dgvPosition.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            frmAddPosition add_position = new frmAddPosition();
            add_position.request_from = "View Position";
            add_position.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
