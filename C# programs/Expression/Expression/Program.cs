using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 5;
            int x = 10;
            //BODMAS = Bracket, Operator, Division, Maths, Addition, Substraction 
            int z = 4 * 5 + 10 / 10;
            Console.WriteLine(z);
            

            float a = 7, b = 3, c = 2;
            float y = a + b / c - c;
            //BODMAS = Bracket, Operator, Division, Maths, Addition, Substraction 
            Console.WriteLine(y);

            float sum = ++a + b + c++;
            Console.WriteLine(sum);

            k = 10;
            x = 20;
            int div = (4 * k + x )/ 10; 
            Console.WriteLine(div);

            // 2x + 4y + 9
            //---------------
            //   9k  -  2
            float expression = ((2 * x) + (4 * y) + 9) / ((9 * k) - 2);
            Console.ReadKey();
        }
    }
}
