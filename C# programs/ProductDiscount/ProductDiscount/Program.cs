//wap to accept productname, productrate, quantity
//calculate totalamount, ant then discount ie 50% if totalamount > 2000 else discount =10% of total amount
//do with if else if

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product_name;
            double product_rate,discount;
            int quantity;
            Console.WriteLine("Enter product Name : ");
            product_name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter product Rate :");
            product_rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter product quantity : ");
            quantity = Convert.ToInt32(Console.ReadLine());

            double total_amount = product_rate * quantity;
            if(total_amount > 2000)
            {
             discount = total_amount - (total_amount * 0.50);
            }
            else
            {
             discount = total_amount - (total_amount * 0.10);
            }
            Console.WriteLine("Your amount of " + quantity + " " + product_name + " with " + total_amount + " is = " + discount);
            Console.ReadKey();

        }
    }
}
