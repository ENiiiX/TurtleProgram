using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace TurtleProgram
{
    public class Parser
    {
        CommandFactory cf = new CommandFactory();
        public Turtle turtle;
        public bool execute = true;
        public int lineNum = 0;

        public Parser()
        {

        }
        public Parser(Turtle turtle)
        {
            this.turtle = turtle;
        }





        public Command programParser(String line)
        {
            String command = "";
            String colour = "";
            int[] ParamsInt = new int[100];

                    String[] split = line.Split(' ');
                    String[] parameters = new string[100];

                    command = split[0];

                    if (command.Equals("forward") || command.Equals("backward") || command.Equals("moveto")
                         || command.Equals("drawto") || command.Equals("rectangle") || command.Equals("circle")
                         || command.Equals("triangle"))
                    {
                        parameters = split[1].Split(',');
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            ParamsInt[i] = Int32.Parse(parameters[i]);
                        }
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
                        TurnLeftCommand c = (TurnLeftCommand)cf.getCommand("turnleft");
                        c.set(turtle);
                        c.turnLeft();
                        c.Execute();
                        return c;
                    }

                    else if (command.Equals("turnright"))
                    {
                        TurnRightCommand c = (TurnRightCommand)cf.getCommand("turnright");
                        c.set(turtle);
                        c.turnRight();
                        c.Execute();
                        return c;
                    }

                    else if (command.Equals("penoff"))
                    {
                        PenUpCommand c = (PenUpCommand)cf.getCommand("penoff");
                        c.set(turtle);
                        c.penUp();
                        c.Execute();
                        return c;
                    }

                    else if (command.Equals("penon"))
                    {
                        PenDownCommand c = (PenDownCommand)cf.getCommand("penon");
                        c.set(turtle);
                        c.penDown();
                        c.Execute();
                        return c;
                    }

                    else if (command.Equals("fillon"))
                    {
                        FillOnCommand c = (FillOnCommand)cf.getCommand("fillon");
                        c.set(turtle);
                        c.fillOn();
                        c.Execute();
                        return c;
                    }

                    else if (command.Equals("filloff"))
                    {
                        FillOffCommand c = (FillOffCommand)cf.getCommand("filloff");
                        c.set(turtle);
                        c.fillOff();
                        c.Execute();
                        return c;
                    }
                    else if (command.Equals("forward")) //Runs this code if the text equals forward
                    {
                        ForwardCommand c = (ForwardCommand)cf.getCommand("forward");
                        c.set(turtle);
                        c.forward(ParamsInt[0]);
                        c.Execute();
                        return c;
                    }

                    else if (command.Equals("backward")) //Runs this code if the text equals forward
                    {
                        ForwardCommand c = (ForwardCommand)cf.getCommand("forward");
                        c.set(turtle);
                        c.forward(-ParamsInt[0]);
                        c.Execute();
                        return c;
                    }

                    else if (command.Equals("moveto"))
                    {
                        MoveToCommand c = (MoveToCommand)cf.getCommand("moveto");
                        c.set(turtle);
                        c.moveTo(ParamsInt[0], ParamsInt[1]);
                        c.Execute();
                        return c;
                    }

                    else if (command.Equals("drawto"))
                    {
                        DrawToCommand c = (DrawToCommand)cf.getCommand("drawto");
                        c.set(turtle);
                        c.drawTo(ParamsInt[0], ParamsInt[1]);
                        c.Execute();
                        return c;
                    }

                    else if (command.Equals("circle"))
                    {
                        CircleCommand c = (CircleCommand)cf.getCommand("circle");
                        c.set(turtle);
                        c.circle(ParamsInt[0]);
                        c.Execute();
                        return c;
                    }

                    else if (command.Equals("rectangle"))
                    {
                        RectangleCommand c = (RectangleCommand)cf.getCommand("rectangle");
                        c.set(turtle);
                        c.rectangle(ParamsInt[0], ParamsInt[1]);
                        c.Execute();
                        return c;
                    }

                    else if (command.Equals("triangle"))
                    {
                        TriangleCommand c = (TriangleCommand)cf.getCommand("triangle");
                        c.set(turtle);
                        c.triangle(ParamsInt[0], ParamsInt[1],
                                    ParamsInt[2], ParamsInt[3]);
                        c.Execute();
                        return c;
                    }
                    else if (command.Equals("reset"))
                    {
                        ResetCommand c = (ResetCommand)cf.getCommand("reset");
                        c.set(turtle);
                        c.reset();
                        c.Execute();
                        return c;
                    }
                    else if (command.Equals("clear"))
                    {
                        ClearCommand c = (ClearCommand)cf.getCommand("clear");
                        c.set(turtle);
                        c.clear();
                        c.Execute();
                        return c;
                    }
                    else if (command.Equals("pencolour"))
                    {
                        PenColourCommand c = (PenColourCommand)cf.getCommand("pencolour");
                        c.set(turtle);
                        c.setPenColour(colour);
                        c.Execute();
                        return c;
                    }
                    else
                    {
                        MessageBox.Show("Command does not exist");
                    }
                    return null;
        }

        public bool isValid(String input)
        {
            bool valid = true;
            input = input.ToLower();

            String[] line = input.Split(' ', ',');
            String command = line[0];

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
                                break;

                            case "black":
                                break;

                            case "red":
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

            
            switch (command)
            {
                case "forward":
                    if (line.Length == 2)
                    {
                        try
                        {
                            int param = Int32.Parse(line[1]);
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
                    break;

                case "backward":
                    if (line.Length == 2)
                    {
                        try
                        {
                            int param = Int32.Parse(line[1]);
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
                    break;

                case "moveto":
                    if (line.Length == 3)
                    {
                        try
                        {
                            int param;
                            param = Int32.Parse(line[1]);
                            param = Int32.Parse(line[2]);
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
                        MessageBox.Show(command + " takes 2 parameters");
                        valid = false;
                        return false;
                    }
                case "drawto":
                    if (line.Length == 3)
                    {
                        try
                        {
                            int param;
                            param = Int32.Parse(line[1]);
                            param = Int32.Parse(line[2]);
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
                        MessageBox.Show(command + " takes 2 parameters");
                        valid = false;
                        return false;
                    }
                case "rectangle":
                    if (line.Length == 3)
                    {
                        try
                        {
                            int param;
                            param = Int32.Parse(line[1]);
                            param = Int32.Parse(line[2]);
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
                        MessageBox.Show(command + " takes 2 parameters");
                        valid = false;
                        return false;
                    }
                case "circle":
                    if (line.Length == 2)
                    {
                        try
                        {
                            int param = Int32.Parse(line[1]);
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
                    break;
                case "triangle":
                    if (line.Length == 5)
                    {
                        try
                        {
                            int param;
                            param = Int32.Parse(line[1]);
                            param = Int32.Parse(line[2]);
                            param = Int32.Parse(line[3]);
                            param = Int32.Parse(line[4]);
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
                    break;
                case "pen on":
                    return valid;
                case "pen off":
                    return valid;
                case "fill on":
                    return valid;
                case "fill off":
                    return valid;
                case "turnleft":
                    return valid;
                case "turnright":
                    return valid;
                case "reset":
                    return valid;
                case "clear":
                    return valid;
                case "pen colour":
                    return valid;
                case "fill colour":
                    return valid;

            }
            valid = false;
            MessageBox.Show("invalid command on line " + lineNum);
            return valid;
        }
    }
}