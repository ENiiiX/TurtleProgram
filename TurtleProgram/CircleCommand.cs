namespace TurtleProgram
{
    public class CircleCommand : Command
    {

        private Turtle _turtle;


        public CircleCommand()
        {

        }
        public CircleCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void circle(int radius)
        {
            _turtle.circle(radius);
        }

        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}