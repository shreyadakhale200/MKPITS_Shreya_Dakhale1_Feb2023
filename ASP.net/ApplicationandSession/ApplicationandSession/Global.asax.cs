using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ApplicationandSession
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            //Appplication - common for all the users
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["companyname"] = "MKP IT Services ";
            Application["counter"] = 0;
        }

        void Session_Start(object sender, EventArgs e)
        {
            Session["counter"] = 0;
            Session["username"] = "";
            Session["email"] = "";
            Session["Pizza"] = "";
            Session["PizzaToppings"] = "";
        }
    }
}