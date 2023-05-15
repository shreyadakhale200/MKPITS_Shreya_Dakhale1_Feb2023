using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating a connection string
            string constr = "server=.\\sqlexpress;database=civica;integrated security = true;";
            //creating a SQLconnection object
            SqlConnection con = new SqlConnection(constr);
            //opening the connection
            try
            {
                con.Open();
                label1.Text = "connection successfull";
            }catch(Exception ex)
            {
                label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }
    }
}