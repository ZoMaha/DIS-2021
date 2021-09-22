using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_time_tracking_system
{
    class Report
    {
        ReportStrategy reportStrategy;
        String message;
        public Report(ReportStrategy reportStrategy)
        {
            this.reportStrategy = reportStrategy;
        }
        public void GetInformationAction()
        {
            message = reportStrategy.GetInformation();
        }
        public void PrintInformation()
        {
            Console.WriteLine("Операция: {0}\nСтатус выполнения: {1}\n--", reportStrategy.Title, message);
        }
    }

}
