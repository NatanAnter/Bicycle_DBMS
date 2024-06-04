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
    public partial class DataGridRepairs : Form
    {
        List<Repairs> RS;
        public DataGridRepairs()
        {
            InitializeComponent();
            RS = Repairs.SelectAllRepairs();
            this.dataGrid_Repair.DataSource = RS;
            Translate();
        }

        protected void UpdateDataGrid(object sender, FormClosedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            RS = Repairs.SelectAllRepairs();
            this.dataGrid_Repair.DataSource = RS;
            this.dataGrid_Repair.Show();
            Translate();
        }

        private void Translate()
        {
            if (AccountWin.isHebrow)
            {
                this.Text = "תיקונים";
                this.dataGrid_Repair.Columns[0].HeaderCell.Value = "מספר תיקון";
                this.dataGrid_Repair.Columns[1].HeaderCell.Value = "תאריך";
                this.dataGrid_Repair.Columns[2].HeaderCell.Value = "שם";
                this.dataGrid_Repair.Columns[3].HeaderCell.Value = "מס' טלפון";
                this.dataGrid_Repair.Columns[4].HeaderCell.Value = "תיאור";
                this.dataGrid_Repair.Columns[5].HeaderCell.Value = "סטטוס";
                this.btnDeleteItem.Text = "מחיקה";
                this.btnInsert.Text = "הוספה";
                this.btnUpdate.Text = "עדכון";
            }
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Form InsertRepair = new InsertRepair(null);//repair
            InsertRepair.FormClosed += UpdateDataGrid;//repair
            InsertRepair.Show();
        }

        protected void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string t0 = "This item will be deleted";
            string t1 = "Are you sure?";
            if (AccountWin.isHebrow)
            {
                t0 = "פריט זה ימחק";
                t1 = "האם אתה בטוח?";
            }
            DialogResult dialogResult = MessageBox.Show(t0, t1, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int i = this.dataGrid_Repair.SelectedCells[0].RowIndex;
                    Repairs R = this.RS[i];
                    R.DeleteRepair();
                    UpdateDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error \n"+ ex);
                }
            }
        
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int i = this.dataGrid_Repair.SelectedCells[0].RowIndex;
                Repairs R = this.RS[i];
                Form update = new InsertRepair(R);
                update.FormClosed += UpdateDataGrid;
                update.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error\n" + ex);
            }
            
        }
    }
}
