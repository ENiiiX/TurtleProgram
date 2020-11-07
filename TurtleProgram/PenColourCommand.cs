namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"
    public class PenColourCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public PenColourCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"
        public PenColourCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        /// <summary>
        /// Invokes the setPenColour method of the Turtle class
        /// </summary>
        /// <param name="colour">Colour specified by user</param>
        public void setPenColour(string colour)
        {
            _turtle.setPenColour(colour);
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}