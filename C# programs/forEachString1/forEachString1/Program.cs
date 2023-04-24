using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEachString1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Mahima", "Rupali", "Anjali", "Monali", "Karishma", "Yasmin" };    //array litera
                                                                                                //l
            int[] num = new int[] { 23, 54, 87, 34, 87, 98, 16 };   //array constructor

            int[] num1 = new int[5];    //creating an array directly using new keyword
            num1[0] = 32;
            num1[1] = 3;
            num1[2] = 33;
            num1[3] = 34;
            num1[4] = 35;

            int[] num2 = new int[5] {43,65,87,09,12};    //2 method of creating an array directly using new keyword

            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
