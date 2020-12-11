using System;

namespace TurtleProgram
{
    ///<inheritdoc cref="ForwardCommand"/>
    public class DrawToCommand : Command
    {

        private Turtle _turtle;

        ///<inheritdoc cref="ForwardCommand.ForwardCommand"/>
        public DrawToCommand()
        {

        }
        ///<inheritdoc cref="ForwardCommand(Turtle)"/>
        public DrawToCommand(Turtle turtle) : base(turtle)
        {
            _turtle = turtle;
        }
        ///<inheritdoc cref="ForwardCommand.Set(Turtle, StoredProgram, string[])"/>
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

        ///<inheritdoc cref="ForwardCommand.Execute"/>
        public override Turtle Execute()
        {
            base.Evaluate(base.parameters);
            _turtle.drawTo(base.ParamsInt[0], base.ParamsInt[1]);
            return _turtle;
        }
    }
}
