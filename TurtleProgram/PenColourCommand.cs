using System.Drawing;

namespace TurtleProgram
{
    ///<inheritdoc cref="TurnRightCommand"
    public class PenColourCommand : Command
    {
        private string colour;
        private Turtle _turtle;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public PenColourCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"
        public PenColourCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"
        public void Set(Turtle turtle, string colour)
        {
            this._turtle = turtle;
            this.colour = colour;
        }

        ///<inheritdoc cref="TurnRightCommand.Execute"
        public override Turtle Execute()
        {
            _turtle.setPenColour(colour);
            return _turtle;
        }
    }
}