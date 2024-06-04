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
    public partial class DataGridAllSales : Form
    {
        List<AllSales> ASS;
        public DataGridAllSales()
        {
            InitializeComponent();
        }
        private void Apply_Click(object sender, EventArgs e)
        {
            try
            {
                string Date = this.dateTimePicker1.Value.ToString("yyyyMMdd");
                ASS = AllSales.SelectAllSales(Date);
                dataGridView1.DataSource = ASS;
                dataGridView1.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error/n"+ex);
            }
            
        }
    }
}
