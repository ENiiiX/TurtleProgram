using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TurtleProgram
{

    public class CommandFactory
    {
        public Command getCommand(String command)
        {
            command = command.ToUpper().Trim();

            if (command.Equals("FORWARD"))
            {
                return new ForwardCommand();
            }

            else if (command.Equals("TURNLEFT"))
            {
                return new TurnLeftCommand();
            }
            else if (command.Equals("TURNRIGHT"))
            {
                return new TurnRightCommand();
            }
            else
            {
                throw new ArgumentException("Command does not exist");
            }

        }
    }

}
