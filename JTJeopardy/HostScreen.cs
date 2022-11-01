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
//using RotatePictureBox;

namespace JTJeopardy
{
    public partial class HostScreen : Form
    {
        float angle;
        bool begin = false;
        Image image = Resources.waitingIcon;
        System.Windows.Forms.Timer timer;
        GameScreen _gameScreen = null;

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

        private void timer_tick(object sender, EventArgs e)
        {
            angle += 2;
            this.Refresh();
        }

        private void HostScreen_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Image = RotateImage(image, angle);
        }

        public bool WaitForStart()
        {
            // Stop rotationtimer
            timer.Stop();

            // Change the tab
            this.tabControl1.Invoke(new Action(ChangeHostTab)); 

            // Start Separate Thread
            Task thread1 = Task.Factory.StartNew(() => ThreadProc());
            Task.WaitAll(thread1);

            return true;
        }

        private void ChangeHostTab()
        {
            this.tabControl1.SelectedTab = this.tabPage2;
        }

        public void ThreadProc()
        {
            while (true)
            {
                Thread.Sleep(20);

                if (begin)
                {
                    return;
                }
            }
        }

        public Tuple<int, bool> DataToAlex(string answer, string question)
        {
            Tuple<int, bool> ex = new Tuple<int, bool>(1, false);
            return ex;
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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            begin = true;
        }
    }
}
