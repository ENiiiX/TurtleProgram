namespace TurtleProgram
{
    public class TurnRightCommand : Command
    {

        private Turtle _turtle;

        public TurnRightCommand()
        {

        }
        public TurnRightCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void turnRight()
        {
            _turtle.turnRight();
        }

        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}