using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountDetails
{
    public partial class WebForm1 : System.Web.UI.Page
    {
            protected void Page_Load(object sender, EventArgs e)
            {
             double Balance = 5000;
            }
             double Balance;
        protected void Button1_Click(object sender, EventArgs e)
        {
            double AccountNo = Convert.ToDouble(TextBox1.Text);
            double Amount = Convert.ToDouble(TextBox2.Text);
            if(TextBox3.Text == "Deposit")
            {
                Balance = Amount + Balance;
                Label1.Text = Balance.ToString();   
            }
            
            else if(TextBox3.Text == "Withdrawl")
            {
                Balance = Convert.ToDouble(Label1.Text);
                if(Amount <= Balance)
                {
                    Balance = Amount - Balance;
                    Label1.Text = Balance.ToString();
                }
                else if(Amount > Balance)
                {
                    Label1.Text = "Invalid Amount";
                }
            }
        }

        protected void Button1_Load(object sender, EventArgs e)
        {

        }
    }
}