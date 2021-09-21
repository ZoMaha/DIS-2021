using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Routing : ActionStrategy
    {
        RouteStrategy routeType;
        public Routing(RouteStrategy routeType)
        {
            this.routeType = routeType;
            Title = "Прокладка маршрута: \"" + routeType.Title + "\"";
        }
        public override String Execution()
        {
            return (routeType.Execution());
        }
    }

}
