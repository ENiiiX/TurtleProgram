namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class TriangleCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public TriangleCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand(Turtle)"/>
        public TriangleCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }

        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"/>
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        /// <summary>
        /// Invokes triangle method from turtle class
        /// </summary>
        /// <param name="pntX1">Sets xPos of point1 of the triangle</param>
        /// <param name="pntY1">Sets yPos of point1 of the triangle</param>
        /// <param name="pntX2">Sets xPos of point2 of the triangle</param>
        /// <param name="pntY2">Sets yPos of point2 of the triangle</param>
        public void triangle(int pntX1, int pntY1, int pntX2, int pntY2)
        {
            _turtle.triangle(pntX1, pntY1, pntX2, pntY2);
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}