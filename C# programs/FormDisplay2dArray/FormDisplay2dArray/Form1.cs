using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FormDisplay2dArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        int row_counter = 1;
        int outer_loop = 0;
        int inner_loop = 0;
        int row, column;
        int[,] data;
          
        private void button1_Click(object sender, EventArgs e)
        {
            row = Convert.ToInt32(textBox1.Text);
            column = Convert.ToInt32(textBox2.Text);
             data = new int[row, column];
            StringBuilder sb = new StringBuilder();
            // row = 3, col = 3
            /*                      (0,0) (0,1) (0,2)
            /*(0,0) (0,1) (0,2)      il=0  il=1  il=2
            /*(1,0) (1,1) (1,2) 
            /*(1,0) (1,1) (1,2) 
             * 
            // row = 2, col = 2
             * (0,0) (0,1)
             * (1,0) (1,1)
             * 
             * row*column = 9/row,   row*column = 9/column
             * 9/3 = 3                  9/3 = 3
             * 
             * row*column = 4/row,   row*column = 4/column
             * 4/2 = 2                 4/2 = 2
             * 
             * (2,3)                 (2,3)
             * row*column = 6/row,   row*column = 6/column
             * 6/2 = 3                 6/3 = 2
             * 
             * (3,2)                 (3,2)
             * row*column = 6/row,   row*column = 6/column
             * 6/3 = 2                 6/2 = 3
             * if(inner_loop < ((row*column)/row))
             * (row*column)/row
             * 
             */
            if (outer_loop <= (row * column))
            {
                if (inner_loop <= (row * column))
                {
                    try
                    {
                        data[outer_loop, inner_loop] = Convert.ToInt32(textBox3.Text);
                        //label4.Text += data[outer_loop, inner_loop].ToString() + " ";
                    }
                    catch (Exception ex)
                    {
                        button1.Enabled = false;
                    }

                    inner_loop++;
                    if (inner_loop == ((row * column) / row))
                    {
                        outer_loop++;
                        inner_loop = 0;
                        label4.Text += "\n";
                    }
                }
            }
            if (counter > (row * counter))
            {
                button1.Enabled = false;
            }
            /*
            for (int outer_loop = 0; outer_loop < row; outer_loop++)
            {
                for (int inner_loop = 0; inner_loop < column; inner_loop++)
                {
                    data[outer_loop, inner_loop] = Convert.ToInt32(textBox3.Text);
                }
                label4.Text += "\n";
            }
            */
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<= row; i++)
            {
                for (int j = 0; j <=column; column++)
                {
                    label4.Text = data[row,column].ToString();
                }
               
            }
        }
        }
}

    /*    
    public int[,] twoD_ArrayDisplay()
         {
             for (int display_outer_loop = 0; display_outer_loop <= (row * column); display_outer_loop++)
             {
                 for (int display_inner_loop = 0; display_inner_loop <= (row * column); display_inner_loop++)
                 {
                     label4.Text += "Array : " + data[display_outer_loop, display_inner_loop].ToString() + " ";
                 }
                 label4.Text += "\n";
             }
             return data;
         }
      */