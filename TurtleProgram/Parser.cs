using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Documents;

namespace TurtleProgram
{
    public class Parser
    {
        CommandFactory cf = new CommandFactory(); //Instantiate a command factory for calling user commands
        StoredProgram sp;
        public Turtle turtle; //Turtle object that is passed from the Form class
        public bool execute = true; //Flag to determine whether commands are valid/invalid
        public int lineNum = 0; //Line number for commands entered into programBox


        /// <summary>
        /// Constructor for empty parser object
        /// </summary>
        public Parser()
        {

        }

        /// <summary>
        /// Constructor to create parser object that assigns turtle object
        /// </summary>
        /// <param name="turtle">Tutle object passed when parser is created</param>
        public Parser(Turtle turtle, StoredProgram sp)
        {
            this.turtle = turtle;
            this.sp = sp;
        }




        /// <summary>
        /// programParser to parse user commands (either single or multiline)
        /// Executes commands from CommandFactory class
        /// </summary>
        /// <param name="line">Command inputted by user</param>
        /// <returns></returns>
        public void programParser(String line)
        {
            String command = "";
            String colour = "";
            int[] ParamsInt = new int[100];

                String[] split = line.Split(' ');
                String[] parameters = new string[100];
                command = split[0];

            if (command.Equals("forward") || command.Equals("backward") || command.Equals("moveto")
                    || command.Equals("drawto") || command.Equals("rectangle") || command.Equals("circle")
                    || command.Equals("triangle") || command.Equals("loop"))
                {
                parameters = split[1].Split(',');

                }
                else if (command.Equals("pen") || command.Equals("fill"))
                {
                    command = split[0] + split[1];
                    if (split[1].Equals("colour"))
                    {
                        colour = split[2];
                    }

                }

            if (command.Equals("turnleft"))
            {
                //TurnLeftCommand c = (TurnLeftCommand)cf.getCommand("turnleft");
                //c.Set(turtle);
                //sp.AddCommand(c);
            }

            else if (command.Equals("turnright"))
            {
                //TurnRightCommand c = (TurnRightCommand)cf.getCommand("turnright");
                //c.Set(turtle);
                //sp.AddCommand(c);
            }

            else if (command.Equals("penoff"))
            {
                //PenUpCommand c = (PenUpCommand)cf.getCommand("penoff");
                //c.Set(turtle);
                //sp.AddCommand(c);
            }

            else if (command.Equals("penon"))
            {
                //PenDownCommand c = (PenDownCommand)cf.getCommand("penon");
                //c.Set(turtle);
                //sp.AddCommand(c);
            }

            else if (command.Equals("fillon"))
            {
                //FillOnCommand c = (FillOnCommand)cf.getCommand("fillon");
                //c.Set(turtle);
                //sp.AddCommand(c);
            }

            else if (command.Equals("filloff"))
            {
                //FillOffCommand c = (FillOffCommand)cf.getCommand("filloff");
                //c.Set(turtle);
                //sp.AddCommand(c);
            }
            else if (command.Equals("forward")) //Runs this code if the text equals forward
            {
                //ForwardCommand c = (ForwardCommand)cf.getCommand("forward");
                //c.Set(turtle, sp, parameters);
                //sp.AddCommand(c);
            }

            else if (command.Equals("backward")) //Runs this code if the text equals forward
            {
                //ForwardCommand c = (ForwardCommand)cf.getCommand("forward");
                //c.Set(turtle, sp, parameters);
                //sp.AddCommand(c);
            }

            else if (command.Equals("moveto"))
            {
                //MoveToCommand c = (MoveToCommand)cf.getCommand("moveto");
                //c.Set(turtle, ParamsInt);
                //sp.AddCommand(c);
            }

            else if (command.Equals("drawto"))
            {
                //DrawToCommand c = (DrawToCommand)cf.getCommand("drawto");
                //c.Set(turtle, ParamsInt);
                //sp.AddCommand(c);
            }

            else if (command.Equals("circle"))
            {
                //CircleCommand c = (CircleCommand)cf.getCommand("circle");
                //c.Set(turtle, sp, parameters);
                //sp.AddCommand(c);
            }

            else if (command.Equals("rectangle"))
            {
                //RectangleCommand c = (RectangleCommand)cf.getCommand("rectangle");
                //c.Set(turtle, ParamsInt);
                //sp.AddCommand(c);
            }

            else if (command.Equals("triangle"))
            {
                //TriangleCommand c = (TriangleCommand)cf.getCommand("triangle");
                //c.Set(turtle, ParamsInt);
                //sp.AddCommand(c);
            }
            else if (command.Equals("reset"))
            {
                //ResetCommand c = (ResetCommand)cf.getCommand("reset");
                //c.Set(turtle);
                //sp.Reset();

            }
            else if (command.Equals("clear"))
            {
                //ClearCommand c = (ClearCommand)cf.getCommand("clear");
                //c.Set(turtle);
                //sp.AddCommand(c);
            }
            else if (command.Equals("pencolour"))
            {
                //PenColourCommand c = (PenColourCommand)cf.getCommand("pencolour");
                //c.Set(turtle, colour);
                //sp.AddCommand(c);
            }
            else if (command.Equals("fillcolour"))
            {
                //FillColourCommand c = (FillColourCommand)cf.getCommand("fillcolour");
                //c.Set(turtle, colour);
                //sp.AddCommand(c);
            }
            else if (line.Contains("=")) // && split.Length > 3
            {
                
            }
            else if (command.Equals("loop"))
            {
                //LoopCommand c = (LoopCommand)cf.getCommand("loop");
                //c.set(turtle, sp, parameters);
                //sp.AddCommand(c);
            }
            else if (command.Equals("endloop"))
            {
                EndLoopCommand c = (EndLoopCommand)cf.getCommand("endloop");
                c.set(turtle);
                sp.AddCommand(c);
            }
            else
            {
                MessageBox.Show("Command does not exist");
            }
        }

