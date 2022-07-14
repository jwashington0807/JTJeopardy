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

        Contestant(string _name)
        {
            this.name = _name;
        }

        int score = 0;
        int getScore
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
