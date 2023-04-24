//wap to accept a number and print whether it is prime no. or not. using for loop

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberForLOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            int num;
            Console.WriteLine("Enter a num : ");
            num = int.Parse(Console.ReadLine());
            int counter = 0;
            for(i=2;i<num;i++)
            {
                if(num%i == 0)
                {
                    counter++;
                    break;
                }
            }
            if(num==0)
            {
                Console.WriteLine(num + " is not a prime number nor composite");
            }
            else if(counter == 0)
            {
                Console.WriteLine(num + " is a prime number");
            }
            else
            {
                Console.WriteLine(num + " is a composite number");
            }
            Console.ReadKey();
        }
    }
}
