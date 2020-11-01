namespace TurtleProgram
{
    public class PenDownCommand : Command
    {

        private Turtle _turtle;

        public PenDownCommand()
        {

        }
        public PenDownCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void penDown()
        {
            _turtle.penDown();
        }

        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}