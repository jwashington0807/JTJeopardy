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
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            hostScreen = new HostScreen();
            hostScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create New Instances of Players

            Contestant playerOne = new Contestant(playerOneName.Text);
            Contestant playerTwo = new Contestant(playerTwoName.Text);
            Contestant playerThree = new Contestant(playerThreeName.Text);

            // Load the Game Screen
            gameScreenTabControl.SelectedTab = startGameTab;

        }
    }
}
