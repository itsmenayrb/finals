using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final.includes.uc.frmDashboard.admin.mr
{
    public partial class ucJobRequestFeedback : UserControl
    {
        public string date_responded
        {
            set { lblDateResponded.Text = value; }
            get { return lblDateResponded.Text; }
        }

        public string findings
        {
            set { lblFindings.Text = value; }
            get { return lblFindings.Text; }
        }

        public string findings_selection
        {
            set { lblFindingsSelection.Text = value; }
            get { return lblFindingsSelection.Text; }
        }

        public string action_taken
        {
            set { lblActionTaken.Text = value; }
            get { return lblActionTaken.Text; }
        }

        public string feedback
        {
            set { lblFeedback.Text = value; }
            get { return lblFeedback.Text; }
        }

        public ucJobRequestFeedback()
        {
            InitializeComponent();
        }
    }
}
