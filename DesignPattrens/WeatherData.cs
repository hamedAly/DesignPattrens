using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers { get; set; }
        public WeatherData()
        {
            this.observers = new List<IObserver>();
        }
        public void Notify(string userKeyword)
        {
            foreach (IObserver observer in observers)
                observer.update(userKeyword);
        }
        public void RegisterObsever(IObserver o)
        {
            observers.Add(o);
        }
        public void RemoveObsever(IObserver o)
        {
            observers.Remove(o);
        }

        public void GetDataFromUI(string userKeyword)
        {
            Notify (userKeyword);
        }
    }
}
