using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_time_tracking_system
{
    class Receiver
    {
        public bool Completion { get; set; } //завершение рабочего сенаса
        public bool Lunch { get; set; } //перерыв на обед
        public bool Glitch { get; set; } //сбой
        //далее могут быть указаны другие причины
        
        public Receiver (bool comp, bool lunch)
        {
            Completion = comp;
            Lunch = lunch;
            Glitch = true;
        }
    }
}
