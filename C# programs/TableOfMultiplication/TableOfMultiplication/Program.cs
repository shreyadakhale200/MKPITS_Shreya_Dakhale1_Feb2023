using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOfMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,num;
            Console.WriteLine("Enter a num to calculate its table : ");
            num = int.Parse(Console.ReadLine());
            int multiply = 1;
            for(i=1;i<=10; i++)
            {
                multiply = num * i;
                //Console.WriteLine(num + " * " + i + " = " +  multiply);
                Console.WriteLine("{2} * {1} = {2}",num,i,multiply);
            }
            Console.ReadKey();
        }
    }
}
