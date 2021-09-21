using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ActionStrategy action = new ShowMap();
            Navigator navigator = new Navigator(action);
            navigator.ExecuteAction();
            navigator.PrintInformation();

            action = new Searching();
            navigator = new Navigator(action);
            navigator.ExecuteAction();
            navigator.PrintInformation();

            action = new Routing(new PublicTransporteRoute());
            navigator = new Navigator(action);
            navigator.ExecuteAction();
            navigator.PrintInformation();

            action = new Routing(new LandmarkRoute());
            navigator = new Navigator(action);
            navigator.ExecuteAction();
            navigator.PrintInformation();

            Console.ReadKey();

        }
    }
}
