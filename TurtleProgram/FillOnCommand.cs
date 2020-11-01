namespace TurtleProgram
{
    public class FillOnCommand : Command
    {

        private Turtle _turtle;

        public FillOnCommand()
        {

        }
        public FillOnCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void fillOn()
        {
            _turtle.fillOn();
        }

        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}