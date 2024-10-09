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
    public partial class CreateMazeForm : Form
    {
        public Maze maze;

        public int boardX;
        public int boardY;
        public int boardWidth;
        public int boardHeight;

        public int colStep;
        public int rowStep;

        public CreateMazeForm()
        {
            InitializeComponent();
            MyInitialize();
        }

        private void MyInitialize()
        {
            this.BackColor = Color.FromArgb(200, 200, 200);
            radGoal.Checked = true;
            txtRowCount.Text = "3";
            txtColCount.Text = "2";

            txtRow.Text = "3";
            txtCol.Text = "2";

            sfdMaze.Filter = "Maze Files|*.txt|All Files|*.*";
            ofdMaze.Filter = "Maze Files|*.txt|All Files|*.*";
            ofdMaze.FileName = "";

            rtxtTemp.Visible = false;

            btnSetDim_Click(null, null);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetDim_Click(object sender, EventArgs e)
        {
            try
            {
                int length = System.Int32.Parse(txtRowCount.Text);
                int width = System.Int32.Parse(txtColCount.Text);

                if ((length <= 0) || (width <= 0))
                {
                    MessageBox.Show("Invalid Dimensions", "Error!");
                    return;
                }

                maze = new Maze();
                maze.setDimension(length, width);
            }
            catch (Exception caught)
            {
                MessageBox.Show(caught.Message, "Error!");
            }

            Invalidate();
        }

        private void btnSetLoc_Click(object sender, EventArgs e)
        {
            try
            {
                int rowNum = System.Int32.Parse(txtRow.Text);
                int colNum = System.Int32.Parse(txtCol.Text);

                if ((rowNum > maze.rowCount) || (colNum > maze.colCount) || (rowNum <= 0) || (colNum <= 0))
                {
                    MessageBox.Show("Invalid Location", "Error!");
                    return;
                }

                rowNum -= 1;
                colNum -= 1;

                if (radGoal.Checked)
                    maze.setGoal(rowNum, colNum);
                else if (radInit.Checked)
                    maze.setInit(rowNum, colNum);
                else if (radObstacle.Checked)
                    maze.setObstacle(rowNum, colNum);
            }
            catch (Exception caught)
            {
                MessageBox.Show(caught.Message, "Error!");
            }

            Invalidate();

        }

        private void ShowMaze()
        {

            rtxtTemp.Text = "";
            for (int i = 0; i < maze.rowCount; i++)
            {
                rtxtTemp.Text += "| ";
                for (int j = 0; j < maze.colCount; j++)
                {
                    rtxtTemp.Text += maze.board[i, j].isGoal.ToString() + " ";
                    rtxtTemp.Text += maze.board[i, j].isInit.ToString() + " ";
                    rtxtTemp.Text += maze.board[i, j].isObstacle.ToString() + ", ";
                }
                rtxtTemp.Text += " |\n";
            }
        }

        private void CreateMazeForm_Paint(object sender, PaintEventArgs e)
        {
//            maze.board[1, 0].isUnderRobot = true;

            DrawBoard.Draw(maze, e, grpCommand.Height, false, false, false, false,
                ref boardX, ref boardY, ref boardWidth, ref boardHeight, ref rowStep, ref colStep);
        }

        private void CreateMazeForm_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void CreateMazeForm_Activated(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void CreateMazeForm_Click(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void CreateMazeForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            int posX = e.X - boardX;
            int posY = e.Y - boardY;

            if ((posX < 0) || (posX > boardWidth) || (posY < 0) || (posY > boardHeight))
                return;

            int colNum = (posX / colStep) + 1;
            int rowNum = (posY / rowStep) + 1;

            txtCol.Text = colNum.ToString();
            txtRow.Text = rowNum.ToString();

            btnSetLoc_Click(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sfdMaze.ShowDialog();
        }

        private void sfdMaze_FileOk(object sender, CancelEventArgs e)
        {
            String strMazeFile = sfdMaze.FileName;
            if (strMazeFile == "") return;

            myUtility.WriteMazeToTextFile(strMazeFile, maze);
        }

        private void btnLoadMaze_Click(object sender, EventArgs e)
        {
            ofdMaze.ShowDialog();
        }

        private void ofdMaze_FileOk(object sender, CancelEventArgs e)
        {
            String strMazeFile = ofdMaze.FileName;
            if (strMazeFile == "") return;

            maze = new Maze();
            myUtility.ReadMazeFromTextFile(strMazeFile, maze);
            Invalidate();
        }

    }
}
