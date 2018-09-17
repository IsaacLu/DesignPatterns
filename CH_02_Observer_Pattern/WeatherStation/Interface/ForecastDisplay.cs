using System;

namespace ObserverPattern.WeatherStation.Interface
{
    internal class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _currentPressure = 29.92f;
        private float _lastPressure;
        private ISubject _weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.Write("Forecast: ");
            if (_currentPressure > _lastPressure)
                Console.WriteLine("Improving weather on the way!");
            else if (_currentPressure.Equals(_lastPressure))
                Console.WriteLine("More of the same");
            else
                Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }
}