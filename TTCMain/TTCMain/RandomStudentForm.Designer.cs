namespace TTCMain
{
    partial class RandomStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomStudentForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.addStudentBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.chooseButton = new System.Windows.Forms.Button();
            this.studentsBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveClassToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(248, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.fileToolStripMenuItem.Text = "Import Class";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveClassToolStripMenuItem
            // 
            this.saveClassToolStripMenuItem.Name = "saveClassToolStripMenuItem";
            this.saveClassToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.saveClassToolStripMenuItem.Text = "Save Class";
            this.saveClassToolStripMenuItem.Click += new System.EventHandler(this.saveClassToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addStudentButton
            // 
            this.addStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentButton.Location = new System.Drawing.Point(149, 302);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(84, 28);
            this.addStudentButton.TabIndex = 12;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // addStudentBox
            // 
            this.addStudentBox.Location = new System.Drawing.Point(149, 276);
            this.addStudentBox.Name = "addStudentBox";
            this.addStudentBox.Size = new System.Drawing.Size(84, 20);
            this.addStudentBox.TabIndex = 11;
            this.addStudentBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addStudentBox_KeyDown);
            this.addStudentBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addStudentBox_MouseDown);
            this.addStudentBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.addStudentBox_MouseMove);
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(152, 157);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(84, 46);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(152, 113);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(84, 32);
            this.resultBox.TabIndex = 9;
            this.resultBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resultBox_MouseDown);
            this.resultBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resultBox_MouseMove);
            // 
            // chooseButton
            // 
            this.chooseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseButton.Location = new System.Drawing.Point(152, 27);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(84, 75);
            this.chooseButton.TabIndex = 8;
            this.chooseButton.Text = "Choose";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // studentsBox
            // 
            this.studentsBox.FormattingEnabled = true;
            this.studentsBox.Location = new System.Drawing.Point(12, 27);
            this.studentsBox.Name = "studentsBox";
            this.studentsBox.Size = new System.Drawing.Size(131, 303);
            this.studentsBox.TabIndex = 7;
            this.studentsBox.SelectedIndexChanged += new System.EventHandler(this.studentsBox_SelectedIndexChanged);
            this.studentsBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.studentsBox_MouseDown);
            this.studentsBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.studentsBox_MouseMove);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(150, 217);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(84, 46);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "🛈";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RandomStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 339);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.addStudentBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.studentsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandomStudentForm";
            this.Text = "Random Student Picker";
            this.Load += new System.EventHandler(this.RandomStudentForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RandomStudentForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RandomStudentForm_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.TextBox addStudentBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.ListBox studentsBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ToolStripMenuItem saveClassToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}