using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TTCMain
{
    public partial class SeatingplangenForm : Form
    {
        public SeatingplangenForm()
        {
            InitializeComponent();
        }

        List<string> students = new List<string>();
        Random rnd = new Random();

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            students.Clear();
            foreach (string item in studentsBox.Items)
            {
                students.Add(item);
            }

            for (int i = 0; i < students.Count; i++)
            {
                int rnum = rnd.Next(0, students.Count);
                string temp = students[i];
                students[i] = students[rnum];
                students[rnum] = temp;
            }
            shuffledBox.Items.Clear();
            foreach (string item in students)
            {
                shuffledBox.Items.Add((students.IndexOf(item) + 1) + " - " + item);
                //Console.WriteLine(item);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            students.Clear();
            shuffledBox.Items.Clear();
            studentsBox.Items.Clear();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getStudents();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            studentsBox.Items.Add(addBox.Text);
            addBox.Text = "";
        }

        private void addBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.Enter))
            {
                studentsBox.Items.Add(addBox.Text);
                addBox.Text = "";
            }
        }

        private void addBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
