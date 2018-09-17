using ObserverPattern.WeatherStation.Interface;
using System.Collections;

namespace ObserverPattern.WeatherStation
{
    public class WeatherData : ISubject
    {
        private readonly ArrayList _observers = new ArrayList();
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = _observers.IndexOf(o);
            if (i >= 0)
                _observers.Remove(i);
        }

        public void NotifyObserver()
        {
            for (int i = 0; i < _observers.Count; i++)
            {
                IObserver observer = (IObserver)_observers[i];
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementsChanged();
        }
    }
}