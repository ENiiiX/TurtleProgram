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
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        /// <summary>
        /// Invokes the fillOff method of the Turtle class
        /// </summary>
        public void fillOff()
        {
            _turtle.fillOff();
        }

        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}