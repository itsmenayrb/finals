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
    public partial class frmAddPosition : Form
    {
        public string request_from { get; set; }
        classes.Position position;

        public frmAddPosition()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPositionName.Text))
            {
                MessageBox.Show("Please indicate the position name.", "Add Position", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPositionName.Focus();
                return;
            }
            else
            {
                if (new classes.Configuration().CheckIfExist("position_name", "Position", txtPositionName.Text))
                {
                    MessageBox.Show(txtPositionName.Text + " is already exist.", "Add Position", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPositionName.Focus();
                    txtPositionName.Text = "";
                    return;
                }
                else
                {
                    position = new classes.Position();
                    position.position_name = txtPositionName.Text;
                    position.add_position();
                    MessageBox.Show(txtPositionName.Text + " has been added.", "Add Position", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (request_from == "Add Employee")
                    {
                        wf.admin.mu.frmAddEmployee.instance.display_data();
                    }
                    else
                    {
                        frmViewPosition.instance.display_position_data();
                    }
                    this.Close();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
