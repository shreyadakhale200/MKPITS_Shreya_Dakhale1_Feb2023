using System.Data;

namespace ProductStoreProject
{
    public partial class Form1 : Form
    {
        enum Nationality { Indian, NRI }
        Nationality nationality;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }
        int CGST = 0;
        int SGST = 0;
        int IGST = 0;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            if (nationality == 0)
            {
                textBox3.Text = CGST.ToString();
                textBox4.Text = SGST.ToString();
                textBox5.Text = (Convert.ToInt32(CGST) + Convert.ToInt32(SGST)).ToString();

            }
            else
            {
                textBox3.Text = CGST.ToString();
                textBox4.Text = SGST.ToString();
                textBox5.Text = IGST.ToString();
            }
            TotalPrice();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductDatabase.GetTableProductCategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_Type_Name";
            comboBox1.ValueMember = "Product_Category_ID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductDatabase.GetTableProduct(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "ProductName";
            comboBox2.ValueMember = "ProductID";

            DataSet ds1 = ProductDatabase.GetPrice(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox9.Text = Convert.ToInt32(dr["price"]).ToString();
            }

            GSTDetails();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = ProductDatabase.GetPrice(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox9.Text = Convert.ToInt32(dr["price"]).ToString();
            }


            DataSet ds2 = ProductDatabase.GetTableGSTDetails(comboBox1.Text);
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                CGST = Convert.ToInt32(dr["cgst"]);
                SGST = Convert.ToInt32(dr["sgst"]);
                IGST = Convert.ToInt32(dr["igst"]);
            }

            GSTDetails();
        }
        public void GSTDetails()
        {
            if (nationality == 0)
            {
                textBox3.Text = CGST.ToString();
                textBox4.Text = SGST.ToString();
                textBox5.Text = (Convert.ToInt32(CGST) + Convert.ToInt32(SGST)).ToString();

            }
            else
            {
                textBox3.Text = CGST.ToString();
                textBox4.Text = SGST.ToString();
                textBox5.Text = IGST.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            if (nationality == 0)
            {
                textBox3.Text = CGST.ToString();
                textBox4.Text = SGST.ToString();
                textBox5.Text = (Convert.ToInt32(CGST) + Convert.ToInt32(SGST)).ToString();

            }
            else
            {
                textBox3.Text = CGST.ToString();
                textBox4.Text = SGST.ToString();
                textBox5.Text = IGST.ToString();
            }
            TotalPrice();
        }

        public void TotalPrice()
        {
            double Total_Amount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text);
            textBox11.Text = Total_Amount.ToString();

            double cgstprice = Convert.ToDouble(textBox11.Text) * (Convert.ToDouble(textBox3.Text) / 100);
            double sgstprice = Convert.ToDouble(textBox11.Text) * (Convert.ToDouble(textBox4.Text) / 100);
            double igstprice = Convert.ToDouble(textBox11.Text) * (Convert.ToDouble(textBox5.Text) / 100);

            textBox6.Text = cgstprice.ToString();
            textBox7.Text = sgstprice.ToString();
            textBox8.Text = igstprice.ToString();

            textBox12.Text = (Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox8.Text)).ToString();

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {

            }
            else
            {
                TotalPrice();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            TotalPrice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter missing values");
            }
            else if (textBox10.Text == "0")
            {
                MessageBox.Show("Quantity cant be 0");
            }

            String result = ProductDatabase.GetTableInvoiceDetails(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(nationality), dateTimePicker1.Value, Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox11.Text));
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            dateTimePicker1.MinDate = DateTime.Today;
            textBox10.Text = "";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            if (textBox9.Text != "")
            {
                textBox9.Text = "0";
            }
            //textBox11.Text = "0";
            //textBox12.Text = "0";

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}