using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTJeopardy.Utilities
{
    internal static class Contestant
    {
        public static string contestantOne = String.Empty;
        public static string contestantTwo = String.Empty;
        public static string contestantThree = String.Empty;

        private static int contestantOneScore = 0;
        public static int _contestantOneScore
        {
            get { return contestantOneScore; }
            set { contestantOneScore = value; }
        }

        private static int contestantTwoScore = 0;
        public static int _contestantTwoScore
        {
            get { return contestantTwoScore; }
            set { contestantTwoScore = value; }
        }

        private static int contestantThreeScore = 0;
        public static int _contestantThreeScore
        {
            get { return contestantThreeScore; }
            set { contestantThreeScore = value; }
        }
    }
}
