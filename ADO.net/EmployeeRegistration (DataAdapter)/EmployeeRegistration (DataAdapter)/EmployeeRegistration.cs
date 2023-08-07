using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeRegistration__DataAdapter_
{
    public partial class EmployeeRegistration : Form
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
        }

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
            DataSet ds = EmployeeDatabase.GetCity();
            foreach (DataRow dr in ds.Tables["City"].Rows)
            {
                comboBox1City.Items.Add(dr["city_name"]).ToString();
            }
        }

        string gender = null;
        private void button1Save_Click(object sender, EventArgs e)
        {
            GenderSelection();
            string result = EmployeeDatabase.InputData(Convert.ToInt32(textBox1EmployeeNumber.Text), textBox2Name.Text, gender, textBox1Email.Text, Convert.ToInt64(textBox1MobileNo.Text), comboBox1City.Text, Convert.ToDateTime(dateTimePicker1DOB.Text));
            label5Result.Text = result;
        }

        public void GenderSelection()
        {
            if (radioButton1Male.Checked)
            {
                gender = "Male";
            }
            else if (radioButton1Female.Checked)
            {
                gender = "Female";
            }
        }
        private void button1Update_Click(object sender, EventArgs e)
        {
            GenderSelection();
            string result = EmployeeDatabase.UpdateData(textBox2Name.Text, gender, textBox1Email.Text, Convert.ToInt64(textBox1MobileNo.Text), comboBox1City.Text, Convert.ToDateTime(dateTimePicker1DOB.Text), Convert.ToInt32(textBox1EmployeeNumber.Text));
            label5Result.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = EmployeeDatabase.DeleteData(Convert.ToInt32(textBox1EmployeeNumber.Text));
            label5Result.Text = query;
        }
    }
}
