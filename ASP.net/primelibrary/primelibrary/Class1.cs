using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primelibrary
{
    public class Class1
    {
        public string Prime(int first, int last)
        {
            string primenumber = "";
            int counter = 0;

            for (int i = first; i <= last; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0)
                {
                    primenumber += i + " ";
                }
                counter = 0;
            }
            return "primenumbers are " + primenumber;
        }
    }
}
