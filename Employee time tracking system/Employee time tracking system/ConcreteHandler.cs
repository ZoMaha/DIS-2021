using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_time_tracking_system
{
    class CompletionHandler : ReasonHandler
    {
        public override void Handle(Receiver receiver) 
        { 
            if (receiver.Completion == true) 
                Console.WriteLine("Записываем время и завершаем сеанс"); 
            else if (Successor != null) 
                Successor.Handle(receiver); 
        }
    }

    class LunchHandler : ReasonHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.Lunch == true)
                Console.WriteLine("Записываем время, сеанс не завершается");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }

    class GlitchHandler : ReasonHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.Glitch == true)
                Console.WriteLine("Сеанс завершен некорректно");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
