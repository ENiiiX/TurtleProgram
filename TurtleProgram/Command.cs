

namespace TurtleProgram
{
    public abstract class Command
    {
        public Turtle turtle;
        public bool valid;

        public Command()
        {

        }
        public Command(Turtle turtle)
        {
            this.turtle = turtle;
        }


        public abstract Turtle Execute();
        
    }

    public enum CommandOption
    {
        forward, backward
    }
}
