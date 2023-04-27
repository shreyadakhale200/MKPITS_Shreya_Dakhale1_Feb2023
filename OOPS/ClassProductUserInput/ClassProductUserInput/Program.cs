using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProductUserInput
{
    class Product
    {
        string product_name;
        int product_rate;
        string expiry_date;
        string manufactured_date;

        public void getProductInfo(string pname, int prate, string expdate, string mdate)
        {
            product_name = pname;
            product_rate = prate;
            expiry_date = expdate;
            manufactured_date = mdate;
        }

        public void displayProductInfo()
        {
            Console.WriteLine("Product's name is : " +  product_name);
            Console.WriteLine("Rate of " +  product_name + " is : " +  product_rate);
            Console.WriteLine("Expiry date of " +  product_name + " is : " +  expiry_date);
            Console.WriteLine("Manufactured date of " +  product_name + " is : " +  manufactured_date);
        }
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Console.WriteLine("Enter your Product name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the rate of your Product : ");
            int rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product's expiry date : ");
            string expdate = Console.ReadLine();

            Console.WriteLine("Enter Product's manufactured date : ");
            string date_of_manufacture = Console.ReadLine();

            p1.getProductInfo(name, rate, expdate, date_of_manufacture);
            p1.displayProductInfo();
            Console.ReadKey();
        }
    }
}
