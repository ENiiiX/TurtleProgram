namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class CircleCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public CircleCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"/>
        public CircleCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"/>
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        /// <summary>
        /// Invokes the circle command fo the Turtle class
        /// </summary>
        /// <param name="radius">sets radius of the circle</param>
        public void circle(int radius)
        {
            _turtle.circle(radius);
        }

        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}