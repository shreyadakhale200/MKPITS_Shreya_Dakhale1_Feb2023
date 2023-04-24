namespace WinFormsAppLoginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            string country = comboBox1.Text;
            comboBox2.Items.Clear();
            switch (country)
            {
                case "India":
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Delhi");
                    comboBox2.Items.Add("Pune");
                    comboBox2.Items.Add("Banglore");
                    break;
                case "USA":
                    comboBox2.Items.Add("LA");
                    comboBox2.Items.Add("New York");
                    comboBox2.Items.Add("Chicago");
                    comboBox2.Items.Add("Boston");
                    break;
                case "UK":
                    comboBox2.Items.Add("London");
                    comboBox2.Items.Add("Liverpool");
                    comboBox2.Items.Add("Cambridge");
                    comboBox2.Items.Add("Derby");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Country : " + comboBox1.Text + "\n";
            label3.Text += "City : " + comboBox2.Text + "\n";
            label3.Text += "Course : " + listBox1.Text + "\n";
            //label3.Text += "Course : " + listBox1.SelectedItem.ToString() + "\n";
            label3.Text += "Date of Birth : " + dateTimePicker1.Text + "\n";
            label3.Text += "Phone number : " + maskedTextBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);
        }


    }
}