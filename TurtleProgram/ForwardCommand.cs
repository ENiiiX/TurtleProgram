using System;

namespace TurtleProgram
{
    /// <summary>
    /// Concrete command that inherits from Command interface
    /// </summary>
    public class ForwardCommand : Command
    {

        private Turtle _turtle;
        

        /// <summary>
        /// Empty concrete constructor
        /// </summary>
        public ForwardCommand()
        {

        }
        /// <summary>
        /// Constructor that takes turtle from base class. Allows movement methods to be accessed
        /// </summary>
        /// <param name="turtle">Assigns turtle to permanent variable</param>
        public ForwardCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        /// <summary>
        /// Set method to set Turtle/StoredProgram as well as store parameter list
        /// </summary>
        /// <param name="turtle">Stores Turtle to permanent variable</param>
        /// <param name="sp">Stores Stored Program to permanent base variable</param>
        /// <param name="list">Stores list of parameters</param>
        public void Set(Turtle turtle, StoredProgram sp, params String[] list)
        {
            this._turtle = turtle;
            base.sp = sp;
            base.parameters = list;
            for (int i = 0; i < base.parameters.Length; i++)
            {
                if (sp.VarExists(parameters[i]))
                {
                    base.ParamsInt[i] = sp.GetVarValue(parameters[i]);
                }
                else
                {
                    base.ParamsInt[i] = Int32.Parse(parameters[i]);
                }
            }
        }

        /// <summary>
        /// Executes Turtle methods on request.
        /// Runs base.Evaluate(base.parameters) to verify parameter values in case change has been
        /// made due to expressional updates
        /// </summary>
        /// <returns>Returns turtle once movement updated</returns>
        public override Turtle Execute()
        {
            base.Evaluate(base.parameters);
            _turtle.forward(base.ParamsInt[0]);
            return _turtle;
        }
    }
}
