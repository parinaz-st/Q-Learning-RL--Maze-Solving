namespace RLMaze
{
    partial class MainForm
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
            this.mazeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAndSaveMazeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAndSolveMazeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mazeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStripMainForm";
            // 
            // mazeToolStripMenuItem
            // 
            this.mazeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAndSaveMazeToolStripMenuItem,
            this.loadAndSolveMazeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mazeToolStripMenuItem.Name = "mazeToolStripMenuItem";
            this.mazeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.mazeToolStripMenuItem.Text = "&Maze";
            // 
            // createAndSaveMazeToolStripMenuItem
            // 
            this.createAndSaveMazeToolStripMenuItem.Name = "createAndSaveMazeToolStripMenuItem";
            this.createAndSaveMazeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.createAndSaveMazeToolStripMenuItem.Text = "&Create and Save Maze";
            this.createAndSaveMazeToolStripMenuItem.Click += new System.EventHandler(this.createAndSaveMazeToolStripMenuItem_Click);
            // 
            // loadAndSolveMazeToolStripMenuItem
            // 
            this.loadAndSolveMazeToolStripMenuItem.Name = "loadAndSolveMazeToolStripMenuItem";
            this.loadAndSolveMazeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.loadAndSolveMazeToolStripMenuItem.Text = "&Load and Solve Maze";
            this.loadAndSolveMazeToolStripMenuItem.Click += new System.EventHandler(this.loadAndSolveMazeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 266);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Reinforcement Learning, Q-Learning, Maze";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mazeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAndSaveMazeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAndSolveMazeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

