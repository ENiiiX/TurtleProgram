namespace TurtleProgram
{
    public class DrawToCommand : Command
    {

        private Turtle _turtle;


        public DrawToCommand()
        {

        }
        public DrawToCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void drawTo(int x, int y)
        {
            _turtle.drawTo(x, y);
        }

        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}
