using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace RLMaze
{
    class Constant
    {
        public static int NOTKNOWN = -5;

        public static int NOMOVE = -1;
        public static int LEFT = 0;
        public static int TOP = 1;
        public static int RIGHT = 2;
        public static int DOWN = 3;


        public static int GOALNode = 0;
        public static int INITNode = 1;
        public static int OBSTNode = 2;
        public static int EMPTNode = 3;

        public static Color REDColor = Color.FromArgb(255, 180, 180);
        public static Color BLUEColor = Color.FromArgb(160, 160, 255);
        public static Color BLACKColor = Color.FromArgb(0, 0, 0);
        public static Color GREENColor = Color.FromArgb(180, 255, 180);

        public static Font TEXTFontR = new Font("Times New Roman", 8);
        public static Font TEXTFontQ = new Font("Times New Roman", 8);
        public static Brush BRUSHR = Brushes.Red;
        public static Brush BRUSHQ = Brushes.Black;

        public static Pen PENLine = new Pen(Color.Black, 2);

    }
}
