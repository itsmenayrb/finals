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
    public partial class frmLogin : Form
    {
        public static frmLogin instance = null;

        public frmLogin()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
    }
}
