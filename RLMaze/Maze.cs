using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RLMaze
{
    public struct Node
    {
        public bool isGoal;
        public bool isInit;
        public bool isObstacle;
        public bool isUnderRobot;

        public int[] qValue;
        public int[] iReward;
        public int[] obstacle;

        public int maxDirection;
        public int openDirectionCount;

        public void initNode(int rowIndex, int colIndex, bool lastRow, bool lastCol)
        { 
            isGoal = isInit = isObstacle = isUnderRobot = false;
            maxDirection = 0;
            qValue = new int[4] { 0, 0, 0, 0 };
            iReward = new int[4] { 0, 0, 0, 0 };
            obstacle = new int[4] { 0, 0, 0, 0 };

            openDirectionCount = 4;

            if (colIndex == 0)
                setObstacleDirection(Constant.LEFT,1);
            if (rowIndex == 0)
                setObstacleDirection(Constant.TOP, 1);
            if (lastCol)
                setObstacleDirection(Constant.RIGHT, 1);
            if (lastRow)
                setObstacleDirection(Constant.DOWN, 1);
        }

        public void setObstacleDirection(int direction, int value)
        {
            obstacle[direction] = value;
            openDirectionCount--;
        }

        public int findDirection(int move)
        {
            int i = Constant.LEFT - 1;
            while ((i < Constant.DOWN) && (move >= 0))
            {
                i++;
                if (obstacle[i] == 0)
                    move--;
            }

            if (move == -1)
                return i;
            else
                return Constant.NOMOVE;
        }
        public void updateMaxDirection()
        {
            maxDirection = 0;
            for (int i = Constant.LEFT; i <= Constant.DOWN; i++)
            {
                if (qValue[i] > qValue[maxDirection])
                    maxDirection = i;
            }
        }
    }

    public class Maze
    {
        public int rowCount;
        public int colCount;
        public int rowGoal;
        public int colGoal;
        public int rowInit;
        public int colInit;

        public int rowRobot;
        public int colRobot;
        public int rowLast;
        public int colLast;
        public int rowNext;
        public int colNext;

        public bool robotMoved;

        public int rewardGoal;
        public int rewardOther;
        public double discountFactor;

        public Node[,] board;

        private Random rnd;

        public Maze()
        {
            rowCount = 0;
            colCount = 0;
            rowGoal = Constant.NOTKNOWN;
            colGoal = Constant.NOTKNOWN;
            rowInit = Constant.NOTKNOWN;
            colInit = Constant.NOTKNOWN;
            rowRobot = Constant.NOTKNOWN;
            colRobot = Constant.NOTKNOWN;
            rowLast = Constant.NOTKNOWN;
            colLast = Constant.NOTKNOWN;
            rowNext = Constant.NOTKNOWN;
            colNext = Constant.NOTKNOWN;
            robotMoved = false;
            rewardGoal = 0;
            rewardOther = 0;
            discountFactor = 0;
            board = null;
            rnd = new Random(DateTime.Now.Millisecond);
        }

        public void setDimension(int r_count, int c_count)
        {
            rowCount = r_count;
            colCount = c_count;
            board = new Node[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < colCount; j++)
                    board[i, j].initNode(i,j,(i == rowCount -1), (j == colCount - 1));

        }

        private void clearSpecialNode(int rowNum, int colNum)
        {
            board[rowNum, colNum].isGoal = false; 
            board[rowNum, colNum].isInit = false; 
            board[rowNum, colNum].isObstacle = false; 
        }

        public void setGoal(int rowNum, int colNum)
        {
            //clear special old properties of this node
            clearSpecialNode(rowNum, colNum);

            // clear old goal
            if (rowGoal != Constant.NOTKNOWN)
                board[rowGoal, colGoal].isGoal = false; 

            // set new goal
            board[rowNum, colNum].isGoal = true; 
            rowGoal = rowNum;
            colGoal = colNum;
        }

        public void setInit(int rowNum, int colNum)
        {
            //clear special old properties of this node
            clearSpecialNode(rowNum, colNum);
            
            // clear old initial location of robot
            if (rowInit != Constant.NOTKNOWN)
                board[rowInit, colInit].isInit = false;

            // set new initial location for robot
            board[rowNum, colNum].isInit = true; 
            rowInit = rowNum;
            colInit = colNum;
        }

        public void setObstacle(int rowNum, int colNum)
        {
            //clear special old properties of this node
            clearSpecialNode(rowNum, colNum);

            board[rowNum, colNum].isObstacle = true;
            board[rowNum, colNum].openDirectionCount = 0;
        }

        public void setQLearningParam(int rewG, int rewO, double discF)
        {
            rewardGoal = rewG;
            rewardOther = rewO;
            discountFactor = discF;
        }


        public void resetRobot()
        {
            if (rowRobot != Constant.NOTKNOWN)
            {
                board[rowRobot, colRobot].isUnderRobot = false;
            }

            rowRobot = rowInit;
            colRobot = colInit;
            board[rowRobot, colRobot].isUnderRobot = true;
        }

        public bool goalReached()
        {
            if ((rowRobot == rowGoal) && (colRobot == colGoal))
                return true;
            else 
                return false;
        }

        public void moveRobot()
        {
            rowLast = rowRobot;
            colLast = colRobot;

            rowNext = rowRobot;
            colNext = colRobot;

            int nextMove = rnd.Next(board[rowRobot, colRobot].openDirectionCount);
            int nextDirection = board[rowRobot, colRobot].findDirection(nextMove);

            if (nextDirection == Constant.NOMOVE)
            {
                robotMoved = false;
                return;
            }

            if (nextDirection == Constant.LEFT)
                colNext--;
            else if (nextDirection == Constant.TOP)
                rowNext--;
            else if (nextDirection == Constant.RIGHT)
                colNext++;
            else if (nextDirection == Constant.DOWN)
                rowNext++;

            if (board[rowNext, colNext].isObstacle)
            {
                board[rowRobot, colRobot].setObstacleDirection(nextDirection, 2);
                robotMoved = false;
                return;
            }

            int reward = rewardOther;
            if (board[rowNext, colNext].isGoal)
                reward = rewardGoal;

            board[rowLast, colLast].qValue[nextDirection] = reward +
                (int)(discountFactor * board[rowNext, colNext].qValue[board[rowNext, colNext].maxDirection]); // + board[rowLast, colLast].iReward[nextDirection]

            board[rowLast, colLast].updateMaxDirection();

            board[rowRobot, colRobot].isUnderRobot = false;
            rowRobot = rowNext;
            colRobot = colNext;
            robotMoved = true;
            board[rowRobot, colRobot].isUnderRobot = true;



        }
    }
}
