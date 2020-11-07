namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class MoveToCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public MoveToCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"/>
        public MoveToCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        /// <summary>
        /// Invokes moveTo method of the Turtle class
        /// </summary>
        /// <param name="x">xPos of the updated turtle</param>
        /// <param name="y">yPos of the updated turtle</param>
        public void moveTo(int x, int y)
        {
            _turtle.moveTo(x, y);
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}
