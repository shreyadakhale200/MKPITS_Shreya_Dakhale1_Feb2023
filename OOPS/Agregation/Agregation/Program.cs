using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregation
{
    class Address
    {
        public string City;
        public string State;

        public Address(string city, string state)
        {
            this.City = city;
            this.State = state;
        }
    }

    class employee
    {
        public int empno;
        public string name;
        public Address add; //reference entity of Address class

        public employee(int empno, string name, Address add)
        {
            this.empno = empno;
            this.name = name;
            this.add = add;
        }
        public void display()
        {
            Console.WriteLine(empno);
            Console.WriteLine(name);
            Console.WriteLine(add.City);
            Console.WriteLine(add.State);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Address a1 = new Address("Nagpur","Maharashtra");
            employee emp = new employee(32, "Rupali",a1);
            emp.display();
            Console.ReadKey();
        }
    }
}
