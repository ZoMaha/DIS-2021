using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    class TemperatureSensor
    {
        Random random;
        double temperature;
        public TemperatureSensor()
        {
            random = new Random();
            temperature = (double)random.Next(-220, 860) / 10;
        }
        public void CheckTemperature()
        {
            temperature = (double)random.Next(-220, 860) / 10;
        }
        public double GetTemperature()
        {
            return temperature;
        }

    }
}
