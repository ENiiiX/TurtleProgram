using System;

namespace TurtleProgram
{
    internal class LoopCommand : Command
    {
        private Turtle _turtle;
        private int loopAmount;


        public LoopCommand()
        {

        }
        public LoopCommand(int amount)
        {
            this.loopAmount = amount;
        }

        public void set(Turtle turtle, StoredProgram sp, params String[] list)
        {
            _turtle = turtle;
            base.sp = sp;
            base.parameters = list;

            for (int i = 0; i < base.parameters.Length; i++)
            {
                if (sp.VarExists(parameters[i]))
                {
                    this.loopAmount = sp.GetVarValue(parameters[i]);
                }
                else
                {
                    this.loopAmount = Int32.Parse(parameters[i]);
                }
            }
        }

        public int LoopAmount
        {
            get { return loopAmount; }
            set { this.loopAmount = loopAmount; }
        }


        public override Turtle Execute()
        {
            base.Evaluate(base.parameters);
            this.LoopAmount = base.ParamsInt[0];
            return _turtle;
        }
    }
}