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
    public partial class InsertRepair : Form
    {
        private bool IsInsert;
        public InsertRepair()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public InsertRepair(Repairs r)
        {
            InitializeComponent();
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            if (r == null)
            {
                IsInsert = true;
                int x = 1;
                while (Repairs.SelectRepair(x) != null)
                    x++;
                this.textBox_Barcode.Text = x.ToString();
            }
            else
            {
                this.textBox_Barcode.Text = r.Repair_Num.ToString();
                this.textBox_Barcode.ReadOnly = true;
                this.dateTimePicker1.Text = Repairs.GetDateorPicker(r.Repair_Num);
                this.textBox_Name.Text = r.Name;
                this.textBoxCost.Text = r.Phone_Num.ToString();
                this.textBox_Ammount.Text = r.Description;
            }
            if (AccountWin.isHebrow)
            {
                this.comboBox1.Items.Add("בתהליך");
                this.comboBox1.Items.Add("בוצע");
            }
            else
            {
                this.comboBox1.Items.Add("In Process");
                this.comboBox1.Items.Add("Done");
            }
            UpdateNames();
        }
        private void UpdateNames()
        {
            if (AccountWin.isHebrow)
            {
                if (IsInsert)
                {
                    this.Text = "הוספת תיקון";
                    this.btnInsert.Text = "הוסף";
                }
                else
                {
                    this.Text = "עדכון תיקון";
                    this.btnInsert.Text = "עדכן";
                }
                this.label1.Text = "מספר תיקון";
                this.label2.Text = "שם";
                this.label3.Text = "תאריך";
                this.label4.Text = "מספר טלפון";
                this.label5.Text = "תיאור";
                this.label6.Text = "סטטוס";
                this.btnCancel.Text = "ביטול";
            }
           /* else
            {
                if (IsInsert)
                {
                    this.Text = "Insert Repair";
                    this.btnInsert.Text = "Insert";
                }
                else
                {
                    this.Text = "Update Repair";
                    this.btnInsert.Text = "Update";
                }
                this.label1.Text = "Repair Number";
                this.label2.Text = "Name";
                this.label3.Text = "Date";
                this.label4.Text = "phone Number";
                this.label5.Text = "Description";
                this.label6.Text = "Status";
                this.btnCancel.Text = "Cancle";
            }*/
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

        private bool IsExist(int repairNum)
        {
            Repairs r = Repairs.SelectRepair(repairNum);
            return r != null;
        }

        private Repairs GetData()
        {
            bool status = false;
            if (this.comboBox1.Text == "Done"|| this.comboBox1.Text == "בוצע") 
                    status = true;
            Repairs i = new Repairs(int.Parse(this.textBox_Barcode.Text), this.dateTimePicker1.Value.ToString("yyyyMMdd"), this.textBox_Name.Text, this.textBoxCost.Text,
               this.textBox_Ammount.Text,status);
            if (i == null)
                IsInsert = true;
            return i;
        }
        

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                bool d = IsExist(int.Parse(this.textBox_Barcode.Text));
                if (IsInsert && d)
                {
                    if (AccountWin.isHebrow)
                        MessageBox.Show("מספר התיקון כבר קיים");
                    else
                        MessageBox.Show("Repair Number is already exist");
                    return;
                }

                Repairs i = GetData();
                bool x;
                if (this.IsInsert)
                    x = i.Insert();
                else
                    x = i.Update();
                if (x)
                {
                    if (AccountWin.isHebrow)
                        MessageBox.Show("בוצע");
                    else
                        MessageBox.Show("Success");
                    this.Close();
                }
                else
                    MessageBox.Show("Error 13");
            }
            catch (Exception ex)
            {
                if (AccountWin.isHebrow)
                    MessageBox.Show("כל השדות חייבים להיות מלאים");
                else
                    MessageBox.Show("you cannot have null values \n" + ex);
            }

        }

    }
}
