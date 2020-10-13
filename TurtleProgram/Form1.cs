using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;


namespace TurtleProgram
{

    public partial class Form1 : Form
    {

        private System.Drawing.Graphics g;
        Turtle Turtle;


        public Form1()
        {
            InitializeComponent();
            //Test commit to github
            g = DrawingArea.CreateGraphics();
            Turtle = new Turtle();
            penDownButton.Checked = true; //Sets pen down to checked
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = commandLine.Text.ToLower();
            input.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);;
            commandLine.Clear();

            if (input.Contains(" ") && input.Contains("forward") || input.Contains("backward")
                    || input.Contains("square") || input.Contains("triangle") || input.Contains("circle")
                    || input.Contains("fillcircle") || input.Contains("move"))
            {

                try
                {
                    String[] text = input.Split(); //If the command was one of the previous inputs, and the text enter includes a space, the text is split into an array
                    String splitter = text[1]; //Sets the second part of the text to a new variable

                    int amount = int.Parse(splitter);



                    if (text[0].Equals("forward")) //Runs this code if the text equals forward
                    {
                        Turtle.forward(g, amount); //Calls the forward method, amount == distance
                        Console.WriteLine("forward " + amount);
                    }
                    else if (text[0].Equals("backward")) //Runs this code if the text equals forward
                    {
                        Turtle.forward(g, -amount); //Calls the forward method, amount == distance
                        Console.WriteLine("backward " + amount);
                    }
                    else if (text[0].Equals("move"))
                    {
                        Turtle.moveTo(amount, number);
                    }


                }
                catch (FormatException) //Picks up on the NumberFormatException Error
                {
                    MessageBox.Show("Distance must be numeric"); //If the distance entered for the commands wasn't numeric, a box will appear


                }
                catch (IndexOutOfRangeException) //Picks up on the ArrayIndexOutOfBoundsException error
                {
                    MessageBox.Show("Distance is missing"); //If there isn't a distance at all, the user will be notified. 
                }

            }

            else if (input.Contains("left"))
            {
                Turtle.turnLeft();
                Console.WriteLine("Turned left");
            }
        }
    }
}
