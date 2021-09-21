using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class ActionStrategy
    {
        public string Title { get; set; }
        public abstract String Execution();
    }

}
