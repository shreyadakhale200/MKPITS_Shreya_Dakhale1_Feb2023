using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTableDO_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, multiply = 1,num;
            Console.WriteLine("Enter a num : ");
            num = int.Parse(Console.ReadLine());
            do
            {
                multiply = num * i;
                Console.WriteLine(num + " * " + i + " = " + multiply);
                i++;
            }while (i <= 10);
            Console.ReadKey();
        }
    }
}
