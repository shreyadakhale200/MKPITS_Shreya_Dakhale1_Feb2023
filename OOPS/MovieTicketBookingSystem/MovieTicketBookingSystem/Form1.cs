using System.DirectoryServices.ActiveDirectory;

namespace MovieTicketBookingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            //comboBox2.Items.Clear();
            comboBox3.Text = "";
            comboBox4.Text = "";
            switch (comboBox2.Text)
            {
                case "Forest Gump":
                    comboBox3.Items.Add("Inox");
                    comboBox3.Items.Add("Liberty");
                    break;

                case "Interstellar":
                    comboBox3.Items.Add("Panchshil");
                    comboBox3.Items.Add("Sudhama");
                    break;

                case "Rocket Boys":
                    comboBox3.Items.Add("Alankar");
                    comboBox3.Items.Add("Smruti");
                    break;

                case "Martian":
                    comboBox3.Items.Add("Cinemax");
                    comboBox3.Items.Add("PVR");
                    break;
                    //Forest Gump
                    //Interstellar
                    //Rocket Boys
                    //Martian
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.Text)
            {
                case "Inox":
                    comboBox4.Items.Add("12:00 PM");
                    comboBox4.Items.Add("3:10 PM");
                    textBox1.Text = "240";
                    break;
                case "Liberty":
                    comboBox4.Items.Add("1:00 PM");
                    comboBox4.Items.Add("5:30 PM");
                    textBox1.Text = "300";
                    break;
                case "Panchshil":
                    comboBox4.Items.Add("2:00 PM");
                    comboBox4.Items.Add("7:30 PM");
                    textBox1.Text = "213";
                    break;
                case "Sudhama":
                    comboBox4.Items.Add("3:00 PM");
                    comboBox4.Items.Add("9:30 PM");
                    textBox1.Text = "300";
                    break;
                case "Alankar":
                    comboBox4.Items.Add("10:00 AM");
                    comboBox4.Items.Add("2:30 PM");
                    textBox1.Text = "500";
                    break;
                case "Smruti":
                    comboBox4.Items.Add("7:00 AM");
                    comboBox4.Items.Add("11:30 PM");
                    textBox1.Text = "100";
                    break;
                case "Cinemax":
                    comboBox4.Items.Add("7:30 PM");
                    comboBox4.Items.Add("11:30 PM");
                    textBox1.Text = "234";
                    break;
                case "PVR":
                    comboBox4.Items.Add("11:00 AM");
                    comboBox4.Items.Add("12:30 PM");
                    textBox1.Text = "504";
                    break;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string MovieName = comboBox2.Text;
            string TheatreName = comboBox3.Text;
            string ShowTime = comboBox4.Text;
            int NoOfSeats;
            float TicketPrice;
            TicketPrice = float.Parse(textBox1.Text);
            label5.Text = TicketPrice.ToString();
            MovieTicket mt = null;

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
            if (radioButton1.Checked)
            {
                mt = new OnlineBooking();

            }
            else if (radioButton2.Checked)
            {
                mt = new BoxOffice();

            }

            string TotalPrice = mt.TicketPrice(number_ofTickets, TicketPrice);
            label5.Text += "\n" + MovieName + Environment.NewLine;
            label5.Text += TheatreName + Environment.NewLine;
            label5.Text += ShowTime + Environment.NewLine;
            label5.Text += "Your tickets are : " + number_ofTickets + Environment.NewLine;
            label5.Text += TotalPrice.ToString();
        }
    }
}