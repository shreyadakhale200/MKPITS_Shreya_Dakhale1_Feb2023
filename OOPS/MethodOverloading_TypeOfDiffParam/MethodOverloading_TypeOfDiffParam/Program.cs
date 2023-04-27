using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading_TypeOfDiffParam
{
    class student
    {
        int roll_no;
        string name;

        //Methods having same Method name but different parameters
    public void getData(int roll_no, string name)
    {
        this.roll_no = roll_no;
        this.name = name;
    }
    public void getData(string name, int roll_no)
        {
            this.name = name;
            this.roll_no = roll_no;
        }

    public void dataDisplay()
        {
            Console.WriteLine("Your roll no is : " + roll_no);
            Console.WriteLine("Your name is : " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Student 1 Details----------------------");
            student std1 = new student();
            std1.getData(65, "Rahul");
            std1.dataDisplay();
            Console.WriteLine("---------------------Student 2 Details----------------------");
            student std2 = new student();
            std2.getData("Monali",54);
            std2.dataDisplay();
            Console.ReadKey();
        }
    }
}
