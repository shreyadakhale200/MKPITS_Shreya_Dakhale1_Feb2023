using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProgramDO_WHILELOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, num, factorial = 1;
            Console.WriteLine("Enter a num : ");
            num = int.Parse(Console.ReadLine());
            do
            {
                factorial = factorial * num;
                num--;
            }while (num > i);
            Console.WriteLine(factorial);
            Console.ReadKey();  
        }
    }
}
