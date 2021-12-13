namespace SpyfallProject.presentatielaag
{
    partial class ScoreBoard
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
            this.Scores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Scores
            // 
            this.Scores.Location = new System.Drawing.Point(64, 28);
            this.Scores.Multiline = true;
            this.Scores.Name = "Scores";
            this.Scores.ReadOnly = true;
            this.Scores.Size = new System.Drawing.Size(617, 335);
            this.Scores.TabIndex = 0;
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Scores);
            this.Name = "ScoreBoard";
            this.Text = "ScoreBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Scores;
    }
}