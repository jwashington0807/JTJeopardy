using JTJeopardy.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTJeopardy
{
    public partial class MainMenu : Form
    {
        MainMenuControl control;
        GameSettingsControl settings;

        public MainMenu()
        {
            // Minimizes "flicker" when resizing
            this.DoubleBuffered = true;

            // Continues with OOB Initialization
            this.InitializeComponent();

            // Initiate User Controls
            control = new MainMenuControl(this);
            settings = new GameSettingsControl(this);

            // Add Control
            this.Controls.Add(control);
        }

        internal void SwitchToSettingsMenu()
        {
            this.Controls.Clear();
            this.Controls.Add(settings);
        }
    }
}
