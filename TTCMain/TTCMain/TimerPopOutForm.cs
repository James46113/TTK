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
    public partial class TimerPopOutForm : Form
    {
        public Point MouseDownLocation;
        public TimerPopOutForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string secs = Math.Floor(TimerForm.countdown % 60).ToString();

            if ((Math.Floor(TimerForm.countdown % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(TimerForm.countdown % 60).ToString();
            }

            label1.Text = Math.Floor(TimerForm.countdown / 60).ToString() + ":" + secs;
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

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }
    }
}
