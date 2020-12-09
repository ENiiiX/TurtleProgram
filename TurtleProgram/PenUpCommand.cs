namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class PenUpCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public PenUpCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"/>
        public PenUpCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"
        public void Set(Turtle turtle)
        {
            this._turtle = turtle;
        }

        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            _turtle.penUp();
            return _turtle;
        }
    }
}