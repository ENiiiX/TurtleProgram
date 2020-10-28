using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    public abstract class CommandBase : CommandInterface
    {
        protected String command;
        protected object[] list;

        public CommandBase(String command)
        {

        }
        public CommandBase()
        {
            
        }

        public virtual void setCommand(string command, params object[] list)
        {
            this.command = command;
            this.list = list;
        }
    }
}
