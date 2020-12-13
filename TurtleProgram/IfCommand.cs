using System;
using System.Data;

namespace TurtleProgram
{
    internal class IfCommand : Command
    {
        private Turtle _turtle;
        private String expression;
        private bool flag;

        ///<inheritdoc cref="TurnRightCommand.TurnRightCommand"/>
        public IfCommand()
        {

        }
        ///<inheritdoc cref="TurnRightCommand(Turtle)"
        public IfCommand(String expression)
        {
            this.expression = expression;
        }

        public bool Flag
        {
            get { return flag; }
            set { this.flag = value; }
        }
        ///<inheritdoc cref="TurnRightCommand.set(Turtle)"/>
        public void set(Turtle turtle, StoredProgram sp, string expression)
        {
            _turtle = turtle;
            base.sp = sp;
            this.expression = expression;
        }
        /// <summary>
        /// Method to evaluate the expression being used in an if statement. Returns try/false
        /// </summary>
        /// <param name="expression"></param>
        public void valueExpression(String expression)
        {
            DataTable dt;
            string[] split = expression.Split(' ');
            String exp = "";

            if (split.Length >= 3)
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
                var result = dt.Compute(exp, "").ToString();
                Console.WriteLine(result);

                if (result.Contains("True"))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
        }

        ///<inheritdoc cref="TurnRightCommand.Execute"/>
        public override Turtle Execute()
        {
            valueExpression(expression);
            return null;
        }
    }
}