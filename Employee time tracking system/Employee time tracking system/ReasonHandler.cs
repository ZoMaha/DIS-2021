using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_time_tracking_system
{
    abstract class ReasonHandler
    {
        public ReasonHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}
