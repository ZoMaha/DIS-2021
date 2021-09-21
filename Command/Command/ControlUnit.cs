using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class ControlUnit //Организация работы калькулятора 
    {
        private List<Command> commands = new List<Command>();
        private int current = 0;
        public void StoreCommand(Command command) //добавление команды в список
        {
            commands.Add(command);
        }
        public void ExecuteCommand() //Выполнение команды
        {
            commands[current].Execute();
            current++;
        }
        public void Undo() //Отмена последней команды
        {
            commands[current - 1].UnExecute();
        }
        public void Undo(int count) //Отмена последней команды count раз
        {
            if (commands.Count() >= count)
            {
                for (int i = 0; i < count; i++)
                {
                    commands[current - 1].UnExecute();
                }
            }
            else 
                Console.WriteLine("Выход за пределы списка. Ошибка выполнения команды");
        }
        public void Redo() //Повтор последней команды
        {
            commands[current - 1].Execute();
        }
        public void Redo(int count) //Повтор последней команды count раз
        {
            for (int i = 0; i < count; i++)
            {
                commands[current - 1].Execute();
            }
        }
    }
}
