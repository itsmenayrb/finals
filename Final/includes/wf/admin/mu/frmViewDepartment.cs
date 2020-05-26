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
    public partial class frmViewDepartment : Form
    {
        public static frmViewDepartment instance = null;
        classes.Department dprtmnt;

        public frmViewDepartment()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            frmAddDepartment add_department = new frmAddDepartment();
            add_department.request_from = "View Department";
            add_department.ShowDialog();
        }

        public void display_department_data()
        {
            dprtmnt = new classes.Department();
            dgvDepartment.DataSource = dprtmnt.select_department_table();
            dgvDepartment.AutoGenerateColumns = false;

            if (dgvDepartment.Columns.Contains("action") && dgvDepartment.Columns["action"].Visible)
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
                    this.dgvDepartment.Columns.Add(button);
                }
            }
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDepartment.Columns["action"].Index)
            {
                int department_id = Convert.ToInt32(dgvDepartment.Rows[dgvDepartment.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}
