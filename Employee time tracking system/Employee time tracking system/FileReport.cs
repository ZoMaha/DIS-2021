using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_time_tracking_system
{
    class FileReport : ReportStrategy
    {
        public FileReport()
        {
            Title = "Информация будет сохранен в файл.";
        }

        public override String GetInformation()
        {
            reportInformation = "Допустим, это отчет";
            GetTheFileInformation(reportInformation); // тут по идее сохранение в файл
            return "Отчет сохранен в файл и открыт.";
        }
        private void GetTheFileInformation(string reportInformation)
        {
            //производится перенос текста в файл
        }

    }
}
