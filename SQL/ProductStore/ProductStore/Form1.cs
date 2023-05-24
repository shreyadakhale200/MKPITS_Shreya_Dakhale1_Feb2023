using System.Data;
using System.Data.SqlClient;

namespace ProductStore
{
    public partial class Form1 : Form
    {
        enum Nationality { Indian, NRI }
        int CGST = 0;
        int SGST = 0;
        int IGST = 0;
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductStoreDatabase.GetTableProductCategory();
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Type_Name";
            comboBox2.ValueMember = "Product_Category_ID";


        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductStoreDatabase.GetTableProductData(comboBox2.Text);
            DataTable productData = ds.Tables[0];

            comboBox1.DataSource = productData;
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ProductID";

            DataSet ds1 = ProductStoreDatabase.GetTableProductGstDetails(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                CGST = Convert.ToInt32(dr["cgst"].ToString());
                SGST = Convert.ToInt32(dr["sgst"].ToString());
                IGST = Convert.ToInt32(dr["igst"].ToString());
            }
            if (nationality == 0)
            {
                textBox4.Text = CGST.ToString();
                textBox5.Text = SGST.ToString();
                textBox6.Text = (CGST + SGST).ToString();

            }
            else
            {
                textBox4.Text = CGST.ToString();
                textBox5.Text = SGST.ToString();
                textBox6.Text = IGST.ToString();
            }

            CalculateGST();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = ProductStoreDatabase.GetProductPrice(comboBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox9.Text = dr["price"].ToString();

            }
            CalculateGST();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {

            }
            else
            {
                CalculateGST();
            }
        }

        Nationality nationality;


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;

            textBox4.Text = CGST.ToString();
            textBox5.Text = SGST.ToString();
            textBox6.Text = (CGST + SGST).ToString();


            CalculateGST();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;

            textBox4.Text = CGST.ToString();
            textBox5.Text = SGST.ToString();
            textBox6.Text = IGST.ToString();

            CalculateGST();
        }

        public void CalculateGST()
        {
            double price = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox3.Text);

            double cgstAmount = price * (Convert.ToDouble(textBox4.Text) / 100);
            textBox11.Text = cgstAmount.ToString();

            double sgstAmount = price * (Convert.ToDouble(textBox5.Text) / 100);
            textBox12.Text = sgstAmount.ToString();

            double igstAmount = price * (Convert.ToDouble(textBox6.Text) / 100);
            textBox13.Text = igstAmount.ToString();

        }


        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = textBox9.Text;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            double NetAmount = Convert.ToDouble(textBox13.Text) + Convert.ToDouble(textBox7.Text);
            textBox8.Text = NetAmount.ToString();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox9.Text = "0";
            textBox3.Text = "0";
            textBox8.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter valid Details");
            }
            else if (textBox3.Text == "0")
            {
                MessageBox.Show("Quantity can't be 0");
            }



            string result = ProductStoreDatabase.SaveTableInvoiceDetails(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(nationality), dateTimePicker1.Value, Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox11.Text), Convert.ToDecimal(textBox12.Text), Convert.ToDecimal(textBox13.Text), Convert.ToDecimal(textBox8.Text));
            //(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(nationality), dateTimePicker1.Value, Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox11.Text), Convert.ToDecimal(textBox12.Text), Convert.ToDecimal(textBox8.Text));
            MessageBox.Show(result);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}