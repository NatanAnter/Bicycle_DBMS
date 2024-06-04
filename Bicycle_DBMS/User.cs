using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Bicycle_DBMS;
using System.Data;


namespace Bicycle_DBMS
{
    public class User
    {

        public string Id { set; get; }
        public string Name { set; get; }
        public string Password { set; get; }
        public string Email { set; get; }

        public User(string id, string name, string password, string email)
        {
            Id = id;
            Name = name;
            Password = password;
            Email = email;
        }

        public bool Insert()
        {
            string str = string.Format("INSERT INTO {0} VALUES( N'{1}', N'{2}', N'{3}', N'{4}' )", "UserM", Id, Name, Password, Email);
            return DB_Conn.ExecuteNonQuery(str) == 1;
        }
        public bool Update()
        {
            string str = string.Format("UPDATE {0} SET [Name] = N'{1}', [Password] = N'{2}', [Email] = N'{3}' " +
                "WHERE [Id] = '{4}'", "UserM", Name, Password, Email, Id);
            return DB_Conn.ExecuteNonQuery(str) > 0;
        }

        public int Delete()
        {
            string str = string.Format("DELETE FROM {0} WHERE [Id] = {1}", "UserM",Id);
            return DB_Conn.ExecuteNonQuery(str);
        }

        public static User Select(string id)
        {
            string str = string.Format("SELECT * FROM [{0}] WHERE [Id] = {1};", "UserM", id);
            SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
            if (!rdr.HasRows)
            {
                rdr.Close();
                return null;
            }
            rdr.Read();
            User u = new User(rdr["Id"].ToString(), rdr["Name"].ToString(), rdr["Password"].ToString(), rdr["Email"].ToString());
            rdr.Close();
            return u;
        }

        public static List<User> SelectAll()
        {
            string str = string.Format("SELECT * FROM [UserM] ");
            SqlDataReader rdr = DB_Conn.ExecuteSelect(str);
            List<User> lst = new List<User>();
            while (rdr.Read())
            {
                lst.Add(new User(rdr["Id"].ToString(), rdr["Name"].ToString(), rdr["Password"].ToString(), rdr["Email"].ToString()));
            }
            rdr.Close();
            return lst;
        }
    }
}