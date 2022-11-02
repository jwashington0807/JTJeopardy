using JTJeopardy.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JTJeopardy.Utilities.ResourceHelper;

namespace JTJeopardy
{
    public partial class HostScreen : Form
    {
        float angle;
        bool begin = false;
        bool questioned = false;
        Image image = Resources.waitingIcon;
        System.Windows.Forms.Timer timer;
        GameScreen _gameScreen = null;
        bool correct;

        Chosen chosen;

        #region Class Functions

        public HostScreen(GameScreen gameScreen)
        {
            _gameScreen = gameScreen;
            InitializeComponent();
        }

        private void HostScreen_Load(object sender, EventArgs e)
        {
            try
            {
                lblWaiting.Text = "Please wait for the game to begin";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                SetStyle(ControlStyles.ResizeRedraw, true);
                SetStyle(ControlStyles.UserPaint, true);
                SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

                timer = new System.Windows.Forms.Timer();
                timer.Interval = 50;
                timer.Tick += new EventHandler(timer_tick);
                timer.Start();
                
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        private void timer_tick(object sender, EventArgs e)
        {
            angle += 2;
            this.Refresh();
        }

        public bool WaitForStart()
        {
            // Stop rotationtimer
            timer.Stop();

            // Change the tab
            this.tabControl1.Invoke(new Action(ChangeToStartScreen)); 

            // Start Separate Thread
            Task thread1 = Task.Factory.StartNew(() => ThreadProc());
            Task.WaitAll(thread1);

            return true;
        }

        #region Wait Methods

        public ResourceHelper.ResponseData DataToAlexAsync(string answer, string question)
        {
            ResourceHelper.ResponseData responseData = new ResourceHelper.ResponseData();

            // Change the tab
            this.tabControl1.Invoke(new Action(ChangeToPrepScreen));

            // Start Separate Thread
            Task thread1 = Task.Factory.StartNew(() => ResponseScreen());
            Task.WaitAll(thread1);

            responseData.correct = correct;
            responseData.player = chosen;

            return responseData;
        }

        public static Bitmap RotateImage(Image image, float rotationAngle)
        {

            if (image != null)
            {
                Bitmap bit = new Bitmap(image.Width, image.Height);
                bit.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                Graphics g = Graphics.FromImage(bit);

                g.TranslateTransform(image.Width / 2, image.Height / 2);

                g.RotateTransform(rotationAngle);

                g.TranslateTransform(-image.Width / 2, -image.Height / 2);

                g.DrawImage(image, new PointF(0, 0));

                return bit;
            }
            else
            {
                throw new ArgumentNullException("Error");
            }
        }

        #endregion

        #region While Methods 

        public void ThreadProc()
        {
            while (true)
            {
                Thread.Sleep(20);

                if (begin)
                {
                    begin = false;
                    return;
                }
            }
        }

        public void ResponseScreen()
        {
            while (true)
            {
                Thread.Sleep(20);

                if (questioned)
                {
                    questioned = false;
                    return;
                }
            }
        }

        #endregion

        #region Event Methods

        private void HostScreen_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Image = RotateImage(image, angle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            begin = true;
        }

        private void btnContestant1_Click(object sender, EventArgs e)
        {
            chosen = Chosen.ONE;
            ChangeToAnswerScreen();
        }

        private void btnContestant2_Click(object sender, EventArgs e)
        {
            chosen = Chosen.TWO;
            ChangeToAnswerScreen();
        }

        private void btnContestant3_Click(object sender, EventArgs e)
        {
            chosen = Chosen.THREE;
            ChangeToAnswerScreen();
        }
        private void btnCorrect_Click(object sender, EventArgs e)
        {
            correct = true;
            questioned = true;
            ChangeToPrepScreen();
        }

        private void btnIncorrect_Click(object sender, EventArgs e)
        {
            correct = false;
            questioned = true;
            ChangeToPrepScreen();
        }

        #endregion

        #region Tab Controls

        private void ChangeToStartScreen()
        {
            this.tabControl1.SelectedTab = this.tabPage2;
        }

        private void ChangeToPrepScreen()
        {
            this.tabControl1.SelectedTab = this.tabPage3;
        }

        private void ChangeToAnswerScreen()
        {
            this.tabControl1.SelectedTab = this.tabPage4;
        }

        #endregion
    }
}
