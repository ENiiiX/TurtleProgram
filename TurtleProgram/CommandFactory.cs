using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            else
            {
                throw new ArgumentException("Command does not exist");
            }
        }
    }

}
