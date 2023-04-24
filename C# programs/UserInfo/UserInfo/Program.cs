//wap to accept rno, name , age , course , mobileno and print it
using System;
namespace Program
{
	class Program
	{
		static void Main()
		{
			int rollNo, age;
			double mobileno;
			string name, course;
			Console.WriteLine("Enter your Roll number : ");
			rollNo = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter your name : ");
			name = Console.ReadLine();

			Console.WriteLine("Enter your age : ");
			age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter your course : ");
			course = Console.ReadLine();

			Console.WriteLine("Enter your Mobile Number : ");
			mobileno = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Your Roll Number is : " + rollNo);
			Console.WriteLine("Your name is : " + name);
			Console.WriteLine("Your age is : " + age);
			Console.WriteLine("Your course is : " + course);
			Console.WriteLine("Your Mobile Number is : " + mobileno);

		}
	}
}