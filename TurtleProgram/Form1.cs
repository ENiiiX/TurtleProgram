using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;



namespace TurtleProgram
{

    public partial class Form1 : Form
    {

        private System.Drawing.Graphics g;
        Turtle turtle;
        Parser parser;

        Bitmap bmp;


        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(DrawingArea.Width, DrawingArea.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White); //Sets bitmap background to white

            turtle = new Turtle(g);

            parser = new Parser();


            
        }

        private void commandLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(programBox.Text)) //Check if program box is empty
                {
                    e.Handled = true;
                    commandLine.Clear();
                    
                    //execute commands if program is empty

                }
                else if (commandLine.Text.ToUpper() == "RUN")
                {
                    e.Handled = true;
                    commandLine.Clear();
                    //run program box 
                    //parser.parse(programBox.Text);
                    //turtle.forward(50);

                }
                else
                {
                    MessageBox.Show("Program can be executed using the 'run' command");
                }

            }
            DrawingArea.Image = bmp;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandLine.Clear();
            programBox.Clear();
            turtle.reset(g);
            DrawingArea.Image = bmp;
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
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
                turtle.moveTo(456, 326);
                MessageBox.Show("Pen has been positioned to centre of canvas");

                

            }
        }
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



        private void button2_Click_1(object sender, EventArgs e)
        {
            //Parser.Shapes(g, Turtle, commandLine.Text);
            DrawingArea.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {



            parser.parse(turtle);



           // Execute(turtle, ModifyState, new TurtleCommand(turtle, Movement.Forward, 50));
            //turtle.turnLeft();
            //turtle.forward(50);
            //turtle.turnRight();
            //turtle.rectangle(50, 30);
            
           // Execute(turtle, ModifyState, new TurtleCommand(turtle, Movement.Backward, 50));

            DrawingArea.Image = bmp;
        }
    }
}
