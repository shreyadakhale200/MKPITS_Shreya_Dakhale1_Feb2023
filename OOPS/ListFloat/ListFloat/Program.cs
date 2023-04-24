using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFloat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> Li1 = new List<double>();
            Li1.Add(10.5);
            Li1.Add(20.4);
            Li1.Add(54.3);
            Li1.Add(98.3);
            Li1.Add(87.3);

            foreach(double d in Li1)
            {
                System.Console.WriteLine(d);
            }
            Console.ReadKey();
        }

    }
}
