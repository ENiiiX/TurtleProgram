namespace TurtleProgram
{
    public class MoveToCommand : Command
    {

        private Turtle _turtle;


        public MoveToCommand()
        {

        }
        public MoveToCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void moveTo(int x, int y)
        {
            _turtle.moveTo(x, y);
        }

        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}
