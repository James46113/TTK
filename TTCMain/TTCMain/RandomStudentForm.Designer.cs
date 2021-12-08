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
            this.importClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.addStudentBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.chooseButton = new System.Windows.Forms.Button();
            this.studentsBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(186, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importClassToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importClassToolStripMenuItem
            // 
            this.importClassToolStripMenuItem.Name = "importClassToolStripMenuItem";
            this.importClassToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.importClassToolStripMenuItem.Text = "Import Class";
            this.importClassToolStripMenuItem.Click += new System.EventHandler(this.importClassToolStripMenuItem_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(97, 256);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(76, 20);
            this.addStudentButton.TabIndex = 12;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // addStudentBox
            // 
            this.addStudentBox.Location = new System.Drawing.Point(12, 256);
            this.addStudentBox.Name = "addStudentBox";
            this.addStudentBox.Size = new System.Drawing.Size(79, 20);
            this.addStudentBox.TabIndex = 11;
            this.addStudentBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addStudentBox_KeyDown);
            this.addStudentBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addStudentBox_MouseDown);
            this.addStudentBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.addStudentBox_MouseMove);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(97, 173);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(76, 68);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(97, 99);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(76, 68);
            this.resultBox.TabIndex = 9;
            this.resultBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resultBox_MouseDown);
            this.resultBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resultBox_MouseMove);
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(97, 27);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(76, 68);
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
            this.studentsBox.Size = new System.Drawing.Size(79, 212);
            this.studentsBox.TabIndex = 7;
            this.studentsBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.studentsBox_MouseDown);
            this.studentsBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.studentsBox_MouseMove);
            // 
            // RandomStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 289);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.addStudentBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.studentsBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandomStudentForm";
            this.Text = "Random Student Picker";
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
        private System.Windows.Forms.ToolStripMenuItem importClassToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.TextBox addStudentBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.ListBox studentsBox;
    }
}