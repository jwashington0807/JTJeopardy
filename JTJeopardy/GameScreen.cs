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
    struct QandAs
    {
        public string question;
        public string answer;
        public int row;
        public int col;
        public int value;
    }

    public partial class GameScreen : Form
    {
        const int boardQuestions = 30;
        Control[,] questions = new Control[6, 6];
        HostScreen hostScreen = null;
        int round = 1;
        QandAs data;

        public GameScreen()
        {
        }

        public GameScreen(string c1, string c2, string c3)
        {
            // Create new instance for struct
            data = new QandAs();

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

            // Assign Question Blocks to Array
            AssignSpaces();

            // Load the Host Screen
            LoadHostScreen();
        }

        private void LoadAnswers(int row, int col)
        {
            data.

            data.answer = "The best person in the world";
            data.question = "Who is JT?";
            data.row = row;
            data.col = col;
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

        private void AssignSpaces()
        {
            int counter = 1;

            for (int col = 0; col < 6; col++)
            {
                for (int row = 1; row <= 5; row++)
                {
                    Control control = this.Controls.Find("question" + counter.ToString(), true).FirstOrDefault();
                    questions[row, col] = control;

                    // Load the questions and assign them
                    LoadAnswers(row, col);

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
                //Continue

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
                        pictureBox.Click += new EventHandler(AnswerClick);
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

        void AnswerClick(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                using (PictureBox box = (PictureBox)sender)
                {
                    var damageResult = await Task.Run(() => CalculateDamageDone());
                }
            }
        }

        private void AssignValue(PictureBox pictureBox, int row, int round)
        {
            pictureBox.Image = ResourceHelper.getImage(row);
        }
    }
}
