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
        HostScreen hostScreen = null;

        public GameScreen()
        {
            // Suspends the GameScreen layout
            this.SuspendLayout();

            // Sets the name of the GameScreen
            this.Name = "JTJeopardy";

            // Minimizes "flicker" when resizing
            this.DoubleBuffered = true;

            // When resized, draw everything again
            this.ResizeRedraw = true;

            // Resumes layout from suspension
            this.ResumeLayout(false);

            // Continues with OOB Initialization
            this.InitializeComponent();

            // Hide the Tabs in the Control
            gameScreenTabControl.Appearance = TabAppearance.FlatButtons;
            gameScreenTabControl.ItemSize = new Size(0, 1);
            gameScreenTabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            // Load the Host Screen
            hostScreen = new HostScreen();
            hostScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create New Instances of Players

            Contestant one = new Contestant(playerOne.Text);
            Contestant two = new Contestant(playerTwo.Text);
            Contestant three = new Contestant(playerThree.Text);

            // Load the Game Background
            gameScreenTabControl.SelectedTab = startGameTab;
            this.Width = startGameTab.BackgroundImage.Width + 25;
            this.Height = startGameTab.BackgroundImage.Height + 75;

            // Load the First Round Class
            FirstRound roundOne = new FirstRound();
            
            // Change Alex's Game Screen

        }
    }
}
