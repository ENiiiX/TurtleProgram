﻿using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;


namespace TurtleProgram
{

    public partial class Form1 : Form
    {

        private System.Drawing.Graphics g;
        Turtle test;


        public Form1()
        {
            InitializeComponent();
            //Test commit to github

            g = DrawingArea.CreateGraphics();
            test = new Turtle();

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
            input.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);















            if (input.Contains("test"))
            {
                test.drawRectangle(g, 60, 60);
            }
            else if (input.Contains("2"))
            {
                test.drawCircle(g, 60, 60);
            }
            else if (input.Contains("clear"))
            {

                test.clear(g);
            }
            else if (input.Contains("forward"))
            {
                test.forward(g, 500);
            }


        }
    }
}
