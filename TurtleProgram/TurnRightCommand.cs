namespace TurtleProgram
{
    /// <summary>
    /// Turtle concrete command that inherits from Command interface
    /// </summary>
    public class TurnRightCommand : Command
    {

        private Turtle _turtle;

        /// <summary>
        /// Empty concrete command constructor
        /// </summary>
        public TurnRightCommand()
        {

        }
        /// <summary>
        /// Constructor that takes turtle from base class
        /// </summary>
        /// <param name="turtle">Assigns turtle to permanent variable</param>
        public TurnRightCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        /// <summary>
        /// Sets turtle to permanent variable
        /// </summary>
        /// <param name="turtle">Turtle set by parser class</param>
        public void Set(Turtle turtle)
        {
            this._turtle = turtle;
        }

        /// <summary>
        /// Execute turtle movement
        /// </summary>
        /// <returns>Returns updated version of the turtle once updated</returns>
        public override Turtle Execute()
        {
            _turtle.turnRight();
            return _turtle;
        }
    }
}