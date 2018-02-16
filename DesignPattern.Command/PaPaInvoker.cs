using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command
{
    public class PaPaInvoker
    {
        private DesignPattern.Command.Command _command;

        public PaPaInvoker(Command command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.MakeDumplings();
        }
    }
}
