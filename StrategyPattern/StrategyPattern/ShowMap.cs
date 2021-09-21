using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ShowMap : ActionStrategy
    {
        public ShowMap()
        {
            Title = "Отображение карты";
        }
        public override String Execution()
        {
            return "Допустим, что это карта";
        }
    }

}
