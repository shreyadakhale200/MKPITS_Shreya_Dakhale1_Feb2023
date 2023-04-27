using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace InheritanceSingleOverridingOverloading
{
    internal class Program
    {
        class person
        {
            string name;
            string address;
            double number;

            public void getData(string name, string address, double number) // method overloading
            {
                this.name = name;
                this.address = address;
                this.number = number;
            }
            public void display() // method overriding
            {
                Console.WriteLine("Name : " + name);
                Console.WriteLine("address : " + address);
                Console.WriteLine("number : " + number);
            }
        }
        class customer : person
        {
            int cust_id;

            public void getData(int cust_id,string name,string address,double number)// method overloading
               // (string name, string address, double number)  // for accessing persong class method's data
            {
                this.cust_id = cust_id;
                getData(name, address, number); // to access getdata of person
            }
            public void display() // method overriding
            {
                Console.WriteLine("Customer id : "+ cust_id);
                base.display(); // to access display data of person
            }
        }
        static void Main(string[] args)
        {
            customer customer = new customer();
            customer.getData(32, "Shreya", "Nagpur", 3249209340);
            customer.display();
            Console.ReadKey();
        }
    }
}
