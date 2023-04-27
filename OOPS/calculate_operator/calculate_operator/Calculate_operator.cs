using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_operator
{
    class Calculate_operator
    {
        int num1, num2;
        int result = 0;
        char op;
        public Calculate_operator(int num1, int num2, char op)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.op = op;
        }
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
                case '/':
                    result = num1 / num2;
                    break;
            }
            return result;
        }
    }
}
