using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterUser
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void button1Submit_Click(object sender, EventArgs e)
        {
            string result = DatabaseConnection.InsertData(textBox1username.Text, textBox2password.Text);
            label1status.Text = result;
            Clear();
        }

        public void Clear()
        {
            textBox1username.Clear();
            textBox2password.Clear();
            textBox1username.Focus();
        }

        private void button1Update_Click(object sender, EventArgs e)
        {
            string result = DatabaseConnection.UpdateData(textBox1username.Text, textBox2password.Text, Convert.ToInt32(textBox1Rollno.Text));
            label1status.Text = result;
            textBox1Rollno.Clear();
            textBox1username.Clear();
            textBox2password.Clear();
            textBox1Rollno.Focus();
        }

        private void button2Edit_Click(object sender, EventArgs e)
        {
            button1Submit.Enabled = false;
            button1Unedit.Visible = true;
            button1Update.Enabled = true;
            textBox1Rollno.Enabled = true;
            button1Delete.Enabled = true;
        }

        private void button1Unedit_Click(object sender, EventArgs e)
        {
            button1Submit.Enabled = true;
            button1Update.Enabled = false;
            button1Delete.Enabled = false;
        }

        private void textBox1Rollno_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void textBox1username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1username_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1username_Leave(object sender, EventArgs e)
        {
            if (textBox1username.Text == string.Empty)
            {
                MessageBox.Show("Username Cannot be empty", "Empty Warning");
                button1Submit.Enabled = false;
            }
            else
            {
                button1Submit.Enabled = true;
            }
        }

        private void textBox1Rollno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1Delete_Click(object sender, EventArgs e)
        {
            string result = DatabaseConnection.DeleteData(Convert.ToInt32(textBox1Rollno.Text));
            label1status.Text = result;
            textBox1Rollno.Clear();
            textBox1username.Clear();
            textBox2password.Clear();
            textBox1Rollno.Focus();

        }
    }
}
