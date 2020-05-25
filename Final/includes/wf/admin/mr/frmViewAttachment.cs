using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.wf.admin.mr
{
    public partial class frmViewAttachment : Form
    {
        public string ticket_id { get; set; }
        private DataTable job_request_attachment_table { get; set; }
        classes.JobRequest job_request;

        PictureBox pb;

        public frmViewAttachment()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void display_attachment()
        {
            gbTicketID.Text = "Ticket ID: " + ticket_id;

            job_request = new classes.JobRequest();
            job_request_attachment_table = job_request.select_job_request_attachment(ticket_id);

            if (job_request_attachment_table.Rows.Count > 0)
            {
                foreach (DataRow row in job_request_attachment_table.Rows)
                {
                    pb = new PictureBox();
                    pb.Name = row["id"].ToString();
                    pb.Image = Image.FromStream(new MemoryStream((Byte[])row["image"]));
                    pb.Size = new Size(90, 70);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pb.Click += new System.EventHandler(this.pb_Click);
                    flpPreview.Controls.Add(pb);
                }
            }
            else
            {
                lblStatusMessage.Visible = true;
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pbImage.Image = pb.Image;
        }
    }
}
