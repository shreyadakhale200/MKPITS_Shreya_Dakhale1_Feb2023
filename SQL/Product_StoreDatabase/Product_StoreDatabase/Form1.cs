using System.Data;

namespace Product_StoreDatabase
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
        int CGST = 0;
        int SGST = 0;
        int IGST = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProducctDatabase.GetTableProduct(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "ProductName";
            comboBox2.ValueMember = "ProductID";

            DataSet ds1 = ProducctDatabase.GetTableProductGSTDetails(comboBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                CGST = Convert.ToInt32(dr["CGST"]);
                SGST = Convert.ToInt32(dr["SGST"]);
                IGST = Convert.ToInt32(dr["IGST"]);
            }
            CGSTDetails();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProducctDatabase.GetTableProductCategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_Type_Name";
            comboBox1.ValueMember = "Product_Category_ID";

        }

        public void CGSTDetails()
        {

            if (nationality == 0)
            {
                textBox3.Text = CGST.ToString();
                textBox4.Text = SGST.ToString();
                textBox5.Text = (SGST + CGST).ToString();
            }
            else
            {
                textBox3.Text = CGST.ToString();
                textBox4.Text = SGST.ToString();
                textBox5.Text = IGST.ToString();

            }
        }

        public void TotalPrice()
        {
            double price = (Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text));
            textBox11.Text = price.ToString();

            double CGST = Convert.ToDouble(textBox11.Text) * (Convert.ToDouble(textBox3.Text) / 100);
            double SGST = Convert.ToDouble(textBox11.Text) * (Convert.ToDouble(textBox4.Text) / 100);
            double IGST = Convert.ToDouble(textBox11.Text) * (Convert.ToDouble(textBox5.Text) / 100);

            textBox6.Text = CGST.ToString();
            textBox7.Text = SGST.ToString();
            textBox8.Text = IGST.ToString();

            double NetAmount = Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox11.Text);
            textBox12.Text = NetAmount.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            CGSTDetails();
            TotalPrice();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds2 = ProducctDatabase.GetTablProductPrice(comboBox2.Text);
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                textBox9.Text = (dr["Price"]).ToString();
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            TotalPrice();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            CGST = CGST;
            SGST = SGST;
            IGST = IGST;

            textBox3.Text = CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text = IGST.ToString();

            TotalPrice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = ProducctDatabase.InsertTableInvoiceDetails(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(nationality), dateTimePicker1.Value, Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox12.Text));
            MessageBox.Show(result);
        }
    }
}