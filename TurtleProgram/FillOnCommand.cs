namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class FillOnCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public FillOnCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"
        public FillOnCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"
        public void Set(Turtle turtle)
        {
            this._turtle = turtle;
        }

        ///<inheritdoc cref="TurnRightCommand.Execute"
        public override Turtle Execute()
        {
            _turtle.fillOn();
            return _turtle;
        }
    }
}