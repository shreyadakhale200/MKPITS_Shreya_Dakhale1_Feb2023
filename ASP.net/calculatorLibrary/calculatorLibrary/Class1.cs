using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace calculatorLibrary
{
    public class Class1
    {
        public string addition(int number1, int number2)
        {
            int result = number1 + number2;
            return "addition is " + result;
        }
        public string subtraction(int number1, int number2)
        {
            int result = number1 - number2;
            return "substraction is " + result;
        }
        public string multiplication(int number1, int number2)
        {
            int result = number1 * number2;
            return "multiplication is " + result;
        }
        public string division(int number1, int number2)
        {
            int result = number1 / number2;
            return "division is " + result;
        }
    }
}
