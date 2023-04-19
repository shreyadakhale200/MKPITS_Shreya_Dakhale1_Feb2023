using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritancewithMethods
{
    internal class Program
    {
        class student
        {
            string name;
            int roll_no;

            public void Studentgetdata(string name, int roll_no)
            {
                this.name = name;
                this.roll_no = roll_no;
            }
            public void Studentdisplaydata()
            {
                Console.WriteLine("Student name : " + name);
                Console.WriteLine("Student roll no : " + roll_no);
            }
        }
        class student_info_picnic : student
        {
            int fees;
            string address;
            string pick_up_point;
            int bus_no;

            public void PicnicgetData(int fees, string address, string pick_up_point,int bus_no)
            {
                this.fees = fees;
                this.address = address;
                this.pick_up_point = pick_up_point;
                this.bus_no = bus_no;
            }
            public void PicnicDisplayData()
            {
                Console.WriteLine("Picnic fees : " + fees);
                Console.WriteLine("student address : " + address);
                Console.WriteLine("student pick up point : " +  pick_up_point); 
                Console.WriteLine("student alloted bus no : " +  bus_no);
            }
        }
        static void Main(string[] args)
        {
            student_info_picnic student1 = new student_info_picnic();
            student1.Studentgetdata("Shreya",54);
            student1.PicnicgetData(2000, "Nagpur", "Civil Lines", 3);
            student1.Studentdisplaydata();
            student1.PicnicDisplayData();
            Console.ReadKey();
        }
    }
}
