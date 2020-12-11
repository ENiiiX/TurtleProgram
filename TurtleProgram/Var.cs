using System;
using System.Collections;
using System.Data;
using System.Text;

namespace TurtleProgram
{
    public class Var : Command
    {

        private Turtle _turtle;

        private String varName;
        private int value;
        private string expression;
        private string varUpdate;


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

        public string Expression
        {
            get { return expression; }
            set { expression = value; }
        }

        public void valueExpression(String expression)
        {
            string result;
            DataTable dt;
            string[] split = expression.Split(' ');
            String exp = "";

            if(split.Length >= 3)
            {
                for (int i = 0; i < split.Length; i++)
                {
                    String search = split[i];
                    if (sp.VarExists(search))
                    {
                        search = sp.GetVarValue(search).ToString();
                    }
                    exp = exp + search;
                }

                Console.WriteLine(exp);

                dt = new DataTable();
                result = dt.Compute(exp, "").ToString();
                Console.WriteLine(result);
                this.value = Int32.Parse(result);
                sp.SetVarValue(varUpdate, this.value);
            }
            else
            {
                value = this.value;
            }

        }

        public void set(StoredProgram program, string command, int value, string expression)
        {
            base.sp = program;
            this.varName = command;
            this.value = value;
            this.expression = expression;
        }

        public void set(StoredProgram program, string varUpdate, string expression)
        {
            base.sp = program;
            this.varUpdate = varUpdate;
            this.expression = expression;
        }

        public override Turtle Execute()
        {
            valueExpression(expression);
            return null;
        }
    }
}