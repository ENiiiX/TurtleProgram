namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class TurnLeftCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public TurnLeftCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"/>
        public TurnLeftCommand(Turtle turtle) : base(turtle)
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
            _turtle.turnLeft();
            return _turtle;
        }
    }
}