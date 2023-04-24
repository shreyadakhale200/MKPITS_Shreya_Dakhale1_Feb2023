using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outAdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            Add(out a, out b,out sum);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static void Add(out int num1, out int num2,out int sum) 
        {
            Console.WriteLine("Enter a : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b : ");
            num2 = int.Parse(Console.ReadLine()); 
            sum = num1 + num2;
        }
    }
}
