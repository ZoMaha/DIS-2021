using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    class SystemClimateControl
    {
        public double GetTemperature(IClimateControl climateControl)
        {
            return climateControl.GetTemperature();
        }

    }
}
