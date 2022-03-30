namespace TTCMain
{
    partial class TimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.add10 = new System.Windows.Forms.Button();
            this.add30 = new System.Windows.Forms.Button();
            this.add60 = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.popOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Location = new System.Drawing.Point(11, 258);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(220, 24);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 73);
            this.label1.TabIndex = 13;
            this.label1.Text = "0:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // add10
            // 
            this.add10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add10.Location = new System.Drawing.Point(12, 120);
            this.add10.Name = "add10";
            this.add10.Size = new System.Drawing.Size(221, 23);
            this.add10.TabIndex = 11;
            this.add10.Text = "+ 30 Seconds";
            this.add10.UseVisualStyleBackColor = true;
            this.add10.Click += new System.EventHandler(this.add10_Click);
            // 
            // add30
            // 
            this.add30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add30.Location = new System.Drawing.Point(12, 149);
            this.add30.Name = "add30";
            this.add30.Size = new System.Drawing.Size(221, 23);
            this.add30.TabIndex = 10;
            this.add30.Text = "+ 2 Minutes";
            this.add30.UseVisualStyleBackColor = true;
            this.add30.Click += new System.EventHandler(this.add30_Click);
            // 
            // add60
            // 
            this.add60.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add60.Location = new System.Drawing.Point(12, 178);
            this.add60.Name = "add60";
            this.add60.Size = new System.Drawing.Size(221, 23);
            this.add60.TabIndex = 9;
            this.add60.Text = "+ 5 Minutes";
            this.add60.UseVisualStyleBackColor = true;
            this.add60.Click += new System.EventHandler(this.add60_Click);
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Location = new System.Drawing.Point(11, 207);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(221, 45);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 90);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // popOutButton
            // 
            this.popOutButton.BackColor = System.Drawing.Color.White;
            this.popOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("popOutButton.BackgroundImage")));
            this.popOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.popOutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.popOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popOutButton.Image = ((System.Drawing.Image)(resources.GetObject("popOutButton.Image")));
            this.popOutButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.popOutButton.Location = new System.Drawing.Point(211, 20);
            this.popOutButton.Name = "popOutButton";
            this.popOutButton.Size = new System.Drawing.Size(20, 20);
            this.popOutButton.TabIndex = 15;
            this.popOutButton.UseVisualStyleBackColor = false;
            this.popOutButton.Click += new System.EventHandler(this.popOutButton_Click);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 297);
            this.Controls.Add(this.popOutButton);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add10);
            this.Controls.Add(this.add30);
            this.Controls.Add(this.add60);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimerForm";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimerForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TimerForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add10;
        private System.Windows.Forms.Button add30;
        private System.Windows.Forms.Button add60;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button popOutButton;
    }
}