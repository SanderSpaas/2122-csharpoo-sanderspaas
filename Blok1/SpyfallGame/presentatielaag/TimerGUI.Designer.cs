namespace SpyfallGame.presentatielaag
{
    partial class TimerGUI
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
            this.TimerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.ColorPanel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TimerLabel
            // 
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(50, 177);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(376, 87);
            this.TimerLabel.TabIndex = 0;
            this.TimerLabel.Text = "8:00";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zoek de Spion 🕵️";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorPanel
            // 
            this.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorPanel.Location = new System.Drawing.Point(12, 9);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(32, 318);
            this.ColorPanel.TabIndex = 8;
            // 
            // ColorPanel1
            // 
            this.ColorPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorPanel1.Location = new System.Drawing.Point(432, 9);
            this.ColorPanel1.Name = "ColorPanel1";
            this.ColorPanel1.Size = new System.Drawing.Size(32, 318);
            this.ColorPanel1.TabIndex = 9;
            // 
            // TimerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 339);
            this.Controls.Add(this.ColorPanel1);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimerLabel);
            this.Name = "TimerGUI";
            this.Text = "TimerGUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Panel ColorPanel1;
    }
}