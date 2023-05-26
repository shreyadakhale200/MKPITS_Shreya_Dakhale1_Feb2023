using System.Data;

namespace InstituteCourseRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }
        enum Category { Student, IT_Professional }
        Category category;
        enum Gender { Male, Female, Other }
        Gender gender;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //For Displaying NationName from the database TableNation 
            DataSet ds = RegistrationDatabase.GetTableNation();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "NationName";
            comboBox1.ValueMember = "NationID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //For Displaying StateName from the database TableState and returning StateID from the form to the database
            //to store it in the id
            DataSet ds = RegistrationDatabase.GetTableState(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateID";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //For Displaying CityName from the database TableCity and returning CityID from the form to the database
            DataSet ds = RegistrationDatabase.GetCity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "CityName";
            comboBox3.ValueMember = "CityID";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Clear();
            //DataSet ds = RegistrationDatabase.GetTotalAmount(textBox1.Text);
            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{
            //textBox2.Text = dr["TotalAmount"].ToString();
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double TotalAmount = Convert.ToDouble(textBox2.Text);
            textBox4.Text = TotalAmount.ToString();
        }
        double studentDiscount = (1000 * 0.5);
        double itProfessionalDiscount = (3000 * 0.8);

        public void discount()
        {
            if (category == 0)
            {
                double studentDiscount = Convert.ToDouble(textBox2.Text) * 0.5;
                textBox4.Text = studentDiscount.ToString();
            }
            else if (category == Category.IT_Professional)
            {
                double ITProff = Convert.ToDouble(textBox2.Text) * 0.8;
                textBox4.Text = ITProff.ToString();
            }
        }

        public void CalculateBalance()
        {
            if (category == 0)
            {
                if (Convert.ToDouble(textBox3.Text) >= studentDiscount)
                {
                    double Balance = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                    textBox4.Text = Balance.ToString();
                }
                else if (Convert.ToDouble(textBox3.Text) > Convert.ToDouble(textBox2.Text))
                {
                    MessageBox.Show("Invalid value");
                }
                else
                {
                    textBox4.Text = textBox2.Text;
                }

            }
            else if (category == Category.IT_Professional)
            {
                if (Convert.ToDouble(textBox3.Text) >= itProfessionalDiscount)
                {
                    double Balance = (Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text));
                    textBox4.Text = Balance.ToString();
                }
                else
                {
                    textBox4.Text = textBox2.Text;
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox4.Text = textBox2.Text;
            }
            else
            {
                CalculateBalance();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                category = Category.Student;
                //double student = (1000 * 50) / 100;
                double student = 1000;
                textBox2.Text = student.ToString();
                //discount();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                category = Category.IT_Professional;
                //double IT_Professional = (3000 * 80) / 100;
                double IT_Professional = 3000;
                textBox2.Text = IT_Professional.ToString();
                //discount();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (category == 0)
            {
                if (Convert.ToDouble(textBox3.Text) < 500)
                {
                    MessageBox.Show("Enter 50% of the fees");
                }
                else
                {
                    MessageBox.Show("Saved successfully");
                }
            }
            else if (category == Category.IT_Professional)
            {

                if (Convert.ToDouble(textBox3.Text) < 2400)
                {
                    MessageBox.Show("Enter 80% of the fees");
                }
                else
                {
                    MessageBox.Show("Saved successfully");
                }
            }
        }


    }
}