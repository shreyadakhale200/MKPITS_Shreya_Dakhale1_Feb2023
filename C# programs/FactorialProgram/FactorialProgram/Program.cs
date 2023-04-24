using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5*4*3*2*1 = 120
            int num,i=1,j,factorial=1;
            Console.WriteLine("Enter a num to calculate its Factorial : ");
            num = int.Parse(Console.ReadLine());
            for(j=num;j>=i;j--)
            {
                factorial = factorial * j;
                Console.Write(factorial + " * " + j + " = " + factorial);
                Console.WriteLine(" , factorial = " + factorial);
            }
            Console.WriteLine(factorial);
            Console.ReadKey();
        }
    }
}
