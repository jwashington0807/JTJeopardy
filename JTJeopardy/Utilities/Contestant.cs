using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTJeopardy.Utilities
{
    internal static class Contestant
    {
        private static string contestantOne = String.Empty;
        public static string _contestantOne
        {
            get { return contestantOne; }
            set { contestantOne = value; }
        }

        private static string contestantTwo = String.Empty;
        public static string _contestantTwo
        {
            get { return contestantTwo; }
            set { contestantTwo = value; }
        }

        private static string contestantThree = String.Empty;
        public static string _contestantThree
        {
            get { return contestantThree; }
            set { contestantThree = value; }
        }

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
