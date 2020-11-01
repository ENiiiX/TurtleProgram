namespace TurtleProgram
{
    public class PenUpCommand : Command
    {

        private Turtle _turtle;

        public PenUpCommand()
        {

        }
        public PenUpCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void penUp()
        {
            _turtle.penUp();
        }

        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}