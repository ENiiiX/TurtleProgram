﻿namespace TurtleProgram
{
    public class ForwardCommand : Command
    {

        private Turtle _turtle;
        

        public ForwardCommand()
        {

        }
        public ForwardCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        public void set(Turtle turtle)
        {
            this._turtle = turtle;
        }
        public void forward(int distance)
        {
            _turtle.forward(distance);
        }

        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}
