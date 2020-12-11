using System;
using System.Collections;

namespace TurtleProgram
{
    /// <summary>
    /// Abstract class in which all Command classes inherit
    /// </summary>
    public abstract class Command : ArrayList
    {
        public Turtle turtle;
        public int[] ParamsInt = new int[100];
        public String[] parameters = new string[100];
        public bool valid;
        public StoredProgram sp;

        /// <summary>
        /// Constructor for empty command
        /// </summary>
        public Command()
        {

        }
        /// <summary>
        /// Constructor for command class that assigns the turtle object
        /// </summary>
        /// <param name="turtle">Turtle object so methods can be accessed</param>
        public Command(Turtle turtle)
        {
            this.turtle = turtle;
        }
        public virtual void Set(Turtle turtle, StoredProgram sp, params String[] parameters)
        {
            this.turtle = turtle;
            this.sp = sp;
            this.parameters = parameters;
        }

        public int[] Evaluate(params String[] list)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                if (sp.VarExists(parameters[i]))
                {
                    ParamsInt[i] = sp.GetVarValue(parameters[i]);
                }
                else
                {
                    ParamsInt[i] = Int32.Parse(parameters[i]);
                }
            }

            return ParamsInt;
        }

        /// <summary>
        /// Execute command to return the turtle once a function has been activated
        /// </summary>
        /// <returns></returns>
        public abstract Turtle Execute();
        
    }
}
