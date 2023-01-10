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
    public partial class GameSettingsControl : UserControl
    {
        MainMenu menu = null;

        public GameSettingsControl(MainMenu _menu)
        {
            InitializeComponent();

            menu = _menu;

            this.Dock = DockStyle.Fill;
        }
    }
}
