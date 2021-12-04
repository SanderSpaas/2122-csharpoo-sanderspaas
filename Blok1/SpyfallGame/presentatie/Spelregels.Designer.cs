namespace SpyfallGame.presentatie
{
    partial class Spelregels
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
            this.SpelregelsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SpelregelsTextBox
            // 
            this.SpelregelsTextBox.ForeColor = System.Drawing.Color.Black;
            this.SpelregelsTextBox.Location = new System.Drawing.Point(44, 36);
            this.SpelregelsTextBox.Multiline = true;
            this.SpelregelsTextBox.Name = "SpelregelsTextBox";
            this.SpelregelsTextBox.ReadOnly = true;
            this.SpelregelsTextBox.Size = new System.Drawing.Size(381, 292);
            this.SpelregelsTextBox.TabIndex = 2;
            this.SpelregelsTextBox.TextChanged += new System.EventHandler(this.SpelregelsTextBox_TextChanged);
            // 
            // Spelregels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 411);
            this.Controls.Add(this.SpelregelsTextBox);
            this.Name = "Spelregels";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SpelregelsTextBox;
    }
}