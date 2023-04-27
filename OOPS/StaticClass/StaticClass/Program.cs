using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class Calculate
    {
        public static int n;
        public static float pi = 3.14f ;

        public static int cube(int n)
        {
            return n * n * n;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pi : " + Calculate.pi); 
            Console.WriteLine("cube : " + Calculate.cube(4));
            Console.ReadKey();

        }
    }
}
