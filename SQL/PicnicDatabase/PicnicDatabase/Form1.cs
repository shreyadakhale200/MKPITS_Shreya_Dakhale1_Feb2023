namespace PicnicDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = null;
            result = DatabaseConnection.InputValues(textBox1.Text, textBox2.Text, Convert.ToInt64(textBox3.Text), comboBox1.Text, comboBox2.Text);
            label6.Text = " ";
            label6.Text = result;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            textBox1.Focus();
            if (label6.Text == result)
            {
                label6.Text = " ";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = " ";
            comboBox2.Items.Clear();
            if (comboBox1.Text == "Koradi Road")
            {
                comboBox2.Items.Add("Mankapur");
                comboBox2.Items.Add("Faras");
                comboBox2.Items.Add("Om Nagar");
            }
            else if (comboBox1.Text == "Civil Lines")
            {
                comboBox2.Items.Add("Shankar Nagar");
                comboBox2.Items.Add("Dharampeth");
                comboBox2.Items.Add("Bajaj Nagar");
            }
            /* switch(comboBox1.Text)
             {
                 case "Koradi Road":
                     comboBox2.Items.Add("Mankapur");
                     break;

                 case "Civil Lines":
                     comboBox2.Items.Add("Shankar Nagar");
                     break;
             }
            */
            //comboBox2.Items.Clear();
        }
    }
}