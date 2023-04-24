using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProgramWHILELOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i = 1,factorial=1;
            Console.WriteLine("Enter a num : ");
            num = int.Parse(Console.ReadLine());
            while(num >= i)  //10>1
            {
                factorial = factorial * num;
                num--;
            }
            Console.WriteLine(factorial);
            Console.ReadKey();
        }
    }
}
