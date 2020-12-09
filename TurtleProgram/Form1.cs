using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TurtleProgram
{
    /// <summary>
    /// Main form where programs/commands can be entered by the user to control the turtle
    /// graphics panel.
    /// </summary>
    public partial class Form1 : Form
    {

        private System.Drawing.Graphics g;
        Turtle turtle;
        StoredProgram sp;
        Bitmap bmp;
        String command;

        /// <summary>
        /// Initialize form, graphic area, turtle and parser. Assign graphic to turtle object and assign turtle to parser
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(DrawingArea.Width, DrawingArea.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White); //Sets bitmap background to 
            turtle = new Turtle(g);
            sp = new StoredProgram(turtle);

        }

        /// <summary>
        /// commandLine text box in which user commands are typed. Detects whether it is a single command or multi-line command in the programBox text box
        /// </summary>
        /// <param name="sender">References commandLine text box in which the event was called</param>
        /// <param name="e">Event data for KeyPress (Enter)</param>
        private void commandLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(programBox.Text)) //Check if programBox is empty (Determines whether commands are single or multiline. If empty, only a single command has been entered
                {
                    e.Handled = true;
                    command = commandLine.Text;
                    bool execute = true;

                    execute = sp.parser.isValid(command);

                    if (execute)
                    {
                        sp.parser.programParser(command);
                    }


                    commandLine.Clear();
                }
                else if (commandLine.Text.ToUpper() == "RUN") //If programBox wasn't empty, checks to see if 'Run' command was entered to execute the program
                {
                    e.Handled = true;
                    command = commandLine.Text;
                    bool execute = true;

                    string[] lines = programBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                    foreach (var line in lines) //Runs each line in programBox to check it is valid. Sets execute flag based on program validity
                    {
                        sp.parser.lineNum++;
                        execute = sp.parser.isValid(line);

                        if (execute == false)
                        {
                            sp.parser.lineNum = 0;
                            break;
                        }
                    }

                    if (execute == true) //If programBox commands are valid, runs each line through the parser so each command can be called by the command factory
                    {
                        foreach (var line in lines)
                        {
                            sp.parser.programParser(line);

                            foreach (Command in sp.commands)
                            {


                            }
                        }
                    }
                    commandLine.Clear();
                }
                else //If programBox is populated, indicates to user that the program can be executed with the 'run' command
                {
                    MessageBox.Show("Program can be executed using the 'run' command");
                }
            }
            DrawingArea.Image = bmp; //Updates graphics after each Turtle update
        }


        /// <summary>
        /// Allows user to populate commandLine text box with previous command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commandLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                commandLine.Text = command;
            }
        }
        /// <summary>
        /// Resets graphics and turtle objects to original state
        /// </summary>
        /// <param name="sender">References tool strip box in which the event was called</param>
        /// <param name="e">Event data for click</param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandLine.Clear();
            programBox.Clear();
            turtle.reset();
            DrawingArea.Image = bmp;
        }
        /// <summary>
        /// Quits program with confirmation popup
        /// </summary>
        /// <param name="sender">References tool strip box in which the event was called</param>
        /// <param name="e">Event data for click</param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Opens saved image and loads it into graphic area
        /// </summary>
        /// <param name="sender">References tool strip box in which the event was called</param>
        /// <param name="e">Event data for click</param>
        private void openImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();

            o.InitialDirectory = ("C:\\Users\\k1lle\\Pictures");

            o.RestoreDirectory = true;

            if (o.ShowDialog() == DialogResult.OK)
            {
                var path = o.FileName;
                Bitmap image1 = (Bitmap)Image.FromFile(path);
                bmp = image1;
                DrawingArea.Image = bmp;
                g = Graphics.FromImage(bmp);
                turtle.reset();
                MessageBox.Show("Pen has been positioned to 50, 50");

                

            }
        }
        /// <summary>
        /// Saves image from graphic area
        /// </summary>
        /// <param name="sender">References tool strip box in which the event was called</param>
        /// <param name="e">Event data for click</param>
        private void saveImage_Click(object sender, EventArgs e)
        {

            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "Image";// Default file name
            s.DefaultExt = ".Bmp";// Default file extension
            s.Filter = "Image (.bmp)|*.bmp"; // Filter files by extension

            s.InitialDirectory = ("C:\\Users\\k1lle\\Pictures");

            // setting the RestoreDirectory property to true causes the
            // dialog to restore the current directory before closing
            s.RestoreDirectory = true;
            // Show save file dialog box
            // Process save file dialog box results
            if (s.ShowDialog() == DialogResult.OK)
            {
                // Save Image
                string filename = s.FileName;
                // the using statement causes the FileStream's dispose method to be
                // called when the object goes out of scope

                using (System.IO.FileStream fstream = new System.IO.FileStream(filename, System.IO.FileMode.Create))
                {
                    Bitmap replace = new Bitmap(bmp);
                    bmp.Dispose();
                    replace.Save(fstream, System.Drawing.Imaging.ImageFormat.Bmp);
                    fstream.Close();
                }
            }
        }
        /// <summary>
        /// Opens saved program from a text file
        /// </summary>
        /// <param name="sender">References tool strip box in which the event was called</param>
        /// <param name="e">Event data for click</param>
        private void openProgram_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            o.FilterIndex = 2;
            o.RestoreDirectory = true;
            if (o.ShowDialog() == DialogResult.OK)
            {
                programBox.Text = System.IO.File.ReadAllText(o.FileName);
            }
        }
        /// <summary>
        /// Saves program that is in the programBox to a text file
        /// </summary>
        /// <param name="sender">References tool strip box in which the event was called</param>
        /// <param name="e">Event data for click</param>
        private void saveProgram_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "Program";// Default file name
            s.DefaultExt = ".Txt";// Default file extension
            s.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // Filter files by extension

            DialogResult result = s.ShowDialog();
            if (result == DialogResult.OK)
            {
                string name = s.FileName;
                File.WriteAllText(name, programBox.Text);
            }
        }
    }
}
