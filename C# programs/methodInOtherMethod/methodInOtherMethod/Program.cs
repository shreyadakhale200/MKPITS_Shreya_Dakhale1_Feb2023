using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodInOtherMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Poly students");
            Poly();
            Console.ReadKey();
        }

        static void Poly()
        {
            String[] Name = {"Shreya","Rupali","Vanshika"};
            Console.WriteLine("BE students");
            BE();
            foreach (String s in Name)
            {
                Console.WriteLine(s);
            }
        }
        static void BE()
        {
            String[] Name = {"Mahima","Pallavi","Rashmi"};
            foreach (String s in Name)
            {
                Console.WriteLine(s);
            }
        }
    }
}
