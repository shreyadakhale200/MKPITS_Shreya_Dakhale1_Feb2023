using System.Data;
using System.Timers;

namespace Courseregistration
{
    public partial class Form1 : Form
    {
        enum Category { Student, IT_Professional }
        enum Gender { Male, Female, Other }

        Category category;
        Gender gender;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = RegistrationCourse.GetTableNation();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "NationName";
            comboBox1.ValueMember = "NationID";
            textBox2.Text = "1000";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = RegistrationCourse.GetTableCity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "CityName";
            comboBox3.ValueMember = "CityID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = RegistrationCourse.GetTableState(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateId";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                category = Category.Student;
                textBox2.Text = "1000";
                textBox3.Clear();
                textBox4.Clear();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                category = Category.IT_Professional;
                textBox2.Text = "3000";
                textBox3.Clear();
                textBox4.Clear();
            }
        }
        static double fp = 0;
        private void textBox3_Leave(object sender, EventArgs e)
        {
            double TotalAmount = Convert.ToDouble(textBox2.Text);
            double PaidAmount = Convert.ToDouble(textBox3.Text);
            if (category == 0)
            {
                fp = TotalAmount * 0.5;
                if (PaidAmount >= fp)
                {
                    double Balance = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                    textBox4.Text = Balance.ToString();
                }
                else
                {
                    MessageBox.Show("Pay atleast 50% of Amount for student");
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
            else if (radioButton2.Checked)
            {
                fp = TotalAmount * 0.8;
                if (PaidAmount >= fp)
                {
                    double Balance = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                    textBox4.Text = Balance.ToString();
                }
                else
                {
                    MessageBox.Show("Pay atleast 80% of Amount for student");
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                gender = Gender.Male;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                gender = Gender.Female;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                gender = Gender.Other;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter values in the required field");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("empty space is not allowed");
            }
            else if (Convert.ToInt32(textBox3.Text) > Convert.ToInt32(textBox2.Text))
            {
                MessageBox.Show("values are invalid");
            }
            else
            {
                string result = RegistrationCourse.GetTableCourseRegDetail(Convert.ToInt32(category), textBox1.Text, Convert.ToInt32(gender));
                MessageBox.Show(result);

                result = RegistrationCourse.GetTableRegAddress(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue));
                MessageBox.Show(result);

                result = RegistrationCourse.GetTableFeeDetail(Convert.ToDouble(textBox2.Text), fp, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), dateTimePicker1.Value);
                MessageBox.Show(result);
            }
        }
    }
}