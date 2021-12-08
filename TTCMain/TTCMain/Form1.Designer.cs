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
            this.infoBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerButton
            // 
            this.timerButton.Location = new System.Drawing.Point(12, 113);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(102, 88);
            this.timerButton.TabIndex = 0;
            this.timerButton.Text = "Timer";
            this.timerButton.UseVisualStyleBackColor = true;
            this.timerButton.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // diceButton
            // 
            this.diceButton.Location = new System.Drawing.Point(128, 114);
            this.diceButton.Name = "diceButton";
            this.diceButton.Size = new System.Drawing.Size(102, 88);
            this.diceButton.TabIndex = 1;
            this.diceButton.Text = "Dice";
            this.diceButton.UseVisualStyleBackColor = true;
            this.diceButton.Click += new System.EventHandler(this.diceButton_Click);
            // 
            // randStuButton
            // 
            this.randStuButton.Location = new System.Drawing.Point(12, 214);
            this.randStuButton.Name = "randStuButton";
            this.randStuButton.Size = new System.Drawing.Size(101, 88);
            this.randStuButton.TabIndex = 2;
            this.randStuButton.Text = "Random Student";
            this.randStuButton.UseVisualStyleBackColor = true;
            this.randStuButton.Click += new System.EventHandler(this.randStuButton_Click);
            // 
            // clockButton
            // 
            this.clockButton.Location = new System.Drawing.Point(128, 214);
            this.clockButton.Name = "clockButton";
            this.clockButton.Size = new System.Drawing.Size(102, 88);
            this.clockButton.TabIndex = 3;
            this.clockButton.Text = "Clock";
            this.clockButton.UseVisualStyleBackColor = true;
            this.clockButton.Click += new System.EventHandler(this.clockButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.Location = new System.Drawing.Point(12, 12);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(218, 74);
            this.infoBox.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 312);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.clockButton);
            this.Controls.Add(this.randStuButton);
            this.Controls.Add(this.diceButton);
            this.Controls.Add(this.timerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TTK";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timerButton;
        private System.Windows.Forms.Button diceButton;
        private System.Windows.Forms.Button randStuButton;
        private System.Windows.Forms.Button clockButton;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Timer timer1;
    }
}

