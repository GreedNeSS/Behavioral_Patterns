using _6_State.Contexts;
using _6_State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_State.StateImplementations
{
    public class LiquidWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем воду в лёд");
            water.State = new SolidWaterState();
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем воду в газ");
            water.State = new GasWaterState();
        }
    }
}
