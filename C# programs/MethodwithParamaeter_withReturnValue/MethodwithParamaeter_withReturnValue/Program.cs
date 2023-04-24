using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodwithParamaeter_withReturnValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,result;
            Console.WriteLine("Enter a num : ");
            n1 = int.Parse(Console.ReadLine());
            result = Square(n1);
            Console.WriteLine("Square of " + n1 + " is : " + result);
            Console.ReadKey();
        }

        static int Square(int num)
        {
            int square = num * num;
            return square;
        }
    }
}
