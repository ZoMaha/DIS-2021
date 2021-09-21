using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Searching : ActionStrategy
    {
        public Searching()
        {
            Title = "Поиск места";
        }
        public override String Execution()
        {
            return ("Осуществлен поиск выбранного места");
        }
    }

}
