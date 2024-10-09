using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RLMaze
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MyInitialize();
        }

        private void MyInitialize()
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frmAbout = new AboutForm();
            frmAbout.MdiParent = this;
            frmAbout.Show();
        }

        private void createAndSaveMazeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMazeForm frmCreateMaze = new CreateMazeForm();
            frmCreateMaze.MdiParent = this;
            frmCreateMaze.Show();
        }

        private void loadAndSolveMazeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolveMazeForm frmSolveMaze = new SolveMazeForm();
            frmSolveMaze.MdiParent = this;
            frmSolveMaze.Show();
        }

    }
}
