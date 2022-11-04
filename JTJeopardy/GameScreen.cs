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
    public struct QandAs
    {
        public string question;
        public string answer;
        public int row;
        public int col;
        public int value;
    }

    public partial class GameScreen : Form
    {
        #region Global Variables

        Control[,] questions = new Control[6, 6];
        MainMenu mainScreen = null;
        HostScreen hostScreen = null;
        List<QandAs> dataBank = new List<QandAs>();
        System.Windows.Forms.Timer picTimer = null;
        int counter = 0;

        #endregion

        #region Class Methods
        public GameScreen()
        {
            // Load the Host Screen
            LoadHostScreen();

            // Load the Main Screen
            LoadMainScreen();

            // Sets the name of the GameScreen
            this.Name = GameSettings.title;

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
        }

        internal void SetContestants(string text1, string text2, string text3)
        {
            Contestant._contestantOne = text1;
            Contestant._contestantTwo = text2;  
            Contestant._contestantThree = text3;

            lblContestantOne.Text = Contestant._contestantOne;
            lblContestantTwo.Text = Contestant._contestantTwo;
            lblContestantThree.Text = Contestant._contestantThree;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            try
            {
                lblContestantOneScore.Text = Contestant._contestantOneScore.ToString();
                lblContestantTwoScore.Text = Contestant._contestantTwoScore.ToString();
                lblContestantThreeScore.Text = Contestant._contestantThreeScore.ToString();

                tableLayoutPanel1.SendToBack();
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
            mainScreen = new MainMenu(this);
            mainScreen.Show();
        }

        private void LoadHostScreen()
        {
            hostScreen = new HostScreen(this);
            hostScreen.Show();
        }


        #endregion

        #region Event Trigger Methods

        async void AnswerClick(object sender, EventArgs e, int row, int col)
        {
            bool finish = false;

            if (sender is PictureBox)
            {
                // Get PictureBox and Set to Blank
                PictureBox pictureBox = sender as PictureBox;
                pictureBox.Image = ResourceHelper.getImage(0);

                // Disable selected answer
                pictureBox.Enabled = false;

                // Get Data for Answer
                QandAs retrieveData = PrepareToSendToAlex(row, col, hostScreen);

                // Add a duplicate to expand
                PictureBox pictureBoxDup = new PictureBox();
                pictureBoxDup.Image = ResourceHelper.getImage(0);
                pictureBoxDup.Width = pictureBox.Width;
                pictureBoxDup.Height = pictureBox.Height;
                pictureBoxDup.SizeMode = PictureBoxSizeMode.StretchImage;

                // Draw the Text onto PictureBox Duplicate
                using (Graphics g = Graphics.FromImage(pictureBoxDup.Image))
                {
                    Rectangle rec = new Rectangle(0, 0, pictureBoxDup.Width, pictureBoxDup.Height);
                    g.DrawString(retrieveData.answer, new Font("Arial", 20), Brushes.White, rec);
                }

                // Add New Control
                this.Controls.Add(pictureBoxDup);
                pictureBoxDup.Location = pictureBox.Location;
                pictureBoxDup.BringToFront();

                // Force Redraw of PictureBox
                pictureBoxDup.Invalidate();

                // Expand Control
                picTimer = new System.Windows.Forms.Timer();
                picTimer.Tick += new EventHandler((sen, x) => PicTimer_Tick(pictureBoxDup));
                picTimer.Interval = 5;
                picTimer.Start();

                // Set Question and Answer on Host Screen
                hostScreen.InsertAnswerAndQuestion(retrieveData.answer, retrieveData.question);

                while (!finish)
                {
                    // Wait for Alex's Response
                    var response = await Task.Run(() => hostScreen.DataToAlexAsync(retrieveData.answer, retrieveData.question));

                    if(response.player == ResourceHelper.Chosen.NONE)
                    {
                        finish = true;
                    }
                    if (response.correct)
                    {
                        finish = true;

                        if (response.player == ResourceHelper.Chosen.ONE)
                        {
                            Contestant._contestantOneScore = Contestant._contestantOneScore + retrieveData.value;
                            lblContestantOneScore.Invalidate();
                        }
                        else if (response.player == ResourceHelper.Chosen.TWO)
                        {
                            Contestant._contestantTwoScore = Contestant._contestantTwoScore + retrieveData.value;
                            lblContestantTwoScore.Invalidate();
                        }
                        else
                        {
                            Contestant._contestantThreeScore = Contestant._contestantThreeScore + retrieveData.value;
                            lblContestantThreeScore.Invalidate();
                        }
                    }
                    else
                    {
                        if(response.player == ResourceHelper.Chosen.ONE)
                        {
                            Contestant._contestantOneScore = Contestant._contestantOneScore - retrieveData.value;
                            lblContestantOneScore.Invalidate();
                        }
                        else if (response.player == ResourceHelper.Chosen.TWO)
                        {
                            Contestant._contestantTwoScore = Contestant._contestantTwoScore - retrieveData.value;
                            lblContestantTwoScore.Invalidate();
                        }
                        else
                        {
                            Contestant._contestantThreeScore = Contestant._contestantThreeScore - retrieveData.value;
                            lblContestantThreeScore.Invalidate();
                        }
                    }
                }

                // Remove Temp PictureBox
                pictureBoxDup.Dispose();
            }
        }

        private void PicTimer_Tick(PictureBox pictureBoxDup)
        {
            if(counter != 1)
            {
                pictureBoxDup.Size = this.Size;
                pictureBoxDup.Location = new Point(0, 0);
                counter++;
            }
            else
            {
                picTimer.Stop();
                counter = 0;
            }
        }

        internal async void PhaseOneBegin()
        {
            await Task.Run(() => hostScreen.WaitForStart());

            LoadGameBoard();
        } 

        private void lblContestantOne_Paint(object sender, PaintEventArgs e)
        {
            lblContestantOne.Text = Contestant._contestantOne;
        }

        private void lblContestantTwo_Paint(object sender, PaintEventArgs e)
        {
            lblContestantTwo.Text = Contestant._contestantTwo;
        }

        private void lblContestantThree_Paint(object sender, PaintEventArgs e)
        {
            lblContestantThree.Text = Contestant._contestantThree;
        }

        private void lblContestantOneScore_Paint(object sender, PaintEventArgs e)
        {
            lblContestantOneScore.Text = Contestant._contestantOneScore.ToString();
        }

        private void lblContestantTwoScore_Paint(object sender, PaintEventArgs e)
        {
            lblContestantTwoScore.Text = Contestant._contestantTwoScore.ToString();
        }

        private void lblContestantThreeScore_Paint(object sender, PaintEventArgs e)
        {
            lblContestantThreeScore.Text = Contestant._contestantThreeScore.ToString();
        }

        #endregion

        #region Helper Methods

        private void AssignValue(PictureBox pictureBox, int row, int round)
        {
            pictureBox.Image = ResourceHelper.getImage(row);
        }

        #endregion

        #region Data Methods

        private QandAs findSelectionData(int row, int col)
        {
            var matchedObject =
                   (from t in dataBank
                    where t.row == row && t.col == col
                    select t).FirstOrDefault();

            return matchedObject;
        }

        internal QandAs PrepareToSendToAlex(int row, int col, HostScreen screen)
        {
            QandAs result = findSelectionData(row, col);

            return result;
        }

        public void LoadAnswers(int row, int col)
        {
            // Create new instance for struct
            QandAs data = new QandAs();

            data.answer = "row = " + row.ToString() + " : col = " + col.ToString();
            data.question = "Who is JT?";
            data.row = row;
            data.col = col;
            data.value = ResourceHelper.getValue(row);

            dataBank.Add(data);
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
                        AssignValue(pictureBox, row, GameSettings.round);

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
                    LoadAnswers(row, col);

                    counter++;
                }
            }
        }

        private void LoadGameBoard()
        {
            List<int> questionLocations = Enumerable.Range(0, 30).ToList();

            for (int i = 0; i < GameSettings.boardQuestions; i++)
            {
                int r = questionLocations.OrderBy(bn => Guid.NewGuid()).FirstOrDefault();
                questionLocations.Remove(r);

                PrepareQuestion(r);
                this.Refresh();
                Thread.Sleep(10);
            }
        }

        #endregion
    }
}
