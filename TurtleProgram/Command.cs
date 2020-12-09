

using System;

namespace TurtleProgram
{
    /// <summary>
    /// Abstract class in which all Command classes inherit
    /// </summary>
    public abstract class Command
    {
        public Turtle turtle;
        public int[] ParamsInt = new int[100];
        public bool valid;

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
        public virtual void set(Turtle turtle, params int[] list)
        {
            this.turtle = turtle;
            this.ParamsInt = list;
        }


        /// <summary>
        /// Execute command to return the turtle once a function has been activated
        /// </summary>
        /// <returns></returns>
        public abstract Turtle Execute();
        
    }
}
