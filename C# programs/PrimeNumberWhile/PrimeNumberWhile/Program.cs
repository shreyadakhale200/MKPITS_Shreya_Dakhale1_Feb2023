using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2, num,counter=0;
            Console.WriteLine("Enter a num : ");
            num = int.Parse(Console.ReadLine());
            while (num > i) //i=2;i<num;i++
            {
                if(num%i == 0)
                {
                    counter++;
                    break;
                }
                i++;
            }
            if(num == 0) 
            {
                Console.WriteLine(num + " is nor prime neither composite");
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
