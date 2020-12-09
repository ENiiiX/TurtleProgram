namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class FillOffCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"
        public FillOffCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"/>
        public FillOffCommand(Turtle turtle) : base(turtle)
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
            _turtle.fillOff();
            return _turtle;
        }
    }
}