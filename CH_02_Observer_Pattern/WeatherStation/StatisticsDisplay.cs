using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.WeatherStation.Interface;

namespace ObserverPattern.WeatherStation
{
    class StatisticsDisplay : IObserver, IDisplayElement
    {
        private List<float> _listTemperature = new List<float>();
        private ISubject _weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _listTemperature.Add(temperature);
            Display();
        }

        public void Display() =>
            Console.WriteLine(
                $"Avg/Max/Min temperature = {_listTemperature.Where(s => true).Average(s => s)}/{_listTemperature.Max(s => s)}/{_listTemperature.Min(s => s)}");
    }
}
