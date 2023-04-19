using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmaticOp_Parameters_returnvalue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,result;
            Console.WriteLine("Enter number 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Calling addition method ");
            result = addition(num1,num2);
            Console.WriteLine("Addition of " + num1 + " + " + num2 + " = " + result);

            Console.WriteLine("\nCalling substraction method");
            result = substraction(num1,num2);
            Console.WriteLine("Substraction of " + num1 + " - " + num2 + " = " + result);
            
            Console.WriteLine("\nCalling division method");
            result = Division(num1,num2);
            Console.WriteLine("Division of " + num1 + " / " + num2 + " = " + result);
            
            Console.WriteLine("\nCalling Multiplication method");
            result = Multiplication(num1,num2);
            Console.WriteLine("Multiplication of " + num1 + " * " + num2 + " = " + result);
            Console.ReadKey();
        }

        static int addition(int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }

        static int substraction(int n1, int n2)
        {
            int result = n1 - n2;
            return result;
        }

        static int Multiplication(int n1, int n2)
        {
            int result = n1 * n2;
            return result;
        }

        static int Division(int n1, int n2)
        {
            int result = n1 / n2;
            return result;
        }
    }
}
