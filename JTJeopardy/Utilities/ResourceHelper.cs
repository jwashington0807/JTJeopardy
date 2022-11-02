using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTJeopardy.Utilities
{
    public static class ResourceHelper
    {
        public struct ResponseData
        {
            public bool correct;
            public Chosen player;
        };

        public enum Chosen
        {
            ONE,
            TWO,
            THREE
        }

        public static Image getImage(int i)
        {
            if (i == 0)
                return Resources.blankBlue;
            else if (i == 1)
                return Resources._200Square;
            else if (i == 2)
                return Resources._400Square;
            else if (i == 3)
                return Resources._600Square;
            else if (i == 4)
                return Resources._800Square;
            else
                return Resources._1000Square;

        }

        public static int getValue(int i)
        {
            if (i == 0)
                return 0;
            else if (i == 1)
                return GameSettings.round == 1 ? 200 : 400;
            else if (i == 2)
                return GameSettings.round == 1 ? 400 : 800;
            else if (i == 3)
                return GameSettings.round == 1 ? 600 : 1200;
            else if (i == 4)
                return GameSettings.round == 1 ? 800 : 1600;
            else
                return GameSettings.round == 1 ? 1000 : 2000;

        }
    }
}
