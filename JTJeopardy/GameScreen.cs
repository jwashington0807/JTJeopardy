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
    }
}
