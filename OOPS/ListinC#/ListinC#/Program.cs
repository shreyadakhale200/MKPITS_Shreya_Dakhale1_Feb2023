using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListinC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();
            l1.Add(1);
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);

            foreach(int i in l1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
