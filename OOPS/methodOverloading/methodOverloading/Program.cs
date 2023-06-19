using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverloading
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            int add = a + b;    
            return add;
        }
        public float Add(float a, float b)
        {
            float add1 = a + b;
            return add1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int addint = calculator.Add(1, 2);
            float sddfloat = calculator.Add(2.32f, 3.54f);
            Console.WriteLine(addint);
            Console.WriteLine(sddfloat);

            //Console.WriteLine(calculator.Add(1,2));
            //Console.WriteLine(calculator.Add(2.32f,3.54f));
            Console.ReadLine();
        }
    }
}
