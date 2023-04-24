using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProgram
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name;
			Console.WriteLine("Enter your name : ");
			name = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Your name is : " + name);
			Console.ReadKey();
		}
	}
}
