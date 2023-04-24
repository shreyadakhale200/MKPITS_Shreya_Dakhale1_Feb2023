using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentageMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float marks1, marks2, marks3;
            Console.WriteLine("Enter marks of Subject 1 : ");
            marks1 = float.Parse(Console.ReadLine());  

            Console.WriteLine("Enter marks of Subject 2 : ");
            marks2 = float.Parse(Console.ReadLine());     

            Console.WriteLine("Enter marks of Subject 3 : ");
            marks3 = float.Parse(Console.ReadLine());

            float res = Calculate(marks1, marks2, marks3);
            Console.WriteLine(res);
            Console.ReadKey();  
        }

        static float Calculate(float m1,float m2, float m3)
        {
            float total = m1 + m2 + m3;
            float percent = (total / 300) * 100;
            Console.WriteLine(percent);
            if(percent<90)
            {
                Console.WriteLine("A++");
            }
            else if(percent>80 || percent<90)
            {
                Console.WriteLine("A");
            }
            else if (percent>70)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("C");
            }
            return percent;
        }
    }
}
