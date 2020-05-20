using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace Final.includes.uc.frmDashboard.admin.cf
{
    public partial class ucComputers : UserControl
    {
        public static ucComputers instance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        classes.Remote remote;

        PictureBox pb;
        Panel pnl;
        Label lbl;
        ToolTip tooltip;
        FlowLayoutPanel flpRemoteManagement;

        private int panelWidth = 250;
        private int panelHeight = 270;
        private int pictureBoxWidth = 250;
        private int pictureBoxHeight = 250;

        Font font = new Font("Century Gothic", 9, FontStyle.Bold);

        private bool list = false;

        public ucComputers()
        {
            instance = this;
            InitializeComponent();
            classes.Database database = new classes.Database();
            this.connectionString = database.dbConnection();

            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            flpRemoteManagement = new FlowLayoutPanel();
        }

        private void btnFacilitateLecture_Click(object sender, EventArgs e)
        {
            facilitate_lecture();
        }

        private void btnSelectDisplay_Click(object sender, EventArgs e)
        {
            cmsSelectDisplay.Show(btnSelectDisplay, new Point(-115, btnSelectDisplay.Height + 5));
        }

        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cmsRemoteManagement.Show(Cursor.Position);
                remote = new classes.Remote();
                remote.machine_name = pb.Name;
                remote.select_computer_unit();
            }
        }

        private void viewOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perform_live_view();
        }

        private void fullControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perform_remote_session();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perform_restart();
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perform_shutdown();
        }

        private void pingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perform_ping();
        }

        private void viewSpecificationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detailViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display_detailed_view();
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display_small_icon();
        }

        private void mediumIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display_medium_icon();
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display_large_icon();
        }

        private void select_computer_facility()
        {
            string status = string.Empty;

            try
            {
                flpRemoteManagement.Size = new Size(946, 437);
                flpRemoteManagement.Location = new Point(28, 57);
                flpRemoteManagement.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left;
                flpRemoteManagement.Controls.Clear();

                classes.Configuration.SetDoubleBuffered(flpRemoteManagement);

                query = "SELECT ComputerUnit.type, ComputerUnit.status, ComputerUnit.screen_capture, MachineInformation.machine_name, MachineInformation.ip_address, MachineInformation.port, " +
                            "MachineInformation.mac_address, Department.department_name, ComputerUnit.user_fullname " +
                        "FROM ComputerUnit " +
                        "INNER JOIN MachineInformation ON ComputerUnit.machineinformation_id = MachineInformation.id " +
                        "INNER JOIN Department ON ComputerUnit.department_id = Department.id " +
                        "WHERE ComputerUnit.type!=@type";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@type", "Server");
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            status = reader["status"].ToString();

                            pnl = new Panel();
                            pnl.Size = new System.Drawing.Size(panelWidth, panelHeight);

                            pb = new PictureBox();
                            pb.Size = new Size(pictureBoxWidth, pictureBoxHeight);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Dock = DockStyle.Top;
                            pb.Name = reader["machine_name"].ToString();
                            pb.MouseDown += new MouseEventHandler(this.pb_MouseDown);

                            pb.Image = (status == "Idle") ?
                                            Resource1.idle_computer :
                                       (status == "Connected") ?
                                            switchEnableLiveView.Checked ?
                                                Image.FromStream(new MemoryStream((Byte[])reader["screen_capture"])) :
                                                Resource1.online_computer :
                                       Resource1.offline_computer;

                            lbl = new Label();
                            lbl.Text = reader["machine_name"].ToString();
                            lbl.AutoSize = false;
                            lbl.Dock = DockStyle.Fill;
                            lbl.Font = font;
                            lbl.TextAlign = ContentAlignment.MiddleCenter;

                            pnl.Controls.Add(lbl);
                            pnl.Controls.Add(pb);

                            tooltip = new ToolTip();
                            tooltip.AutoPopDelay = 5000;
                            tooltip.InitialDelay = 500;
                            tooltip.ReshowDelay = 500;
                            tooltip.SetToolTip(pb, "Machine name: " + reader["machine_name"].ToString() + "\n" +
                                                    "Status: " + reader["status"].ToString() + "\n" +
                                                    "IP address: " + reader["ip_address"].ToString() + "\n" +
                                                    "Port: " + reader["port"].ToString() + "\n" +
                                                    "Mac address: " + reader["mac_address"].ToString() + "\n" +
                                                    "-\n" +
                                                    "Current user: " + reader["user_fullname"].ToString() + "\n" +
                                                    "Room: " + reader["department_name"].ToString()
                                                    );

                            flpRemoteManagement.Controls.Add(pnl);
                        }
                    }
                    conn.Close();
                    this.Controls.Add(flpRemoteManagement);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading computer facility: " + ex.Message, "Computer Facility", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void start_server()
        {
            timerLoadPC.Start();
        }

        public void stop_server()
        {
            timerLoadPC.Stop();
        }

        public void perform_live_view()
        {
            stop_server();
            includes.wf.admin.cf.frmView frmView = new wf.admin.cf.frmView();
            frmView.ShowDialog();
            frmView.start_capturing();
        }

        public void perform_remote_session()
        {
            stop_server();
            includes.wf.admin.cf.frmFullControl frmFullControl = new wf.admin.cf.frmFullControl();
            frmFullControl.ShowDialog();
            frmFullControl.remote_session();
        }

        public void perform_restart()
        {
            string ip_address = remote.ip_address;
            string machine_name = remote.machine_name;

            try
            {
                DialogResult result = MessageBox.Show("Do you want to restart " + machine_name + " PC?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var shutdown = new ProcessStartInfo("shutdown", " /r /m " + ip_address + " /c " + "\"The Administrator has initiated a remote restart on your computer. Your computer will restart after 30 seconds. Please save your work.\"" + " /t 30");
                    shutdown.CreateNoWindow = true;
                    shutdown.UseShellExecute = false;
                    Process.Start(shutdown);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on restarting remote pc: " + ex.Message);
            }
        }

        public void perform_shutdown()
        {
            string ip_address = remote.ip_address;
            string machine_name = remote.machine_name;

            try
            {
                DialogResult result = MessageBox.Show("Do you want to shutdown " + machine_name + " PC?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var shutdown = new ProcessStartInfo("shutdown", " /s /m " + ip_address + " /c " + "\"The Administrator has initiated a remote restart on your computer. Your computer will shutdown after 30 seconds. Please save your work.\"" + " /t 30");
                    shutdown.CreateNoWindow = true;
                    shutdown.UseShellExecute = false;
                    Process.Start(shutdown);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on shutdown remote pc: " + ex.Message);
            }
        }

        public void perform_ping()
        {
            string ip_address = remote.ip_address;

            try
            {
                var shutdown = new ProcessStartInfo("cmd.exe", " /c ping " + ip_address + " -t");
                shutdown.CreateNoWindow = false;
                shutdown.UseShellExecute = false;
                Process.Start(shutdown);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on pinging remote pc: " + ex.Message);
            }
        }

        private void display_detailed_view()
        {
            list = true;
            switchEnableLiveView.Enabled = false;
            detailViewToolStripMenuItem.Checked = true;
            smallIconToolStripMenuItem.Checked = false;
            mediumIconToolStripMenuItem.Checked = false;
            largeIconToolStripMenuItem.Checked = false;

            foreach (Control control in this.Controls)
            {
                if (control is FlowLayoutPanel)
                {
                    this.Controls.Remove(control);
                }
            }

            ucDetailedView1.Visible = true;
            ucDetailedView1.select_detailed_view();
        }

        private void display_small_icon()
        {
            list = false;

            switchEnableLiveView.Enabled = true;
            detailViewToolStripMenuItem.Checked = false;
            smallIconToolStripMenuItem.Checked = true;
            mediumIconToolStripMenuItem.Checked = false;
            largeIconToolStripMenuItem.Checked = false;

            panelWidth = 70;
            panelHeight = 90;
            pictureBoxWidth = 70;
            pictureBoxHeight = 70;

            font = new Font("Century Gothic", 8, FontStyle.Regular);
            select_computer_facility();
        }

        private void display_medium_icon()
        {
            list = false;

            switchEnableLiveView.Enabled = true;
            detailViewToolStripMenuItem.Checked = false;
            smallIconToolStripMenuItem.Checked = false;
            mediumIconToolStripMenuItem.Checked = true;
            largeIconToolStripMenuItem.Checked = false;

            panelWidth = 150;
            panelHeight = 170;
            pictureBoxWidth = 150;
            pictureBoxHeight = 150;

            font = new Font("Century Gothic", 8, FontStyle.Bold);
            select_computer_facility();
        }

        private void display_large_icon()
        {
            list = false;

            switchEnableLiveView.Enabled = true;
            detailViewToolStripMenuItem.Checked = false;
            smallIconToolStripMenuItem.Checked = false;
            mediumIconToolStripMenuItem.Checked = false;
            largeIconToolStripMenuItem.Checked = true;

            panelWidth = 250;
            panelHeight = 270;
            pictureBoxWidth = 250;
            pictureBoxHeight = 250;

            font = new Font("Century Gothic", 9, FontStyle.Bold);
            select_computer_facility();
        }

        private void facilitate_lecture()
        {
            remote = new classes.Remote();

            try
            {
                DialogResult res = MessageBox.Show("You are about to facilitate a lecture. This means that your screen will display to all connected user. Do you wish to proceed?", "Facilitate Lecture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    remote.send_request_to_facilitate_lecture();
                    includes.wf.admin.cf.frmLectureRespondee respondee = new wf.admin.cf.frmLectureRespondee();
                    respondee.ShowDialog();
                    respondee.start_load_client();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on facilitating lecture: " + ex.Message);
            }
        }
    }
}
