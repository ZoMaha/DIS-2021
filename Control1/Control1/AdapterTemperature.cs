using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    class AdapterTemperature :IClimateControl
    {
        TemperatureInCelsius temperatureInCelsius;
        public AdapterTemperature(TemperatureInCelsius temperatureInCelsius)
        {
            this.temperatureInCelsius = temperatureInCelsius;
        }
        public double GetTemperature()
        {
            return temperatureInCelsius.GetTemperatureInCelsius();
        }

    }
}
