//wap to accept productname, productrate , quantity
//suppose laptop, 42000 ,1    display totalamount
//calculate tax =18% if totalamount >= 10000 or tax =12% if total amount >=5000 and total amount < 10000
//or tax =5% if total amount < 5000

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productRateProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String product_name;
            double product_rate,Totalamount=0;
            int quantity;
            Console.WriteLine("Enter Your product Name : ");
            product_name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Product Rate : ");
            product_rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Product Quantity : ");
            quantity = Convert.ToInt32(Console.ReadLine());

            double price = product_rate * quantity;

            if (price >= 10000)
            {
                Totalamount = price + (0.18 * price);
            }
            else if (price >= 5000)
            {
                Totalamount = price + (0.12 * price);
            }
            else if(price < 5000)
            {
                Totalamount = price + (0.05 * price);
            }
            Console.WriteLine("Total amount of " + quantity + " " + product_name + " is : " + Totalamount);
            //calculate tax =18% if totalamount >= 10000 or tax =12% if total amount >=5000 and total amount < 10000
            //or tax =5% if total amount < 5000
            Console.ReadKey();
        }
    }
}
