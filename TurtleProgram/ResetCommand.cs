namespace TurtleProgram
{
    public class ResetCommand : Command
    {

        private Turtle _turtle;


        public ResetCommand()
        {

        }
        public ResetCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void reset()
        {
            _turtle.reset();
        }

        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}