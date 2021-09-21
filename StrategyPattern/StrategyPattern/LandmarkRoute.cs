using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class LandmarkRoute : RouteStrategy
    {
        public LandmarkRoute()
        {
            Title = "маршрут по достопримечательностям";
        }
        public override String Execution()
        {
            return ("Выполнено построение маршрута по достопримечательностям");
        }

    }
}
