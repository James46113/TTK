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
    public partial class ClockForm : Form
    {
        public Point MouseDownLocation;
        public ClockForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm");
        }

        private void timeLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void timeLabel_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }

        private void ClockForm_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void ClockForm_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClockForm_Load(object sender, EventArgs e)
        {
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;

            if (Form1.theme == "dark")
            {
                this.BackColor = Form1.dark;
                timeLabel.BackColor = Form1.dark;
                timeLabel.ForeColor = Color.White;
            }
            else if (Form1.theme == "light")
            {
                this.BackColor = Color.White;
                timeLabel.BackColor = Color.White;
                timeLabel.ForeColor = Color.Black;
            }
        }

    }
}
