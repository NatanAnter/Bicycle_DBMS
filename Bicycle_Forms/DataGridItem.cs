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

    public partial class DataGridItem : Form
    {
        string State;
        List<Item> IS;
        public DataGridItem()
        {
            InitializeComponent();
            IS = Item.SelectAllItems();
            this.dataGrid_Item.DataSource = IS;
            State = "Item";
            Translate();
        }
        public DataGridItem(string str)
        {
            InitializeComponent();
            if (str == "Orders")
            {
                State = "Order";
                IS = Item.SelectAllOrders();
                this.Text = "Items you need to order";
            }
            else
            {
                IS = Item.SelectAllItems();
                State = "Item";
            }
            this.dataGrid_Item.DataSource = IS;
            Translate();
        }

        private void Translate()
        {
            if (AccountWin.isHebrow)
            {
                if (State == "Item")
                    this.Text = "פריטים";
                else if (State == "Order")
                    this.Text = "פריטים שאתה צריך להזמין";
                this.dataGrid_Item.Columns[0].HeaderCell.Value = "ברקוד";
                this.dataGrid_Item.Columns[1].HeaderCell.Value = "שם";
                this.dataGrid_Item.Columns[2].HeaderCell.Value = "מחיר";
                this.dataGrid_Item.Columns[3].HeaderCell.Value = "עלות";
                this.dataGrid_Item.Columns[4].HeaderCell.Value = "כמות";
                this.dataGrid_Item.Columns[5].HeaderCell.Value = "מינימום";
                this.generateNewItemToolStripMenuItem.Text = "ייצר פריט";
                this.showAllSaleDaysToolStripMenuItem.Text = " כל המכירות";
                this.btnDeleteItem.Text = "מחיקה";
                this.btnInsert.Text = "הוספה";
                this.btnUpdate.Text = "עדכון";
                this.serchToolStripMenuItem.Text = "חיפוש";
                this.serchBarcodeToolStripMenuItem.Text = "חפש ברקוד";
                this.serchNameToolStripMenuItem.Text = "חפש שם";
                this.startingInToolStripMenuItem.Text = "מתחיל ב";
                this.hasToolStripMenuItem.Text = "מכיל";
                this.serchPriceToolStripMenuItem.Text = "מחיר";
                this.serchCostStripMenuItem.Text = "עלות";
                this.serchAmountToolStripMenuItem.Text = "כמות";
                this.serchMinToolStripMenuItem.Text = "מינ' כמות";
                this.refreshToolStripMenuItem.Text = "רענן";
                this.toOrderToolStripMenuItem.Text = "להזמנה";
                this.allItemsToolStripMenuItem.Text = "איפוס";
                this.seeSalesDayToolStripMenuItem.Text = "טבלת מכירות";
            }
        }

        protected void UpdateDataGrid(object sender, FormClosedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            if (State == "Order")
                IS = Item.SelectAllOrders();
            else
                IS = Item.SelectAllItems();
            this.dataGrid_Item.DataSource = IS;
            this.dataGrid_Item.Show();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Form InsertItem = new InsertItem(null);
            InsertItem.FormClosed += UpdateDataGrid;
            InsertItem.Show();
        }


        protected void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (IS.Count == 0)
            {
                if (AccountWin.isHebrow)
                    MessageBox.Show("בחר פריט תחילה");
                else
                    MessageBox.Show("Please select item First");
                return;
            }
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
                    int i = this.dataGrid_Item.SelectedCells[0].RowIndex;
                    Item I = this.IS[i];
                    I.DeleteItem();
                    UpdateDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IS.Count == 0)
                {
                    if (AccountWin.isHebrow)
                        MessageBox.Show("בחר פריט תחילה");
                    else
                        MessageBox.Show("Please select item First");
                    return;
                }
                int i = this.dataGrid_Item.SelectedCells[0].RowIndex;
                Item I = this.IS[i];
                Form update = new InsertItem(I);
                update.FormClosed += UpdateDataGrid;
                update.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void showAllSaleDaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int i = this.dataGrid_Item.SelectedCells[0].RowIndex;
                Item I = this.IS[i];
                if (AccountWin.isSingIn)
                {
                    Form saleSaleDG = new DataGridSaleDays(I);
                    saleSaleDG.Show();
                }
                else
                {
                    Form form = new singIn(singIn.ToOpen.saleDays, I);
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex);
            }
        }

        private void generateNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 1;
            while (Item.SelectItem(x.ToString()) != null)
                x++;
            string barcode = x.ToString();
            Item i = Item.SelectItem(x.ToString());
            Form InsertItem = new InsertItem(x.ToString(), true);
            InsertItem.FormClosed += UpdateDataGrid;
            InsertItem.Show();

        }

        private void serchBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SerchBox.Text != "")
            {
                IS = Item.SelectAllOrdersByBarcode(this.SerchBox.Text);
                this.dataGrid_Item.DataSource = IS;
                this.dataGrid_Item.Show();
            }
        }

        private void startingInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SerchBox.Text != "")
            {
                IS = Item.SelectAllOrdersByNameStarting(this.SerchBox.Text);
                this.dataGrid_Item.DataSource = IS;
                this.dataGrid_Item.Show();
            }
        }

        private void hasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SerchBox.Text != "")
            {
                IS = Item.SelectAllOrdersByNameHas(this.SerchBox.Text);
                this.dataGrid_Item.DataSource = IS;
                this.dataGrid_Item.Show();
            }
        }

        private void serchPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SerchBox.Text != "")
            {
                IS = Item.SelectAllOrdersByPrice(this.SerchBox.Text);
                this.dataGrid_Item.DataSource = IS;
                this.dataGrid_Item.Show();
            }
        }

        private void serchCostStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SerchBox.Text != "")
            {
                IS = Item.SelectAllOrdersByCost(this.SerchBox.Text);
                this.dataGrid_Item.DataSource = IS;
                this.dataGrid_Item.Show();
            }
        }

        private void serchAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SerchBox.Text != "")
            {
                IS = Item.SelectAllOrdersByAmount(this.SerchBox.Text);
                this.dataGrid_Item.DataSource = IS;
                this.dataGrid_Item.Show();
            }
        }

        private void serchMinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SerchBox.Text != "")
            {
                IS = Item.SelectAllOrdersByMin(this.SerchBox.Text);
                this.dataGrid_Item.DataSource = IS;
                this.dataGrid_Item.Show();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }
        private void noGerash(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == '\'') || (e.KeyChar == '"');
        }

        private void toOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                State = "Order";
                UpdateDataGrid();
                Translate();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void allItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State = "Item";
            UpdateDataGrid();
            Translate();
        }

        private void seeSalesDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new DataGridAllSales();
            form.Show();
        }
    }
}
