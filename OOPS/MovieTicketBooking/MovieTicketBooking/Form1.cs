using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;
using System.Windows.Forms;
using System;

namespace MovieTicketBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            string movie_name = comboBox2.Text;
            string theater_name = comboBox3.Text;
            DateTime show_Time = Convert.ToDateTime(dateTimePicker1.Text);
            int seat_number;
            double ticket_price = 0;
            movieInfo mi = null;

            if (comboBox1.Text == "Online Booking")
            {
                if (comboBox2.Text == "Forest Gump")
                {
                    mi = new OnlineBooking();
                }
                else if (comboBox2.Text == "Interstellar")
                {
                    mi = new OnlineBooking();
                }
                else if (comboBox2.Text == "Rocket Boys")
                {
                    mi = new OnlineBooking();

                }
                else if (comboBox2.Text == "Martian")
                {
                    mi = new OnlineBooking();
                }
            }
            else if (comboBox1.Text == "Box Office Booking")
            {
                if (comboBox2.Text == "Forest Gump")
                {
                    mi = new BoxOffice();
                }
                else if (comboBox2.Text == "Interstellar")
                {
                    mi = new BoxOffice();
                }
                else if (comboBox2.Text == "Rocket Boys")
                {
                    mi = new BoxOffice();

                }
                else if (comboBox2.Text == "Martian")
                {
                    mi = new BoxOffice();
                }
            }
            int count = 0;
            List<string> checkedCheckboxes = new List<string>();
            label5.Text = "Your seats are = ";
            for (int i = 1; i <= 408; i++)
            {
                string checkboxName = "Checkbox" + i.ToString();
                CheckBox checkbox = this.Controls.Find(checkboxName, true).FirstOrDefault() as CheckBox;

                if (checkbox != null && checkbox.Checked)
                {
                    checkedCheckboxes.Add(checkboxName);
                }
            }

            foreach (string checkboxName in checkedCheckboxes)
            {
                string nameWithoutCheckbox = checkboxName.Replace("Checkbox", ""); // remove "Checkbox" from the name
                label5.Text += nameWithoutCheckbox + " ";
                count++;
            }
            int number_ofTickets = count;
            DateTime dt = dateTimePicker1.Value;
            string format = "yyyy/MM/dd HH:mm:ss";
            mi.MovieTicket(movie_name, ticket_price, number_ofTickets);
            label4.Text = Environment.NewLine;
            label4.Text += "Movie : " + movie_name + Environment.NewLine;
            label4.Text += "Theatre : " + theater_name + Environment.NewLine;
            //label4.Text += show_Time.ToString() + Environment.NewLine;
            label4.Text += "Date and Time : " + dt.ToString(format) + Environment.NewLine;
            label4.Text += "Number of Seats : " + count.ToString() + Environment.NewLine;
            //label4.Text = tableLayoutPanel1.Controls.Add(seat, col, row);

            label4.Text += "Total Price : " + mi.ticket_Price.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}