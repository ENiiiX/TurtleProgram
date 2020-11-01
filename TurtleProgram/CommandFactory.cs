using System;


namespace TurtleProgram
{

    public class CommandFactory
    {
        public Command getCommand(String command)
        {
            command = command.ToUpper().Trim();

            if (command.Equals("FORWARD"))
            {
                return new ForwardCommand();
            }
            else if (command.Equals("MOVETO"))
            {
                return new MoveToCommand();
            }
            else if (command.Equals("PENUP"))
            {
                return new PenUpCommand();
            }
            else if (command.Equals("PENDOWN"))
            {
                return new PenDownCommand();
            }
            else if (command.Equals("FILLON"))
            {
                return new FillOnCommand();
            }
            else if (command.Equals("FILLOFF"))
            {
                return new FillOffCommand();

            }
            else if (command.Equals("TURNLEFT"))
            {
                return new TurnLeftCommand();
            }
            else if (command.Equals("TURNRIGHT"))
            {
                return new TurnRightCommand();
            }
            else if (command.Equals("RESET"))
            {
                return new ResetCommand();
            }
            else
            {
                throw new ArgumentException("Command does not exist");
            }

        }
    }

}
