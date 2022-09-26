using _6_State.Contexts;
using _6_State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_State.StateImplementations
{
    public class SolidWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Продолжаем морозить лёд");
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем лед в воду");
            water.State = new LiquidWaterState();
        }
    }
}
