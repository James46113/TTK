using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCMain
{
    public partial class TimerForm : Form
    {
        static public float countdown = 0;
        public Point MouseDownLocation;
        public TimerForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                if (timer1.Enabled)
                {
                    timer1.Enabled = false;
                    startButton.Text = "Start";
                }
                else
                {
                    timer1.Enabled = true;
                    startButton.Text = "Stop";
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            countdown -= 1;
            //countdown = ((int)Math.Round(countdown, 1));
            bool point = false;
            /*
            foreach (char c in countdown.ToString())
            {
                if (c == '.')
                {
                    point = true;
                }
            }
            if (!point)
            {
                label1.Text = countdown.ToString() + ".0";
            }
            else
            {
                label1.Text = countdown.ToString();
            }
            */

            string secs = Math.Floor(countdown % 60).ToString();

            if ((Math.Floor(countdown % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(countdown % 60).ToString();
            }

            label1.Text = Math.Floor(countdown / 60).ToString() + ":" + secs;
            if (countdown == 0f)
            {
                timer1.Enabled = false;
                startButton.Text = "Start";
            }
            Console.WriteLine(Math.Floor(countdown / 60).ToString() + ":" + secs);

        }

        private void add60_Click(object sender, EventArgs e)
        {
            if (countdown + 300 <= 3540)
            {
                countdown += 300;
            }
            else
            {
                countdown += 3600 - countdown;
            }

            string secs = Math.Floor(countdown % 60).ToString();

            if ((Math.Floor(countdown % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(countdown % 60).ToString();
            }

            label1.Text = Math.Floor(countdown / 60).ToString() + ":" + secs;

        }

        private void add30_Click(object sender, EventArgs e)
        {
            if (countdown + 120 <= 3540)
            {
                countdown += 120;
            }
            else
            {
                countdown += 3600 - countdown;

            }
            string secs = Math.Floor(countdown % 60).ToString();

            if ((Math.Floor(countdown % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(countdown % 60).ToString();
            }

            label1.Text = Math.Floor(countdown / 60).ToString() + ":" + secs;

        }

        private void add10_Click(object sender, EventArgs e)
        {
            if (countdown + 30 <= 3540)
            {
                countdown += 30;
            }
            else
            {
                countdown += 3600 - countdown;
            }

            string secs = Math.Floor(countdown % 60).ToString();

            if ((Math.Floor(countdown % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(countdown % 60).ToString();
            }
            label1.Text = Math.Floor(countdown / 60).ToString() + ":" + secs;

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            countdown = 0;
            label1.Text = Math.Round(countdown, 1).ToString() + ":00";
            startButton.Text = "Start";
        }

        private void Mouse_Down(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void Mouse_Move(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void TimerForm_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void TimerForm_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            if (Form1.theme == "dark")
            {
                BackColor = Form1.dark;
                label1.BackColor = Form1.dark;
                pictureBox1.BackColor = Form1.dark;
                add10.BackColor = Form1.dark;
                add30.BackColor = Form1.dark;
                add60.BackColor = Form1.dark;
                startButton.BackColor = Form1.dark;
                Reset.BackColor = Form1.dark;
                label1.ForeColor = Color.White;
                add10.ForeColor = Color.White;
                add30.ForeColor = Color.White;
                add60.ForeColor = Color.White;
                startButton.ForeColor = Color.White;
                Reset.ForeColor = Color.White;
            }
        }

        private void popOutButton_Click(object sender, EventArgs e)
        {
            TimerPopOutForm timerPopOutForm = new TimerPopOutForm();
            timerPopOutForm.Show();
        }
    }

}

