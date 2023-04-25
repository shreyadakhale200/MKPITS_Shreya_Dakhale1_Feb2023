using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingAndOverridingMathods
{
    class SevenSTD
    {
        public string SubjectName = "Geometry";
        public static int Geometry;
        public virtual void SubjectMarks()
        {
            Geometry = 78;
            Console.WriteLine("Geometry Marks : " + Geometry);
        }
    }
    class EightSTD:SevenSTD 
    {
        public override void SubjectMarks()
        {
            Geometry = 88;
            Console.WriteLine("Geometry Marks : " + Geometry);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SevenSTD std = null;
            if(SevenSTD.Geometry == 78)
            {
                std = new SevenSTD();
            }
            else
            {
                std = new EightSTD();
            }
            std.SubjectMarks();
            Console.ReadKey();
        }
    }
}
