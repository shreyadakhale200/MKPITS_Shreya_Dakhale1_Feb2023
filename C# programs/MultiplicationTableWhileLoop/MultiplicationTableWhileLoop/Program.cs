using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTableWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1, i = 1 , multiply=1;
            Console.WriteLine("Enter a num to calculate its table : ");
            num = int.Parse(Console.ReadLine());
            while (i<=10)
            {
                multiply = num * i;
                Console.WriteLine(num + " * " + i + " = " + multiply);
                i++;
            }
            Console.ReadKey();
        }
    }
}
