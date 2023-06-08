using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TemporaryCookie
{
    public partial class cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cook");
            cookie.Values.Add("username", TextBox1.Text);
            cookie.Values.Add("password", TextBox2.Text);
            Response.Cookies.Add(cookie);
            Label1.Text = "Temporary cookie saved";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cook"];
            if(cookie != null)
            {
                string uname = cookie.Values["username"];
                string psw = cookie.Values["password"];
                sb.Append("username : " + uname + "<br>");
                sb.Append("password : " + psw);
                Label2.Text = sb.ToString(); 
            }
            else
            {
                Label1.Text = "no cookie exist";
            }
        }
    }
}