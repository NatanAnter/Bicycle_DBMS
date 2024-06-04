using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Bicycle_DBMS;


namespace Bicycle_DBMS
{
    public class DailyReport
    {
        public const string EMAIL_ADDRESS = "";

        public string Date { get; set; }
        public double DailyIncome {get; set;}
        public double DailyExpense { get; set; }
        public double DailyProfit { get; set; }

        public DailyReport()
        {
            
            Date = SaleDay.Today();
            DailyIncome = 0;
            DailyExpense = 0;
            DailyProfit = 0;
        }

        public DailyReport(string date, double dailyIncome, double dailyExpense, double dailyProfit)
        {
            Date = date;
            DailyIncome = dailyIncome;
            DailyExpense = dailyExpense;
            DailyProfit = dailyProfit;

        }

        public DailyReport(double dailyIncome, double dailyExpense)
        {
            Date = SaleDay.Today();
            DailyIncome = dailyIncome;
            DailyExpense = dailyExpense;
            DailyProfit = dailyIncome - dailyExpense;
        }
        public static DailyReport RestoreDailyReport()
        {
            try
            {
                DailyReport report = DailyReport.SelectDailyReport(SaleDay.Today());
                if (report != null)
                    return report;
                return new DailyReport();
            }
            catch
            {
                throw;
            }
        }
        public bool InsertDailyReport()
        {
            try
            {
                if (DailyReport.SelectDailyReport(Date) != null)
                    return false;
                string str = string.Format("SET DATEFORMAT YMD INSERT INTO DailyReport VALUES('{0}', {1}, {2}, {3}); ", Date, DailyIncome, DailyExpense, DailyProfit);
                return DB_Conn.ExecuteNonQuery(str) == 1;
            }
            catch
            {
                throw;
            }
        }
        public bool UpdateDailyReport()
        {
            try
            {
                string str = string.Format("SET DATEFORMAT YMD UPDATE {0} SET [DailyIncome] = {1}, [DailyExpense] = {2}, [DailyProfit] = {3} WHERE [Date] = '{4}'", "DailyReport", DailyIncome, DailyExpense, DailyProfit, Date);
                return DB_Conn.ExecuteNonQuery(str) > 0;
            }
            catch
            {
                throw;
            }
            
        }
        public static DailyReport SelectDailyReport(string date)
        {
            try
            {
                string str = string.Format("SELECT * FROM DailyReport WHERE [Date] = '{0}';", date);
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                if (!rdr.HasRows)
                {
                    rdr.Close();
                    return null;
                }
                rdr.Read();
                DailyReport D = new DailyReport(SaleDay.GetDateYMD(DateTime.Parse(rdr["Date"].ToString())), double.Parse(rdr["DailyIncome"].ToString()), double.Parse(rdr["DailyExpense"].ToString()), double.Parse(rdr["DailyProfit"].ToString()));
                rdr.Close();
                return D;
            }
            catch
            {
                throw;
            }
        }
        public static List<DailyReport> SelectAllDailyReport()
        {
            try
            {
                string str = string.Format("SELECT * FROM DailyReport;");
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                List<DailyReport> lst = new List<DailyReport>();
                while (rdr.Read())
                {
                    lst.Add(new DailyReport(SaleDay.GetVisualDate(DateTime.Parse(rdr["Date"].ToString())), double.Parse(rdr["DailyIncome"].ToString()), double.Parse(rdr["DailyExpense"].ToString()), double.Parse(rdr["DailyProfit"].ToString())));
                }
                rdr.Close();
                return lst;
            }
            catch
            {
                throw;
            }
        }
        public void AddToProfit(double payment, double expense)
        {
            try
            {
                this.DailyIncome += payment;
                this.DailyExpense += expense;
                this.DailyProfit += payment - expense;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
