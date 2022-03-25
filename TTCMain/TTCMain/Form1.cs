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
        static public string theme = "light";
        static public Color dark = Color.FromArgb(50, 50, 50);

        public Point MouseDownLocation;
        string time;
        int timeNum;
        int countdownTime;
        int periodInfoNum;
        List<string> perInf = new List<string>() { "Before School Hours", "Period 1\r\nEnds at 9:35", "Period 2\r\nEnds at 10:30", "Tutor 1\r\nEnds at 10:45", "Tutor 2\r\n Ends at 11:00", "Tutor 3\r\nEnds at 11:15", "Period 3\r\nEnds at 12:10", "Period 4a\r\nEnds at 12:40", "Period 4b\r\nEnds at 13:10", "Period 4c\r\nEnds at 13:40", "Period 5\r\nEnds at 14:35", "Period 6\r\nEnds at 15:25(Y10) 15:30(Y11)", "Period 7\r\nEnds at 16:30", "School Hours Over"};
        List<int> perInd = new List<int>() { 515, 575, 630, 645, 660, 615, 730, 760, 790, 820, 875, 930, 990, 99999999};
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

            timeLabel.Text = time;
            periodLabel.Text = perInf[periodInfoNum];
            if (timeNum != 13)
            {
                countdownTime = perInd[periodInfoNum]/60*3600 + (perInd[periodInfoNum]%60)*60 - (int.Parse(DateTime.Now.ToString("HH")) * 3600 + int.Parse(DateTime.Now.ToString("mm")) * 60 + int.Parse(DateTime.Now.ToString("ss")));
                Console.WriteLine(countdownTime);
                countdownLabel.Text = perInf[periodInfoNum].Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0] + Convert.ToString(countdownTime/3600) + ":" + Convert.ToString(countdownTime/60) + ":" + Convert.ToString(;
            }
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theme = "light";
            this.BackColor = Color.White;
            menuStrip1.BackColor = Color.White;
            menuStrip1.ForeColor = Color.Black;
            lightToolStripMenuItem.BackColor = Color.White;
            lightToolStripMenuItem.ForeColor = Color.Black;
            darkToolStripMenuItem.BackColor = Color.White;
            darkToolStripMenuItem.ForeColor = Color.Black;
            timerButton.BackColor = Color.White;
            timerButton.ForeColor = Color.Black;
            diceButton.BackColor = Color.White;
            diceButton.ForeColor = Color.Black;
            randStuButton.BackColor = Color.White;
            randStuButton.ForeColor = Color.Black;
            clockButton.BackColor = Color.White;
            clockButton.ForeColor = Color.Black;
            timeLabel.BackColor = Color.White;
            timeLabel.ForeColor = Color.Black;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Black;
            periodLabel.BackColor = Color.White;
            periodLabel.ForeColor = Color.Black;
            seatplanbutton.BackColor = Color.White;
            seatplanbutton.ForeColor = Color.Black;
            label1.Focus();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theme = "dark";
            this.BackColor = dark;
            menuStrip1.BackColor = dark;
            menuStrip1.ForeColor = Color.White;
            lightToolStripMenuItem.BackColor = dark;
            lightToolStripMenuItem.ForeColor = Color.White;
            darkToolStripMenuItem.BackColor = dark;
            darkToolStripMenuItem.ForeColor = Color.White;
            timerButton.BackColor = dark;
            timerButton.ForeColor = Color.White;
            diceButton.BackColor = dark;
            diceButton.ForeColor = Color.White;
            randStuButton.BackColor = dark;
            randStuButton.ForeColor = Color.White;
            clockButton.BackColor = dark;
            clockButton.ForeColor = Color.White;
            timeLabel.BackColor = dark;
            timeLabel.ForeColor = Color.White;
            label2.BackColor = dark;
            label2.ForeColor = Color.White;
            periodLabel.BackColor = dark;
            periodLabel.ForeColor = Color.White;
            seatplanbutton.BackColor = dark;
            seatplanbutton.ForeColor = Color.White;
            label1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(238, 125, 0);
            periodLabel.ForeColor = Color.FromArgb(0, 155, 180);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeatingplangenForm f = new SeatingplangenForm();
            f.Show();
        }
    }
}
