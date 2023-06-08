using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace CookieExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cook");
            //This line creates a new instance of the HttpCookie class and assigns it to the variable cookie1.
            //The constructor of HttpCookie takes a string parameter, which represents the name of the cookie.
            //In this case, the cookie's name is set as "cook".

            cookie.Values.Add("username", TextBox1.Text);
            //username will be assigned to cookie obejct and
            //the value will be taken from the TextBox1

            Response.Cookies.Add(cookie);
            //this is the response being sent back to the client

            Label1.Text = "temporary cookie added to client machine";
            //message to display in label1
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cook"];
            //it will request for the values stored in cook and it will be
            //stored in the cookie

            if (cookie != null)
            //This line checks if the cookie object is not null.
            //It verifies whether a cookie with the name "cook" exists.
            {
                string uname = cookie.Values["username"].ToString();
                //This line retrieves the value of the "username" key from
                //the Values property of the cookie object.
                Label1.Text = "username " + uname;
                //it will display the cookie value which is username
            }
            else
            {
                Label1.Text = "no cookie exist";
                //else if the cookie is empty it will display this code
            }
        }
    }
}