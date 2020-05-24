using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace Final.includes.uc.frmDashboard.admin.inv
{
    public partial class ucOtherInventoryInformation : UserControl
    {
        public static ucOtherInventoryInformation instance = null;
        classes.Inventory inventory;

        private DataTable inventory_department_table { get; set; }
        private DataTable inventory_report_count_table { get; set; }

        private int total = 0;
        private int working = 0;
        private int defective = 0;
        private int condemned = 0;

        public ucOtherInventoryInformation()
        {
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        public void display_inventory_information()
        {
            inventory = new classes.Inventory();
            var result = inventory.select_inventory_count();
            total = result.Item1;
            working = result.Item2;
            defective = result.Item3;
            condemned = result.Item4;

            inventory_department_table = inventory.select_inventory_per_department();
            inventory_report_count_table = inventory.select_inventory_report_count();

            display_inventory_count();
            display_inventory_per_department();
            display_inventory_report_count();
            display_ipd_chart();
            display_irc_chart();
        }

        private void display_inventory_count()
        {
            lblTotal.Text = total.ToString();
            lblWorking.Text = working.ToString();
            lblDefective.Text = defective.ToString();
            lblCondemned.Text = condemned.ToString();
        }

        private void display_inventory_per_department()
        {
            dgvItemsPerDepartment.DataSource = inventory_department_table;
            dgvItemsPerDepartment.AutoGenerateColumns = false;
        }

        private void display_inventory_report_count()
        {
            dgvMostReportedItem.DataSource = inventory_report_count_table;
            dgvItemsPerDepartment.AutoGenerateColumns = false;
        }

        private void display_ipd_chart()
        {
            SeriesCollection s = new SeriesCollection();
            foreach (DataRow row in inventory_department_table.Rows)
            {
                s.Add
                (
                    new PieSeries
                    {
                        Title = row["department_name"].ToString(),
                        Values = new ChartValues<int> { Convert.ToInt32(row["item_count"]) },
                        DataLabels = true
                    }
                );
            }
            pieChart1.Series = s;
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void display_irc_chart()
        {
            SeriesCollection s = new SeriesCollection();
            foreach (DataRow row in inventory_report_count_table.Rows)
            {
                s.Add
                (
                    new PieSeries
                    {
                        Title = row["item_name"].ToString(),
                        Values = new ChartValues<int> { Convert.ToInt32(row["report_count"]) },
                        DataLabels = true
                    }
                );
            }
            pieChart2.Series = s;
            pieChart2.LegendLocation = LegendLocation.Bottom;
        }
    }
}
