using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Renault reno = new Renault("Рено", "Renault LOGAN Active", 499.0);
            Print(reno);
            AutoBase myreno = new MediaNAV(reno, "Навигация");
            Print(myreno);
            AutoBase newmyReno = new SystemSecurity(new MediaNAV(reno, "Навигация"), "Безопасность");
            Print(newmyReno);

            Console.WriteLine("\n");

            Audi audi = new Audi("Ауди", "Audi e-tron", 999.0);
            Print(audi);
            AutoBase audiEl = new ElectricityPower(audi, "Электрический двигатель");
            Print(audiEl);
            AutoBase topAudi = new AdditionalLights(audiEl, "Дополнительная подсветка");
            Print(topAudi);


            Console.ReadKey();
        }
        private static void Print(AutoBase av)
        {
            Console.WriteLine(av.ToString());
        }
    }
}
