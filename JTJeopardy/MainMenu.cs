using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTJeopardy
{
    public partial class MainMenu : Form
    {
        string contestantOne = String.Empty;
        string contestantTwo = String.Empty;
        string contestantThree = String.Empty;

        public MainMenu()
        {
            // Minimizes "flicker" when resizing
            this.DoubleBuffered = true;

            // Continues with OOB Initialization
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validation Steps
            bool validation = false;

            //Enter Validation 

            if (!validation)
            {
                GameScreen gameScreen = new GameScreen(contestantOne, contestantTwo, contestantThree);
                gameScreen.Show();
            }
            else
            {
                // Show Validation Errors
            }
        }
    }
}
