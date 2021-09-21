using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class DriverRoute : RouteStrategy
    {
        public DriverRoute()
        {
            Title = "автомобильный маршрут";
        }
        public override String Execution()
        {
            return ("Выполнено построение автомобильного маршрута");
        }

    }
}
