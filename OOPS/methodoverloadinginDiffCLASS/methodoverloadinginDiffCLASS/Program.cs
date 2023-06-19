using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverloadinginDiffCLASS
{
    class cal
    {
        public int add(int x, int y)
        {
            int add = x + y;
            return add;
        }
    }
    class calculate : cal
    {
        public float add(float x, float y)
        {
            float add = x + y;
            return add;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            calculate calc = new calculate();
            cal c = new cal();
            int addint = c.add(1, 2);
            float addfloat = calc.add(2.3f,4.53f);
        }
    }
}
