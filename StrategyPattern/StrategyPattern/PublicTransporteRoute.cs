using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class PublicTransporteRoute : RouteStrategy
    {
        public PublicTransporteRoute()
        {
            Title = "маршрут на общественном транспорте";
        }
        public override String Execution()
        {
            return ("Выполнено построение маршрута на общественном транспорте");
        }

    }
}
