using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass1
{
    public static class ArithmeticOperations    //static class is  static
    {
        static int num3;  //if class is static then data members or fields should also be static
        public static void Add(int num1, int num2)  //functions must be static if class is static
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperations.Add(1, 2);
            Console.ReadLine();
        }
    }
}
