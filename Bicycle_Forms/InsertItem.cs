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
    public partial class InsertItem : Form
    {
        private bool IsInsert;

        public InsertItem(Item i)
        {
            InitializeComponent();
            if (i == null) IsInsert = true;
            else
            {
                this.textBox_Barcode.Text = i.Barcode;
                this.textBox_Barcode.ReadOnly = true;
                this.textBox_Name.Text = i.Name;
                this.textBox_Price.Text = i.Price.ToString();
                this.textBox_Min.Text = i.Min.ToString();
                this.textBox_Ammount.Text = i.Amount.ToString();
                this.textBoxCost.Text = i.Cost.ToString();
            }
            UpdateNames();
        }
        private void UpdateNames()
        {
            if (AccountWin.isHebrow)
            {
                if (IsInsert)
                {
                    this.Text = "הוספת פריט";
                    this.btnInsert.Text = "הוסף";
                }
                else
                {
                    this.Text = "עדכון פריט";
                    this.btnInsert.Text = "עדכן";
                }
                this.label1.Text = "ברקוד";
                this.label2.Text = "שם";
                this.label3.Text = "מחיר";
                this.label4.Text = "עלות";
                this.label5.Text = "כמות";
                this.label6.Text = "מינ' כמות";
                this.btnCancel.Text = "ביטול";
            }
            else
            {
                if (IsInsert)
                {
                    this.Text = "Insert Item";
                    this.btnInsert.Text = "Insert";
                }
                else
                {
                    this.Text = "Update Item";
                    this.btnInsert.Text = "Update";
                }
                this.label1.Text = "Barcode";
                this.label2.Text = "Name";
                this.label3.Text = "Price";
                this.label4.Text = "Cost";
                this.label5.Text = "Amount";
                this.label6.Text = "Minimum ";
                this.btnCancel.Text = "Cancle";
            }
        }
        public InsertItem(string barcode, bool isInsert)
        {
            InitializeComponent();
            this.textBox_Barcode.Text = barcode;
            IsInsert = isInsert;
            UpdateNames();
        }

        private bool IsExistBarcode(string barcode)
        {
            Item i = Item.SelectItem(barcode);
            return i != null;
        }

        private Item GetData()
        {
            Item i = new Item(this.textBox_Barcode.Text, this.textBox_Name.Text, double.Parse(this.textBox_Price.Text),
              double.Parse(this.textBoxCost.Text), int.Parse(this.textBox_Ammount.Text), int.Parse(this.textBox_Min.Text));
            if (i == null)
                IsInsert = true;
            return i;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsInsert && IsExistBarcode(this.textBox_Barcode.Text))
                {
                    if (AccountWin.isHebrow)
                        MessageBox.Show("ברקוד כבר קיים");
                    else
                        MessageBox.Show("Barcode already exist");
                    return;
                }

                Item i = GetData();
                bool x;
                if (this.IsInsert)
                    x = i.InsertItem();
                else
                    x = i.UpdateItem();
                if (x)
                {
                    if (AccountWin.isHebrow)
                        MessageBox.Show("בוצע");
                    else
                        MessageBox.Show("Success");
                    this.Close();
                }
                else
                    MessageBox.Show("Error ");
            }
            catch (Exception)
            {
                if (AccountWin.isHebrow)
                    MessageBox.Show("כל השדות צריכים להיות מלאים");
                else
                    MessageBox.Show("you cannot have null values");
            }
            
        }
        private void int_Barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void double_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') || (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }
        private void noGerash(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == '\'') || (e.KeyChar == '"');
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
