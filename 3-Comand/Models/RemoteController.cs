using _3_Comand.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Comand.Models
{
    public class RemoteController
    {
        ICommand? _command = null;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            if (_command != null)
            {
                _command.Execute();
            }
        }

        public void PressUndo()
        {
            if (_command != null)
            {
                _command.Undo();
            }
        }
    }
}
