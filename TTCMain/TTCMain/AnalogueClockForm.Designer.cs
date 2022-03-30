namespace TTCMain
{
    partial class AnalogueClockForm
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
            this.clockFace = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clockFace)).BeginInit();
            this.SuspendLayout();
            // 
            // clockFace
            // 
            this.clockFace.Location = new System.Drawing.Point(0, 0);
            this.clockFace.Name = "clockFace";
            this.clockFace.Size = new System.Drawing.Size(200, 200);
            this.clockFace.TabIndex = 1;
            this.clockFace.TabStop = false;
            this.clockFace.Paint += new System.Windows.Forms.PaintEventHandler(this.clockFace_Paint);
            this.clockFace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clockFace_MouseDown);
            this.clockFace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.clockFace_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AnalogueClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.clockFace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnalogueClockForm";
            this.Text = "Clock";
            ((System.ComponentModel.ISupportInitialize)(this.clockFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox clockFace;
        private System.Windows.Forms.Timer timer1;
    }
}