        /// <summary>
        /// Method to determine whether user commands are valid. If invalid, invalid flag is set and returned
        /// Includes all commands that can be entered by user.
        /// </summary>
        /// <param name="input">Command user is inputting</param>
        /// <returns>Returns valid if command conform to valid command requirements.
        /// If commands are invalid, flag is set to false and returned. User is also notified about
        /// the error within their command and line number of the command if it is from the programBox</returns>
        public bool isValid(String input)
        {
            bool valid = true;
            input = input.ToLower();

            String[] line = input.Split(' ');
            String command = line[0];
            String colour = "";

            int[] ParamsInt = new int[100];
            String[] parameters = new string[100];

            if (command.Equals("forward") || command.Equals("backward") || command.Equals("moveto")
               || command.Equals("drawto") || command.Equals("rectangle") || command.Equals("circle")
               || command.Equals("triangle") || command.Equals("loop"))
            {
                parameters = line[1].Split(',');
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (sp.VarExists(parameters[i]))
                    {
                        ParamsInt[i] = sp.GetVarValue(parameters[i]);
                    }
                    else
                    {
                        try
                        {
                            ParamsInt[i] = Int32.Parse(parameters[i]);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Parameter isn't numeric on line " + lineNum);
                            valid = false;
                            return valid;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            MessageBox.Show("Parameters are missing on line " + lineNum);
                            valid = false;
                            return valid;
                        }
                    }
                }
            }

