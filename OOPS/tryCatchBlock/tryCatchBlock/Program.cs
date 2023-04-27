using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchBlock
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 0;

            try
            {
                int res = num1 / num2;
                Console.WriteLine("result : " + res);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();  
        }
    }
}
