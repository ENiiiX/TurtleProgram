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
        public void Set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            _turtle.clear();
            return _turtle;
        }
    }
}