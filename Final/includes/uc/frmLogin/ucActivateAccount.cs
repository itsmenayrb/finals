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
    public partial class ucActivateAccount : UserControl
    {
        private bool hasError = false;
        classes.Register register;

        public string username { get; set; }

        public ucActivateAccount()
        {
            InitializeComponent();
            register = new classes.Register();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (txtNewPassword.Text == "New Password" || string.IsNullOrEmpty(txtNewPassword.Text))
            {
                hasError = true;
                MessageBox.Show("Please enter your new password.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Focus();
                return;
            }
            else
            {
                if (txtConfirmPassword.Text == "Confirm Password" || string.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    hasError = true;
                    MessageBox.Show("Please confirm your password.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmPassword.Focus();
                    return;
                }
                else
                {
                    if (register.checkCharacterLength(txtNewPassword.Text) == false)
                    {
                        hasError = true;
                        MessageBox.Show("Password must be at least 8-32 characters long.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNewPassword.Focus();
                        return;
                    }
                    else
                    {
                        if (register.checkLowercase(txtNewPassword.Text) == false)
                        {
                            hasError = true;
                            MessageBox.Show("Password must have at least 1 lowercase letter.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNewPassword.Focus();
                            return;
                        }
                        else
                        {
                            if (register.checkUppercase(txtNewPassword.Text) == false)
                            {
                                hasError = true;
                                MessageBox.Show("Password must have at least 1 uppercase letter.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtNewPassword.Focus();
                                return;
                            }
                            else
                            {
                                if (register.checkDigit(txtNewPassword.Text) == false)
                                {
                                    hasError = true;
                                    MessageBox.Show("Password must have at least 1 numeric value.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtNewPassword.Focus();
                                    return;
                                }
                                else
                                {
                                    if (register.checkSymbol(txtNewPassword.Text) == false)
                                    {
                                        hasError = true;
                                        MessageBox.Show("Password must have at least 1 special characters.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtNewPassword.Focus();
                                        return;
                                    }
                                    else
                                    {
                                        if (txtNewPassword.Text != txtConfirmPassword.Text)
                                        {
                                            hasError = true;
                                            MessageBox.Show("Password did not match.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtConfirmPassword.Focus();
                                            return;
                                        }
                                        else
                                        {
                                            if (hasError == false)
                                            {
                                                register.username = txtUsername.Text;
                                                register.password = txtNewPassword.Text;
                                                register.status = 1;

                                                if (register.activate_account())
                                                {
                                                    MessageBox.Show("You have successully activated your account! Please log-in using your new password.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "New Password")
            {
                txtNewPassword.Text = "";
                txtNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                txtNewPassword.Text = "New Password";
                txtNewPassword.UseSystemPasswordChar = false;
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

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtNewPassword.Text;
            lblEightRule.ForeColor = register.checkCharacterLength(password) ? Color.FromArgb(47, 97, 72) : Color.Orange;
            lblLowerRule.ForeColor = register.checkLowercase(password) ? Color.FromArgb(47, 97, 72) : Color.Orange;
            lblUpperRule.ForeColor = register.checkUppercase(password) ? Color.FromArgb(47, 97, 72) : Color.Orange;
            lblDecimalRule.ForeColor = register.checkDigit(password) ? Color.FromArgb(47, 97, 72) : Color.Orange;
            lblSpecialRule.ForeColor = register.checkSymbol(password) ? Color.FromArgb(47, 97, 72) : Color.Orange;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Going back will keep your account in-active. Go back?", "Activate Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                username = "";
                Final.frmLogin.instance.Controls["panelContainer"].Controls["ucRegister1"].Visible = false;
                Final.frmLogin.instance.Controls["panelContainer"].Controls["ucLogin1"].Visible = true;
                Final.frmLogin.instance.Controls["panelContainer"].Controls["ucActivateAccount1"].Visible = false;
            }
        }
    }
}
