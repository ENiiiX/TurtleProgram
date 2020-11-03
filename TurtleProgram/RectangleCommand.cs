namespace TurtleProgram
{
    public class RectangleCommand : Command
    {

        private Turtle _turtle;


        public RectangleCommand()
        {

        }
        public RectangleCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void rectangle(int width, int height)
        {
            _turtle.rectangle(width, height);
        }

        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}