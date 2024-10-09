using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RLMaze
{
    class myUtility
    {
        static public int[] splitToIntArray(string strList, char seperator)
        {
            string[] strTemp = strList.Split(seperator);

            int len = strTemp.Length;
            if (strTemp[strTemp.Length - 1] == "")
                len--;

            int[] intArray = new int[len];
            for (int i = 0; i < len; i++)
                intArray[i] = int.Parse(strTemp[i]);
            return intArray;
        }

        static public void ReadMazeFromTextFile(String strTextFile, Maze maze)
        {
            String content;
            int[] buffer;
            int index;
            using (StreamReader sr = new StreamReader(strTextFile))
            {
                content = sr.ReadLine();
                buffer = splitToIntArray(content, ' ');

                maze.setDimension(buffer[0], buffer[1]);
                maze.setGoal(buffer[3], buffer[4]);
                maze.setInit(buffer[6], buffer[7]);


                for (int i = 0; i < maze.rowCount; i++)
                {
                    content = sr.ReadLine();
                    buffer = splitToIntArray(content, ' ');
                    index = 0;
                    for (int j = 0; j < maze.colCount; j++)
                    {
                        if (buffer[index++] == Constant.OBSTNode)
                            maze.setObstacle(i, j);

                        index++;

                        for (int k = Constant.LEFT; k <= Constant.DOWN; k++)
                            maze.board[i, j].qValue[k] = buffer[index++];

                        index++;

                        for (int k = Constant.LEFT; k <= Constant.DOWN; k++)
                            maze.board[i, j].iReward[k] = buffer[index++];

                        index++;

                        for (int k = Constant.LEFT; k <= Constant.DOWN; k++)
                            maze.board[i, j].obstacle[k] = buffer[index++];
                    }
                }
            }

        }

        static public void WriteMazeToTextFile(String strTextFile, Maze maze)
        {
            using (StreamWriter sw = new StreamWriter(strTextFile))
            {
                sw.Write(maze.rowCount); sw.Write(" ");
                sw.Write(maze.colCount); sw.Write(" -1 ");
                sw.Write(maze.rowGoal); sw.Write(" ");
                sw.Write(maze.colGoal); sw.Write(" -1 ");
                sw.Write(maze.rowInit); sw.Write(" ");
                sw.Write(maze.colInit); sw.WriteLine();

                for (int i = 0; i < maze.rowCount; i++)
                {
                    for (int j = 0; j < maze.colCount; j++)
                    {
                        if (maze.board[i, j].isGoal)
                            sw.Write(Constant.GOALNode);
                        else if (maze.board[i, j].isInit)
                            sw.Write(Constant.INITNode);
                        else if (maze.board[i, j].isObstacle)
                            sw.Write(Constant.OBSTNode);
                        else
                            sw.Write(Constant.EMPTNode);

                        sw.Write(" -1 ");

                        for (int k = Constant.LEFT; k <= Constant.DOWN; k++ )
                        {
                            sw.Write(maze.board[i, j].qValue[k]);
                            sw.Write(" ");
                        }

                        sw.Write("-1 ");

                        for (int k = Constant.LEFT; k <= Constant.DOWN; k++)
                        {
                            sw.Write(maze.board[i, j].iReward[k]);
                            sw.Write(" ");
                        }

                        sw.Write("-1 ");

                        for (int k = Constant.LEFT; k <= Constant.DOWN; k++)
                        {
                            sw.Write(maze.board[i, j].obstacle[k]);
                            sw.Write(" ");
                        }
                    }
                    sw.WriteLine();
                }
            }
        }

    }
}
    