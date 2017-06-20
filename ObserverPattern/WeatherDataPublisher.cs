using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherDataPublisher : ISubject
    {
        public List<IObserver> registorObservers = new List<IObserver>();

        public float Temp { get; set; }
        public float Humiditity { get; set; }
        public float Pressure { get; set; }

        public void NotifyObserver()
        {
            if (registorObservers == null) return;

            foreach (var observer in registorObservers)
            {
                observer.Update(this.Temp, this.Humiditity, this.Pressure);
            }
        }

        public void RegistorObserver(IObserver o)
        {
            registorObservers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            registorObservers.Remove(o);
        }

        public void ChangeWeatherData(float temp,float humiditity, float pressure)
        {
            this.Temp =temp;
            this.Humiditity = humiditity;
            this.Pressure = pressure;

            NotifyObserver();
        }
    }
}
