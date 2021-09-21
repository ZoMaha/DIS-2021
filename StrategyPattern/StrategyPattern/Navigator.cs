using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Navigator
    {
        ActionStrategy actionStrategy;
        String message;
        public Navigator(ActionStrategy actionStrategy)
        {
            this.actionStrategy = actionStrategy;
        }
        public void ExecuteAction()
        {
            message = actionStrategy.Execution();
        }
        public void PrintInformation()
        {
            Console.WriteLine("Операция: {0}. Статус выполнения: {1}", actionStrategy.Title, message);
        }

    }
}
