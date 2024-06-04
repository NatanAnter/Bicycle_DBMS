using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data.Sql;


namespace Bicycle_DBMS
{

    public class DB_Conn
    {
        private static string conn_str = getConnectinString();
        private static SqlConnection connection = new SqlConnection(conn_str);

        public static SqlDataReader ExecuteSelect(string str)
        {
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                connection.Open();
            }
            try
            {
                SqlCommand command = new SqlCommand(str, connection);
                return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch
            {
                throw;
            }
        }

        public static int ExecuteNonQuery(string str)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(str, connection);
                int x = command.ExecuteNonQuery();
                connection.Close();
                return x;
            }
            catch
            {
                throw;
            }
        }

        public static string getConnectinString()
        {
            string location = Directory.GetCurrentDirectory().ToString();
            int i = location.IndexOf(@"\Bicycle_Forms");
            if (i != -1)
                location = location.Remove(i);
            return @"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDbFilename=" + @location + @"\Bicycle_DBMS\BicycleDB.mdf" + @";Integrated Security=True";

        }
    }
}