using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Bicycle_DBMS
{
    public class AllSales
    {
        public string Barcode { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }
        public double Profit { get; set; }
        public AllSales()
        {
            Barcode = "1";
            Date = DateTime.Now.ToString();
            Name = "";
            Amount = 0;
            Price = 0;
            Cost = 0;
            Profit = 0;
        }
        public AllSales(string barcode, string date, string name, int amount, double price, double cost, double profit)
        {
            Barcode = barcode;
            Date = date;
            Name = name;
            Amount = amount;
            Price = price;
            Cost = cost;
            Profit = profit;
        }
        public static List<AllSales> SelectAllSales(string date)
        {
            string str = string.Format("SET DATEFORMAT YMD SELECT S.Date, I.Name, S.Barcode,  S.Amount, I.Price*S.Amount as Revenues, I.Cost*S.Amount as Expenses, I.Price*S.Amount - I.Cost*S.Amount as Profit FROM Sale as S full join Item as I on S.Barcode = I.Barcode where S.Date = '{0}'", date);
            SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
            if (!rdr.HasRows)
            {
                rdr.Close();
                return null;
            }
            List<AllSales> lst = new List<AllSales>();
            while (rdr.Read()) // TODO FIX
            {
                lst.Add(new AllSales(rdr["Barcode"].ToString(), SaleDay.GetVisualDate(DateTime.Parse(rdr["Date"].ToString())), rdr["Name"].ToString(),int.Parse(rdr["Amount"].ToString())
                    ,double.Parse(rdr["Revenues"].ToString()),double.Parse(rdr["Expenses"].ToString()), double.Parse(rdr["Profit"].ToString())));
            }
            rdr.Close();
            return lst;
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
    }
}

