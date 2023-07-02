using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormRegister
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void groupBoxRegister_Enter(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {
        }

        #region==========AGE VALIDATION==========

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxAge.Text))
                {
                    // Handle the case when the textbox is empty
                    // You can display an error message or perform any other appropriate action
                }
                else
                {
                    int age = Convert.ToInt32(textBoxAge.Text);

                    if (age < 1 || age > 100)
                    {
                        MessageBox.Show("Invalid Age", "Age Restriction");
                        textBoxAge.Text = 12.ToString();
                    }
                    else
                    {
                        // Handle valid age input
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurred");
                MessageBox.Show(ex.ToString());
            }

        }

        #endregion

        #region==========CONTACT VALIDATION==========
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion


        private void textBoxName_Leave(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxName.Text))
            {
                MessageBox.Show("Enter Name", "Name Validation");
            }
            if (string.IsNullOrEmpty(this.textBoxMobileNo.Text) || this.textBoxMobileNo.Text.Length < 10)
            {
                MessageBox.Show("Enter Mobile number", "Mobile number Validation");
            }
            else
            {
                //MessageBox.Show("OK");
                PopUpDisplay pud = new PopUpDisplay(this.textBoxName.Text, Convert.ToInt32(this.textBoxAge.Text), this.textBoxMobileNo.Text);
                pud.ShowDialog();
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textBoxName.Clear();
            this.textBoxAge.Clear();
            this.textBoxMobileNo.Clear();
        }
    }
}
