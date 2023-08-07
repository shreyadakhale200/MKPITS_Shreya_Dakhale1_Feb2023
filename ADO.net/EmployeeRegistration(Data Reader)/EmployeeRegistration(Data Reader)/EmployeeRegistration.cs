using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeRegistration_Data_Reader_
{
    public partial class EmployeeRegistration : Form
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
        }

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = DatabaseConnection.GetCity();
            while (dr.Read())
            {
                comboBox1City.Items.Add(dr["city_name"]).ToString();
            }
        }

        private void button1Save_Click(object sender, EventArgs e)
        {
            string gender = null;
            if (radioButton1Male.Checked)
            {
                gender = "Male";
            }
            else if (radioButton1Female.Checked)
            {
                gender = "Female";
            }
            string result = DatabaseConnection.SaveData(Convert.ToInt32(textBox1EmployeeNumber.Text), textBox2Name.Text, gender, textBox1Email.Text, textBox1MobileNo.Text, comboBox1City.Text, Convert.ToDateTime(dateTimePicker1.Text));
            label5Result.Text = result;


            //textBox1EmployeeNumber.Clear();
            //textBox2Name.Clear();
            //radioButton1Female.Checked = false;
            //radioButton1Male.Checked = false;
            //textBox1Email.Clear();
            //textBox1MobileNo.Clear();
            //comboBox1City.Text = " ";
        }

        private void button1Update_Click(object sender, EventArgs e)
        {
            string gender = null;
            if (radioButton1Male.Checked)
            {
                gender = "Male";
            }
            else if (radioButton1Female.Checked)
            {
                gender = "Female";
            }
            string result = DatabaseConnection.UpdateData(textBox2Name.Text, gender, textBox1Email.Text, textBox1MobileNo.Text, comboBox1City.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(textBox1EmployeeNumber.Text));
            label5Result.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = DatabaseConnection.DeleteData(Convert.ToInt32(textBox1EmployeeNumber.Text));
            label5Result.Text = result;
        }
    }
}
