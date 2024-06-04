using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Bicycle_DBMS;
using System.Data.SqlClient;

namespace Bicycle_DBMS
{
    //

    public class SaleDay
    {

        public string Barcode { get; set; }
        public string Date { get; set; }
        public int Amount { get; set; }
        public double DailyProfit { get; set; }
        public double DailyIncome { get; set; }
        public double DailyExpense { get; set; }
        public SaleDay(string barcode, string date, int quantity)
        {
            Barcode = barcode;
            Date = date;
            Amount = quantity;
        }
        public SaleDay() { }
        public bool DeletSaleBarcode()
        {
            string str = string.Format("DELETE FROM Sale WHERE {0} = {1}", "barcode", Barcode);
            return DB_Conn.ExecuteNonQuery(str) > 0;
        }
        public bool DeletSaleDate()
        {
            string str = string.Format("DELETE FROM Sale WHERE {0} = {1}", "Date", Date);
            return DB_Conn.ExecuteNonQuery(str) > 0;
        }
        public static List<SaleDay> SelectAllSaleDays(string barcode)
        {
            string str = string.Format("SELECT * FROM DailyReport AS D INNER JOIN Sale AS S ON D.Date = S.Date WHERE {0} = {1}", "Barcode", barcode);
            SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
            if (!rdr.HasRows)
            {
                rdr.Close();
                return null;
            }
            List<SaleDay> lst = new List<SaleDay>();
            while (rdr.Read()) // TODO FIX
            {
                lst.Add(new SaleDay(rdr["Barcode"].ToString(), SaleDay.GetVisualDate(DateTime.Parse(rdr["Date"].ToString())), int.Parse(rdr["Amount"].ToString())));
            }
            rdr.Close();
            foreach (var s in lst)
            {
                s.DailyProfit = DailyReport.SelectDailyReport(SearchDateYMD(s.Date)).DailyProfit;
                s.DailyIncome = DailyReport.SelectDailyReport(SearchDateYMD(s.Date)).DailyIncome;
                s.DailyExpense = DailyReport.SelectDailyReport(SearchDateYMD(s.Date)).DailyExpense;
            }
            return lst;
        }
        public static int AddSales(List<Account> AS, string date)
        {
            int count = 0;
            foreach (var account in AS)
            {
                if(SaleDay.SelectSale(account.Barcode, date) != null)
                {
                    string str = string.Format("SET DATEFORMAT YMD UPDATE {0} SET  [Amount] = {1} + {2} WHERE [Barcode] = '{3}'", "Sale", "Amount", account.Amount, account.Barcode);
                    count += DB_Conn.ExecuteNonQuery(str);
                }
                else
                {
                    string str = string.Format("SET DATEFORMAT YMD INSERT INTO Sale VALUES('{0}', '{1}', {2}); ", account.Barcode, date, account.Amount);
                    count += DB_Conn.ExecuteNonQuery(str);
                }
            }
            return count;
        }
        public static int AddSales(List<Account> AS, DateTime date)
        {
            string realDate = GetDateYMD(date);
            int count = 0;
            foreach (var account in AS)
            {
                if (SaleDay.SelectSale(account.Barcode, realDate.ToString()) != null)
                {
                    string str = string.Format("SET DATEFORMAT YMD UPDATE {0} SET  [Amount] = {1} + {2} WHERE [Barcode] = '{3}' AND [Date] = '{4}'", "Sale", "Amount", account.Amount, account.Barcode, realDate);
                    count += DB_Conn.ExecuteNonQuery(str);
                }
                else
                {
                    string str = string.Format("SET DATEFORMAT YMD INSERT INTO Sale VALUES('{0}', '{1}', {2}); ", account.Barcode, realDate, account.Amount);
                    count += DB_Conn.ExecuteNonQuery(str);
                }
            }
            return count;
        }
        public static SaleDay SelectSale(string barcode, string date)
        {
            string str = string.Format("SELECT * FROM Sale WHERE Barcode = '{0}' AND Date = '{1}';", barcode, date);
            SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
            if (!rdr.HasRows)
            {
                rdr.Close();
                return null;
            }
            rdr.Read();
            SaleDay s = new SaleDay(rdr["Barcode"].ToString(), rdr["Date"].ToString(), int.Parse(rdr["Amount"].ToString()));
            rdr.Close();
            return s;
        }
        public static string Today()
        {
            DateTime date = DateTime.Now;
            string day = date.Day.ToString("00");
            string month = date.Month.ToString("00");
            string year = date.Year.ToString();
            return string.Format("{0}{1}{2}", year, month, day);

        }

        public static string GetDateYMD(DateTime date)
        {
            string day = date.Day.ToString("00");
            string month = date.Month.ToString("00");
            string year = date.Year.ToString();
            return string.Format("{0}{1}{2}", year, month, day);

        }
        public static string GetVisualDate(DateTime date)
        {
            string day = date.Day.ToString("00");
            string month = date.Month.ToString("00");
            string year = date.Year.ToString();
            return string.Format("{0}/{1}/{2}", day, month, year);

        }
        public static string SearchDateYMD(string date)
        {
            if (date.Length > 10)
                date = date.Remove(10);
            string day = date.Remove(2);
            string month = date.Remove(0, 3);
            month = month.Remove(2);
            string year = date.Remove(0, 6);
            return string.Format("{0}{1}{2}", year, month, day);
        }
        /*public static string GetVisualDate(string date)
        {
            date = date.Remove(date.IndexOf(":")-3);
            string[] arr = date.Split("/");
            return string.Format("{0}/{1}/{2}", arr[0], arr[1], arr[2]);
        }*/
        /* public static string Today()
         {
             string date = DateTime.Now.ToString();
             return date.Remove(date.IndexOf(":")-3);
         }
         public static string GetDate(DateTime dateD)
         {
             string date = dateD.ToString();
             return date.Remove(date.IndexOf(":") - 3);

         }*/
    }
}
