using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTJeopardy.Utilities
{
    internal class Contestant
    {

        public Contestant(string _one, string _two, string _three)
        {
            getOneName = _one;
            getTwoName = _two;
            getThreeName = _three;
        }

        #region Player One
        // Player One's score throughout the game
        private int scoreOne = 0;
        public int getScoreOne
        {
            get
            {
                return scoreOne;
            }

            set
            {
                this.scoreOne = value;
            }
        }

        // Player One's name throughout the game
        string oneName = String.Empty;
        public string getOneName
        {
            get
            {
                return oneName;
            }

            set
            {
                this.oneName = value;
            }
        }

        #endregion

        #region Player Two
        // Player Two's score throughout the game
        private int scoreTwo = 0;
        public int getScoreTwo
        {
            get
            {
                return scoreTwo;
            }

            set
            {
                this.scoreTwo = value;
            }
        }

        // Player Two's name throughout the game
        string twoName = String.Empty;
        public string getTwoName
        {
            get
            {
                return twoName;
            }

            set
            {
                this.twoName = value;
            }
        }

        #endregion

        #region Player Three
        // Player Three's score throughout the game
        private int scoreThree = 0;
        public int getScoreThree
        {
            get
            {
                return scoreThree;
            }

            set
            {
                this.scoreThree = value;
            }
        }

        // Player Three's name throughout the game
        string threeName = String.Empty;
        public string getThreeName
        {
            get
            {
                return threeName;
            }

            set
            {
                this.threeName = value;
            }
        }

        #endregion
    }
}
