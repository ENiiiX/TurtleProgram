using System;

namespace TurtleProgram
{
    public class Forward : CommandBase
    {
        private int amount;

        public Forward() : base()
        {

        }

        public Forward(string command, int amount) : base(command)
        {
            
        }

        public override void setCommand(string command, params object[] list)
        {
            base.setCommand(command);
            this.amount = Convert.ToInt32(list[0]);
        }
    }
}