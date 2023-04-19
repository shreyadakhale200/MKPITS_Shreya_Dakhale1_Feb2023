using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomerClass
{
    class customer
    {
        string name;
        string Address;
        double couponNo;
        int totalBill;
    public void getCustomerInfo(string n, string a,double c, int b)
    {
        name = n;
        Address = a;
        couponNo = c;
        totalBill = b;
    }
    
    public void displayCustomerInfo()
        {
            Console.WriteLine("Name of customer is : " +  name);
            Console.WriteLine("Address of customer is : " +  Address);
            Console.WriteLine("Coupon number of customer is : " + couponNo);
            Console.WriteLine("Total price customer bought is : " + totalBill);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            customer c1 = new customer();
            
            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Address : ");
            string Address = Console.ReadLine();

            Console.WriteLine("Enter coupon number : ");
            double coupon = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter total bill : ");
            int totalBill = Convert.ToInt32(Console.ReadLine());

            c1.getCustomerInfo(name, Address, coupon, totalBill);
            c1.displayCustomerInfo();
            Console.ReadKey();
        }
    }
}
