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
        Image image = Resources.waitingIcon;

        public HostScreen()
        {
            InitializeComponent();
        }

        public static bool ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top=20, Text=text };
            TextBox textBox = new TextBox() { Left = 50, Top=50, Width=400 };
            Button confirmation = new Button() { Text = "Ok", Left=350, Width=100, Top=70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? true : false;
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

                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
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
            bool promptValue = ShowDialog("Test", "123");
            return true;
        }

        public Tuple<int, bool> DataToAlex(string answer, string question)
        {
            return null;
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
    }
}
