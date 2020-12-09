namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class CircleCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public CircleCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"/>
        public CircleCommand(Turtle turtle) : base(turtle)
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
            _turtle.circle(ParamsInt[0]);
            return _turtle;
        }
    }
}