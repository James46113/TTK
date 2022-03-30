namespace TTCMain
{
    partial class ClockForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Black;
            this.timeLabel.Location = new System.Drawing.Point(-5, -6);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(247, 88);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "00:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeLabel_MouseDown);
            this.timeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeLabel_MouseMove);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 98);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClockForm";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.ClockForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClockForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClockForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
    }
}