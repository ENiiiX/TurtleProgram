using System.Windows;

namespace TurtleProgram
{
    internal class EndIfCommand : Command
    {
        private Turtle _turtle;

        public EndIfCommand()
        {

        }
        public void set(Turtle turtle)
        {
            _turtle = turtle;
        }
        public override Turtle Execute()
        {
            return null;
        }
    }
}