using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmLogin
{
    public partial class ucLogin : UserControl
    {
        public static ucLogin mainInstance = null;
        private bool hasError = false;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        classes.Login login;
        classes.Register register;

        public ucLogin()
        {
            mainInstance = this;
            InitializeComponent();
            classes.Database database = new classes.Database();
            this.connectionString = database.dbConnection();

            register = new classes.Register();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (string.IsNullOrEmpty(txtUsername.Text) || txtUsername.Text == "Username")
            {
                hasError = true;
                MessageBox.Show("Please enter your username.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Password")
                {
                    hasError = true;
                    MessageBox.Show("Please enter your password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtPassword.Focus();
                    return;
                }
                else
                {
                    if (hasError == false)
                    {
                        login = new classes.Login();
                        login.username = txtUsername.Text;
                        login.password = txtPassword.Text;

                        if (login.login())
                        {
                            if (login.active_account())
                            {
                                
                            }
                            else
                            {
                                register.username = txtUsername.Text;
                                MessageBox.Show("Your account is currently in-active.\nTo continue, please set-up your new password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Final.frmLogin.instance.Controls["panelContainer"].Controls["ucRegister1"].Visible = false;
                                Final.frmLogin.instance.Controls["panelContainer"].Controls["ucLogin1"].Visible = false;
                                Final.frmLogin.instance.Controls["panelContainer"].Controls["ucActivateAccount1"].Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Text = "";
                            txtPassword.Focus();
                            return;
                        }
                    }
                    else
                    {
                    }
                }
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Text = "Username";
            }
            else
            {
                txtUsername.Text = txtUsername.Text.ToUpper();
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnLogin.PerformClick();
                return true;
            }
            else if (keyData == Keys.Home)
            {
                show_register();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void show_register()
        {
            if (register.select_super_administrator() == false)
            {
                Final.frmLogin.instance.Controls["panelContainer"].Controls["ucRegister1"].Visible = true;
                Final.frmLogin.instance.Controls["panelContainer"].Controls["ucLogin1"].Visible = false;
                Final.frmLogin.instance.Controls["panelContainer"].Controls["ucActivateAccount1"].Visible = false;
            }
            else
            {
                MessageBox.Show("Creating an account for the Super Administrator has been prohibited due to any of this reasons:\n\n1)There is an existing account for Super Administrator.\n2)Creating an account for Super Administrator has been disabled.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
