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
        public static Image getImage(int i)
        {
            if (i == 1)
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
    }
}
