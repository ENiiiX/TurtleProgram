namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"
    public class FillColourCommand : Command
    {

        private Turtle _turtle;
        private string colour;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"
        public FillColourCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"
        public FillColourCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"/>
        public void Set(Turtle turtle, string colour)
        {
            this._turtle = turtle;
            this.colour = colour;
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            _turtle.setShapeColour(colour);
            return _turtle;
        }
    }
}