using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTJeopardy.Utilities
{
    internal class Contestant
    {
        string name = String.Empty;

        public Contestant(string _name)
        {
            this.name = _name;
        }

        // Player's score throughout the game
        private int score = 0;
        public int getScore
        {
            get
            {
                return score;
            }

            set
            {
                this.score = value;
            }
        }
    }
}
