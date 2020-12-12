using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace TurtleProgram
{
    /// <summary>
    /// CommandFactory class that creates commands when called by a user from the parser class
    /// Every command availale to the user can be called from this class.
    /// </summary>
    public class CommandFactory
    {
        /// <summary>
        /// getCommand method that is used to call user commands
        /// </summary>
        /// <param name="command">String to determine which command a user wants to call</param>
        /// <returns>Returns an instance of the command a user has requested. Retruns null if command doesn't
        /// exist</returns>
        public Command getCommand(String command)
        {
            command = command.ToUpper().Trim();

            if (command.Equals("FORWARD"))
            {
                return new ForwardCommand();
            }
            else if (command.Equals("BACKWARD"))
            {
                return new BackwardCommand();
            }
            else if (command.Equals("MOVETO"))
            {
                return new MoveToCommand();
            }
            else if (command.Equals("DRAWTO"))
            {
                return new DrawToCommand();
            }
            else if (command.Equals("CIRCLE"))
            {
                return new CircleCommand();
            }
            else if (command.Equals("RECTANGLE"))
            {
                return new RectangleCommand();
            }
            else if (command.Equals("TRIANGLE"))
            {
                return new TriangleCommand();
            }
            else if (command.Equals("PENOFF"))
            {
                return new PenUpCommand();
            }
            else if (command.Equals("PENON"))
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
            else if (command.Equals("CLEAR"))
            {
                return new ClearCommand();
            }
            else if (command.Equals("PENCOLOUR"))
            {
                return new PenColourCommand();
            }    
            else if (command.Equals("FILLCOLOUR"))
            {
                return new FillColourCommand();
            }
            else if (command.Equals("VAR"))
            {
                return new Var();
            }
            else if (command.Equals("LOOP"))
            {
                return new LoopCommand();
            }
            else if (command.Equals("ENDLOOP"))
            {
                return new EndLoopCommand();
            }
            else if (command.Equals("IF"))
            {
                return new IfCommand();
            }
            else if (command.Equals("ENDIF"))
            {
                return new EndIfCommand();
            }
            else
            {
                MessageBox.Show("Command does not exist");
                return null;
            }

        }
    }

}
