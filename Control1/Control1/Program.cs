using System;

namespace Control1
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();

            TemperatureInFahrenheit temperatureInFahrenheit = new TemperatureInFahrenheit(sensor);
            TemperatureInCelsius temperatureInCelsius = new TemperatureInCelsius(sensor);
            IClimateControl climateControlAdapter = new AdapterTemperature(temperatureInCelsius);

            SystemClimateControl systemClimateControl = new SystemClimateControl();

            Console.WriteLine("Текущая температура: {0} градусов по Фаренгейту и  {1:0.0} градусов по Цельсию", systemClimateControl.GetTemperature(temperatureInFahrenheit), systemClimateControl.GetTemperature(climateControlAdapter));

        }
    }
}
