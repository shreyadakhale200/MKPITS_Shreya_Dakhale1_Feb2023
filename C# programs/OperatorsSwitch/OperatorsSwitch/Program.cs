using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2,result=0;
            char Operator;
            Console.WriteLine("Enter number 1 : ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2 : ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Operator : ");
            Operator = Convert.ToChar(Console.ReadLine());

            switch (Operator)
            {
                case '+':
                    result = number1 + number2;
                    break;

                case '-':
                    result = number1 - number2;
                    break;

                case '*':
                    result = number1 * number2;
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
            Console.WriteLine(number1 + " " + Operator + " " + number2 + "  = " + result);
            Console.ReadKey();
        }
    }
}
