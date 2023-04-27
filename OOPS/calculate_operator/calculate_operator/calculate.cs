using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    class Calculates
    {
        int num1, num2;
        int result = 0;
        char op;

        public int calculateResult(int num1, int num2, char op)
        {
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;
            }
            return result;
        }
    }
}
