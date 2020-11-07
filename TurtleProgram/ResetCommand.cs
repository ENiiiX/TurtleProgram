namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class ResetCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public ResetCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand(Turtle)"/>
        public ResetCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"/>
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        /// <summary>
        /// Invokes reset method from the Turtle class
        /// </summary>
        public void reset()
        {
            _turtle.reset();
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}