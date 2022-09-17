using _2_Observer.Interfaces;
using _2_Observer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Observer.Implementations
{
    public class Stock : IObservable
    {
        List<IObserver> _observers;
        StockInfo _stockInfo;

        public Stock()
        {
            _observers = new List<IObserver>();
            _stockInfo = new StockInfo();
        }

        public void NotifyObservers()
        {
            foreach (var obs in _observers)
            {
                obs.Update(_stockInfo);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Market() 
        {
            Random rand = new Random();
            _stockInfo.USD = rand.Next(45, 60);
            _stockInfo.Euro = rand.Next(50, 65);
            NotifyObservers();
        }
    }
}
