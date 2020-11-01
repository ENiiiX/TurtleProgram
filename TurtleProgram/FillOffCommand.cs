namespace TurtleProgram
{
    public class FillOffCommand : Command
    {

        private Turtle _turtle;

        public FillOffCommand()
        {

        }
        public FillOffCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void fillOff()
        {
            _turtle.fillOff();
        }

        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}