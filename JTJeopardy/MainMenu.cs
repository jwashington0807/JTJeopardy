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
                new GameScreen().createContestants(textBox1.Text, textBox2.Text, textBox3.Text);
            }
            else
            {
                // Show Validation Errors
            }
        }
    }
}
