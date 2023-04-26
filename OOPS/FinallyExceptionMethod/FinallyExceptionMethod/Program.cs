using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FinallyExceptionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 0;

            try
            {
                int res = num1 / num2;
                Console.WriteLine("result = " + res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine("Finally Executed");
            }
            Console.WriteLine("BYe" + "\n");

            int num3 = 12;
            int num4 = 2;

            try
            {
                int res = num3 / num4;
                Console.WriteLine("result = " + res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine("Finally Executed Second time.");
            }
            Console.WriteLine("Bye Again");

            Console.ReadKey();
        }
    }
}
