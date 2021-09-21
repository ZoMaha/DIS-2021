using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    class TemperatureInFahrenheit : IClimateControl
    {
        TemperatureSensor temperatureSensor;
        public TemperatureInFahrenheit(TemperatureSensor temperatureSensor)
        {
            this.temperatureSensor = temperatureSensor;
        }
        public double GetTemperature()
        {
            return temperatureSensor.GetTemperature();
        }

    }
}
