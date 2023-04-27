using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumShapes
{
    class Perimeter
    {
        public enum shape
        {
            Circle, Square
        }

        public void Peri(int val, shape s1)
        {
            if (s1 == 0)
            {
                double cir = 2 * 3.14 * val;
                Console.WriteLine("Circumference of a circle : " + cir);
            }
            else
            {
                double perimeter = 4 * val;
                Console.WriteLine("Perimeter of a Square : " + perimeter);
            }
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Perimeter p1 = new Perimeter();
                p1.Peri(3, Perimeter.shape.Circle);
                p1.Peri(4, Perimeter.shape.Square);
                Console.ReadKey();
            }
        }
}
