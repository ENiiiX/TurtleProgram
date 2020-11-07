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
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        /// <summary>
        /// Invokes penUp method of the Turtle class
        /// </summary>
        public void penUp()
        {
            _turtle.penUp();
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}