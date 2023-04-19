using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_print_string_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int counter = 0;
            Console.WriteLine("Enter a string : ");
            str = Convert.ToString(Console.ReadLine());
            char[] ch2 = str.ToCharArray();

            for (int i = 0; i < ch2.Length; i++)
            {
                for (int j = 0; j < ch2.Length; j++)
                {
                    if (ch2[i] == ch2[j])
                    {
                        if (i > j || j > i)
                        {
                            //Console.WriteLine(ch2[j]);
                            counter++;
                        }
                    }
                }

                if(counter == 1)
                {
                 Console.WriteLine("index " + Array.IndexOf(ch2, ch2[i]) + " : " + ch2[i]);
                }
                counter = 0;
            }
            Console.ReadKey();
        }
    }
}