            if (command.Equals("pen") || command.Equals("fill"))
            {
                if (line[1].Equals("on") || line[1].Equals("off") || line[1].Equals("colour"))
                {
                    command = line[0] + " " + line[1];
                }
                else
                {
                    MessageBox.Show("Pen can be toggled on/off");
                    valid = false;
                    return valid;
                }
                if (command.Equals("pen colour") || command.Equals("fill colour"))
                {
                    try
                    {
                        switch (line[2])
                        {
                            case "blue":
                                colour = line[2];
                                break;

                            case "black":
                                colour = line[2];
                                break;

                            case "red":
                                colour = line[2];
                                break;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Colour is missing on line " + lineNum);
                        valid = false;
                        return valid;
                    }
                }
            }
            else if (input.Contains("="))
            {
                if (line.Length == 3 && line[1] == "=")
                {
                    try
                    {
                        int param;
                        param = Int32.Parse(line[2]);

                        if (sp.VarExists(command))
                        {
                            return valid;
                        }
                        else
                        {
                            Var c = (Var)cf.getCommand("var");
                            c.set(sp, command, int.Parse(line[2]), line[2]);
                            sp.AddVar(c);
                            sp.AddCommand(c);
                        }
                        return valid;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Parameter isn't numeric on line " + lineNum);
                        valid = false;
                        return valid;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Parameters are missing on line " + lineNum);
                        valid = false;
                        return valid;
                    }
                }
                else
                {
                    if(sp.VarExists(command))
                    {
                        line = input.Split('=');
                        String expression = line[1];
                        String varUpdate = line[0];
                        expression = expression.TrimStart();


                        string[] split = expression.Split(' ');
                        String exp = "";

                        for (int i = 0; i < split.Length; i++)
                        {
                            String search = split[i];
                            if (sp.VarExists(search))
                            {
                                search = sp.GetVarValue(search).ToString();
                            }
                            else if (Regex.IsMatch(search, "[0-9*+/-]"))
                            {

                            }
                            else
                            {
                                valid = false;
                                return valid;
                            }
                        }

                        Var c = (Var)cf.getCommand("var");
                        c.set(sp, varUpdate, expression);
                        sp.AddVar(c);
                        sp.AddCommand(c);

                        return valid;
                    }
                    else
                    {
                        MessageBox.Show("Variable declared incorrectly on line " + lineNum);
                        valid = false;
                        return valid;
                    }
                }
            }


            switch (command)
            {

                case "forward":
                    if (parameters.Length == 1)
                    {
                        ForwardCommand a = (ForwardCommand)cf.getCommand("forward");
                        a.Set(turtle, sp, parameters);
                        sp.AddCommand(a);
                        return valid;
                    }
                    else
                    {
                        MessageBox.Show(command + " takes 1 parameter");
                        valid = false;
                        return false;
                    }
                    break;

                case "backward":
                    if (parameters.Length == 1)
                    {
                        BackwardCommand b = (BackwardCommand)cf.getCommand("backward");
                        b.Set(turtle, sp, parameters);
                        sp.AddCommand(b);
                        return valid;

                    }
                    else
                    {
                        MessageBox.Show(command + " takes 1 parameter");
                        valid = false;
                        return false;
                    }
                    break;

                case "moveto":
                    if (parameters.Length == 2)
                    {
                        MoveToCommand c = (MoveToCommand)cf.getCommand("moveto");
                        c.Set(turtle, sp, parameters);
                        sp.AddCommand(c);
                        return valid;
                    }
                    else
                    {
                        MessageBox.Show(command + " takes 2 parameters");
                        valid = false;
                        return false;
                    }
                case "drawto":
                    if (parameters.Length == 2)
                    {
                        DrawToCommand d = (DrawToCommand)cf.getCommand("drawto");
                        d.Set(turtle, sp, parameters);
                        sp.AddCommand(d);
                        return valid;
                    }
                    else
                    {
                        MessageBox.Show(command + " takes 2 parameters");
                        valid = false;
                        return false;
                    }
                case "rectangle":
                    if (parameters.Length == 2)
                    {
                        RectangleCommand e = (RectangleCommand)cf.getCommand("rectangle");
                        e.Set(turtle, sp, parameters);
                        sp.AddCommand(e);
                        return valid;
                    }
                    else
                    {
                        MessageBox.Show(command + " takes 2 parameters");
                        valid = false;
                        return false;
                    }
                case "circle":
                    if (parameters.Length == 1)
                    {
                        CircleCommand f = (CircleCommand)cf.getCommand("circle");
                        f.Set(turtle, sp, parameters);
                        sp.AddCommand(f);
                        return valid;
                    }
                    else
                    {
                        MessageBox.Show(command + " takes 1 parameter");
                        valid = false;
                        return false;
                    }
                    break;
                case "triangle":
                    if (parameters.Length == 4)
                    {
                        TriangleCommand g = (TriangleCommand)cf.getCommand("triangle");
                        g.Set(turtle, sp, parameters);
                        sp.AddCommand(g);
                        return valid;
                    }
                    else
                    {
                        MessageBox.Show(command + " takes 4 parameters");
                        valid = false;
                        return false;
                    }
                    break;
                case "pen on":
                    PenDownCommand h = (PenDownCommand)cf.getCommand("penon");
                    h.Set(turtle);
                    sp.AddCommand(h);
                    return valid;

                case "pen off":
                    PenUpCommand i = (PenUpCommand)cf.getCommand("penoff");
                    i.Set(turtle);
                    sp.AddCommand(i);
                    return valid;

                case "fill on":
                    FillOnCommand j = (FillOnCommand)cf.getCommand("fillon");
                    j.Set(turtle);
                    sp.AddCommand(j);
                    return valid;

                case "fill off":
                    FillOffCommand k = (FillOffCommand)cf.getCommand("filloff");
                    k.Set(turtle);
                    sp.AddCommand(k);
                    return valid;

                case "turnleft":
                    TurnLeftCommand l = (TurnLeftCommand)cf.getCommand("turnleft");
                    l.Set(turtle);
                    sp.AddCommand(l);
                    return valid;

                case "turnright":
                    TurnRightCommand m = (TurnRightCommand)cf.getCommand("turnright");
                    m.Set(turtle);
                    sp.AddCommand(m);
                    return valid;

                case "reset":
                    ResetCommand n = (ResetCommand)cf.getCommand("reset");
                    n.Set(turtle);
                    sp.Reset();
                    return valid;

                case "clear":
                    ClearCommand o = (ClearCommand)cf.getCommand("clear");
                    o.Set(turtle);
                    sp.AddCommand(o);
                    return valid;

                case "pen colour":
                    PenColourCommand p = (PenColourCommand)cf.getCommand("pencolour");
                    p.Set(turtle, colour);
                    sp.AddCommand(p);
                    return valid;

                case "fill colour":
                    FillColourCommand q = (FillColourCommand)cf.getCommand("fillcolour");
                    q.Set(turtle, colour);
                    sp.AddCommand(q);
                    return valid;

                case "loop":
                    LoopCommand r = (LoopCommand)cf.getCommand("loop");
                    r.set(turtle, sp, parameters);
                    sp.AddCommand(r);
                    return valid;

                case "endloop":
                    return valid;



            }
            valid = false;
            MessageBox.Show("invalid command on line " + lineNum);
            return valid;
        }
    }
}