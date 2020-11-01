using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    public class InvalidCommand : Command
    {

        private Turtle _turtle;


        public InvalidCommand()
        {

        }
        public InvalidCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }

        public override Turtle Execute()
        {
            Console.WriteLine("Couldn't find command: ");
        }
    }
}
