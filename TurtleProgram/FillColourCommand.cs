namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"
    public class FillColourCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"
        public FillColourCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"
        public FillColourCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"/>
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        /// <summary>
        /// Invokes the setShapeColour method of the Turtle class
        /// </summary>
        /// <param name="colour">Sets shape colour specified by the user</param>
        public void setShapeColour(string colour)
        {
            _turtle.setShapeColour(colour);
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}