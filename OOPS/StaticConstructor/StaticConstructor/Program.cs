using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    public class Calculate
    {
        public static float pi = 3.14f;
        static Calculate()
        {
            pi = 3.14f;
            Console.WriteLine("Static constructor is called");
        }
        public void display()
        {
            Console.WriteLine("pie = " + 3.14);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate c1 = new Calculate();
            Calculate c2 = new Calculate();
            c1.display();
            c2.display();   
            Console.ReadKey();
        }
    }
}
