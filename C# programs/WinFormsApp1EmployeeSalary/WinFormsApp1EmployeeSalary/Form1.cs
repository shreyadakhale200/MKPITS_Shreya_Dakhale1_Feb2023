namespace WinFormsApp1EmployeeSalary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EmployeeName = textBox1.Text;
            int EmployeeSalary = Convert.ToInt32(textBox2.Text);
            //HRA - House Rent Allowance
            //DA  - Dearness Allowance
            //HRA = 35%
            //DA  = 45%
            int HRA = (EmployeeSalary * 35) / 100;
            int DA = (EmployeeSalary * 45) / 100;
            label3.Text = "HRA : " + HRA;
            label4.Text = "DA : " + DA;
            int total = (EmployeeSalary + HRA + DA);
            label5.Text = "Total Salary = " + total;
        }
    }
}