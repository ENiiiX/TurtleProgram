﻿namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"/>
    public class PenDownCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public PenDownCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"
        public PenDownCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"/>
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        /// <summary>
        /// Invokes penDown method of the Turtle class
        /// </summary>
        public void penDown()
        {
            _turtle.penDown();
        }
        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}