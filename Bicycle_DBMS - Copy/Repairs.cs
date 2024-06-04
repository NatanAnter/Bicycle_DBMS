using System;
using System.Collections.Generic;
using System.Text;
using Bicycle_DBMS;
using System.Data.SqlClient;

namespace Bicycle_DBMS
{
    public class Repairs
    {
        public int Repair_Num { set; get; }
        public string Date { set; get; }
        public string Name { set; get; }
        public string Phone_Num { set; get; }
        public string Description { set; get; }
        public bool Status { set; get; }
        public Repairs(int repair_Num, string date, string name, string phone_Num, string description, bool status)
        {
            Repair_Num = repair_Num;
            Date = date;
            Name = name;
            Phone_Num = phone_Num;
            Description = description;
            Status = status;
        }

        public bool Insert()
        {
            try
            {
                int intStatus;
                if (Status)
                    intStatus = 1;
                else
                    intStatus = 0;
                string str = string.Format("SET DATEFORMAT YMD INSERT INTO {6} VALUES({0}, N'{1}', N'{2}', N'{3}', N'{4}', {5}); ", Repair_Num, Date, Name, Phone_Num, Description, intStatus, "Repairs");
                return DB_Conn.ExecuteNonQuery(str) == 1;
            }
            catch
            {
                throw;
            }
        }
        public bool Update()
        {
            try
            {
                int intStatus;
                if (Status)
                    intStatus = 1;
                else
                    intStatus = 0;
                string str = string.Format("SET DATEFORMAT YMD UPDATE {0} SET [Date] = '{1}', [Name] = N'{2}', [Phone_number] = '{3}', [Description] = N'{4}', [Status] = {5} " +
                    "WHERE [Repair_Num] = {6}", "Repairs", Date, Name, Phone_Num, Description, intStatus, Repair_Num);
                return DB_Conn.ExecuteNonQuery(str) > 0;
            }
            catch
            {
                throw;
            }
            
        }

        public int DeleteRepair()
        {
            try
            {
                string str = string.Format("DELETE FROM Repairs WHERE [Repair_Num] = {0}", Repair_Num);
                return DB_Conn.ExecuteNonQuery(str);
            }
            catch
            {
                throw;
            }
            
        }

        public static Repairs SelectRepair(int repair_num)
        {
            try
            {
                string str = string.Format("SELECT * FROM Repairs WHERE Repair_Num = {0};", repair_num);
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                if (!rdr.HasRows)
                {
                    rdr.Close();
                    return null;
                }
                rdr.Read();
                Repairs r = new Repairs(int.Parse(rdr["Repair_Num"].ToString()), rdr["Name"].ToString(), rdr["Date"].ToString(), rdr["Phone_Number"].ToString(), rdr["Description"].ToString(), bool.Parse(rdr["Status"].ToString()));
                rdr.Close();
                return r;
            }
            catch
            {
                throw;
            }
            
        }

        public static List<Repairs> SelectAllRepairs()
        {
            try
            {
                string str = string.Format("SELECT * FROM Repairs order by Status, Date;");
                SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
                List<Repairs> lst = new List<Repairs>();
                while (rdr.Read())
                {
                    lst.Add(new Repairs(int.Parse(rdr["Repair_Num"].ToString()), SaleDay.GetVisualDate(DateTime.Parse(rdr["Date"].ToString())), rdr["Name"].ToString(), rdr["Phone_Number"].ToString(), rdr["Description"].ToString(), bool.Parse(rdr["Status"].ToString())));
                }
                rdr.Close();
                return lst;
            }
            catch
            {
                throw;
            }
            
        }
        public static string GetDateorPicker(int repairNum)
        {
            string str = string.Format("SELECT * FROM Repairs WHERE Repair_Num = {0};", repairNum);
            SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
            if (!rdr.HasRows)
            {
                rdr.Close();
                return null;
            }
            rdr.Read();
            return rdr["Date"].ToString();
            
        }
    }
}