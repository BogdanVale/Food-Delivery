using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DeliveryFood
{
    internal class My_DB
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-O7UPJEJ; Initial Catalog=Users; INtegrated Security=True ");


        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        //Function to open the connection
        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

        }
        //Function to close the connection
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();

        }
    }
}
