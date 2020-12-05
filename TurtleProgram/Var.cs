using System;

namespace TurtleProgram
{
    internal class Var : Command
    {

        private Turtle _turtle;

        private String varName;
        private int value;
        private string expression;


        public Var()
        {

        }
        public Var(Turtle turtle, string varName)
        {
            _turtle = turtle;
            this.varName = varName;
        }
        
        public Var(String varName, int value)
        {
            this.varName = varName;
            this.value = value;
        }

        public String VarName
        {
            get { return varName; }
        }
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public void set(string command, int value)
        {
            this.varName = command;
            this.value = value;
        }






        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}