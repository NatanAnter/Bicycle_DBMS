using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bicycle_DBMS;

namespace Bicycle_Forms
{
    public partial class DataGridDailyReport : Form
    {
        List<DailyReport> DRS;
        public DataGridDailyReport()
        {
            try
            {
                InitializeComponent();
                UpdateDataGrid();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void UpdateDataGrid(object sender, FormClosedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            DRS = DailyReport.SelectAllDailyReport();
            this.dataGrid_DailyReport.DataSource = DRS;
            this.dataGrid_DailyReport.Show();
            if (AccountWin.isHebrow)
            {
                this.Text = "דוח יומי";
                this.dataGrid_DailyReport.Columns[0].HeaderCell.Value = "תאריך";
                this.dataGrid_DailyReport.Columns[1].HeaderCell.Value = "הכנסות";
                this.dataGrid_DailyReport.Columns[2].HeaderCell.Value = "הוצאות";
                this.dataGrid_DailyReport.Columns[3].HeaderCell.Value = "רווח";
            }
            else
            {
                
                this.dataGrid_DailyReport.Columns[1].HeaderCell.Value = "Income";
                this.dataGrid_DailyReport.Columns[2].HeaderCell.Value = "Expense";
                this.dataGrid_DailyReport.Columns[3].HeaderCell.Value = "Profit";
            }
        }
    }
}
