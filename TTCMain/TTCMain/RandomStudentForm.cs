using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace TTCMain
{
    public partial class RandomStudentForm : Form
    {
        Random rnd = new Random();
        public Point MouseDownLocation;
        public RandomStudentForm()
        {
            InitializeComponent();
        }
        List<string> names = new List<string>();

        private void chooseButton_Click(object sender, EventArgs e)
        {
            int num = studentsBox.Items.Count;
            if (num > 0)
            {
                int studentInd = rnd.Next(0, num);
                string result = studentsBox.Items[studentInd].ToString();
                resultBox.Text = result;
                studentsBox.Items.RemoveAt(studentInd);
                names.Add(result);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            studentsBox.Items.Clear();
            getStudentsFile();
        }

        void getStudents()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                getStudentsFile();
            }
        }

        void getStudentsFile()
        {
            try
            {
                using (StreamReader sReader = new StreamReader(openFileDialog1.FileName))
                {
                    string line;
                    while (true)
                    {
                        line = sReader.ReadLine();
                        if (line != null)
                        {
                            studentsBox.Items.Add(line);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void importClassToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            getStudents();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            Add_Student();
        }

        private void Add_Student()
        {
            string student = addStudentBox.Text;
            names.Add(student);
            studentsBox.Items.Add(student);
            addStudentBox.Text = "";
        }

        private void addStudentBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add_Student();
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

        private void RandomStudentForm_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void RandomStudentForm_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }

        private void studentsBox_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void studentsBox_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }

        private void resultBox_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void resultBox_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }

        private void addStudentBox_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Down(e);
        }

        private void addStudentBox_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move(e);
        }
    }
}
