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
        public void Set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            _turtle.reset();
            return _turtle;
        }
    }
}