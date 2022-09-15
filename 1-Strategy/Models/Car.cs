using _1_Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Strategy.Models
{
    public class Car
    {
        public int Passengers { get; set; }
        public string Model { get; set; }
        public IEngine Engine{ get; private set; }

        public Car(int passengers, string model, IEngine engine)
        {
            Passengers = passengers;
            Model = model;
            Engine = engine;
        }

        public void SwapEngine(IEngine engine)
        {
            Engine = engine;
        }

        public void Move()
        {
            Engine.Move();
        }
    }
}
