namespace TTCMain
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerButton = new System.Windows.Forms.Button();
            this.diceButton = new System.Windows.Forms.Button();
            this.randStuButton = new System.Windows.Forms.Button();
            this.clockButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seatplanbutton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerButton
            // 
            this.timerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timerButton.Location = new System.Drawing.Point(36, 117);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(102, 88);
            this.timerButton.TabIndex = 0;
            this.timerButton.Text = "Timer";
            this.timerButton.UseVisualStyleBackColor = true;
            this.timerButton.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // diceButton
            // 
            this.diceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diceButton.Location = new System.Drawing.Point(168, 117);
            this.diceButton.Name = "diceButton";
            this.diceButton.Size = new System.Drawing.Size(102, 88);
            this.diceButton.TabIndex = 1;
            this.diceButton.Text = "Dice";
            this.diceButton.UseVisualStyleBackColor = true;
            this.diceButton.Click += new System.EventHandler(this.diceButton_Click);
            // 
            // randStuButton
            // 
            this.randStuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randStuButton.Location = new System.Drawing.Point(295, 117);
            this.randStuButton.Name = "randStuButton";
            this.randStuButton.Size = new System.Drawing.Size(101, 88);
            this.randStuButton.TabIndex = 2;
            this.randStuButton.Text = "Random Student";
            this.randStuButton.UseVisualStyleBackColor = true;
            this.randStuButton.Click += new System.EventHandler(this.randStuButton_Click);
            // 
            // clockButton
            // 
            this.clockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clockButton.Location = new System.Drawing.Point(427, 117);
            this.clockButton.Name = "clockButton";
            this.clockButton.Size = new System.Drawing.Size(102, 88);
            this.clockButton.TabIndex = 3;
            this.clockButton.Text = "Clock";
            this.clockButton.UseVisualStyleBackColor = true;
            this.clockButton.Click += new System.EventHandler(this.clockButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(11, 29);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(103, 29);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "00:00:00";
            this.timeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.timeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // periodLabel
            // 
            this.periodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.periodLabel.Location = new System.Drawing.Point(557, 24);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(184, 73);
            this.periodLabel.TabIndex = 8;
            this.periodLabel.Text = "Current Period Label";
            this.periodLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.periodLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.periodLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(120, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 63);
            this.label2.TabIndex = 9;
            this.label2.Text = "UTC Teacher Toolkit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // seatplanbutton
            // 
            this.seatplanbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seatplanbutton.Location = new System.Drawing.Point(559, 117);
            this.seatplanbutton.Name = "seatplanbutton";
            this.seatplanbutton.Size = new System.Drawing.Size(102, 88);
            this.seatplanbutton.TabIndex = 10;
            this.seatplanbutton.Text = "Seating \r\nPlanGenerator";
            this.seatplanbutton.UseVisualStyleBackColor = true;
            this.seatplanbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 231);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seatplanbutton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.clockButton);
            this.Controls.Add(this.randStuButton);
            this.Controls.Add(this.diceButton);
            this.Controls.Add(this.timerButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.periodLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "UTC Teacher Toolkit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timerButton;
        private System.Windows.Forms.Button diceButton;
        private System.Windows.Forms.Button randStuButton;
        private System.Windows.Forms.Button clockButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button seatplanbutton;
    }
}

