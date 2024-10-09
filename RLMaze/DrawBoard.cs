using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace RLMaze
{
    class DrawBoard
    {
        static public void Draw(Maze maze, PaintEventArgs e, int usedHeader, bool showAll, bool showRewards, bool showOthers, bool showValue,
            ref int boardX, ref int boardY, ref int boardWidth, ref int boardHeight, ref int rowStep, ref int colStep)
        {
            Graphics g = e.Graphics;

            Rectangle boardRect = e.ClipRectangle;
            boardX = 20;
            boardY = 20 + usedHeader;
            boardWidth = boardRect.Width - 40;
            boardHeight = boardRect.Height - 40 - usedHeader;

            // Create rectangle for clipping region.
            Rectangle clipRect = new Rectangle(boardX, boardY, boardWidth, boardHeight);
            // Set clipping region of graphics to rectangle.
            g.SetClip(clipRect);
            g.Clear(Color.White);

            colStep = boardWidth / maze.colCount;
            rowStep = boardHeight / maze.rowCount;

            int rectX = boardX;
            int rectY = boardY;
            int rectWidth = colStep;
            int rectHeight = rowStep;

            for (int i = 0; i < maze.rowCount; i++)
            {
                rectX = boardX;
                for (int j = 0; j < maze.colCount; j++)
                {
                    if (maze.board[i, j].isGoal)
                    {
                        g.FillRectangle(new SolidBrush(Constant.REDColor), rectX, rectY, rectWidth, rectHeight);
                    }
                    else if (maze.board[i, j].isInit)
                    {
                        g.FillRectangle(new SolidBrush(Constant.BLUEColor), rectX, rectY, rectWidth, rectHeight);
                    }
                    else if (maze.board[i, j].isObstacle)
                    {
                        g.FillRectangle(new SolidBrush(Constant.BLACKColor), rectX, rectY, rectWidth, rectHeight);
                    }
                    else
                    {
                        g.DrawRectangle(new Pen(Color.Black), rectX, rectY, rectWidth, rectHeight);
                    }

                    if (showAll)
                    {
                        if (maze.board[i, j].isUnderRobot)
                        {
                            g.FillRectangle(new SolidBrush(Constant.GREENColor), rectX, rectY, rectWidth, rectHeight);
                        }

                        if (!maze.board[i, j].isObstacle)
                        {
                            g.DrawString(maze.board[i, j].qValue[Constant.LEFT].ToString(), Constant.TEXTFontQ, Constant.BRUSHQ,
                                rectX + 10, rectY + rectHeight / 3);
                            if (showRewards)
                                g.DrawString(maze.board[i, j].iReward[Constant.LEFT].ToString(), Constant.TEXTFontR, Constant.BRUSHR,
                                    rectX + 10, rectY + 3 * rectHeight / 5);
                            if (showRewards)
                                g.DrawString(maze.board[i, j].iReward[Constant.RIGHT].ToString(), Constant.TEXTFontR, Constant.BRUSHR,
                                    rectX + rectWidth - 25, rectY + rectHeight / 3);
                            g.DrawString(maze.board[i, j].qValue[Constant.RIGHT].ToString(), Constant.TEXTFontQ, Constant.BRUSHQ,
                                rectX + rectWidth - 25, rectY + 3 * rectHeight / 5);
                            if (showRewards)
                                g.DrawString(maze.board[i, j].iReward[Constant.TOP].ToString(), Constant.TEXTFontR, Constant.BRUSHR,
                                    rectX + rectWidth / 3, rectY + 10);
                            g.DrawString(maze.board[i, j].qValue[Constant.TOP].ToString(), Constant.TEXTFontQ, Constant.BRUSHQ,
                                rectX + 3 * rectWidth / 5, rectY + 10);

                            g.DrawString(maze.board[i, j].qValue[Constant.DOWN].ToString(), Constant.TEXTFontQ, Constant.BRUSHQ,
                                rectX + rectWidth / 3, rectY + rectHeight - 25);
                            if (showRewards)
                                g.DrawString(maze.board[i, j].iReward[Constant.DOWN].ToString(), Constant.TEXTFontR, Constant.BRUSHR,
                                    rectX + 3 * rectWidth / 5, rectY + rectHeight - 25);

                        }
                        if (showValue && (!maze.board[i, j].isObstacle))
                            g.DrawString(maze.board[i, j].qValue[maze.board[i, j].maxDirection].ToString(), Constant.TEXTFontR, Constant.BRUSHR,
                            rectX + rectWidth / 2, rectY + rectHeight / 2);
                    }



                    if (showOthers)
                        g.DrawString(maze.board[i, j].openDirectionCount.ToString(), Constant.TEXTFontR, Constant.BRUSHQ,
                            rectX + rectWidth / 2, rectY + 2 * rectHeight / 3);


                    rectX += colStep;
                }
                rectY += rowStep;
            }
        }
    }
}
