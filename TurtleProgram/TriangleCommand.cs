namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class TriangleCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public TriangleCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand(Turtle)"/>
        public TriangleCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }

        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"/>
        public void Set(Turtle turtle, params int[] list)
        {
            this._turtle = turtle;
            base.ParamsInt = list;
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            _turtle.triangle(ParamsInt[0], ParamsInt[1], ParamsInt[2], ParamsInt[3]);
            return _turtle;
        }
    }
}