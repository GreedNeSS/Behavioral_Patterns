using _1_Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Strategy.Implementations
{
    public class HybridEngine : IEngine
    {
        public void Move()
        {
            Console.WriteLine("Двигаемся с помощью бензинового генератора и электродвигателя.");
        }
    }
}
