//wap to accept 3 no. and display smallest no.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeSmallestNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1,number2,number3;
            Console.WriteLine("Enter number 1 : ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2 : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter number 3 : ");
            number3 = Convert.ToInt32(Console.ReadLine());

            if(number1 < number2 && number1 < number3)
            {
                Console.WriteLine(number1 + " is small than " + number2 + " and " + number3);
            }
            else if (number2 < number1 && number2 < number3)
            {
                Console.WriteLine(number2 + " is small than " + number1 + " and " + number3);
            }
            else
            {
                Console.WriteLine(number3 + " is the smallest");
            }
            Console.ReadKey();
        }
    }
}
