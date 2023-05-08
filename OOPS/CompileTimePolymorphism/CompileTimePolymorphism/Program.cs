using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileTimePolymorphism
{
    class Add
    {
        public void Calculate(int  number1, int number2)
        {
            int add = number1 + number2;
            Console.WriteLine(add);
        }
    }
    class Multiply : Add
    {
        public void Calculate(int number1, int number2, int number3)
        {
            int mul = number1 * number2 * number3;
            Console.WriteLine(mul);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Multiply m = new Multiply();
            m.Calculate(1, 2);
            m.Calculate(2, 3, 5);
            Console.ReadKey();
        }
    }
}
