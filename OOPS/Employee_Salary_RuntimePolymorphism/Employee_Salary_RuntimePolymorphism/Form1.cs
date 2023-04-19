namespace Employee_Salary_RuntimePolymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salary = Convert.ToInt32(textBox2.Text);
            Employee emp = null;
            if(comboBox1.Text == "Manager")
            {
                emp = new Manager();
                label4.Text = emp.calculateSalary(salary).ToString();
            }
            else if(comboBox1.Text == "Engineer")
            {
                emp = new Engineer();
                label4.Text = emp.calculateSalary(salary).ToString();
            }
            else if(comboBox1.Text == "Salesperson")
            {
                emp = new Salesperson();
                label4.Text = emp.calculateSalary(salary).ToString();
            }
        }
    }
}