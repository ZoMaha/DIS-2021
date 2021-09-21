using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    abstract class Command
    {
        protected ArithmeticUnit unit; //арифметическое устройство, выполняющее одну из команд
        protected double operand; 
        public abstract void Execute();  //Выполнение действия
        public abstract void UnExecute(); //Отмена действия
    }
}
