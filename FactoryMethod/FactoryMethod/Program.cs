using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportCompany trCom = new TaxiTransCom("Служба такси");
            TransportService compService = trCom.Create("Такси", 1);
            double dist = 15.5;
            Print(compService, dist);

            TransportCompany gCom = new ShipTransCom("Служба перевозок");
            compService = gCom.Create("Грузоперевозки", 2);
            double distg = 150.5; Print(compService, distg);

            DrankDriverCom drankCom = new DrankDriverCom("Перевозка пьяным водителем");
            TransportService drankService = drankCom.Create("Пьяное такси", 10);
            double dist2 = 25.2;
            Print(drankService, dist2);

            Console.ReadKey();
        }

        private static void Print(TransportService compTax, double distg)
        {
            Console.WriteLine("Компания {0}, расстояние {1}, стоимость: {2}", compTax.ToString(), distg, compTax.CostTransportation(distg));
        }
    }
}

