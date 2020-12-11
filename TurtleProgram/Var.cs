using System;
using System.Collections;
using System.Data;
using System.Text;

namespace TurtleProgram
{
    /// <summary>
    /// Command object to store  user initiated variables
    /// </summary>
    public class Var : Command
    {

        private Turtle _turtle;

        private String varName; //Variable name
        private int value; //Value of variable
        private string expression; //Expression of variable being created
        private string varUpdate; //Updated value of variable once expression evaluated

        /// <summary>
        /// Empty variable constructor
        /// </summary>
        public Var()
        {

        }
        /// <summary>
        /// Variable constructor
        /// </summary>
        /// <param name="turtle">Assigns turtle to permanent variable</param>
        /// <param name="varName">Assigns varName of Var object</param>
        public Var(Turtle turtle, string varName)
        {
            _turtle = turtle;
            this.varName = varName;
        }

        /// <summary>
        /// Variable constructor that creates Var object with varName/value/expression
        /// </summary>
        /// <param name="varName">Assigns varName of Var object</param>
        /// <param name="value">Assigns varValue of Var object</param>
        /// <param name="expression">Assigns expression of Var object</param>
        public Var(String varName, int value, String expression)
        {
            this.varName = varName;
            this.value = value;
            this.expression = expression;
        }
        /// <summary>
        /// Getter for varName
        /// </summary>
        public String VarName
        {
            get { return varName; }
        }
        /// <summary>
        /// Getter/Setter to get/set Var value
        /// </summary>
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }
        /// <summary>
        /// Getter/Setter to get/set Var expression
        /// </summary>
        public string Expression
        {
            get { return expression; }
            set { expression = value; }
        }
        /// <summary>
        /// Method to calculate value of var expression. If no expression given, default
        /// value assigned
        /// </summary>
        /// <param name="expression">expression given in command</param>
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
        /// <summary>
        /// Set objects/values to permanent variables
        /// </summary>
        /// <param name="program">Assigns StoredProgram to permanent base varaible</param>
        /// <param name="command">Assigns command to permanent varaible</param>
        /// <param name="value">Assigns command to value of Var to permanent varaible</param>
        /// <param name="expression">Assigns expression to permanent varaible</param>
        public void set(StoredProgram program, string command, int value, string expression)
        {
            base.sp = program;
            this.varName = command;
            this.value = value;
            this.expression = expression;
        }
        /// <summary>
        /// Set objects/values to permanent variables
        /// </summary>
        /// <param name="program">Assigns StoredProgram to permanent base varaible</param>
        /// <param name="varUpdate">Assigns updated value to permanent variable</param>
        /// <param name="expression">Assigns expression to permanent varaible</param>
        public void set(StoredProgram program, string varUpdate, string expression)
        {
            base.sp = program;
            this.varUpdate = varUpdate;
            this.expression = expression;
        }
        /// <summary>
        /// Calculates and assign value of var object given an expression
        /// </summary>
        /// <returns></returns>
        public override Turtle Execute()
        {
            valueExpression(expression);
            return null;
        }
    }
}