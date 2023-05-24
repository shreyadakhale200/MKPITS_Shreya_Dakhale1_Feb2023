using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace MKPITSAdmission
{
    public partial class Form1 : Form
    {
        enum Gender { Male, Female }
        Gender gender;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = AdmissionDatabase.GetCountry();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "CountryName";

            DataSet ds1 = AdmissionDatabase.GetCourse();
            comboBox4.DataSource = ds1.Tables[0];
            comboBox4.DisplayMember = "CourseName";
            comboBox4.ValueMember = "CourseId";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = AdmissionDatabase.GetState(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "StateName";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = AdmissionDatabase.GetCity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "CityName";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = AdmissionDatabase.GetFees(comboBox4.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox3.Text = dr["fees"].ToString();
            }
            string fees = textBox3.Text;
            textBox5.Text = fees;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double fees = Convert.ToDouble(textBox3.Text);

            if (textBox4.Text == "")
            {
                textBox5.Text = textBox3.Text;

            }
            else
            {
                textBox5.Text = (Convert.ToDouble(textBox3.Text) - Convert.ToDouble(textBox4.Text)).ToString();
                double amountPaid = Convert.ToDouble(textBox4.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

            double Balance = Convert.ToDouble(textBox5.Text);
            double Fees = Convert.ToDouble(textBox3.Text);
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox3.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Fill the Required fields");
                Clearall();
            }
            else if (Balance < 0)
            {
                MessageBox.Show("Not valid");
                textBox5.Text = Fees.ToString();
                Clearall();
            }
            else
            {
                string result = AdmissionDatabase.InsertAdmissionDetails(textBox1.Text, gender, textBox2.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, dateTimePicker1.Value, Convert.ToInt32(comboBox4.SelectedValue), Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                MessageBox.Show(result);
                Clearall();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clearall();
        }
        public void Clearall()
        {
            textBox1.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox2.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
            dateTimePicker1.Value = DateTime.Today;
            //comboBox4.Text = " ";
            textBox4.Clear();
            textBox1.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = Gender.Male;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = Gender.Female;
        }
    }
}