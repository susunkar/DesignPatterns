using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class SeccondConditionSubscriber : IObserver, IDisplayElement
    {
        public float Temp { get; set; }
        public float Humiditity { get; set; }
        public float Pressure { get; set; }
        public void Display()
        {
            Console.WriteLine("*** SeccondConditionSubscriber ***");
            Console.WriteLine("Temp {0}\nHumiditity {1}\nPressure {2}", Temp, Humiditity, Pressure);
        }

        public void Update(float temp, float humiditity, float pressure)
        {

            this.Temp = temp;
            this.Humiditity = humiditity;
            this.Pressure = pressure;

            Display();
        }
    }
}