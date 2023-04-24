using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Method without parameters and returning a value
namespace squareFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = CalculateSquare();
            Console.WriteLine("Sqwuare is : " + result);
            Console.ReadKey();
        }

        static int CalculateSquare()
        {
            int num;
            Console.WriteLine("Enter a num : ");
            num = int.Parse(Console.ReadLine());
            int square = num * num;
            return square;
        }
    }
}
