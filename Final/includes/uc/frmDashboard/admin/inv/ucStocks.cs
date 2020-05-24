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
using System.Windows.Forms.VisualStyles;

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
            instance = this;
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 5, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        public void display_stocks_table()
        {
            stocks = new classes.Inventory_Stocks();
            stocks_table = stocks.select_stocks_table();
            dgvInventoryStocks.DataSource = stocks_table;
            dgvInventoryStocks.AutoGenerateColumns = false;

            if ((dgvInventoryStocks.Columns.Contains("get_stock") && dgvInventoryStocks.Columns["get_stock"].Visible)
                && (dgvInventoryStocks.Columns.Contains("add_stock") && dgvInventoryStocks.Columns["add_stock"].Visible))
            {

            }
            else
            {
                DataGridViewButtonColumn get_stock = new DataGridViewButtonColumn();
                {
                    get_stock.Name = "get_stock";
                    get_stock.HeaderText = "Get Stock";
                    get_stock.Text = "Get Stock";
                    get_stock.UseColumnTextForButtonValue = true;
                    this.dgvInventoryStocks.Columns.Add(get_stock);
                }

                DataGridViewButtonColumn add_stock = new DataGridViewButtonColumn();
                {
                    add_stock.Name = "add_stock";
                    add_stock.HeaderText = "Add Stock";
                    add_stock.Text = "Add Stock";
                    add_stock.UseColumnTextForButtonValue = true;
                    this.dgvInventoryStocks.Columns.Add(add_stock);
                }

            }
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

        private void dgvInventoryStocks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInventoryStocks.Columns["get_stock"].Index)
            {
                int inventory_id = Convert.ToInt32(dgvInventoryStocks.Rows[dgvInventoryStocks.SelectedCells[0].RowIndex].Cells[0].Value.ToString());

                includes.wf.admin.inv.frmGetStocks get_stocks = new wf.admin.inv.frmGetStocks();
                get_stocks.inventory_id = inventory_id;
                get_stocks.quantity = dgvInventoryStocks.Rows[dgvInventoryStocks.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                get_stocks.ShowDialog();
            }
        }

        private void dgvInventoryStocks_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvInventoryStocks.IsCurrentCellDirty)
            {
                dgvInventoryStocks.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvInventoryStocks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInventoryStocks.Columns[e.ColumnIndex].Name == "quantity")
            {
                DataGridViewDisableButtonCell buttonCell =
                    (DataGridViewDisableButtonCell)dgvInventoryStocks.
                    Rows[e.RowIndex].Cells["get_stock"];

                int quantity = (int)dgvInventoryStocks[dgvInventoryStocks.Columns["quantity"].Index, e.RowIndex].Value;
                buttonCell.Enabled = (quantity < 1) ? true : false;

                dgvInventoryStocks.Invalidate();
            }
        }

    }

    public class DataGridViewDisableButtonCell : DataGridViewButtonCell
    {
        private bool enabledValue;
        public bool Enabled
        {
            get
            {
                return enabledValue;
            }
            set
            {
                enabledValue = value;
            }
        }

        // Override the Clone method so that the Enabled property is copied.
        public override object Clone()
        {
            DataGridViewDisableButtonCell cell =
                (DataGridViewDisableButtonCell)base.Clone();
            cell.Enabled = this.Enabled;
            return cell;
        }

        // By default, enable the button cell.
        public DataGridViewDisableButtonCell()
        {
            this.enabledValue = true;
        }

        protected override void Paint(Graphics graphics,
            Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
            DataGridViewElementStates elementState, object value,
            object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            // The button cell is disabled, so paint the border,
            // background, and disabled button for the cell.
            if (!this.enabledValue)
            {
                // Draw the cell background, if specified.
                if ((paintParts & DataGridViewPaintParts.Background) ==
                    DataGridViewPaintParts.Background)
                {
                    SolidBrush cellBackground =
                        new SolidBrush(cellStyle.BackColor);
                    graphics.FillRectangle(cellBackground, cellBounds);
                    cellBackground.Dispose();
                }

                // Draw the cell borders, if specified.
                if ((paintParts & DataGridViewPaintParts.Border) ==
                    DataGridViewPaintParts.Border)
                {
                    PaintBorder(graphics, clipBounds, cellBounds, cellStyle,
                        advancedBorderStyle);
                }

                // Calculate the area in which to draw the button.
                Rectangle buttonArea = cellBounds;
                Rectangle buttonAdjustment =
                    this.BorderWidths(advancedBorderStyle);
                buttonArea.X += buttonAdjustment.X;
                buttonArea.Y += buttonAdjustment.Y;
                buttonArea.Height -= buttonAdjustment.Height;
                buttonArea.Width -= buttonAdjustment.Width;

                // Draw the disabled button.
                ButtonRenderer.DrawButton(graphics, buttonArea,
                    PushButtonState.Disabled);

                // Draw the disabled button text.
                if (this.FormattedValue is String)
                {
                    TextRenderer.DrawText(graphics,
                        (string)this.FormattedValue,
                        this.DataGridView.Font,
                        buttonArea, SystemColors.GrayText);
                }
            }
            else
            {
                // The button cell is enabled, so let the base class
                // handle the painting.
                base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                    elementState, value, formattedValue, errorText,
                    cellStyle, advancedBorderStyle, paintParts);
            }
        }
    }
}
