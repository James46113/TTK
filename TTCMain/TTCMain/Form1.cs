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
        string time;
        int timeNum;
        int periodInfoNum;
        List<string> perInf = new List<string>() { "Period 1\r\nEnds at 9:35", "Period 2\r\nEnds at 10:30", "Tutor 1\r\nEnds at 10:45", "Tutor 2\r\n Ends at 11:00", "Tutor 3\r\nEnds at 11:15", "Period 3\r\nEnds at 12:10", "Period 4a\r\nEnds at 12:40", "Period 4b\r\nEnds at 13:10", "Period 4c\r\nEnds at 13:40", "Period 5\r\nEnds at 14:35", "Period 6\r\nEnds at 15:25(Y10) 15:30(Y11)" };
        List<int> perInd = new List<int>() { 575, 630, 645, 660, 615, 730, 760, 790, 820, 875, 930};
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
        private void clockButton_Click(object sender, EventArgs e)
        {
            ClockForm cf = new ClockForm();
            cf.Show();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("HH:mm:ss");

            timeNum = int.Parse(DateTime.Now.ToString("HH"))*60 + int.Parse(DateTime.Now.ToString("mm"));
            foreach (int item in perInd)
            {
                if (timeNum < item)
                {
                    periodInfoNum = perInd.IndexOf(item);
                    break;
                }
            }

            infoBox.Text = time + "\r\n" + perInf[periodInfoNum];
        }
    }
}
