using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final
{
    public partial class frmDashboard : Form
    {
        public static frmDashboard instance = null;
        classes.Remote remote;

        public frmDashboard()
        {
            instance = this;
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                panelNav.Height = panelNav.Height + 40;
                panelTop.Height = panelTop.Height + 7;
            }
            else
            {
                panelNav.Height = panelNav.Height - 40;
                panelTop.Height = panelTop.Height - 7;
            }
        }

        private void timerLectureSession_Tick(object sender, EventArgs e)
        {
            remote = new classes.Remote();
            remote.image_screen = classes.CaptureScreen.CaptureDesktopWithCursor();
            remote.insert_captured_image();
        }

        public void start_lecture()
        {
            timerLectureSession.Start();
        }

        public void end_lecture()
        {
            timerLectureSession.Stop();
        }
    }
}
