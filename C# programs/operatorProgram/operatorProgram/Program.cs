//-wap to accept 2 no and operator like + - * and display the result

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Enter number 1 : ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2 : ");
            number2 = Convert.ToInt32(Console.ReadLine());

            int add, subtract, multiply;
            add = number1 + number2;
            subtract = number1 - number2;
            multiply = number1 * number2;
            Console.WriteLine(number1 + " + " + number2 + " = " + add);
            Console.WriteLine(number1 + " - " + number2 + " = " + subtract);
            Console.WriteLine(number1 + " * " + number2 + " = " + multiply);
            Console.ReadKey();
        }
    }
}
