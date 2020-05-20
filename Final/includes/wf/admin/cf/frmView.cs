using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.wf.admin.cf
{
    public partial class frmView : Form
    {
        public string machine_name { get; set; }
        public string ip_address { get; set; }

        classes.Remote remote;

        public frmView()
        {
            InitializeComponent();
            remote = new classes.Remote();

            machine_name = remote.machine_name;
            ip_address = remote.ip_address;
            lblLiveView.Text = machine_name + ": " + ip_address;
        }

        public void start_capturing()
        {
            timerDisplayScreenCapture.Start();
        }

        public void stop_capturing()
        {
            timerDisplayScreenCapture.Stop();
        }

        private void timerDisplayScreenCapture_Tick(object sender, EventArgs e)
        {
            display_image();
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                Bitmap bitmap = ImageScreenshot(pbLiveView);
                sfd.Title = "Select folder";
                sfd.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    bitmap.Save(sfd.FileName);
                }
            }
        }

        private static Bitmap ImageScreenshot(Control control)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            Graphics graphic = Graphics.FromImage(bitmap);
            Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
            graphic.CopyFromScreen(rect.Location, Point.Empty, control.Size);
            return bitmap;
        }

        private void display_image()
        {
            Byte[] screen_capture = remote.select_computer_unit_image();
            pbLiveView.Image = Image.FromStream(new MemoryStream(screen_capture));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
