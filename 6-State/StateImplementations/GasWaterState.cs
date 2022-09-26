using _6_State.Contexts;
using _6_State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_State.StateImplementations
{
    public class GasWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем газ в воду");
            water.State = new LiquidWaterState();
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Продолжаем нагревать водяной пар");
        }
    }
}
