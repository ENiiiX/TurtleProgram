using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace TurtleProgram
{
    public class Parser
    {

        public void parse(string input)
        {
            if (input.Length == 0)
                throw new ApplicationException("Command missing");

            String[] ins = input.Split(' ');
            String[] parameters = new string[32];
            int[] paramCount = new int[32];

            String command = ins[0].ToLower();

            if (ins.Length > 1)
            {
                parameters = ins[1].Split(',');

                for (int i = 0; i < parameters.Length; i++)
                {
                    try 
                    {
                        paramCount[i] = Int32.Parse(parameters[i]);
                    }
                    catch
                    {
                        throw new ApplicationException("Must be numberic character");
                    }
                }
            }

            if (command.Equals("moveto"))
            {
                return;
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
}
