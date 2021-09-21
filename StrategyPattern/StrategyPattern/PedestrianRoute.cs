using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class PedestrianRoute : RouteStrategy
    {
        public PedestrianRoute()
        {
            Title = "пеший маршрут";
        }
        public override String Execution()
        {
            return ("Выполнено построение пешеходного маршрута");
        }
    }

}
