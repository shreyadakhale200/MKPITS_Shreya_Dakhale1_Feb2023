using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area, circum;
            Console.WriteLine("Enter the radius : ");
            radius = Convert.ToInt32(Console.ReadLine());
            Calculatearea(radius, out area, out circum);
            Console.WriteLine("area of circle : " +  area); 
            Console.WriteLine("circumference of circle : " +  circum);
            Console.ReadKey();
        }
        static void Calculatearea(int r,out float a, out float c)
        {
            a = 3.14f * r * r;
            c = 2 * 3.14f * r;
        }
    }
}
