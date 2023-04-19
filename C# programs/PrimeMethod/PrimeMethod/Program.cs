// Create a method CheckPrime with one parameter to display the number is prime or not

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Enter a number : ");
            n1 = int.Parse(Console.ReadLine());
            CheckPrime(n1);
            Console.ReadKey();
        }

        static void CheckPrime(int num)
        {
            int counter = 0;
            int i = 2;
            while(i<num) 
            {
                if(num% i == 0)
                {
                    counter++;
                    break;
                }
                i++;
            }if(num == 0)
            {
                Console.WriteLine(num + " neither prime nor Composite");
            }
            else if(counter == 0)
            {
                Console.WriteLine(num + " is prime");
            }
            else
            {
                Console.WriteLine(num + " is not prime");
            }
        }
    }
}
