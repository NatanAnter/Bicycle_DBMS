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
    public partial class DataGridSaleDays : Form
    {
        List<SaleDay> SS { get; set; }
        Item Item { get; set; }
        public DataGridSaleDays(Item item)
        {
            InitializeComponent();
            SS = SaleDay.SelectAllSaleDays(item.Barcode);
            this.Item = item;
            this.dataGridView1.DataSource = SS;
            Translate();
        }

        private void Translate()
        {
            if (AccountWin.isHebrow)
            {
                this.Text = "ימי מכירות";
                this.dataGridView1.Columns[0].HeaderCell.Value = "ברקוד";
                this.dataGridView1.Columns[1].HeaderCell.Value = "תאריך";
                this.dataGridView1.Columns[2].HeaderCell.Value = "כמות";
                this.dataGridView1.Columns[3].HeaderCell.Value = "רווח ";
                this.dataGridView1.Columns[4].HeaderCell.Value = "הכנסות ";
                this.dataGridView1.Columns[5].HeaderCell.Value = "הוצאות ";
            }
            else
            {
                this.dataGridView1.Columns[3].HeaderCell.Value = "Profit";
                this.dataGridView1.Columns[4].HeaderCell.Value = "Income";
                this.dataGridView1.Columns[5].HeaderCell.Value = "Expense";
            }
        }

        protected void UpdateDataGrid(object sender, FormClosedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            SS = SaleDay.SelectAllSaleDays(this.Item.Barcode);
            this.dataGridView1.DataSource = SS;
            this.dataGridView1.Show();
        }
    }
}
