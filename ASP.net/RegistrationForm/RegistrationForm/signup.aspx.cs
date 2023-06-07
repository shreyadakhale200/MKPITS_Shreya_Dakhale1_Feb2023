using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationForm
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string firstname, lastname, birthday, email, inlineRadioOptions, phone;
            firstname = Request.QueryString["firstname"].ToString();
            lastname = Request.QueryString["lastname"].ToString();
            birthday = Request.QueryString["birthday"].ToString();
            inlineRadioOptions = Request.QueryString["inlineRadioOptions"].ToString();
            email = Request.QueryString["email"].ToString();
            phone = Request.QueryString["phone"].ToString();


            Response.Write("email :" + firstname + "<br>");
            Response.Write("lastname :" + lastname + "<br>");
            Response.Write("birthday :" + birthday + "<br>");
            Response.Write("gender :" + inlineRadioOptions + "<br>");
            Response.Write("email :" + email + "<br>");
            Response.Write("phone :" + phone + "<br>");

        }
    }
}