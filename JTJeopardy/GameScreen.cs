using JTJeopardy.Utilities;
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
    public partial class GameScreen : Form
    {
        //HostScreen hostScreen = null;

        public GameScreen()
        {
        }

        public GameScreen(string c1, string c2, string c3) {

            // Create New Instances for Contestants
            Contestant contestant1 = new Contestant(c1);
            Contestant contestant2 = new Contestant(c1);
            Contestant contestant3 = new Contestant(c1);

            // Sets the name of the GameScreen
            this.Name = "JTJeopardy";

            // Minimizes "flicker" when resizing
            this.DoubleBuffered = true;
             
            // Whenever the screen resizes, redraw the Form
            this.ResizeRedraw = true;

            // Initial screen size to mathch the client's window
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Width = Screen.PrimaryScreen.Bounds.Height;

            // Continues with OOB Initialization
            this.InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            // Load the Host Screen
            //hostScreen = new HostScreen();
            //hostScreen.Show();
        }
    }
}
