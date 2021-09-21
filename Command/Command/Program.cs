using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator(); 
            double result = 0;
            Console.WriteLine(result);

            Console.WriteLine("___+6");
            result = calculator.Add(6);
            Console.WriteLine(result);

            Console.WriteLine("___*3");
            result = calculator.Multiplication(3);
            Console.WriteLine(result);

            Console.WriteLine("___-4");
            result = calculator.Delete(4);
            Console.WriteLine(result);

            Console.WriteLine("___/2"); //последняя команда (так вышло)
            result = calculator.Division(2);
            Console.WriteLine(result);

            Console.WriteLine("___*повтор последней ком 3 раза*");
            result = calculator.Redo(3);
            Console.WriteLine(result);

            Console.WriteLine("___*отмена последней ком 4 раза");
            result = calculator.Undo(4);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
