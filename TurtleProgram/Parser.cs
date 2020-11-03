using System;
using System.Collections.Generic;
using System.Windows;

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

        public Command Parse(string input)
        {
            input = input.ToLower();
            if (input.Length == 0)
                throw new ApplicationException("No command inputted");


            String command;

            String[] split = input.Split(' ');
            String[] parameters = new string[100];

            //        var input = commandLine.Text.ToLower();
            //        input.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None); ;
            //        commandLine.Clear();

            //        if (input.Contains(" ") && input.Contains("forward") || input.Contains("backward")
            //                || input.Contains("test"))
            //        {
            //            try
            //            {
            //                String[] text = input.Split(); //If the command was one of the previous inputs, and the text enter includes a space, the text is split into an array
            //                String splitter = text[1]; //Sets the second part of the text to a new variable

            //                int amount = int.Parse(splitter);

            int[] ParamsInt = new int[100];

            command = split[0];

            if (split.Length>1)
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

            else if (command.Equals("penup"))
            {
                PenUpCommand c = (PenUpCommand)cf.getCommand("penup");
                c.set(turtle);
                c.penUp();
                c.Execute();
                return c;
            }

            else if (command.Equals("pendown"))
            {
                PenDownCommand c = (PenDownCommand)cf.getCommand("pendown");
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
            else if (command.Equals("reset"))
            {
                ResetCommand c = (ResetCommand)cf.getCommand("reset");
                c.set(turtle);
                c.reset();
                c.Execute();
                return c;
            }

            throw new ArgumentException("Invalid command");

            }
        }
    }














    //            if (e.KeyChar == (char) Keys.Enter)
    //{
    //    if (string.IsNullOrWhiteSpace(programBox.Text))
    //    {
    //        e.Handled = true; //Handled property set to true to indicate KeyPressEvent has been handled

    //        var input = commandLine.Text.ToLower();
    //        input.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None); ;
    //        commandLine.Clear();

    //        if (input.Contains(" ") && input.Contains("forward") || input.Contains("backward")
    //                || input.Contains("test"))
    //        {
    //            try
    //            {
    //                String[] text = input.Split(); //If the command was one of the previous inputs, and the text enter includes a space, the text is split into an array
    //                String splitter = text[1]; //Sets the second part of the text to a new variable

    //                int amount = int.Parse(splitter);

    //                if (text[0].Equals("forward")) //Runs this code if the text equals forward
    //                {
    //                    Turtle.forward(g, amount); //Calls the forward method, amount == distance
    //                    Console.WriteLine("forward " + amount);
    //                }
    //                else if (text[0].Equals("backward")) //Runs this code if the text equals forward
    //                {
    //                    Turtle.forward(g, -amount); //Calls the forward method, amount == distance
    //                    Console.WriteLine("backward " + amount);
    //                }
    //                else if (text[0].Equals("test"))
    //                {
    //                    Turtle.rectangle(g, 200, 500);
    //                    Turtle.circle(g, 50);
    //                }
    //            }
    //            catch (FormatException) //Picks up on the NumberFormatException Error
    //            {
    //                MessageBox.Show("Distance must be numeric"); //If the distance entered for the commands wasn't numeric, a box will appear
    //            }
    //            catch (IndexOutOfRangeException) //Picks up on the ArrayIndexOutOfBoundsException error
    //            {
    //                MessageBox.Show("Distance is missing"); //If there isn't a distance at all, the user will be notified. 
    //            }
    //        }

    //        else if (input.Contains("right"))
    //        {
    //            Turtle.turnRight();
    //            Console.WriteLine("Turned right");
    //        }
    //        else if (input.Contains("left"))
    //        {
    //            Turtle.turnLeft();
    //            Console.WriteLine("Turned left");
    //        }

    //        DrawingArea.Image = bmp;
    //    }
    //    else if (commandLine.Text.ToUpper() == "RUN")
    //    {
    //        //PROGRAM SHOULD BE RUN FROM COMMAND BOX
    //    }
    //    else
    //    {
    //        MessageBox.Show("Program input box is populated, please ensure this is correct");
    //    }
    //}

