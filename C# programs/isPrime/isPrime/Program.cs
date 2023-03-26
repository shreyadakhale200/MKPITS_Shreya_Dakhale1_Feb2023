using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPrime = 0,first,last,check,divisible_number;
            Console.WriteLine("Enter first : ");
            first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter last : ");
            last = int.Parse(Console.ReadLine());

            for(check = first;check<=last;check++)
            {
                for(divisible_number = 2;divisible_number<check;divisible_number++)
                {
                    if(check%divisible_number == 0)
                    {
                        isPrime = 1; 
                        break;
                    }
                }
                if(isPrime == 0)
                {
                    Console.WriteLine(check + " is prime");
                }
                else
                {
                    Console.WriteLine(check + " is not prime");
                }
                isPrime = 0;
                divisible_number = 2;
                
            }
            Console.ReadKey();
        }
    }
}
