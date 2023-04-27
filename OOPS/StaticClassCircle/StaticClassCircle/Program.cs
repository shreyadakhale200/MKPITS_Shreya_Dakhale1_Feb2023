using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassCircle
{
    public static class Circle
    {
        public static double pi = 3.14f;
        public static int radius;
        public static void CircleCalculate(int radius)
        {
            double AreaOfCircle = pi * radius * radius;
            Console.WriteLine("Area of Circle : " + AreaOfCircle + "\n");
            double CircumferenceOfCircle = 2 * pi * radius;
            Console.WriteLine("Circumference of Circle : " + CircumferenceOfCircle);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle.CircleCalculate(4);
            Console.ReadKey();
        }
    }
}
