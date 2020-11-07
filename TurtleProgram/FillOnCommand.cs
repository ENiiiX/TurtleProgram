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
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        /// <summary>
        /// Invokes the fillOn command of the Turtle class
        /// </summary>
        public void fillOn()
        {
            _turtle.fillOn();
        }

        ///<inheritdoc cref="TurnRightCommand.Execute"
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}