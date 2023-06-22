using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeeshoProject
{
    public partial class addToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //https://www.example.com/products.aspx?prodid=12345

            //This line gets a value called "prodid" from the URL of a webpage.
            //It then stores that value in a variable called prodid, which is a text (string) variable.
            string prodid = Request.QueryString["prodid"].ToString();

            //This line saves the prodid value in a special storage area called a session.
            //The session is like a temporary storage that can remember data while you're using a website or application.
            Session["prodid"] = prodid;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("checkmno.aspx");
        }
    }
}