using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;



namespace TurtleProgram
{

    public partial class Form1 : Form
    {

        private System.Drawing.Graphics g;
        Turtle Turtle;
        Bitmap bmp;


        public Form1()
        {
            InitializeComponent();
            //Test commit to github
            bmp = new Bitmap(DrawingArea.Width, DrawingArea.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White); //Sets bitmap background to white
            
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
                    || input.Contains("fillcircle") || input.Contains("test"))
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
                    else if (text[0].Equals("test"))
                    {
                        Turtle.triangle(g, amount);
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

            DrawingArea.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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
                Turtle.moveTo(456, 326);
                MessageBox.Show("Pen has been positioned to centre of canvas");

            }
        }
    }
}
