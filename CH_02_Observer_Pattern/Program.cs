using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.WeatherStation;
using ObserverPattern.WeatherStation.Interface;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            Console.ReadLine();
            weatherData.SetMeasurements(82, 70, 29.2f);
            Console.ReadLine();
            weatherData.SetMeasurements(78, 90, 30.4f);
            Console.ReadLine();
        }
    }
}
