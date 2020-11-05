namespace TurtleProgram
{
    public class PenColourCommand : Command
    {

        private Turtle _turtle;

        public PenColourCommand()
        {

        }
        public PenColourCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void setPenColour(string colour)
        {
            _turtle.setPenColour(colour);
        }
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}