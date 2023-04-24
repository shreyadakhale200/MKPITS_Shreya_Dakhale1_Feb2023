using System.Diagnostics.Metrics;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ArrayDisplayForm
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int[] arr = new int[5];
        int[] arr1 = new int[5];
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(counter < arr.Length)
            {
                if (counter < arr.Length)
                {
                    arr[counter] = Convert.ToInt32(textBox1.Text);
                    arr1[counter] = arr[counter];
                    arr1 = (int[])arr.Clone();
                    counter++;

                    try 
                    { 
                    if (arr[counter] != 0)
                    {
                        for (int i = 0; i < arr1.Length; i++)
                        {
                            label2.Text = "" + arr1[i];
                        }
                    } 
                    } 
                    catch (Exception ex)
                    {
                        button1.Enabled = false;
                    }
                    
                }
                else if(counter > arr.Length) 
                {
                    button1.Enabled = false;
                }
            textBox1.Clear();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < arr1.Length; i++)
            {
                if (button2.Capture)
                {
                    label2.Text += arr1[i].ToString() + " ";
                }
            }
        }

        /*int counter = 0;
        string num = Convert.ToString(textBox1.Text);
        StringBuilder sb = new StringBuilder();
        if (button1.Capture = true)
        {
         label2.Text += num + " ";
            textBox1.Clear();
        }*/



    }
}