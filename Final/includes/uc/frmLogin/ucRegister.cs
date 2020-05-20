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
    public partial class ucRegister : UserControl
    {
        private bool hasError = false;
        classes.Register register;
        
        public ucRegister()
        {
            InitializeComponent();
            register = new classes.Register();
        }

        private void btnCreateAdministrator_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (string.IsNullOrEmpty(txtUsername.Text) || txtUsername.Text == "Username")
            {
                hasError = true;
                MessageBox.Show("Please enter your username.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Password")
                {
                    hasError = true;
                    MessageBox.Show("Please enter your password.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtConfirmPassword.Text) || txtConfirmPassword.Text == "Confirm Password")
                    {
                        hasError = true;
                        MessageBox.Show("Please confirm your password.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtConfirmPassword.Focus();
                        return;
                    }
                    else
                    {
                        if (register.checkCharacterLength(txtPassword.Text) == false)
                        {
                            hasError = true;
                            MessageBox.Show("Password must be at least 8-32 characters long.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Focus();
                            return;
                        }
                        else
                        {
                            if (register.checkLowercase(txtPassword.Text) == false)
                            {
                                hasError = true;
                                MessageBox.Show("Password must have at least 1 lowercase letter.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPassword.Focus();
                                return;
                            }
                            else
                            {
                                if (register.checkUppercase(txtPassword.Text) == false)
                                {
                                    hasError = true;
                                    MessageBox.Show("Password must have at least 1 uppercase letter.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtPassword.Focus();
                                    return;
                                }
                                else
                                {
                                    if (register.checkDigit(txtPassword.Text) == false)
                                    {
                                        hasError = true;
                                        MessageBox.Show("Password must have at least 1 numeric value.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtPassword.Focus();
                                        return;
                                    }
                                    else
                                    {
                                        if (register.checkSymbol(txtPassword.Text) == false)
                                        {
                                            hasError = true;
                                            MessageBox.Show("Password must have at least 1 special characters.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtPassword.Focus();
                                            return;
                                        }
                                        else
                                        {
                                            if (txtPassword.Text != txtConfirmPassword.Text)
                                            {
                                                hasError = true;
                                                MessageBox.Show("Password did not match.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtConfirmPassword.Focus();
                                                return;
                                            }
                                            else
                                            {
                                                if (hasError == false)
                                                {
                                                    register.username = txtUsername.Text;
                                                    register.password = txtPassword.Text;
                                                    register.user_type = "Super Administrator";
                                                    register.is_logged_in = 0;
                                                    register.status = 1;

                                                    if (register.register())
                                                    {
                                                        MessageBox.Show("You have successully created an Administrator Account.\nPress OK to login.", "Create Administrator account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        Final.frmLogin.instance.Controls["panelContainer"].Controls["ucRegister1"].Visible = false;
                                                        Final.frmLogin.instance.Controls["panelContainer"].Controls["ucLogin1"].Visible = true;
                                                        Final.frmLogin.instance.Controls["panelContainer"].Controls["ucActivateAccount1"].Visible = false;
                                                    }
                                                    else
                                                    {
                                                        return;
                                                    }
                                                }
                                                else
                                                {
                                                    return;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
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

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "Confirm Password")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Text = "Confirm Password";
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            lblEightRule.ForeColor = register.checkCharacterLength(password) ? Color.FromArgb(47, 97, 72) : Color.Orange;
            lblLowerRule.ForeColor = register.checkLowercase(password) ? Color.FromArgb(47, 97, 72) : Color.Orange;
            lblUpperRule.ForeColor = register.checkUppercase(password) ? Color.FromArgb(47, 97, 72) : Color.Orange;
            lblDecimalRule.ForeColor = register.checkDigit(password) ? Color.FromArgb(47, 97, 72) : Color.Orange;
            lblSpecialRule.ForeColor = register.checkSymbol(password) ? Color.FromArgb(47, 97, 72) : Color.Orange;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "Username";
            txtPassword.Text = "Password";
            txtConfirmPassword.Text = "Confirm Password";

            Final.frmLogin.instance.Controls["panelContainer"].Controls["ucRegister1"].Visible = false;
            Final.frmLogin.instance.Controls["panelContainer"].Controls["ucLogin1"].Visible = true;
            Final.frmLogin.instance.Controls["panelContainer"].Controls["ucActivateAccount1"].Visible = false;
        }
    }
}
