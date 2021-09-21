using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class ArithmeticUnit
    {
        public double Register { get; private set; } //"кэш" калькулятора
        public void Run(char operationCode, double operand)
        {
            switch (operationCode)
            {
                case '+':
                    Register += operand; break;
                case '-':
                    Register -= operand; break;
                case '*':
                    Register *= operand;
                    break;
                case '/':
                    Register /= operand;
                    break;
            }
        }
    }
}
