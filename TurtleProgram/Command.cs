using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    public abstract class Command
    {
        public Turtle turtle;
        public Command()
        {

        }
        public Command(Turtle turtle)
        {
            this.turtle = turtle;
        }


        public abstract Turtle Execute();
        
    }

    public enum CommandOption
    {
        forward, backward
    }
}
