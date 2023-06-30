using System.Data;

namespace EmployeeDetails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string gender = null;
        private void button1_Click(object sender, EventArgs e)
        {
            Getgender();
            string result = EmployeeDatabaseConnection.InsertEmployeeDetails(Convert.ToInt32(textBox1.Text), textBox2.Text, gender, textBox3.Text, Convert.ToInt64(textBox4.Text), Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Value);
            label8.Text = result;
            ClearAll();
        }

        public void ClearAll()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            comboBox1.Text = " ";
        }

        public void Getgender()
        {
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = EmployeeDatabaseConnection.GetCity();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "cityid";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Getgender();
            string result = EmployeeDatabaseConnection.UpdateEmployee(Convert.ToInt32(textBox1.Text), textBox2.Text, gender, textBox3.Text, Convert.ToInt64(textBox4.Text), Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Value);
            label8.Text = result;
            ClearAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = EmployeeDatabaseConnection.DeleteEmployee(Convert.ToInt32(textBox1.Text));
            label8.Text = result;
            ClearAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = EmployeeDatabaseConnection.SearchEmployee(Convert.ToInt32(textBox1.Text));
            textBox2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
           string gender = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            if (gender == "male")
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
            textBox3.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            textBox4.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            comboBox1.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();


        }
    }
}