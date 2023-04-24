using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace functionWithParameters_noReturnValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Enter a number : ");
            n1 = int.Parse(Console.ReadLine());
            oddEven(n1);
            prime(n1); 
            Console.ReadKey();
        }

        static void oddEven(int num)
        {
            if(num%2 == 0)
            {
                Console.WriteLine(num + " is even number");
            }
            else
            {
                Console.WriteLine(num + " is odd number");
            }
        }

        static void prime(int num)
        {
            int counter = 0;
            for(int i=2;i<num; i++)
            {
                if(num%i == 0)
                {
                    counter++;
                    break;
                }
            }
            if(num == 0)
            {
                Console.WriteLine(num + " is neither prime nor composite");
            }
            else if(counter == 0) 
            {
                Console.WriteLine(num + " is prime ");
            }
            else
            {
                Console.WriteLine(num + " is composite ");
            }
        }
    }
}
