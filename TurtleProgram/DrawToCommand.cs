namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class DrawToCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public DrawToCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"/>
        public DrawToCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"/>
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        /// <summary>
        /// Invokes drawTo method of the Turtle class
        /// </summary>
        /// <param name="x">xPos of the drawTo command</param>
        /// <param name="y">yPos of the drawTo command</param>
        public void drawTo(int x, int y)
        {
            _turtle.drawTo(x, y);
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}
