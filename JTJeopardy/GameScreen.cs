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
using JTJeopardy.Utilities;

namespace JTJeopardy
{

    public partial class GameScreen : Form
    {
        #region Global Variables

        const int boardQuestions = 30;
        Control[,] questions = new Control[6, 6];
        MainMenu mainScreen = null;
        HostScreen hostScreen = null;
        DataMethods dataMethods = new DataMethods();
        Contestant contestant = null;

        int round = 1;
        #endregion

        #region Class Methods
        public GameScreen()
        {
            // Load the Main Screen
            LoadMainScreen();

            // Sets the name of the GameScreen
            this.Name = "JT Jeopardy";

            // Minimizes "flicker" when resizing
            this.DoubleBuffered = true;

            // Whenever the screen resizes, redraw the Form
            this.ResizeRedraw = true;

            // Initial screen size to mathch the client's window
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            // Continues with OOB Initialization
            this.InitializeComponent();

            // Assign Question Blocks to Array
            AssignSpaces();

            // Load the Host Screen
            LoadHostScreen();
        }
        private void GameScreen_Load(object sender, EventArgs e)
        {
            try
            {
             
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
            }
        }

        #endregion

        #region Loading Methods
        private void LoadMainScreen()
        {
            mainScreen = new MainMenu();
            mainScreen.Show();
        }

        private async void LoadHostScreen()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            hostScreen = new HostScreen();
            hostScreen.Show();

            bool answer = await Task.Run(() => hostScreen.WaitForStart());

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs.ToString());

            if (answer)
            {
                // Load The Board
                LoadGameBoard();
            }
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
                        pictureBox.Click += new EventHandler((sender, e) => AnswerClick(sender, e, row, col));
                        AssignValue(pictureBox, row, round);

                        return;
                    }
                    else
                    {
                        counter++;
                    }
                }
            }
        }

        private void AssignSpaces()
        {
            int counter = 1;

            for (int col = 0; col < 6; col++)
            {
                for (int row = 1; row <= 5; row++)
                {
                    Control control = Controls.Find("question" + counter.ToString(), true).FirstOrDefault();
                    questions[row, col] = control;

                    // Load the questions and assign them
                    dataMethods.LoadAnswers(row, col);

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
                this.Refresh();
                Thread.Sleep(10);
            }
        }
        #endregion

        #region Event Trigger Methods

        void AnswerClick(object sender, EventArgs e, int row, int col)
        {
            if (sender is PictureBox)
            {
                using (PictureBox box = (PictureBox)sender)
                {
                    dataMethods.PrepareToSendToAlex(row, col, hostScreen);
                }
            }
        }

        #endregion

        #region Helper Methods
        private void AssignValue(PictureBox pictureBox, int row, int round)
        {
            pictureBox.Image = ResourceHelper.getImage(row);
        }

        #endregion

        #region Data Methods

        public void createContestants(string text1, string text2, string text3)
        {
            contestant = new Contestant(text1, text2, text3);
        }

        #endregion
    }
}
