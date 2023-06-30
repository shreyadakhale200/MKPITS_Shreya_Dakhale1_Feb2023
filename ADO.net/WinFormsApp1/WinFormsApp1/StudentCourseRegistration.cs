using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class StudentCourseRegistration : Form
    {
        public StudentCourseRegistration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentCourseRegistration_Load(object sender, EventArgs e)
        {
            DataSet ds = StudentCourseDatabaseConnection.CourseDetails();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "courseid";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = StudentCourseDatabaseConnection.insertValues(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text));
            label6.Text = result;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox4.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = StudentCourseDatabaseConnection.UpdateValues(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text));
            label6.Text = result;
            textBox4.Focus();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = StudentCourseDatabaseConnection.DeleteValues(Convert.ToInt32(textBox3.Text));
            label6.Text = result;
            textBox4.Focus();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = StudentCourseDatabaseConnection.FindStudents(Convert.ToInt32(textBox3.Text));
            //foreach(DataRow dr in ds.Tables[0].Rows)
            //{
            //    textBox1.Text = dr["name"].ToString();
            //    textBox2.Text = dr["address"].ToString();
            //    comboBox1.Text = dr["courseid"].ToString();
            //    textBox4.Text = dr["age"].ToString();
            //}
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            textBox2.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            comboBox1.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            textBox4.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        }
    }
}
