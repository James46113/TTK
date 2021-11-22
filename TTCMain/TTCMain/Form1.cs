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
    public partial class Form1 : Form
    {
        public Point MouseDownLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            TimerForm timerForm = new TimerForm();
            timerForm.Show();
        }

        private void diceButton_Click(object sender, EventArgs e)
        {
            DiceForm diceForm = new DiceForm();
            diceForm.Show();
        }

        private void randStuButton_Click(object sender, EventArgs e)
        {
            RandomStudentForm randStuForm = new RandomStudentForm();
            randStuForm.Show();
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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }


    }
}
