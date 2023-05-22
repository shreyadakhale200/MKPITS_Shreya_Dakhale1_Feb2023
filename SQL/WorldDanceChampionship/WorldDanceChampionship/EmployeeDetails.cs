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

namespace WorldDanceChampionship
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = null;
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }
            label8.Text = EmployeeDatabase.InputEmployee(Convert.ToInt32(textBox1.Text), textBox2.Text, gender, textBox3.Text, Convert.ToInt64(textBox4.Text), comboBox1.Text, dateTimePicker1.Text);

            allClear();
        }
        public void allClear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = " ";
            dateTimePicker1.Text = "01 January 1900";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Focus();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            //SqlDataReader dr = EmployeeDatabase.GetCity();
            //while(dr.Read())
            //{
            //    comboBox1.Items.Add(dr["cityName"]).ToString();
            //}

            DataSet ds = EmployeeDatabase.GetCity();
            foreach (DataRow dr in ds.Tables["city"].Rows)
            {
                comboBox1.Items.Add(dr["cityName"].ToString());
            }
            DataSet ds1 = EmployeeDatabase.GetEmployeeDetails();
            dataGridView1.DataSource = ds1.Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = EmployeeDatabase.EmployeeUpdate(textBox2.Text, Convert.ToInt32(textBox1.Text));
            allClear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = EmployeeDatabase.SearchEmployee(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = ds.Tables[0];
            textBox2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string gender = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            if (gender == "Male")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            textBox3.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            textBox4.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            comboBox1.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = EmployeeDatabase.EmployeeDelete(Convert.ToInt32(textBox1.Text));
            allClear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            allClear();
        }

        /*private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = EmployeeDatabase.GetCity();
            //reading the records from sqldatareader  
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["cityName"].ToString());
            }
        }*/


    }
}
