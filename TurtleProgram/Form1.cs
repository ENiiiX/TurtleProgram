using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurtleProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Test commit to github

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
                
            }
        }

        private void penBox_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
