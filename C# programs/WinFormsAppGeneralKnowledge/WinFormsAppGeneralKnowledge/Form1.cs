using System.Security.Cryptography.Xml;

namespace WinFormsAppGeneralKnowledge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int total = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                total += 10;
            }
            int counter = 0;
            if (checkBox1.Checked)
            {
                counter += 1;
                if (counter < 3)
                {
                    total += 5;
                }
                else
                {
                    MessageBox.Show("Select only 2 options");
                }
            }
            if (checkBox2.Checked)
            {
                counter += 1;
                if (counter < 3)
                {
                    total -= 5;
                }
                else
                {
                    MessageBox.Show("Select only 2 options");
                }
            }
            if (checkBox3.Checked)
            {
                counter += 1;
                if (counter < 3)
                {
                    total += 5;
                }
                else
                {
                    MessageBox.Show("Select only 2 options");
                }
            }
            if (radioButton7.Checked)
            {
                total += 10;
            }
            if (radioButton4.Checked)
            {
                total += 10;
            }
            int veg = 0;
            if (checkBox4.Checked)
            {
                veg += 1;
                if (veg <= 3)
                {
                    total += 4;
                }
                else
                {
                    MessageBox.Show("Please Select only 2 options");
                }
            }
            if (checkBox5.Checked)
            {
                veg += 1;
                if (veg <= 3)
                {
                    total += 3;
                }
                else
                {
                    MessageBox.Show("Please Select only 2 options");
                }
            }
            if (checkBox6.Checked)
            {
                veg += 1;
                if (veg <= 3)
                {
                    total += 3;
                }
                else
                {
                    MessageBox.Show("Please Select only 2 options");
                }
            }
            if (checkBox7.Checked)
            {
                veg += 1;
                if (veg <= 3)
                {
                    total -= 3;
                }
                else
                {
                    MessageBox.Show("Please Select only 2 options");
                }
            }
            if (checkBox8.Checked)
            {
                veg += 1;
                if (veg <= 3)
                {
                    total -= 3;
                }
                else
                {
                    MessageBox.Show("Please Select only 2 options");
                }
            }
            label6.Text = "total = " + total;
            if (button1.Capture = true)
            {
                button1.Enabled = false;
                timer1.Enabled = false;
                label7.Enabled = false;
                label8.Text = "Your Total is : " + total;
                label9.Text = "You Finished in : " + (count + 1) + " seconds";
            }

        }
        int count = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count >= 0)
            {
                label7.Text = "Timer left = " + count + ":00 sec ";
            }
            if (count <= 10)
            {
                label7.ForeColor = Color.Red;
                label7.BorderStyle = BorderStyle.Fixed3D;

            }
            else if (count <= 0)
            {
                button1.Enabled = false;
                timer1.Enabled = false;
                label7.Enabled = false;
                MessageBox.Show("Time Up");
            }
            count -= 1;
        }

        
    }
}