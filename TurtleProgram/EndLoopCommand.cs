namespace TurtleProgram
{
    internal class EndLoopCommand : Command
    {
        private Turtle _turtle;

        public EndLoopCommand()
        {

        }
        public void set(Turtle turtle)
        {
            _turtle = turtle;
        }
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}