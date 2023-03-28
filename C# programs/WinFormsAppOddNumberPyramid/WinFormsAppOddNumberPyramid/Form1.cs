using System.Text;

namespace WinFormsAppOddNumberPyramid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            //string builder class is used to append new string to the existing string
            int height = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    sb.Append(" ");
                }
                for (int k = 1; k < 2 * i; k++)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }
            label2.Text = sb.ToString();
        }


    }
}