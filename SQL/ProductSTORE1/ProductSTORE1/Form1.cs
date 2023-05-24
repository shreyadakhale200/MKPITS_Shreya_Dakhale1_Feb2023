using System.Data;
using System.Runtime.CompilerServices;

namespace ProductSTORE1
{
    public partial class Form1 : Form
    {
        enum Nationality { Indian, NRI }
        Nationality nationality;
        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductDatabase.GetTableProductCategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_Type_Name";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductDatabase.GetTableProduct(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "ProductName";

            DataSet ds1 = ProductDatabase.GetTableGSTDetails(comboBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                cgst = Convert.ToInt32(dr["cgst"]);
                sgst = Convert.ToInt32(dr["sgst"]);
                igst = Convert.ToInt32(dr["igst"]);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductDatabase.GetPrice(comboBox2.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox9.Text = Convert.ToInt32(dr["price"]).ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            GstDetails();
        }
        public void GstDetails()
        {
            if (nationality == 0)
            {
                textBox3.Text = cgst.ToString();
                textBox4.Text = sgst.ToString();
                textBox5.Text = (cgst + sgst).ToString();
            }
            else
            {
                textBox3.Text = cgst.ToString();
                textBox4.Text = sgst.ToString();
                textBox5.Text = igst.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            GstDetails();
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

            Double NetAmount = (Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox11.Text));
            textBox12.Text = NetAmount.ToString();
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
    }
}