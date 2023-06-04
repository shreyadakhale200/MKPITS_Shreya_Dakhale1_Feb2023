using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AsusStores
{
    internal class InvoiceDatabase
    {
        //connection wtih database
        private static string ConnectionString = "server = .\\sqlexpress;integrated security = true;database = InvoiceDetails";
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                return con;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public static DataSet GetProductName()
        {
            SqlConnection con = GetConnection();
            string query = "select * from computer";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.Fill(ds,"computer");
            return ds;
        }

        public static DataSet GetProductDetails(string Name)
        {
            SqlConnection con = GetConnection();
            string query = "select * from computer where Name = @Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.SelectCommand.Parameters.AddWithValue("@Name", Name);
            da.Fill(ds,"computer");
            return ds;
        }

        //public static string InsertCustomerDetails(string firstname,string lastname,string gender,double mobile,double paidamount)
        //{
        //    SqlConnection con = GetConnection();
        //    string query = "insert into CUSTOMER values(@firstname,@lastname,@gender,@mobile,@paidamount)";
        //    SqlCommand command = new SqlCommand(query,con);
        //    command.Parameters.AddWithValue("@firstname", firstname);
        //}
    }
}
