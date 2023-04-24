using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 1, last = 5,even=0,sum=0;

            first:
            while(first <= last)
            {
                if(first%2==0)
                {
                    even = first;
                    goto add;
                }
                first++;
            }goto end;
        add:
            sum = even + sum;
            first++;
            goto first;

        end:
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
