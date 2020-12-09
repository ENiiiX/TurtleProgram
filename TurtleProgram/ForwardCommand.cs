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
        public void set(Turtle turtle, params int[] list)
        {
            this._turtle = turtle;
            base.ParamsInt = list;
        }
        /// <summary>
        /// Invokes the forward method of the Turtle class
        /// </summary>
        /// <param name="distance">Distance to move forward specified by the user</param>
        public void forward(int distance)
        {
            _turtle.forward(distance);
        }

        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            _turtle.forward(ParamsInt[0]);
            return _turtle;
        }
    }
}
