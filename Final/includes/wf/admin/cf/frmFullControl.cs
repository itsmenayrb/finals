using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MSTSCLib;

namespace Final.includes.wf.admin.cf
{
    public partial class frmFullControl : Form
    {
        public string ip_address { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public frmFullControl()
        {
            InitializeComponent();
        }

        public void remote_session()
        {
            try
            {
                rdp.Server = ip_address;
                rdp.UserName = username;
                MsRdpClient8NotSafeForScripting secured = (MsRdpClient8NotSafeForScripting)rdp.GetOcx();
                secured.AdvancedSettings8.ClearTextPassword = password;
                secured.AdvancedSettings8.EnableCredSspSupport = true;
                secured.ColorDepth = 24;
                secured.AdvancedSettings8.SmartSizing = true;
                secured.DesktopHeight = Screen.PrimaryScreen.Bounds.Height;
                secured.DesktopWidth = Screen.PrimaryScreen.Bounds.Width;
                rdp.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
