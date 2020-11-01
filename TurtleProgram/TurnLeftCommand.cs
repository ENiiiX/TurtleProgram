namespace TurtleProgram
{
    public class TurnLeftCommand : Command
    {

        private Turtle _turtle;

        public TurnLeftCommand()
        {

        }
        public TurnLeftCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void turnLeft()
        {
            _turtle.turnLeft();
        }

        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}