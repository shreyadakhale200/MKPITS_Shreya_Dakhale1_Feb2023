using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = 5;
                int num2 = 0;
                int result = num1 / num2;  // this will throw a DivideByZeroException
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted to divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected exception occurred: " + ex.Message);
            }
        }
    }
}
