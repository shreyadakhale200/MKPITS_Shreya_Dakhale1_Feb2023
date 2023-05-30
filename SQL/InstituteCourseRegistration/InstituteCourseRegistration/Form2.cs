using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstituteCourseRegistration
{
    public partial class Form2 : Form
    {
        enum Category { Student, IT_Professional }
        enum Gender { Male, Female, Other }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataSet ds = RegistrationCourseDatabase.GetNation();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "NationName";
            comboBox1.ValueMember = "NationID";
            textBox2.Text = "1000";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = RegistrationCourseDatabase.GetState(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateID";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = RegistrationCourseDatabase.GetCity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "CityName";
            comboBox3.ValueMember = "CityID";
        }

        Gender gender;
        Category category;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Clear();
                category = Category.Student;
                textBox2.Text = "1000";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Clear();
                category = Category.IT_Professional;
                textBox2.Text = "3000";
            }

        }
        double fp = 0;
        private void textBox3_Leave(object sender, EventArgs e)
        {
            double TotalAmount = Convert.ToDouble(textBox2.Text);
            double PaidAmount = Convert.ToDouble(textBox3.Text);

            if (category == 0)
            {
                fp = 1000 * 0.5;
                if (PaidAmount >= fp)
                {
                    double Balance = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                    textBox4.Text = Balance.ToString();
                }
                else
                {
                    MessageBox.Show("Pay atleast 50% of the amount for student");
                    textBox3.Clear();
                }
            }
            if (category == Category.IT_Professional)
            {
                fp = 3000 * 0.8;
                if (PaidAmount >= fp)
                {
                    double Balance = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                    textBox4.Text = Balance.ToString();
                }
                else
                {
                    MessageBox.Show("Pay atleast 80% of the amount for student");
                    textBox3.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Fill the required fields");
            }
            else if(textBox3.Text == "")
            {
                MessageBox.Show("Amount cannot be empty");
            }
            else if(Convert.ToInt32(textBox3.Text) > Convert.ToInt32(textBox2.Text))
            {
                MessageBox.Show("values not allowed");
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                string result = RegistrationCourseDatabase.SaveTableCourseRegDetail(Convert.ToInt32(category), textBox1.Text, Convert.ToInt32(gender));
                MessageBox.Show(result);

                result = RegistrationCourseDatabase.SaveTableRegAddress(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue));
                MessageBox.Show(result);

                result = RegistrationCourseDatabase.InsertTableFeeDetail(Convert.ToInt32(textBox2.Text), fp, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), dateTimePicker1.Value);
                MessageBox.Show(result);
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                gender = Gender.Male;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                gender = Gender.Female;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                gender = Gender.Other;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
