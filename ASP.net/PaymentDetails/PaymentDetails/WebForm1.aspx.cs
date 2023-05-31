using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaymentDetails
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        enum Payment { cash,emi}
        Payment payment;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
            double TotalAmount;
            StringBuilder sb = new StringBuilder();
        protected void Button1_Click(object sender, EventArgs e)
        {
            string customerName = TextBox1.Text;
            string productName = TextBox2.Text;
            int rate = Convert.ToInt32(TextBox3.Text);
            int quantity = Convert.ToInt32(TextBox4.Text);
            if(RadioButton1.Checked)
            {
                TotalAmount = rate * quantity;
                Label1.Text = TotalAmount.ToString();
            }
            else if(RadioButton2.Checked) 
            {
                TotalAmount = rate * quantity;
                double Monthly = 0;
                double Balance = 0;
                Monthly = TotalAmount / 3;
                sb.Append("<br>");
               while(Balance < TotalAmount)
                {
                    Balance = Balance + Monthly;
                    Label1.Text = sb.Append(Monthly + "<br>").ToString();
                }
            }
        }

        public void Calculate()
        {
            int rate = Convert.ToInt32(TextBox3.Text);
            int quantity = Convert.ToInt32(TextBox4.Text);
            if (RadioButton1.Checked)
            {
                TotalAmount = rate * quantity;
                Label1.Text = TotalAmount.ToString();
            }
            else if (RadioButton2.Checked)
            {
                TotalAmount = rate * quantity;
                double Monthly = 0;
                double Balance = 0;
                Monthly = TotalAmount / 3;
                sb.Append("<br>");
                while (Balance < TotalAmount)
                {
                    Balance = Balance + Monthly;
                    Label1.Text = sb.Append(Monthly + "<br>").ToString();
                }
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}