using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_time_tracking_system
{
    abstract class ReportStrategy
    {
        public string reportInformation { get; set; }
        public string Title { get; set; }
        public abstract String GetInformation();

    }
}
