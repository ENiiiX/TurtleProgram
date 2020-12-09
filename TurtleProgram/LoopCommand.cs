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

        public void set(Turtle turtle, int amount)
        {
            _turtle = turtle;
            this.loopAmount = amount;
        }

        public int LoopAmount
        {
            get { return loopAmount; }
            set { this.loopAmount = loopAmount; }
        }


        public override Turtle Execute()
        {
            return _turtle;
        }
    }
}