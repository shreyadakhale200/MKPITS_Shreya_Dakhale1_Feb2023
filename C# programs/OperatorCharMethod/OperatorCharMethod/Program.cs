//Create a method calculate with 2 integer parameter and one char parameter to display result

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OperatorCharMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char op;
            Console.WriteLine("Enter number 1 : ");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter number 2 : ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter  a operator : ");
            op = char.Parse(Console.ReadLine());

            int res = Calaculate(num1, num2, op);
            Console.WriteLine(res);

            Console.ReadKey();
        }
        static int Calaculate(int n1,int n2,char op) 
        {
            int result=0;
            switch (op)
            {
                case '+':
                    result = n1 + n2;
                    break;

                case '-':
                    result = n1 - n2;
                    break;

                case '*':
                    result = n1 * n2;
                    break;

                case '/':
                    result = n1 / n2;
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            return result;
        }
    }
}
