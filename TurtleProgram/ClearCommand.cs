namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class ClearCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public ClearCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"/>
        public ClearCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"/>
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        /// <summary>
        /// Invokes the clear method of the Turtle class
        /// </summary>
        public void clear()
        {
            _turtle.clear();
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}