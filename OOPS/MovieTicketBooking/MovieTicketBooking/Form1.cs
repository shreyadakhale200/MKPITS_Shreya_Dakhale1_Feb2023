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
            int seat_number = Convert.ToInt32(textBox4.Text);
            double ticket_price = 0;
            int number_ofTickets = Convert.ToInt32(textBox3.Text);

            movieInfo mi = null;
            mi = new OnlineBooking();
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

            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.RowCount = 18;
            tableLayoutPanel1.ColumnCount = 10;
            this.Controls.Add(tableLayoutPanel1);

            CheckBox[,] seats = new CheckBox[tableLayoutPanel1.RowCount, tableLayoutPanel1.ColumnCount];
            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    CheckBox seat = new CheckBox();
                    seat.Text = "Seat " + (row * tableLayoutPanel1.ColumnCount + col + 1).ToString();
                    seats[row, col] = seat;
                    tableLayoutPanel1.Controls.Add(seat, col, row);
                    bool allChecked = true;

                    foreach (Control control in this.Controls)
                    {
                        if (control is CheckBox)
                        {
                            CheckBox checkbox = (CheckBox)control;

                            if (!checkbox.Checked)
                            {
                                allChecked = false;
                                break;
                            }
                        }
                    }

                    if (allChecked)
                    {
                        // All checkboxes are checked
                    label4.Text = (seat).ToString();
                    }
                    //else
                    //{
                        // Not all checkboxes are checked
                    //}

                }
            }
    DateTime dt = dateTimePicker1.Value;
    string format = "yyyy/MM/dd HH:mm:ss";
    mi.MovieTicket(movie_name, ticket_price, number_ofTickets);
            label4.Text = Environment.NewLine;
            label4.Text += "Movie : " + movie_name + Environment.NewLine;
            label4.Text += "Theatre : " + theater_name + Environment.NewLine;
            //label4.Text += show_Time.ToString() + Environment.NewLine;
            label4.Text += "Date and Time : " + dt.ToString(format) + Environment.NewLine;
            //label4.Text += "Seat Number : " + seat_number.ToString() + Environment.NewLine;
            //label4.Text = tableLayoutPanel1.Controls.Add(seat, col, row);
            
            label4.Text += "Total Price : " + mi.ticket_Price.ToString();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}