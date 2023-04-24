using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByReference1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum=0,a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            CalaculateSum(ref sum, a, b);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static void CalaculateSum(ref int sum, int a, int b)
        {
            sum = a + b;
        }
    }
}
