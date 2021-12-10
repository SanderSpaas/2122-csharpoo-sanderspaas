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
            this.label2 = new System.Windows.Forms.Label();
            this.aantalTijd = new System.Windows.Forms.NumericUpDown();
            this.SpyfallPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aantalSpelers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalSpionnen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalTijd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpyfallPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(27, 203);
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
            this.textBox1.Location = new System.Drawing.Point(30, 415);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(323, 140);
            this.textBox1.TabIndex = 1;
            // 
            // aantalSpelers
            // 
            this.aantalSpelers.Location = new System.Drawing.Point(27, 37);
            this.aantalSpelers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aantalSpelers.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.aantalSpelers.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.aantalSpelers.Name = "aantalSpelers";
            this.aantalSpelers.Size = new System.Drawing.Size(120, 27);
            this.aantalSpelers.TabIndex = 2;
            this.aantalSpelers.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // labelSpelers
            // 
            this.labelSpelers.AutoSize = true;
            this.labelSpelers.Location = new System.Drawing.Point(157, 39);
            this.labelSpelers.Name = "labelSpelers";
            this.labelSpelers.Size = new System.Drawing.Size(182, 20);
            this.labelSpelers.TabIndex = 3;
            this.labelSpelers.Text = "Geef het aantal spelers op";
            // 
            // aantalSpionnen
            // 
            this.aantalSpionnen.Location = new System.Drawing.Point(27, 94);
            this.aantalSpionnen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aantalSpionnen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aantalSpionnen.Name = "aantalSpionnen";
            this.aantalSpionnen.Size = new System.Drawing.Size(120, 27);
            this.aantalSpionnen.TabIndex = 4;
            this.aantalSpionnen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Geef het aantal spionnen op";
            // 
            // dataFileLabel
            // 
            this.dataFileLabel.AutoSize = true;
            this.dataFileLabel.Location = new System.Drawing.Point(27, 253);
            this.dataFileLabel.Name = "dataFileLabel";
            this.dataFileLabel.Size = new System.Drawing.Size(308, 20);
            this.dataFileLabel.TabIndex = 6;
            this.dataFileLabel.Text = "Selecteer een databestand om mee te spelen";
            // 
            // dataFileButton
            // 
            this.dataFileButton.Location = new System.Drawing.Point(27, 277);
            this.dataFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataFileButton.Name = "dataFileButton";
            this.dataFileButton.Size = new System.Drawing.Size(326, 36);
            this.dataFileButton.TabIndex = 7;
            this.dataFileButton.Text = "Select File";
            this.dataFileButton.UseVisualStyleBackColor = true;
            this.dataFileButton.Click += new System.EventHandler(this.DataFileButton_Click);
            // 
            // SpelRegelsButton
            // 
            this.SpelRegelsButton.Location = new System.Drawing.Point(156, 203);
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
            this.SpelBestandButton.Location = new System.Drawing.Point(27, 356);
            this.SpelBestandButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpelBestandButton.Name = "SpelBestandButton";
            this.SpelBestandButton.Size = new System.Drawing.Size(326, 36);
            this.SpelBestandButton.TabIndex = 9;
            this.SpelBestandButton.Text = "Open de editor";
            this.SpelBestandButton.UseVisualStyleBackColor = true;
            this.SpelBestandButton.Click += new System.EventHandler(this.SpelBestandButton_Click);
            // 
            // MaakJeEigenSpelbestandLabel
            // 
            this.MaakJeEigenSpelbestandLabel.AutoSize = true;
            this.MaakJeEigenSpelbestandLabel.Location = new System.Drawing.Point(27, 332);
            this.MaakJeEigenSpelbestandLabel.Name = "MaakJeEigenSpelbestandLabel";
            this.MaakJeEigenSpelbestandLabel.Size = new System.Drawing.Size(186, 20);
            this.MaakJeEigenSpelbestandLabel.TabIndex = 10;
            this.MaakJeEigenSpelbestandLabel.Text = "Maak je eigen spelbestand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Duur van het spel";
            // 
            // aantalTijd
            // 
            this.aantalTijd.Location = new System.Drawing.Point(27, 151);
            this.aantalTijd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aantalTijd.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.aantalTijd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aantalTijd.Name = "aantalTijd";
            this.aantalTijd.Size = new System.Drawing.Size(120, 27);
            this.aantalTijd.TabIndex = 11;
            this.aantalTijd.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // SpyfallPicture
            // 
            this.SpyfallPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SpyfallPicture.Image = global::SpyfallProject.Properties.Resources.SpyFall;
            this.SpyfallPicture.Location = new System.Drawing.Point(370, 29);
            this.SpyfallPicture.Name = "SpyfallPicture";
            this.SpyfallPicture.Size = new System.Drawing.Size(431, 526);
            this.SpyfallPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpyfallPicture.TabIndex = 13;
            this.SpyfallPicture.TabStop = false;
            // 
            // startGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 590);
            this.Controls.Add(this.SpyfallPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aantalTijd);
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
            this.MaximizeBox = false;
            this.Name = "startGui";
            this.Text = "Spyfall";
            ((System.ComponentModel.ISupportInitialize)(this.aantalSpelers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalSpionnen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalTijd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpyfallPicture)).EndInit();
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
        private Label label2;
        private NumericUpDown aantalTijd;
        private PictureBox SpyfallPicture;
    }
}
