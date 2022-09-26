using _6_State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_State.Contexts
{
    public class Water
    {
        public IWaterState State{ get; set; }

        public Water(IWaterState state)
        {
            State = state;
        }

        public void Heat()
        {
            State.Heat(this);
        }

        public void Frost()
        {
            State.Frost(this);
        }
    }
}
