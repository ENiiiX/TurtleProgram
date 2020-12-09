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
        public void Set(Turtle turtle, params int[] list)
        {
            this._turtle = turtle;
            base.ParamsInt = list;
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            _turtle.moveTo(ParamsInt[0], ParamsInt[1]);
            return _turtle;
        }
    }
}
