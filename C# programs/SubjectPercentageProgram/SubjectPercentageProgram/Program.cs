//wap to accept 3 subject marks and print total , per and grade

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectPercentageProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Maths,Science,SST;
            Console.WriteLine("Enter Maths marks : ");
            Maths = float.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter Science marks : ");
            Science = float.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter SST marks : ");
            SST = float.Parse(Console.ReadLine());
            float total = Maths + Science + SST;
            float percentage = (total / 300.0f) * 100.0f;
            if(percentage > 90)
            {
                Console.WriteLine("A++");
            }
            else if(percentage > 75 && percentage < 90)
            {
                Console.WriteLine("A");
            }
            else if (percentage > 65 && percentage < 75)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("C");
            }
            Console.ReadKey();
        }
    }
}
