using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_time_tracking_system
{
    class TextReport : ReportStrategy
    {
        public TextReport ()
        {
            Title = "Информация будет представлена в виде уведомления.";
        }

        public override String GetInformation()
        {
            reportInformation = "Допустим, это отчет";
            return "Отчет выполнен";
        }
    }
}
