using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practise
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DropDownList1.Items.Clear();
            DropDownList2.Items.Clear();
            switch(DropDownList1.Text)
            {
                case "India":
                    DropDownList2.Items.Add("Goa");
                    DropDownList2.Items.Add("Chattisgarh");
                    DropDownList2.Items.Add("Assam");
                    break;

                case "Nepal":
                    DropDownList2.Items.Add("Karnali Pradesh");
                    DropDownList2.Items.Add("Lumbini Pradesh");
                    DropDownList2.Items.Add("Madhesh Pradesh");
                    break;
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.Items.Clear();
            switch(DropDownList2.Text)
            {
                case "Goa":
                    DropDownList3.Items.Add("Mapusa");
                    DropDownList3.Items.Add("Margao");
                    break;

                case "Chattisgarh":
                    DropDownList3.Items.Add("Raipur");
                    DropDownList3.Items.Add("Raigarh");
                    break;

                case "Assam":
                    DropDownList3.Items.Add("Jorhat");
                    DropDownList3.Items.Add("Guwahati");
                    break;

                case "Karnali Pradesh":
                    DropDownList3.Items.Add("Dullu");
                    DropDownList3.Items.Add("Simikot");
                    break;

                case "Lumbini Pradesh":
                    DropDownList3.Items.Add("Gulariya");
                    DropDownList3.Items.Add("Liwang");
                    break;

                case "Madhesh Pradesh":
                    DropDownList3.Items.Add("Lahan");
                    DropDownList3.Items.Add("Janakpur");
                    break;
            }
        }
        StringBuilder sb = new StringBuilder();
        protected void Button1_Click(object sender, EventArgs e)
        {
            sb.Append("Country : " + (DropDownList1.Text) + "<br>");
            sb.Append("State : " + (DropDownList2.Text) + "<br>");
            sb.Append("City : " + (DropDownList3.Text) + "<br>");
            foreach(ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                   sb.Append("Course : " + li.Value + "<br>");
                }
            }
            sb.Append("Centers : " + (ListBox1.SelectedItem.Text) + "<br>");
            Label1.Text = sb.ToString();

        }
    }
}