using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_State.Interfaces
{
    public interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}
