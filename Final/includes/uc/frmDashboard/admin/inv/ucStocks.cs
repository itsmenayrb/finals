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
    public partial class ucStocks : UserControl
    {
        public static ucStocks instance = null;

        classes.Inventory_Stocks stocks;
        private DataTable stocks_table { get; set; }

        SeriesCollection series;
        public int high_stocks, critical_stocks, low_stocks;

        public ucStocks()
        {
            InitializeComponent();
        }

        private void btnAddStocks_Click(object sender, EventArgs e)
        {

        }

        public void display_stocks_table()
        {
            stocks = new classes.Inventory_Stocks();
            stocks_table = stocks.select_stocks_table();
            dgvInventoryStocks.DataSource = stocks_table;
            dgvInventoryStocks.AutoGenerateColumns = false;
        }

        public void display_stocks_chart()
        {
            stocks = new classes.Inventory_Stocks();
            var result = stocks.select_stocks_chart();
            high_stocks = result.Item1;
            critical_stocks = result.Item2;
            low_stocks = result.Item3;

            pieChartStocks.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "High",
                    Values = new ChartValues<int> { high_stocks },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Critical",
                    Values = new ChartValues<int> { critical_stocks },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Low",
                    Values = new ChartValues<int> { low_stocks },
                    DataLabels = true
                }
            };

            pieChartStocks.LegendLocation = LegendLocation.Bottom;
        }
    }
}
