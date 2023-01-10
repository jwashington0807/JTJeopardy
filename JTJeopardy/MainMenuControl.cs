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
    public partial class MainMenuControl : UserControl
    {
        MainMenu menu = null;

        public MainMenuControl(MainMenu _menu)
        {
            InitializeComponent();

            menu = _menu;

            this.Dock = DockStyle.Fill;
        }
        private void pBxSettings_Click(object sender, EventArgs e)
        {
            menu.SwitchToSettingsMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validation Steps
            bool validation = false;

            //Enter Validation 
            

            if (!validation)
            {
                //_gameScreen.SetContestants(textBox1.Text, textBox2.Text, textBox3.Text);
                //_gameScreen.PhaseOneBegin();
            }
            else
            {
                // Show Validation Errors
            }
        }
    }
}
