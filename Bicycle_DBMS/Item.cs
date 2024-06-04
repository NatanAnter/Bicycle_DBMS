using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Bicycle_DBMS;
using System.Data;


namespace Bicycle_DBMS
{
    public class Item
    {
        public string Barcode { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public double Cost { set; get; }
        public int Amount { set; get; }
        public int Min { set; get; }


        public Item(string barcode, string name, double price, double cost, int ammount, int min)
        {
            Barcode = barcode;
            Name = name;
            Price = price;
            Cost = cost;
            Amount = ammount;
            Min = min;
        }
        /*public Item(string barcode)
        {
            Barcode = barcode;
        }*/
        /*public List<DailyReport> GetAllDAys(DateTime date)
        {
            try
            {
                string str = string.Format("SELECT * FROM Sale WHERE [Barcode] = '{0}' AND [Date] = {1} ;", this.Barcode, date.Date);
                SqlDataReader d = DB_Conn.ExecuteSelect(str);
                List<DailyReport> days = new List<DailyReport>();
                while (d.Read())
                {
                    days.Add(DailyReport.SelectDailyReport(SaleDay.GetDate(date)));
                }
                return days;
            }
            catch
            {
                throw;
            }
        }*/

        /*public bool UpdateSale(DateTime date, int quantity)
        {
            string str = string.Format("UPDATE {0} SET [Amount] = {1} WHERE [Barcode] = '{2}' AND [Date] = '{3}'", "Sale",  quantity, this.Barcode, date.Date);
            return DB_Conn.ExecuteNonQuery(str) > 0;
        }
        public bool InsertSale(DateTime date, int quantity)
        {
            string str = string.Format("INSERT INTO Sale VALUES('{0}', '{1}', {2}); ", this.Barcode, date, quantity);
            return DB_Conn.ExecuteNonQuery(str) == 1;

        }*/
        /*public static int GetQuantity(string barcode, DateTime date)
        {
            string str = string.Format("SELECT Amount FROM Sale WHERE Barcode = '{0}' AND Date = '{1}';", barcode, date.Date);
            SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
            if (!rdr.HasRows)
            {
                rdr.Close();
                return 0;
            }
            rdr.Read();
            int num = int.Parse(rdr["Amount"].ToString());
            rdr.Close();
            return num;
        }*/
        /*public bool AddtSale(DateTime date)
        {
            int quantity = GetQuantity(this.Barcode, date);
            if (UpdateSale(date, ++quantity))
                return true;
            return InsertSale(date, 1);
        }*/
        /*public List<Sale> SelectAllSaleDays()
        {
            string str = string.Format("SELECT * FROM DailyReport AS D INNER JOIN Sale AS S ON D.Date = S.Date WHERE {0} = {1}", "Barcode", this.Barcode);
            SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
            if (!rdr.HasRows)
            {
                rdr.Close();
                return null;
            }
            List<Sale> lst = new List<Sale>();
            while (rdr.Read())
            {
                lst.Add(new Sale(rdr["Barcode"].ToString(), DateTime.Parse(rdr["Date"].ToString()), int.Parse(rdr["Amount"].ToString())));
            }
            rdr.Close();
            return lst;
        }*/

        public bool InsertItem()
        {
            try
            {
                string str = string.Format("INSERT INTO Item VALUES('{0}', N'{1}', {2}, {3}, {4}, {5}); ", Barcode, Name, Price, Cost, Amount, Min);
                return DB_Conn.ExecuteNonQuery(str) == 1;
            }
            catch
            {
                throw;
            }
            
        }

        public bool UpdateItem()
        {
            try
            {
                if (Amount < 0)
                    Amount = 0;
                string str = string.Format("UPDATE {0} SET [Name] = N'{1}', [Price] = {2}, [Cost] = {3}, [Amount] = {4},  [Min] = {5} " +
                    "WHERE [Barcode] = '{6}'", "Item", Name, Price, Cost, Amount, Min, Barcode);
                return DB_Conn.ExecuteNonQuery(str) > 0;
            }
            catch
            {
                throw;
            }
            
        }

        public int DeleteItem()
        {
            try
            {
                List<SaleDay> s = SaleDay.SelectAllSaleDays(Barcode);
                if (s != null)
                    foreach (var sale in s)
                    {
                        sale.DeletSaleBarcode();
                    }

                string str = string.Format("DELETE FROM Item WHERE [Barcode] = '{0}'", Barcode);
                return DB_Conn.ExecuteNonQuery(str);
            }
            catch
            {
                throw;
            }
            
        }

        public static Item SelectItem(string barcode)
        {
            try
            {
                string str = string.Format("SELECT * FROM Item WHERE Barcode = '{0}';", barcode);
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                if (!rdr.HasRows)
                {
                    rdr.Close();
                    return null;
                }
                rdr.Read();
                Item i = new Item(rdr["Barcode"].ToString(), rdr["Name"].ToString(), double.Parse(rdr["price"].ToString()), double.Parse(rdr["Cost"].ToString()), int.Parse(rdr["Amount"].ToString()), int.Parse(rdr["Min"].ToString()));
                rdr.Close();
                return i;
            }
            catch
            {
                throw;
            }
            
        }

        public static List<Item> SelectAllItems()
        {
            try
            {
                string str = string.Format("SELECT * FROM Item;");
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                List<Item> lst = new List<Item>();
                while (rdr.Read())
                {
                    lst.Add(new Item(rdr["Barcode"].ToString(), rdr["Name"].ToString(), double.Parse(rdr["Price"].ToString()), double.Parse(rdr["Cost"].ToString()), int.Parse(rdr["Amount"].ToString()), int.Parse(rdr["Min"].ToString())));
                }
                rdr.Close();
                return lst;
            }
            catch
            {
                throw;
            }
        }
        public static List<Item> SelectAllOrders()
        {
            try
            {
                string str = string.Format("SELECT * FROM Item WHERE [{0}] < [{1}];", "Amount", "Min");
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                List<Item> lst = new List<Item>();
                while (rdr.Read())
                {
                    lst.Add(new Item(rdr["Barcode"].ToString(), rdr["Name"].ToString(), double.Parse(rdr["Price"].ToString()),
                        double.Parse(rdr["Cost"].ToString()), int.Parse(rdr["Amount"].ToString()), int.Parse(rdr["Min"].ToString())));
                }
                rdr.Close();
                return lst;
            }
            catch
            {
                throw;
            }
        }
        /*public static List<Item> SelectAllDate(DateTime date)
        {
            string str = string.Format("SELECT * FROM Item AS I FULL JOIN Sale AS S ON I.Barcode = S.Barcode WHERE S.Date = '{0}", date);
            SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
            List<Item> lst = new List<Item>();
            while (rdr.Read())
            {
                lst.Add(new Item(rdr["Barcode"].ToString(), rdr["Name"].ToString(), double.Parse(rdr["Price"].ToString()), double.Parse(rdr["Cost"].ToString()), int.Parse(rdr["Amount"].ToString()), int.Parse(rdr["Min"].ToString())));
            }
            rdr.Close();
            return lst;
        }*/
        public static int SubtractFromItems(List<Account> AS)
        {
            try
            {
                int count = 0;
                foreach (var account in AS)
                {
                    string str = string.Format("UPDATE Item SET Amount = CASE WHEN Amount - {0} <0 THEN 0 " +
                        "ELSE Amount  - {1} END  WHERE Barcode = '{2}'", account.Amount, account.Amount, account.Barcode);
                    count += DB_Conn.ExecuteNonQuery(str);
                }
                return count;
            }
            catch
            {
                throw;
            }
        }
        public static double GetTotalExpense(List<Account> AS)
        {
            try
            {
                List<Item> IS = SelectAllItems();
                double expense = 0;
                foreach (var account in AS)
                {
                    foreach (var item in IS)
                    {
                        if (account.Barcode == item.Barcode)
                            expense += item.Cost * account.Amount;
                    }
                }
                return expense;
            }
            catch
            {
                throw;
            }
        }
        public static List<Item> SelectAllOrdersByBarcode(string barcode)
        {
            try
            {
                string str = string.Format("select * from item where Barcode like '{0}' ", barcode);
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                List<Item> lst = new List<Item>();
                while (rdr.Read())
                {
                    lst.Add(new Item(rdr["Barcode"].ToString(), rdr["Name"].ToString(), double.Parse(rdr["Price"].ToString()),
                        double.Parse(rdr["Cost"].ToString()), int.Parse(rdr["Amount"].ToString()), int.Parse(rdr["Min"].ToString())));
                }
                rdr.Close();
                return lst;
            }
            catch
            {
                throw;
            }
            
        }

        public static List<Item> SelectAllOrdersByNameStarting(string sring)
        {
            try
            {
                string str = string.Format("select * from item where Name like N'{0}%' ", sring);
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                List<Item> lst = new List<Item>();
                while (rdr.Read())
                {
                    lst.Add(new Item(rdr["Barcode"].ToString(), rdr["Name"].ToString(), double.Parse(rdr["Price"].ToString()),
                        double.Parse(rdr["Cost"].ToString()), int.Parse(rdr["Amount"].ToString()), int.Parse(rdr["Min"].ToString())));
                }
                rdr.Close();
                return lst;
            }
            catch
            {
                throw;
            }
        }

        public static List<Item> SelectAllOrdersByNameHas(string sring)
        {
            try
            {
                string str = string.Format("select * from item where Name like N'%{0}%' ", sring);
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                List<Item> lst = new List<Item>();
                while (rdr.Read())
                {
                    lst.Add(new Item(rdr["Barcode"].ToString(), rdr["Name"].ToString(), double.Parse(rdr["Price"].ToString()),
                        double.Parse(rdr["Cost"].ToString()), int.Parse(rdr["Amount"].ToString()), int.Parse(rdr["Min"].ToString())));
                }
                rdr.Close();
                return lst;
            }
            catch
            {
                throw;
            }
        }

        public static List<Item> SelectAllOrdersByPrice(string price)
        {
            try
            {
                string str;
                if (price.Contains("."))
                    str = string.Format("select * from item where Price = '{0}' ", price);
                else
                    str = string.Format("select * from item where Price like '{0}.%' ", price);
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                List<Item> lst = new List<Item>();
                while (rdr.Read())
                {
                    lst.Add(new Item(rdr["Barcode"].ToString(), rdr["Name"].ToString(), double.Parse(rdr["Price"].ToString()),
                        double.Parse(rdr["Cost"].ToString()), int.Parse(rdr["Amount"].ToString()), int.Parse(rdr["Min"].ToString())));
                }
                rdr.Close();
                return lst;
            }
            catch
            {
                throw;
            }
        }

        public static List<Item> SelectAllOrdersByCost(string cost)
        {
            try
            {
                string str = string.Format("select * from item where Cost like '{0}.%' ", cost);
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                List<Item> lst = new List<Item>();
                while (rdr.Read())
                {
                    lst.Add(new Item(rdr["Barcode"].ToString(), rdr["Name"].ToString(), double.Parse(rdr["Price"].ToString()),
                        double.Parse(rdr["Cost"].ToString()), int.Parse(rdr["Amount"].ToString()), int.Parse(rdr["Min"].ToString())));
                }
                rdr.Close();
                return lst;
            }
            catch
            {
                throw;
            }
        }

        public static List<Item> SelectAllOrdersByAmount(string amount)
        {
            try
            {
                string str = string.Format("select * from item where Amount like '{0}' ", amount);
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                List<Item> lst = new List<Item>();
                while (rdr.Read())
                {
                    lst.Add(new Item(rdr["Barcode"].ToString(), rdr["Name"].ToString(), double.Parse(rdr["Price"].ToString()),
                        double.Parse(rdr["Cost"].ToString()), int.Parse(rdr["Amount"].ToString()), int.Parse(rdr["Min"].ToString())));
                }
                rdr.Close();
                return lst;
            }
            catch
            {
                throw;
            }
        }

        public static List<Item> SelectAllOrdersByMin(string min)
        {
            try
            {
                string str = string.Format("select * from item where Min like '{0}' ", min);
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                List<Item> lst = new List<Item>();
                while (rdr.Read())
                {
                    lst.Add(new Item(rdr["Barcode"].ToString(), rdr["Name"].ToString(), double.Parse(rdr["Price"].ToString()),
                        double.Parse(rdr["Cost"].ToString()), int.Parse(rdr["Amount"].ToString()), int.Parse(rdr["Min"].ToString())));
                }
                rdr.Close();
                return lst;
            }
            catch
            {
                throw;
            }
        }
    }
}