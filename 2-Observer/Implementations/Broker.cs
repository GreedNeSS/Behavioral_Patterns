using _2_Observer.Interfaces;
using _2_Observer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Observer.Implementations
{
    public class Broker : IObserver
    {
        public string Name { get; set; }
        IObservable? stock;

        public Broker(string name, IObservable stock)
        {
            Name = name;
            this.stock = stock;
            stock.RegisterObserver(this);
        }

        public void Update(object obj)
        {
            StockInfo stockInfo = (StockInfo)obj;

            if (stockInfo.USD > 55)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, stockInfo.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, stockInfo.USD);
        }

        public void StopTrade()
        {
            stock?.RemoveObserver(this);
            stock = null;
        }
    }
}
