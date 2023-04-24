using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCircumOfCircl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float circum, area;
            area = 0.0f;
            circum = 0.0f;
            Console.WriteLine("Enter the readius : ");
            radius = Convert.ToInt32(Console.ReadLine());
            Calculatearea(radius, ref area, ref circum);
            Console.WriteLine("area of circle : " + area);
            Console.WriteLine("Circumference of circle : " + circum);
            Console.ReadKey();
        }
        static void Calculatearea(int r, ref float a, ref float c)
        {
            a = 3.14f * r * r;
            c = 2 * 3.14f * r;
        }
    }
}
