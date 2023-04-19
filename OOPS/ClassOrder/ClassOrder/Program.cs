using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOrder
{
    class order
    {
        int order_no;
        
        string dish_name1;
        
        int dish_rate1;
    

        public void getOrderdetails(int order_no,string dish_name1,int dish_rate1)
        {
            this.order_no = order_no;
            this.dish_name1 = dish_name1;
            this.dish_rate1 = dish_rate1;
         
        }
        public void displayOrderDetails()
        {
            Console.WriteLine("Your order number is : " + order_no);
            Console.WriteLine("Your dish name is : " + dish_name1);
            Console.WriteLine("rate of dish 1 is : " + dish_rate1);
            Console.WriteLine("your total bill is : " + (dish_rate1));

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            order o1 = new order();


            Console.WriteLine("Enter order number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter dish 1 : ");
            string dish1 = Console.ReadLine();

            Console.WriteLine("Enter rate of dish");
            int dish1rate = Convert.ToInt32(Console.ReadLine());

            o1.getOrderdetails(num, dish1, dish1rate);
            o1.displayOrderDetails();
            Console.ReadKey();

        }
    }
}
