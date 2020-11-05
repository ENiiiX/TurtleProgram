using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace TurtleProgram
{
    public class Parser
    {
        CommandFactory cf = new CommandFactory();
        public Turtle turtle;
        
        public Parser()
        {

        }
        public Parser(Turtle turtle)
        {
            this.turtle = turtle;
        }





        public Command programParser(String[] lines)
        {
            int lineNum = 1;
            bool execute = true;
            String command = "";
            int[] ParamsInt = new int[100];

            foreach (var item in lines)
            {
                execute = isValid(item);

                if (execute == false)
                {
                    return null;
                }
                else
                {
                    String[] split = item.Split(' ');
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
                    }
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
                FillOnCommand c = (FillOnCommand)cf.getCommand("fill on");
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
            else
            {
                MessageBox.Show("Command does not exist");
            }
            return null;
        }

























        public Command Parse(string input)
        {
            input = input.ToLower();
            if (input.Length == 0)
            {
                MessageBox.Show("No command inputted");
                return null;
            }

            String command;

            String[] split = input.Split(' ');
            String[] parameters = new string[100];

            int[] ParamsInt = new int[100];

            command = split[0];

            if (split.Length > 1)
            {
                if (command.Equals("turnleft") || command.Equals("turnright") || command.Equals("reset"))
                {
                    MessageBox.Show(command + " Does not take parameters");
                    return null;
                }
                parameters = split[1].Split(',');
                for (int i = 0; i < parameters.Length; i++)
                {
                    try
                    {

                        ParamsInt[i] = Int32.Parse(parameters[i]);
                    }

                    catch (FormatException)
                    {
                        MessageBox.Show("Parameter isn't numeric");
                        return null;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Parameters are missing");
                        return null;
                    }
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

            else if (command.Equals("pen off"))
            {
                PenUpCommand c = (PenUpCommand)cf.getCommand("pen off");
                c.set(turtle);
                c.penUp();
                c.Execute();
                return c;
            }

            else if (command.Equals("pen on"))
            {
                PenDownCommand c = (PenDownCommand)cf.getCommand("pen on");
                c.set(turtle);
                c.penDown();
                c.Execute();
                return c;
            }

            else if (command.Equals("fill on"))
            {
                FillOnCommand c = (FillOnCommand)cf.getCommand("fill on");
                c.set(turtle);
                c.fillOn();
                c.Execute();
                return c;
            }

            else if (command.Equals("fill off"))
            {
                FillOffCommand c = (FillOffCommand)cf.getCommand("fill off");
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

            if (line.Length == 1)
            {
                if (command.Equals("reset") || command.Equals("turnleft") || command.Equals("turnright"))
                {
                    return valid;
                }
                else
                {
                    valid = false;
                    return valid;
                }
            }
            else if (line.Length == 2)
            {
                if (command.Equals("forward") || command.Equals("backward") || command.Equals("circle"))
                {
                    try
                    {
                        int param = Int32.Parse(line[1]);
                        return valid;
                    }

                    catch (FormatException)
                    {
                        MessageBox.Show("Parameter isn't numeric");
                        valid = false;
                        return valid;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Parameters are missing");
                        valid = false;
                        return valid;
                    }

                }
                else if (command.Equals("fill") || command.Equals("pen"))
                {
                    if (line[1].Equals("on") || line[1].Equals("off"))
                    {
                        return valid;
                    }
                    else
                    {
                        valid = false;
                        return valid;
                    }
                }
                else
                {
                    MessageBox.Show("Command doesn't exist");
                }
            }
            else if (line.Length == 3)
            {
                if (command.Equals("drawto") || command.Equals("moveto") || command.Equals("rectangle"))
                {


                }
            }
            else
            {
                MessageBox.Show("Command doesn't exist, or does not take parameters");
            }
            valid = false;
            return valid;
        }
    }
}