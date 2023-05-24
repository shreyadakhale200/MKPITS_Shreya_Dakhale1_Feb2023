using System.Data;
using System.Runtime.CompilerServices;

namespace Product_StoreDatabase1
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

        public void GSTDetails()
        {
            if (nationality == 0)
            {
                textBox3.Text = CGST.ToString();
                textBox4.Text = SGST.ToString();
                textBox5.Text = (Convert.ToInt32(SGST) + Convert.ToInt32(CGST)).ToString();

            }
            else
            {
                textBox3.Text = CGST.ToString();
                textBox4.Text = SGST.ToString();
                textBox5.Text = IGST.ToString();

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductDatabase.GetTableProduct(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "ProductName";
            comboBox2.ValueMember = "ProductID";

            DataSet ds1 = ProductDatabase.GetTableProductGSTDetails(comboBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                CGST = Convert.ToInt32(dr["cgst"]);
                SGST = Convert.ToInt32(dr["sgst"]);
                IGST = Convert.ToInt32(dr["igst"]);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataSet ds1 = ProductDatabase.GetPrice(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox9.Text = Convert.ToInt32(dr["price"]).ToString();
            }
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
        public void TotalPrice()
        {
            double TotalAmount = (Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text));
            textBox11.Text = TotalAmount.ToString();

            double cgstprice = (Convert.ToDouble(textBox11.Text) * (Convert.ToDouble(textBox3.Text) / 100));
            double sgstprice = (Convert.ToDouble(textBox11.Text) * (Convert.ToDouble(textBox4.Text) / 100));
            double igstprice = (Convert.ToDouble(textBox11.Text) * (Convert.ToDouble(textBox5.Text) / 100));
            textBox6.Text = cgstprice.ToString();
            textBox7.Text = sgstprice.ToString();
            textBox8.Text = igstprice.ToString();

            double Netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox8.Text);
            textBox12.Text = Netamount.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            GSTDetails();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            GSTDetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Fill the required values");
            }
            else if (textBox10.Text == "0")
            {
                MessageBox.Show("Quantity cant be 0");
            }

            string result = ProductDatabase.InsertTableInvoiceDetails(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(nationality), dateTimePicker1.Value, Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox12.Text));
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
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            dateTimePicker1.MinDate = DateTime.Today;
            comboBox1.Text = "";
        }
    }
}