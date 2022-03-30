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
    public partial class AnalogueClockForm : Form
    {
        int handLen = 75;
        float hHandLen = 56.25f;
        int mid;
        int secs;
        int mins;
        int hrs;
        float x1;
        float y1;
        float x2;
        float y2;
        Point MouseDownLocation;
        float scale = 1;
        Pen linPen = new Pen(Color.Black, 5);
        Pen thinPen = new Pen(Color.Black, 1);
        int add;
        public AnalogueClockForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockFace.Refresh();
        }

        private void clockFace_Paint(object sender, PaintEventArgs e)
        {
            mid = clockFace.Width / 2;

            secs = Convert.ToInt32(DateTime.Now.ToString("ss"));
            mins = Convert.ToInt32(DateTime.Now.ToString("mm"));
            hrs = Convert.ToInt32(DateTime.Now.ToString("hh"));

            e.Graphics.DrawLine(new Pen(Color.Red, 2), mid, mid, mid + Convert.ToSingle(scale * handLen * Math.Sin(6 * secs * (Math.PI / 180))), // Second hand
                mid - Convert.ToSingle(scale * handLen * Math.Cos(6 * secs * (Math.PI / 180))));

            e.Graphics.DrawLine(new Pen(Color.Black, 4), mid, mid, mid + Convert.ToSingle(scale * handLen * Math.Sin(6 * mins * (Math.PI / 180))), // Minuite hand
                mid - Convert.ToSingle(scale * handLen * Math.Cos(6 * mins * (Math.PI / 180))));

            e.Graphics.DrawLine(new Pen(Color.Black, 5), mid, mid, mid + Convert.ToSingle(scale * hHandLen * Math.Sin(30 * hrs * (Math.PI / 180))), // Hour hand
                mid - Convert.ToSingle(scale * hHandLen * Math.Cos(30 * hrs * (Math.PI / 180))));

            for (int i = 0; i <= 60; i += 1)
            {
                if (i % 5 == 0) add = 0;
                else add = 6;
                x1 = Convert.ToSingle(scale * (70.5 + add) * Math.Sin(6 * i * (Math.PI / 180)));
                y1 = Convert.ToSingle(scale * (70.5 + add) * Math.Cos(6 * i * (Math.PI / 180)));
                x2 = Convert.ToSingle(scale * 82.5 * Math.Sin(6 * i * (Math.PI / 180)));
                y2 = Convert.ToSingle(scale * 82.5 * Math.Cos(6 * i * (Math.PI / 180)));
                if (i % 5 == 0)
                {
                    e.Graphics.DrawLine(linPen, mid + x1, mid - y1, mid + x2, mid - y2);
                }
                else
                {
                    e.Graphics.DrawLine(thinPen, mid + x1, mid - y1, mid + x2, mid - y2);
                }
            }
        }

        private void clockFace_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
        private void clockFace_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }
    }
}
