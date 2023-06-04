using System.Data;

namespace AsusStores
{
    public partial class Form1 : Form
    {
        enum Gender { Male, Female, Other };
        Gender gender;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = InvoiceDatabase.GetProductName();
            listBox1.DataSource = ds.Tables[0];
            listBox1.DisplayMember = "Name";
        }
        double cgst = 0;
        double sgst = 0;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = InvoiceDatabase.GetProductDetails(listBox1.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox3.Text = dr["Name"].ToString();
                textBox4.Text = dr["AVAILABLE_QTY"].ToString();
                textBox5.Text = dr["SELL_QTY"].ToString();
                textBox6.Text = dr["PRICE_PER_UNIT"].ToString();
                textBox9.Text = dr["CGST"].ToString();
                textBox11.Text = dr["SGST"].ToString();
            }
            double TotalPrice = Convert.ToDouble(textBox6.Text) * Convert.ToDouble(textBox7.Text);
            textBox8.Text = TotalPrice.ToString();

            //DataSet ds1 = InvoiceDatabase.GetProductDetails(listBox1.Text);
            //foreach (DataRow dr1 in ds1.Tables[0].Rows)
            //{
            //    textBox9.Text = dr1["CGST"].ToString();
            //    textBox11.Text = dr1["SGST"].ToString();
            //}
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void Calculate()
        {
            double TotalPrice = Convert.ToDouble(textBox6.Text) * Convert.ToDouble(textBox7.Text);
            textBox8.Text = TotalPrice.ToString();

            double cgst = Convert.ToDouble(textBox8.Text) * (Convert.ToDouble(textBox9.Text) / 100);
            textBox10.Text = cgst.ToString();

            double sgst = Convert.ToDouble(textBox8.Text) * (Convert.ToDouble(textBox11.Text) / 100);
            textBox12.Text = sgst.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {

            }
            else
            {
                Calculate();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            double cgst = Convert.ToDouble(textBox8.Text) * (Convert.ToDouble(textBox9.Text) / 100);
            textBox10.Text = cgst.ToString();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            double sgst = Convert.ToDouble(textBox8.Text) * (Convert.ToDouble(textBox11.Text) / 100);
            textBox12.Text = sgst.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                double PaidAmount = Convert.ToDouble(textBox10.Text) + Convert.ToDouble(textBox8.Text);
                textBox16.Text = PaidAmount.ToString();
                textBox16.Enabled = false;
            }
            else if (radioButton4.Checked)
            {
                textBox16.Enabled = true;
                textBox16.Text = string.Empty;
                double emi = Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox16.Text);
                label1.Text = emi.ToString();
                }
            }
        }

        
    }
