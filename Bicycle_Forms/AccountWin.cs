using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bicycle_DBMS;
using System.Data.SqlClient;


namespace Bicycle_Forms
{

    public partial class AccountWin : Form
    {
        List<Account> AS;
        const string NEW_SHEKEL_SIGN = "\u20AA";
        public double totalPayment = 0;
        public double totalExpense = 0;
        public static bool isHebrow = true;
        public static bool isSingIn = false;
        public AccountWin()
        {
            InitializeComponent();
            try
            {
                AS = Account.SelectAllFromAcoount();
                this.dataGrid_Account.DataSource = AS;
                try
                {
                    RestoreTotalPayment();
                }
                catch
                {
                    MessageBox.Show("לא מצליח להתחבר ל database");
                }
                UpdateNames();
            }
            catch {}
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string barcode = BarcodeText.Text;
            try
            {
                if (Account.IsExsist(barcode))
                {
                    Account a = Account.SelectFromAccount(barcode);
                    a.Amount++;
                    Account.SelectFromAccount(barcode).DeleteFromAccount();
                    a.InsertToAccount();
                    totalPayment += a.Price;
                    UpdateTotalPayment();
                    UpdateDataGrid();
                }
                else
                {
                    Item i = Item.SelectItem(barcode);
                    if (i == null)
                    {
                        if (barcode == "")
                            return;
                        string t0 = "Do you want to add it?";
                        string t1 = "Item not found";
                        if (AccountWin.isHebrow)
                        {
                            t0 = "האם תרצה להוסיף אותו";
                            t1 = "פריט לא נמצא";
                        }
                        DialogResult dialogResult = MessageBox.Show(t0, t1, MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Form InsertItem = new InsertItem(barcode, true);
                            InsertItem.FormClosed += UpdateDataGrid;
                            InsertItem.Show();
                        }
                        return;
                    }
                    string MyBrcode = i.Barcode;
                    string MyName = i.Name;
                    double MyPrice = i.Price;
                    int MyAmmount = 1;
                    Account temp = new Account(MyBrcode, MyName, MyPrice, MyAmmount);
                    temp.InsertToAccount();
                    totalPayment += temp.Price;
                    UpdateTotalPayment();
                    UpdateDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int i = this.dataGrid_Account.SelectedCells[0].RowIndex;
                Account a = this.AS[i];
                totalPayment -= (double)a.Price * a.Amount;
                UpdateTotalPayment();
                a.DeleteFromAccount();
                UpdateDataGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            try
            {
                totalPayment = Math.Round(totalPayment * 10) / 10;
                MessageBox.Show(NEW_SHEKEL_SIGN + totalPayment);
                Program.Reports = DailyReport.RestoreDailyReport();
                Program.Reports.AddToProfit(totalPayment, Item.GetTotalExpense(AS));
                if (!Program.Reports.UpdateDailyReport())
                {
                    Program.Reports.InsertDailyReport();
                }
                int y = SaleDay.AddSales(AS, DateTime.Now);
                int x = Item.SubtractFromItems(AS);
                Account.DeleteAllFromAccount();
                UpdateDataGrid();
                ResetTotalPayment();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex);
            }

        }

        private void BtnCancelWholeSale_Click(object sender, EventArgs e)
        {
            string t0 = "you will remove all the account";
            string t1 = "Are you sure?";
            if (AccountWin.isHebrow)
            {
                t0 = "אתה תסיר את כל החשבון";
                t1 = "האם אתה בטוח?";
            }
            DialogResult dialogResult = MessageBox.Show(t0, t1, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    this.dataGrid_Account.DataSource = null;
                    Account.DeleteAllFromAccount();
                    AS = Account.SelectAllFromAcoount();
                    UpdateDataGrid();
                    ResetTotalPayment();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                isSingIn = false;
                UpdateNames();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccountWin.isHebrow)
                MessageBox.Show(" © על ידי נתן אנטר & נועם אבוטבול");
            else
                MessageBox.Show("By Natan Anter & Noam Abutbul ©");
        }

        private void UpdateDataGrid(object sender, FormClosedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            AS = Account.SelectAllFromAcoount();
            this.dataGrid_Account.DataSource = AS;
            this.dataGrid_Account.Show();
        }

        private void BtnShowItems_Click(object sender, EventArgs e)
        {
         
            try
            {
                if (isSingIn)
                {
                    Form DataGridItems = new DataGridItem();
                    DataGridItems.FormClosed += UpdateNames;
                    DataGridItems.Show();
                }
                else
                {
                    Form sing = new singIn(singIn.ToOpen.items);
                    sing.FormClosing += UpdateNames;
                    sing.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n"+ex);
            }
        }

        private void UpdateTotalPayment()
        {

            if (totalPayment > -0.01 && totalPayment < 0)
                totalPayment = 0;
            TotalPayment.Text = NEW_SHEKEL_SIGN + string.Format("{0:0.00}", totalPayment);
        }

        private void ResetTotalPayment()
        {
            totalPayment = 0;
            TotalPayment.Text = NEW_SHEKEL_SIGN + string.Format("{0:0.00}", totalPayment);
        }

        private void RestoreTotalPayment()
        {
            totalPayment = 0;
            foreach (var account in AS)
                totalPayment += account.Price * account.Amount;
            if (totalPayment != 0)
                MessageBox.Show("Graet! We managed to restore your data");
            TotalPayment.Text = NEW_SHEKEL_SIGN + string.Format("{0:0.00}", totalPayment);
        }

        private void AccountWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            string t0 = "you will lose unsaved data";
            string t1 = "Are you sure?";
            if (AccountWin.isHebrow)
            {
                t0 = "אתה תאבד נתונים לא שמורים";
                t1 = "האם אתה בטוח?";
            }
            DialogResult dialogResult = MessageBox.Show(t0, t1, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    this.dataGrid_Account.DataSource = null;
                    Account.DeleteAllFromAccount();
                    AS = Account.SelectAllFromAcoount();
                    UpdateDataGrid();
                    ResetTotalPayment();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else
                e.Cancel = true;
        }

        private void BarcodeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                ((TextBox)sender).SelectionStart = 0;
                ((TextBox)sender).SelectionLength = ((TextBox)sender).Text.Length;
                BtnAdd_Click(this, new EventArgs());
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }

        private void newDayReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Program.Reports = new DailyReport();
                if (!Program.Reports.InsertDailyReport())
                {
                    if (AccountWin.isHebrow)
                        MessageBox.Show("יום המכירות כבר קיים");
                    else
                        MessageBox.Show("this day is already existied");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        public static void setSingIn(bool isCorrect)
        {
            isSingIn = isCorrect;
        }

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isSingIn)
                {
                    Form dailyReports = new DataGridDailyReport();
                    dailyReports.Show();
                }
                else
                {
                    Form sing = new singIn(singIn.ToOpen.dailyReport);
                    sing.FormClosing += UpdateNames;
                    sing.Show();
                }
            }
            catch
            {
                MessageBox.Show("no items soled");
            }
        }

