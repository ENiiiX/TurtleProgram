using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    public class ModifyState
    {
        private readonly List<ICommand> _commands;
        private ICommand _command;
        public ModifyState()
        {
            _commands = new List<ICommand>();
        }
        public void setCommand(ICommand command) => _command = command;

        public void invoke()
        {
            _commands.Add(_command);
            _command.Execute();
        }




    }
}
