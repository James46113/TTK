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
            this.timerButton = new System.Windows.Forms.Button();
            this.diceButton = new System.Windows.Forms.Button();
            this.randStuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerButton
            // 
            this.timerButton.Location = new System.Drawing.Point(12, 84);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(102, 88);
            this.timerButton.TabIndex = 0;
            this.timerButton.Text = "Timer";
            this.timerButton.UseVisualStyleBackColor = true;
            this.timerButton.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // diceButton
            // 
            this.diceButton.Location = new System.Drawing.Point(154, 84);
            this.diceButton.Name = "diceButton";
            this.diceButton.Size = new System.Drawing.Size(102, 88);
            this.diceButton.TabIndex = 1;
            this.diceButton.Text = "Dice";
            this.diceButton.UseVisualStyleBackColor = true;
            this.diceButton.Click += new System.EventHandler(this.diceButton_Click);
            // 
            // randStuButton
            // 
            this.randStuButton.Location = new System.Drawing.Point(12, 191);
            this.randStuButton.Name = "randStuButton";
            this.randStuButton.Size = new System.Drawing.Size(101, 88);
            this.randStuButton.TabIndex = 2;
            this.randStuButton.Text = "Random Student";
            this.randStuButton.UseVisualStyleBackColor = true;
            this.randStuButton.Click += new System.EventHandler(this.randStuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 383);
            this.Controls.Add(this.randStuButton);
            this.Controls.Add(this.diceButton);
            this.Controls.Add(this.timerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button timerButton;
        private System.Windows.Forms.Button diceButton;
        private System.Windows.Forms.Button randStuButton;
    }
}

