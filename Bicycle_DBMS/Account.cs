using System;
using System.Collections.Generic;
using System.Text;
using Bicycle_DBMS;
using System.Data.SqlClient;

namespace Bicycle_DBMS
{
    public class Account
    {
        public string Barcode { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public int Amount { set; get; }

        public Account(string barcode, string name, double price, int ammount)
        {
            Barcode = barcode;
            Name = name;
            Price = price;
            Amount = ammount;
        }
        public bool InsertToAccount()
        {
            try
            {
                string str = string.Format("INSERT INTO Account VALUES('{0}', N'{1}', {2}, {3}); ", Barcode, Name, Price, Amount);
                return DB_Conn.ExecuteNonQuery(str) == 1;
            }
            catch
            {
                throw;
            }
            
        }
        public bool UpdateAccount()
        {
            try
            {
                string str = string.Format("UPDATE {0} SET [Name] = N'{1}', [Price] = {2}, [Amount] = {3}" +
                    "WHERE [Barcode] = '{4}'", "Account", Name, Price, Amount, Barcode);        
                return DB_Conn.ExecuteNonQuery(str) > 0;
            }
            catch
            {
                throw;
            }
            
        }
        public int DeleteFromAccount()
        {
            try
            {
                string str = string.Format("DELETE FROM Account WHERE [Barcode] = '{0}'", Barcode);
                return DB_Conn.ExecuteNonQuery(str);
            }
            catch
            {
                throw;
            }
            
        }
        public static bool DeleteAllFromAccount()
        {
            try
            {
                string str = string.Format("DELETE FROM Account");
                return DB_Conn.ExecuteNonQuery(str) > 0;
            }
            catch
            {
                throw;
            }
            

        }
        public static bool IsExsist(string barcode)
        {
            try
            {
                string str = string.Format("SELECT * FROM Account WHERE Barcode = '{0}';", barcode);
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                if (!rdr.HasRows)
                {
                    rdr.Close();
                    return false;
                }
                rdr.Close();
                return true;
            }
            catch
            {
                throw;
            }
        }
        public static Account SelectFromAccount(string barcode)
        {
            try
            {
                string str = string.Format("SELECT * FROM Account WHERE Barcode = '{0}';", barcode);
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                if (!rdr.HasRows)
                {
                    rdr.Close();
                    return null;
                }
                rdr.Read();
                Account a = new Account(rdr["Barcode"].ToString(), rdr["Name"].ToString(), double.Parse(rdr["price"].ToString()), int.Parse(rdr["Amount"].ToString()));
                rdr.Close();
                return a;
            }
            catch
            {
                throw;
            }
        }
        public static List<Account> SelectAllFromAcoount()
        {
            try
            {
                string str = string.Format("SELECT * FROM Account;");
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                List<Account> lst = new List<Account>();
                while (rdr.Read())
                {
                    lst.Add(new Account(rdr["Barcode"].ToString(), rdr["Name"].ToString(), double.Parse(rdr["Price"].ToString()), int.Parse(rdr["Amount"].ToString())));
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