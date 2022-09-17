using _2_Observer.Interfaces;
using _2_Observer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Observer.Implementations
{
    public class Bank : IObserver
    {
        public string Name { get; set; }

        public Bank(string name, IObservable observable)
        {
            Name = name;
            observable.RegisterObserver(this);
        }

        public void Update(object obj)
        {
            StockInfo stockInfo = (StockInfo) obj;

            if (stockInfo.Euro > 60)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, stockInfo.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, stockInfo.Euro);
        }
    }
}
