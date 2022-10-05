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
    public partial class GameScreen : Form
    {
        const int boardQuestions = 30;
        HostScreen hostScreen = null;
        Control[,] questions = new Control[6, 6];

        int round = 1;

        public GameScreen()
        {
        }

        public GameScreen(string c1, string c2, string c3)
        {

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
            try
            {
                bool start = false;

                // Assign Question Blocks to Array
                AssignSpaces();

                // Load the questions and assign them


                // Load the Host Screen
                LoadHostScreen();

                // Load The Board
                LoadGameBoard();
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
            }
        }

        private void AssignSpaces()
        {
            int counter = 1;

            for (int col = 0; col < 6; col++)
            {
                for (int row = 1; row <= 5; row++)
                {
                    Control control = this.Controls.Find("question" + counter.ToString(), true).FirstOrDefault();
                    questions[row, col] = control;
                    counter++;
                }
            }
        }

        private void LoadGameBoard()
        {
            List<int> questionLocations = Enumerable.Range(0, 30).ToList();

            for (int i = 0; i < boardQuestions; i++)
            {
                int r = questionLocations.OrderBy(bn => Guid.NewGuid()).FirstOrDefault();
                questionLocations.Remove(r);

                PrepareQuestion(r);
            }
        }

        private async void LoadHostScreen()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            hostScreen = new HostScreen();
            hostScreen.Show();

            await hostScreen.WaitForStart();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs.ToString());
        }

        private void PrepareQuestion(int question)
        {
            int counter = 0;

            for (int col = 0; col < 6; col++)
            {
                for (int row = 1; row <= 5; row++)
                {
                    if (counter == question)
                    {
                        PictureBox pictureBox = questions[row, col] as PictureBox;
                        AssignValue(pictureBox, row, round);

                        break;
                    }
                    else
                    {
                        counter++;
                    }
                }
            }
        }

        private void AssignValue(PictureBox pictureBox, int row, int round)
        {
            pictureBox.Image = ResourceHelper.getImage(row);
        }
    }
}
