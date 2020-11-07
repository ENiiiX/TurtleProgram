namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class RectangleCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public RectangleCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"/>
        public RectangleCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }

        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"/>
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        /// <summary>
        /// Invokes rectangle method from the Turtle class
        /// </summary>
        /// <param name="width">Sets width of rectangle</param>
        /// <param name="height">Sets height of rectangle</param>
        public void rectangle(int width, int height)
        {
            _turtle.rectangle(width, height);
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}