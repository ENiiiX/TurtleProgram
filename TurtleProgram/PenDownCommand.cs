namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class PenDownCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public PenDownCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"
        public PenDownCommand(Turtle turtle) : base(turtle)
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
            _turtle.penDown();
            return _turtle;
        }
    }
}