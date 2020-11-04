namespace TurtleProgram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImage = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.openProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penUpButton = new System.Windows.Forms.RadioButton();
            this.penDownButton = new System.Windows.Forms.RadioButton();
            this.penBox = new System.Windows.Forms.GroupBox();
            this.programBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DrawingArea = new System.Windows.Forms.PictureBox();
            this.commandLine = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.penBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shapesToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1338, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openImage,
            this.saveImage,
            this.openProgram,
            this.saveProgram,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openImage
            // 
            this.openImage.Name = "openImage";
            this.openImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openImage.Size = new System.Drawing.Size(227, 22);
            this.openImage.Text = "Open Image";
            this.openImage.Click += new System.EventHandler(this.openImage_Click);
            // 
            // saveImage
            // 
            this.saveImage.Name = "saveImage";
            this.saveImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveImage.Size = new System.Drawing.Size(227, 22);
            this.saveImage.Text = "Save Image";
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // openProgram
            // 
            this.openProgram.Name = "openProgram";
            this.openProgram.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openProgram.Size = new System.Drawing.Size(227, 22);
            this.openProgram.Text = "Open Program";
            this.openProgram.Click += new System.EventHandler(this.openProgram_Click);
            // 
            // saveProgram
            // 
            this.saveProgram.Name = "saveProgram";
            this.saveProgram.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveProgram.Size = new System.Drawing.Size(227, 22);
            this.saveProgram.Text = "Save Program";
            this.saveProgram.Click += new System.EventHandler(this.saveProgram_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.shapesToolStripMenuItem.Text = "Shapes";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // penUpButton
            // 
            this.penUpButton.AutoSize = true;
            this.penUpButton.Checked = true;
            this.penUpButton.Location = new System.Drawing.Point(6, 22);
            this.penUpButton.Name = "penUpButton";
            this.penUpButton.Size = new System.Drawing.Size(61, 17);
            this.penUpButton.TabIndex = 2;
            this.penUpButton.TabStop = true;
            this.penUpButton.Text = "Pen Up";
            this.penUpButton.UseVisualStyleBackColor = true;
            // 
            // penDownButton
            // 
            this.penDownButton.AutoSize = true;
            this.penDownButton.Location = new System.Drawing.Point(6, 46);
            this.penDownButton.Name = "penDownButton";
            this.penDownButton.Size = new System.Drawing.Size(75, 17);
            this.penDownButton.TabIndex = 3;
            this.penDownButton.Text = "Pen Down";
            this.penDownButton.UseVisualStyleBackColor = true;
            // 
            // penBox
            // 
            this.penBox.Controls.Add(this.penUpButton);
            this.penBox.Controls.Add(this.penDownButton);
            this.penBox.Location = new System.Drawing.Point(12, 614);
            this.penBox.Name = "penBox";
            this.penBox.Size = new System.Drawing.Size(200, 81);
            this.penBox.TabIndex = 4;
            this.penBox.TabStop = false;
            this.penBox.Text = "Pen Status";
            // 
            // programBox
            // 
            this.programBox.Location = new System.Drawing.Point(18, 39);
            this.programBox.Multiline = true;
            this.programBox.Name = "programBox";
            this.programBox.Size = new System.Drawing.Size(380, 433);
            this.programBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrawingArea
            // 
            this.DrawingArea.BackColor = System.Drawing.Color.White;
            this.DrawingArea.Location = new System.Drawing.Point(413, 39);
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.Size = new System.Drawing.Size(912, 652);
            this.DrawingArea.TabIndex = 5;
            this.DrawingArea.TabStop = false;
            // 
            // commandLine
            // 
            this.commandLine.Location = new System.Drawing.Point(18, 488);
            this.commandLine.Name = "commandLine";
            this.commandLine.Size = new System.Drawing.Size(380, 20);
            this.commandLine.TabIndex = 8;
            this.commandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandLine_KeyDown);
            this.commandLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commandLine_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 707);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.commandLine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.programBox);
            this.Controls.Add(this.DrawingArea);
            this.Controls.Add(this.penBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.penBox.ResumeLayout(false);
            this.penBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImage;
        private System.Windows.Forms.ToolStripMenuItem saveImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton penUpButton;
        private System.Windows.Forms.RadioButton penDownButton;
        private System.Windows.Forms.GroupBox penBox;
        private System.Windows.Forms.TextBox programBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox DrawingArea;
        private System.Windows.Forms.TextBox commandLine;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem openProgram;
        private System.Windows.Forms.ToolStripMenuItem saveProgram;
    }
}