        private void translateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isHebrow = !isHebrow;
            UpdateNames();
        }

        public void UpdateNames(object sender, EventArgs e)
        {
            UpdateNames();
        }

        public void UpdateNames()
        {
            if (isHebrow)
            {
                this.Text = "חשבון";
                this.appToolStripMenuItem.Text = "אפשרויות";
                this.aboutToolStripMenuItem.Text = "מידע";
                this.translateToolStripMenuItem.Text = "תרגם";
                this.quitToolStripMenuItem.Text = "התנתק";
                this.newDayReportToolStripMenuItem.Text = "יום מכירות חדש";
                this.viewReportsToolStripMenuItem.Text = "הצג דוחות";
                this.btnAdd.Text = "הוסף";
                this.btnRemove.Text = "הסר";
                this.btnEnd.Text = "אישור";
                this.btnCancelWholeSale.Text = "ביטול";
                this.btnShowItems.Text = "הצג פריטים";
                this.btnRepairs.Text = "תיקונים";
                this.dataGrid_Account.Columns[0].HeaderCell.Value = "ברקוד";
                this.dataGrid_Account.Columns[1].HeaderCell.Value = "שם";
                this.dataGrid_Account.Columns[2].HeaderCell.Value = "מחיר";
                this.dataGrid_Account.Columns[3].HeaderCell.Value = "כמות";
                if (isSingIn)
                    this.singInToolStripMenuItem.Text = "מחובר";
                else
                    this.singInToolStripMenuItem.Text = "התחבר";

            }
            else
            {
                this.Text = "Account";
                this.appToolStripMenuItem.Text = "App";
                this.aboutToolStripMenuItem.Text = "About";
                this.translateToolStripMenuItem.Text = "Translate";
                this.quitToolStripMenuItem.Text = "Quit";
                this.newDayReportToolStripMenuItem.Text = "New Day Report";
                this.viewReportsToolStripMenuItem.Text = "View Reports";
                this.btnAdd.Text = "Add";
                this.btnRemove.Text = "Remove";
                this.btnEnd.Text = "End";
                this.btnCancelWholeSale.Text = "Cancel";
                this.btnShowItems.Text = "Show Items";
                this.btnRepairs.Text = "Show Repairs";
                this.dataGrid_Account.Columns[0].HeaderCell.Value = "Barcode";
                this.dataGrid_Account.Columns[1].HeaderCell.Value = "Name";
                this.dataGrid_Account.Columns[2].HeaderCell.Value = "Price";
                this.dataGrid_Account.Columns[3].HeaderCell.Value = "Amount";
                if (isSingIn)
                    this.singInToolStripMenuItem.Text = "connected";
                else
                    this.singInToolStripMenuItem.Text = "sing in";
            }
        }

        private void btnRepairs_Click(object sender, EventArgs e)
        {
            try
            {
                Form repair = new DataGridRepairs();
                repair.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }

        }

        private void singInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSingIn)
            {
                string t0 = "Do you want to log out?";
                string t1 = "You are already coneccted.";
                if (isHebrow)
                {
                    t0 = "האם אתה רוצה להתנתק?";
                    t1 = "אתה כבר מחובר";
                }
                DialogResult dialogResult = MessageBox.Show(t0, t1, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    isSingIn = false;
                    UpdateNames();
                }
                else
                {
                    Form sing = new singIn(singIn.ToOpen.nothing);
                    sing.FormClosed += UpdateNames;
                    sing.Show();
                }
            }
            else
            {
                Form sing = new singIn(singIn.ToOpen.nothing);
                sing.FormClosed += UpdateNames;
                sing.Show();

            }
        }
    }
}
