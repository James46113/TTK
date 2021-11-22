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
    public partial class DiceForm : Form
    {
        float countDown = 1000;
        Random rnd = new Random();
        public Point MouseDownLocation;
        public DiceForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            timer1.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            countDown -= timer1.Interval;
            label1.Text = rnd.Next(1, 7).ToString();
            if (countDown < 0)
            {
                label1.BackColor = Color.Chartreuse;
                pictureBox1.BackColor = Color.Chartreuse;
                countDown = 1000;
                timer1.Enabled = false;
            }
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

        private void DiceForm_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void DiceForm_MouseMove(object sender, MouseEventArgs e)
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
