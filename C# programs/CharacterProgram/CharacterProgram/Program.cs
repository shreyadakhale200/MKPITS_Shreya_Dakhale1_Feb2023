using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterProgram
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char ch;
			Console.WriteLine("Enter a character : ");
			ch = Convert.ToChar(Console.ReadLine());
			Console.WriteLine("Character eneterd is : " + ch);
			Console.ReadKey();
		}
	}
}
