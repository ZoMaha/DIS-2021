using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    class TemperatureInCelsius
    {
        TemperatureSensor temperatureSensor;
        public TemperatureInCelsius(TemperatureSensor temperatureSensor)
        {
            this.temperatureSensor = temperatureSensor;
        }
        public double GetTemperatureInCelsius()
        {
            double temperature = (temperatureSensor.GetTemperature() - 32) * 5 / 9;
            return temperature;
        }

    }
}
