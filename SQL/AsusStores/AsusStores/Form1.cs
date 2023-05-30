using System.Data;

namespace AsusStores
{
    public partial class Form1 : Form
    {
        enum Gender { Male,Female,Other};
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

                switch (listBox1.Text)
                {
                    case "Asus":
                        Calculate();
                        break;

                    case "Dell":
                        Calculate(); 
                        break;

                    case "Acer":
                        Calculate(); 
                        break;

                    case "Lenovo":
                        Calculate();
                        break;

                    case "Alienware":
                        Calculate();
                        break;

                    case "Apple":
                        Calculate();
                        break;

                    case "Samsung":
                        Calculate();
                        break;
                }

            }
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
            if(textBox7.Text == "")
            {

            }
            else
            {
                Calculate();
            }
        }
    }
}