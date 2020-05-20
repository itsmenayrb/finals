using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.wf.admin.cf
{
    public partial class frmLecturePlayer : Form
    {
        private bool showForm = true;
        private bool playing = true;

        classes.Remote remote;

        public frmLecturePlayer()
        {
            InitializeComponent();
            setFormLocation();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);

            remote = new classes.Remote();
        }

        private void timerToggle_Tick(object sender, EventArgs e)
        {
            if (showForm)
            {
                btnShowHide.Image = Resource1.chevron_left_50px_white;
                btnShowHide.OnHoverImage = Resource1.chevron_left_50px_white;
                this.Width = this.Width - 10;
                setFormLocation();
                if (this.Width == 40)
                {
                    timerToggle.Stop();
                    showForm = false;
                    this.Refresh();
                }

            }
            else
            {
                btnShowHide.Image = Resource1.chevron_right_50px_white;
                btnShowHide.OnHoverImage = Resource1.chevron_right_50px_white;
                this.Width = this.Width + 10;
                setFormLocation();
                if (this.Width == 290)
                {
                    timerToggle.Stop();
                    showForm = true;
                    this.Refresh();
                }

            }
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            timerToggle.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                lblStatus.Text = "Paused.";
                btnPause.Image = Resource1.resume_button_50px;
                btnPause.OnHoverImage = Resource1.resume_button_50px;
                frmDashboard.instance.end_lecture();
                playing = false;
            }
            else
            {
                lblStatus.Text = "Broadcasting...";
                btnPause.Image = Resource1.pause_50px;
                btnPause.OnHoverImage = Resource1.pause_50px;
                frmDashboard.instance.start_lecture();
                playing = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("End your lecture?", "Lecture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                remote.end_lecture();
                frmDashboard.instance.end_lecture();
                new frmLectureRespondee().dispose();
                this.Close();
            }
        }

        private void setFormLocation()
        {
            foreach (var screen in Screen.AllScreens)
            {
                if (screen.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(screen.Bounds.Right - this.Width, screen.Bounds.Top + this.Height);
                    return;
                }
            }
        }
    }
}
