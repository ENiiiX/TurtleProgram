using System;

namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class ForwardCommand : Command
    {

        private Turtle _turtle;
        

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public ForwardCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"
        public ForwardCommand(Turtle turtle) : base(turtle)
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
            _turtle.forward(ParamsInt[0]);
            return _turtle;
        }
    }
}
