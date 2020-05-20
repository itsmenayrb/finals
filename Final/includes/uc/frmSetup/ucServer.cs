using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Final.includes.uc.frmSetup
{
    public partial class ucServer : UserControl
    {
        public static ucServer mainInstance = null;
        private bool hasError = false;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        classes.Setup setup;
        classes.Department department;

        public ucServer()
        {
            mainInstance = this;
            InitializeComponent();
            classes.Database database = new classes.Database();
            this.connectionString = database.dbConnection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Final.frmSetup.instance.Controls["panelContainer"].Controls["ucInstallationType1"].Visible = true;
            Final.frmSetup.instance.Controls["panelContainer"].Controls["ucServer1"].Visible = false;
        }

        public void start_scanning()
        {
            backgroundWorker1.RunWorkerAsync();
            btnBack.Cursor = Cursors.No;
            lblProgressBarText.Text = "Please wait while we prepare to scan your machine.";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (string.IsNullOrEmpty(txtLocation.Text) || txtLocation.Text == "Location")
            {
                hasError = true;
                MessageBox.Show("Please indicate the location you want to install this application.", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || txtUsername.Text == "Username")
                {
                    hasError = true;
                    MessageBox.Show("Please indicate the username of this machine.", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Password")
                    {
                        hasError = true;
                        MessageBox.Show("Please indicate the password of this machine.", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Focus();
                    }
                    else
                    {
                        if (hasError == true)
                        {
                            MessageBox.Show("We cannot process your request at this time. Please try again later.", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            department = new classes.Department();
                            department.department_name = txtLocation.Text;

                            if (department.select_department())
                            {
                                MessageBox.Show("The server is already installed in this department.", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtLocation.Text = "";
                                txtLocation.Focus();
                                return;
                            }
                            else
                            {
                                department.add_department();

                                setup = new classes.Setup();
                                setup.machine_name = txtMachineName.Text;
                                setup.ip_address = txtIPAddress.Text;
                                setup.mac_address = txtMACAddress.Text;
                                setup.username = txtUsername.Text;
                                setup.password = txtPassword.Text;
                                setup.department_id = department.select_department_id();

                                setup.port = 8888;
                                setup.status = "Idle";
                                setup.type = "Server";

                                if (setup.select_machine_name())
                                {
                                    MessageBox.Show("This machine is already installed.", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                else
                                {
                                    if (setup.select_ip_address())
                                    {
                                         MessageBox.Show("The ip address is been using by another computer. To avoid conflict, please change your ip address.", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                         return;
                                    }
                                    else
                                    {
                                        setup.add_local_account_information();
                                        setup.add_machine_information();
                                        setup.add_computer_unit();
                                        MessageBox.Show("Server has been set-up!", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        setup.add_directory();


                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                backgroundWorker1.ReportProgress(i);
                Thread.Sleep(100);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarSetup.Value = e.ProgressPercentage;
            if (progressBarSetup.Value == 25)
            {
                lblProgressBarText.Text = "Getting Machine Name information...";
            }
            else if (progressBarSetup.Value == 50)
            {
                txtMachineName.Text = Environment.MachineName.ToString();
                lblProgressBarText.Text = "Capturing IP Address...";
            }
            else if (progressBarSetup.Value == 75)
            {
                txtIPAddress.Text = GetLocalIPv4();
                lblProgressBarText.Text = "Capturing MAC Address...";
            }
            else if (progressBarSetup.Value == 100)
            {
                txtMACAddress.Text = GetMacAddress().ToString();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblProgressBarText.Text = "All necessary information was captured. Please fill-up remaining required fields.";
            txtLocation.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            btnFinish.Enabled = true;

            txtLocation.Focus();
            btnBack.Enabled = true;
            btnBack.Cursor = Cursors.Default;
        }

        private static string GetLocalIPv4()
        {
            UnicastIPAddressInformation _mostSuitableIp = null;

            var _networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (var _network in _networkInterfaces)
            {
                if (_network.OperationalStatus != OperationalStatus.Up)
                    continue;

                var properties = _network.GetIPProperties();

                if (properties.GatewayAddresses.Count == 0)
                    continue;

                foreach (var _address in properties.UnicastAddresses)
                {
                    if (_address.Address.AddressFamily != AddressFamily.InterNetwork)
                        continue;

                    if (IPAddress.IsLoopback(_address.Address))
                        continue;

                    if (!_address.IsDnsEligible)
                    {
                        if (_mostSuitableIp == null)
                            _mostSuitableIp = _address;
                        continue;
                    }

                    // The best IP is the IP got from DHCP server
                    if (_address.PrefixOrigin != PrefixOrigin.Dhcp)
                    {
                        if (_mostSuitableIp == null || !_mostSuitableIp.IsDnsEligible)
                            _mostSuitableIp = _address;
                        continue;
                    }

                    return _address.Address.ToString();
                }
            }

            return _mostSuitableIp != null
                ? _mostSuitableIp.Address.ToString()
                : "";
        }

        public static PhysicalAddress GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress();
                }
            }
            return null;
        }

        private void txtLocation_Enter(object sender, EventArgs e)
        {
            if (txtLocation.Text == "Location")
            {
                txtLocation.Text = "";
            }
        }

        private void txtLocation_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocation.Text))
            {
                txtLocation.Text = "Location";
            }
            else
            {
                txtLocation.Text = txtLocation.Text.ToUpper();
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnFinish.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
