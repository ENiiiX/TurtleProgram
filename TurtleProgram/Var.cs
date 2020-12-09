using System;

namespace TurtleProgram
{
    public class Var : Command
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
        
        public Var(String varName, int value, String expression)
        {
            this.varName = varName;
            this.value = value;
            this.expression = expression;
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

        public void set(string command, int value, string expression)
        {
            this.varName = command;
            this.value = value;
            this.expression = expression;
        }

        //private void Compute(String expression)
        //{
        //    DataTable dt = new DataTable();

        //}




        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}