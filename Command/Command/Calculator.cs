using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;
        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }
        private double Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }
        public double Add(double operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }
        public double Delete(double operand)
        {
            return Run(new Delete(arithmeticUnit, operand));
        }
        public double Multiplication(double operand)
        {
            return Run(new Multiplication(arithmeticUnit, operand));
        }
        public double Division(double operand)
        {
            return Run(new Division(arithmeticUnit, operand));
        }
        public double Redo()
        {
            controlUnit.Redo();
            return arithmeticUnit.Register;
        }
        public double Undo()
        {
            controlUnit.Undo();
            return arithmeticUnit.Register;
        }
        public double Undo(int count)
        {
            controlUnit.Undo(count);
            return arithmeticUnit.Register;
        }
        public double Redo(int count)
        {
            for (int i = 0; i < count; i++)
            {
                controlUnit.Redo();
            }
            return arithmeticUnit.Register;
        }
    }
}
