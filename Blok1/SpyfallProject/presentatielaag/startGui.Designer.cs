namespace SpyfallProject.presentatielaag
{
    partial class startGui
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
            this.StartButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aantalSpelers = new System.Windows.Forms.NumericUpDown();
            this.labelSpelers = new System.Windows.Forms.Label();
            this.aantalSpionnen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataFileLabel = new System.Windows.Forms.Label();
            this.dataFileButton = new System.Windows.Forms.Button();
            this.SpelRegelsButton = new System.Windows.Forms.Button();
            this.SpelBestandButton = new System.Windows.Forms.Button();
            this.MaakJeEigenSpelbestandLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aantalSpelers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalSpionnen)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(27, 194);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(120, 35);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Crimson;
            this.textBox1.Location = new System.Drawing.Point(27, 254);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(326, 140);
            this.textBox1.TabIndex = 1;
            // 
            // aantalSpelers
            // 
            this.aantalSpelers.Location = new System.Drawing.Point(27, 74);
            this.aantalSpelers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aantalSpelers.Name = "aantalSpelers";
            this.aantalSpelers.Size = new System.Drawing.Size(120, 27);
            this.aantalSpelers.TabIndex = 2;
            // 
            // labelSpelers
            // 
            this.labelSpelers.AutoSize = true;
            this.labelSpelers.Location = new System.Drawing.Point(153, 76);
            this.labelSpelers.Name = "labelSpelers";
            this.labelSpelers.Size = new System.Drawing.Size(225, 20);
            this.labelSpelers.TabIndex = 3;
            this.labelSpelers.Text = "Geef het totaal aantal spelers op";
            // 
            // aantalSpionnen
            // 
            this.aantalSpionnen.Location = new System.Drawing.Point(27, 141);
            this.aantalSpionnen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aantalSpionnen.Name = "aantalSpionnen";
            this.aantalSpionnen.Size = new System.Drawing.Size(120, 27);
            this.aantalSpionnen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Geef het aantal spionnen op";
            // 
            // dataFileLabel
            // 
            this.dataFileLabel.AutoSize = true;
            this.dataFileLabel.Location = new System.Drawing.Point(27, 415);
            this.dataFileLabel.Name = "dataFileLabel";
            this.dataFileLabel.Size = new System.Drawing.Size(337, 20);
            this.dataFileLabel.TabIndex = 6;
            this.dataFileLabel.Text = "Selecteer je eigen databestand om mee te spelen";
            // 
            // dataFileButton
            // 
            this.dataFileButton.Location = new System.Drawing.Point(27, 440);
            this.dataFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataFileButton.Name = "dataFileButton";
            this.dataFileButton.Size = new System.Drawing.Size(305, 36);
            this.dataFileButton.TabIndex = 7;
            this.dataFileButton.Text = "Select File";
            this.dataFileButton.UseVisualStyleBackColor = true;
            this.dataFileButton.Click += new System.EventHandler(this.dataFileButton_Click);
            // 
            // SpelRegelsButton
            // 
            this.SpelRegelsButton.Location = new System.Drawing.Point(156, 194);
            this.SpelRegelsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpelRegelsButton.Name = "SpelRegelsButton";
            this.SpelRegelsButton.Size = new System.Drawing.Size(197, 35);
            this.SpelRegelsButton.TabIndex = 8;
            this.SpelRegelsButton.Text = "Spelregels";
            this.SpelRegelsButton.UseVisualStyleBackColor = true;
            this.SpelRegelsButton.Click += new System.EventHandler(this.SpelRegelsButton_Click);
            // 
            // SpelBestandButton
            // 
            this.SpelBestandButton.Location = new System.Drawing.Point(30, 519);
            this.SpelBestandButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpelBestandButton.Name = "SpelBestandButton";
            this.SpelBestandButton.Size = new System.Drawing.Size(305, 36);
            this.SpelBestandButton.TabIndex = 9;
            this.SpelBestandButton.Text = "Open de editor";
            this.SpelBestandButton.UseVisualStyleBackColor = true;
            this.SpelBestandButton.Click += new System.EventHandler(this.SpelBestandButton_Click);
            // 
            // MaakJeEigenSpelbestandLabel
            // 
            this.MaakJeEigenSpelbestandLabel.AutoSize = true;
            this.MaakJeEigenSpelbestandLabel.Location = new System.Drawing.Point(27, 495);
            this.MaakJeEigenSpelbestandLabel.Name = "MaakJeEigenSpelbestandLabel";
            this.MaakJeEigenSpelbestandLabel.Size = new System.Drawing.Size(186, 20);
            this.MaakJeEigenSpelbestandLabel.TabIndex = 10;
            this.MaakJeEigenSpelbestandLabel.Text = "Maak je eigen spelbestand";
            // 
            // startGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 590);
            this.Controls.Add(this.MaakJeEigenSpelbestandLabel);
            this.Controls.Add(this.SpelBestandButton);
            this.Controls.Add(this.SpelRegelsButton);
            this.Controls.Add(this.dataFileButton);
            this.Controls.Add(this.dataFileLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aantalSpionnen);
            this.Controls.Add(this.labelSpelers);
            this.Controls.Add(this.aantalSpelers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "startGui";
            this.Text = "Spyfall";
            ((System.ComponentModel.ISupportInitialize)(this.aantalSpelers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalSpionnen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown aantalSpelers;
        private System.Windows.Forms.Label labelSpelers;
        private System.Windows.Forms.NumericUpDown aantalSpionnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dataFileLabel;
        private System.Windows.Forms.Button dataFileButton;
        private System.Windows.Forms.Button SpelRegelsButton;
        private System.Windows.Forms.Button SpelBestandButton;
        private System.Windows.Forms.Label MaakJeEigenSpelbestandLabel;
    }
}
