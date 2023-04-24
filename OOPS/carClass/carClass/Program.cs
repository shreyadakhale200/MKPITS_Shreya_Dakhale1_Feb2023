using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carClass
{
    internal class Program
    {
        class car
        {
            string brand_name;
            string colour;
            double price;
            int mileage;

            public void getCarInfo(string b, string colour, double price, int m)
            {
                brand_name = b;
                colour = colour;
                price = price;
                mileage = m;
            }
            public void displayCarInfo()
            {
                Console.WriteLine("Branf of car : " + brand_name);
                Console.WriteLine("Colour of car : " + colour);
                Console.WriteLine("Price of car : " + price);
                Console.WriteLine("Mileage of car : " + mileage);
            }
        }
        static void Main(string[] args)
        {
            car c1 = new car();
            
            Console.WriteLine("Enter Brand name of car : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter colour of car : ");
            string colour = Console.ReadLine();

            Console.WriteLine("Enter Price of car : ");
            double price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mileage of car : ");
            int mileage = Convert.ToInt32(Console.ReadLine());  

            c1.getCarInfo(name, colour, price, mileage);
            c1.displayCarInfo();
            Console.ReadKey();
        }
    }
}
