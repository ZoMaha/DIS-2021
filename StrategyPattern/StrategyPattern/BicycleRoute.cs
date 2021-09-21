using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class BicycleRoute : RouteStrategy
    {
        public BicycleRoute() 
        {
            Title = "велосипедный маршрут";
        }
        public override String Execution()
        {
            return ("Выполнено построение велосипедного маршрута");
        }

    }
}
