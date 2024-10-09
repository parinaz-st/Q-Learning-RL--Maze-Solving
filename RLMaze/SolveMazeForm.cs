using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RLMaze
{
    public partial class SolveMazeForm : Form
    {
        public bool mazeLoaded;
        public Maze maze;

        public int boardX;
        public int boardY;
        public int boardWidth;
        public int boardHeight;

        public int colStep;
        public int rowStep;

        String strMazeFile;

        public SolveMazeForm()
        {
            InitializeComponent();
            MyInitialize();
        }

        private void MyInitialize()
        {
            mazeLoaded = false;

            this.BackColor = Color.FromArgb(200, 200, 200);
            txtIReward.Text = "100";
            txtOReward.Text = "0";
            txtDiscount.Text = "0.9";
            txtDelay.Text = "100";
            txtEpisodeLimit.Text = "200";

            ofdMaze.Filter = "Maze Files|*.txt|All Files|*.*";
            ofdMaze.FileName = "";

            strMazeFile = "";

            grpControl.Enabled = false;
        }

        private void btnLoadMaze_Click(object sender, EventArgs e)
        {
            ofdMaze.ShowDialog();
        }

        private void ofdMaze_FileOk(object sender, CancelEventArgs e)
        {
            strMazeFile = ofdMaze.FileName;
            if (strMazeFile == "") return;

            resetMaze();

            mazeLoaded = true;
            grpControl.Enabled = true;
        }

        private void resetMaze()
        {
            maze = new Maze();
            myUtility.ReadMazeFromTextFile(strMazeFile, maze);
            maze.resetRobot();
            btnSetQLearning_Click(null, null);
            Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SolveMazeForm_Click(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void SolveMazeForm_Paint(object sender, PaintEventArgs e)
        {
            if (!mazeLoaded) return;
            //            maze.board[1, 0].isUnderRobot = true;
            DrawBoard.Draw(maze, e, grpCommand.Height, true, false, false, true,
                ref boardX, ref boardY, ref boardWidth, ref boardHeight, ref rowStep, ref colStep);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetMaze();
        }

        private void btnSetQLearning_Click(object sender, EventArgs e)
        {
            try
            {
                int rewG = System.Int32.Parse(txtIReward.Text);
                int rewO = System.Int32.Parse(txtOReward.Text);
                double discF = System.Double.Parse(txtDiscount.Text);

                maze.setQLearningParam(rewG, rewO, discF);
            }
            catch (Exception caught)
            {
                MessageBox.Show(caught.Message, "Error!");
            }
            
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            if (maze.goalReached())
                maze.resetRobot();
            else
                maze.moveRobot();

            Invalidate();
        }

        private void CompleteEpisode()
        {
            if (maze.goalReached())
            {
                maze.resetRobot();
                Invalidate();
                return;
            }

            try
            {
                int moveLimit = System.Int32.Parse(txtEpisodeLimit.Text);
                int delay = System.Int32.Parse(txtDelay.Text);
                int i = 0;
                while ((i < moveLimit) && (!(maze.goalReached())))
                {
                    maze.moveRobot();
                    if (delay > 0)
                    {
                        Invalidate();
                        Thread.Sleep(delay);
                    }
                    i++;
                }

            }
            catch (Exception caught)
            {
                MessageBox.Show(caught.Message, "Error!");
            }


        }
        private void btnEpisode_Click(object sender, EventArgs e)
        {
            Thread workerThread = new Thread(
                 () => CompleteEpisode());
            workerThread.Start();
        }

        private void btnTenEpisodes_Click(object sender, EventArgs e)
        {
            Thread workerThread = new Thread(
                 () => Complete10Episode());
            workerThread.Start();
        }

        private void Complete10Episode()
        {
            for (int i = 0; i < 20; i++)
            {
                CompleteEpisode();
            }

        }
    }
}
