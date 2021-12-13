namespace TTCMain
{
    partial class SeatingplangenForm
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
            this.clearButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addBox = new System.Windows.Forms.TextBox();
            this.shuffledBox = new System.Windows.Forms.ListBox();
            this.studentsBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(202, 122);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(136, 63);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear Students";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.fileToolStripMenuItem.Text = "Import Class";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffleButton.Location = new System.Drawing.Point(203, 53);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(136, 63);
            this.shuffleButton.TabIndex = 13;
            this.shuffleButton.Text = "Shuffle Students";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(205, 316);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(136, 63);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add Student";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addBox
            // 
            this.addBox.Location = new System.Drawing.Point(204, 290);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(136, 20);
            this.addBox.TabIndex = 11;
            this.addBox.TextChanged += new System.EventHandler(this.addBox_TextChanged);
            this.addBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addBox_KeyPress);
            // 
            // shuffledBox
            // 
            this.shuffledBox.FormattingEnabled = true;
            this.shuffledBox.Location = new System.Drawing.Point(345, 29);
            this.shuffledBox.Name = "shuffledBox";
            this.shuffledBox.Size = new System.Drawing.Size(181, 420);
            this.shuffledBox.TabIndex = 10;
            // 
            // studentsBox
            // 
            this.studentsBox.FormattingEnabled = true;
            this.studentsBox.Location = new System.Drawing.Point(15, 29);
            this.studentsBox.Name = "studentsBox";
            this.studentsBox.Size = new System.Drawing.Size(181, 420);
            this.studentsBox.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SeatingplangenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 468);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.shuffledBox);
            this.Controls.Add(this.studentsBox);
            this.Name = "SeatingplangenForm";
            this.Text = "SeatingplangenForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.ListBox shuffledBox;
        private System.Windows.Forms.ListBox studentsBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}