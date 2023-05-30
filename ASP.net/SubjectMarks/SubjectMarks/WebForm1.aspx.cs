using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SubjectMarks
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double subject1 = 0;
            double subject2 = 0;
            double subject3 = 0;
            char grade = 'a';
            subject1 = Convert.ToDouble(TextBox1.Text);
            subject2 = Convert.ToDouble(TextBox2.Text);
            subject3 = Convert.ToDouble(TextBox3.Text);
            double total = 0;
            total = subject1 + subject2 + subject3;
            Label1.Text = total.ToString();

            double Percentage = (total / 300) * 100;
            Label2.Text = Percentage.ToString();

            if(Percentage > 90)
            {
                grade = 'A';
            }
            else if(Percentage > 80 && Percentage < 90)
            {
                grade = 'B';
            }
            else if(Percentage > 70 && Percentage < 80)
            {
                grade = 'C';
            }
            else
            {
                Label3.Text = "Try Again";
            }
            Label3.Text = grade.ToString();
            
        }
    }
}