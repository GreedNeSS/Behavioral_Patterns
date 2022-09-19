using _3_Comand.Interfaces;
using _3_Comand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Comand.Implementations
{
    public class TVCommand : ICommand
    {
        TV _TV;

        public TVCommand(TV tV)
        {
            _TV = tV;
        }

        public void Execute()
        {
            _TV.OnTV();
        }

        public void Undo()
        {
            _TV.OffTV();
        }
    }
}
