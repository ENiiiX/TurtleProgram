namespace TurtleProgram
{
    public class TriangleCommand : Command
    {

        private Turtle _turtle;


        public TriangleCommand()
        {

        }
        public TriangleCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void triangle(int pntX1, int pntY1, int pntX2, int pntY2)
        {
            _turtle.triangle(pntX1, pntY1, pntX2, pntY2);
        }

        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}