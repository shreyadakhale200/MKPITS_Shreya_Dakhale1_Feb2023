using System.Data;

namespace WorldDanceChampionship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            switch (comboBox1.Text)
            {
                case "India":
                    comboBox2.Items.Add("Mumbai");
                    comboBox2.Items.Add("Chennari");
                    comboBox2.Items.Add("Pune");
                    comboBox2.Items.Add("Jaipur");
                    comboBox2.Items.Add("Hyederabad");
                    comboBox2.Items.Add("Surat");
                    break;

                case "USA":
                    comboBox2.Items.Add("New York");
                    comboBox2.Items.Add("Los Angeles");
                    comboBox2.Items.Add("Chicago");
                    comboBox2.Items.Add("Austin");
                    comboBox2.Items.Add("Boston");
                    comboBox2.Items.Add("Washington DC");
                    break;

                case "France":
                    comboBox2.Items.Add("Paris");
                    comboBox2.Items.Add("Lyon");
                    comboBox2.Items.Add("Nice");
                    comboBox2.Items.Add("Bordeaux");
                    comboBox2.Items.Add("Colmar");
                    comboBox2.Items.Add("Caen");
                    break;

                case "Australia":
                    comboBox2.Items.Add("Sydney");
                    comboBox2.Items.Add("Gold Course");
                    comboBox2.Items.Add("Melbourne");
                    comboBox2.Items.Add("Darwin");
                    comboBox2.Items.Add("Bunbury");
                    comboBox2.Items.Add("Mackay");
                    break;

                case "Italy":
                    comboBox2.Items.Add("Rome");
                    comboBox2.Items.Add("Milan");
                    comboBox2.Items.Add("Venice");
                    comboBox2.Items.Add("Florence");
                    comboBox2.Items.Add("Pisa");
                    comboBox2.Items.Add("Bari");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string Status = null;
            label6.Text = DatabaseConnection.InputValues(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), comboBox1.Text, comboBox2.Text);
            clearAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            textBox1.Focus();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = DatabaseConnection.UpdateValues(textBox1.Text, textBox2.Text);
            clearAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = DatabaseConnection.DeleteValues(textBox1.Text, textBox2.Text);
            clearAll();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = DatabaseConnection.GetEmployeeDetails();
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}