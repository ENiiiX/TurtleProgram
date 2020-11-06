namespace TurtleProgram
{
    public class ClearCommand : Command
    {

        private Turtle _turtle;


        public ClearCommand()
        {

        }
        public ClearCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void clear()
        {
            _turtle.clear();
        }

        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}