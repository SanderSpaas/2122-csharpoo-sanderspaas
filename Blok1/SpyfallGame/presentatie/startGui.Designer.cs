namespace SpyfallGame
{
    partial class Spyfall
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aantalSpelers = new System.Windows.Forms.NumericUpDown();
            this.labelSpelers = new System.Windows.Forms.Label();
            this.aantalSpionnen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataFileLabel = new System.Windows.Forms.Label();
            this.dataFileButton = new System.Windows.Forms.Button();
            this.SpelRegelsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aantalSpelers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalSpionnen)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Crimson;
            this.textBox1.Location = new System.Drawing.Point(27, 203);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(326, 113);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // aantalSpelers
            // 
            this.aantalSpelers.Location = new System.Drawing.Point(27, 59);
            this.aantalSpelers.Name = "aantalSpelers";
            this.aantalSpelers.Size = new System.Drawing.Size(120, 22);
            this.aantalSpelers.TabIndex = 2;
            this.aantalSpelers.ValueChanged += new System.EventHandler(this.aantalSpelers_ValueChanged);
            // 
            // labelSpelers
            // 
            this.labelSpelers.AutoSize = true;
            this.labelSpelers.Location = new System.Drawing.Point(153, 61);
            this.labelSpelers.Name = "labelSpelers";
            this.labelSpelers.Size = new System.Drawing.Size(200, 16);
            this.labelSpelers.TabIndex = 3;
            this.labelSpelers.Text = "Geef het totaal aantal spelers op";
            this.labelSpelers.Click += new System.EventHandler(this.label1_Click);
            // 
            // aantalSpionnen
            // 
            this.aantalSpionnen.Location = new System.Drawing.Point(27, 113);
            this.aantalSpionnen.Name = "aantalSpionnen";
            this.aantalSpionnen.Size = new System.Drawing.Size(120, 22);
            this.aantalSpionnen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Geef het aantal spionnen op";
            // 
            // dataFileLabel
            // 
            this.dataFileLabel.AutoSize = true;
            this.dataFileLabel.Location = new System.Drawing.Point(27, 332);
            this.dataFileLabel.Name = "dataFileLabel";
            this.dataFileLabel.Size = new System.Drawing.Size(305, 16);
            this.dataFileLabel.TabIndex = 6;
            this.dataFileLabel.Text = "Selecteer je eigen databestand om mee te spelen";
            this.dataFileLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataFileButton
            // 
            this.dataFileButton.Location = new System.Drawing.Point(27, 352);
            this.dataFileButton.Name = "dataFileButton";
            this.dataFileButton.Size = new System.Drawing.Size(305, 29);
            this.dataFileButton.TabIndex = 7;
            this.dataFileButton.Text = "Select File";
            this.dataFileButton.UseVisualStyleBackColor = true;
            this.dataFileButton.Click += new System.EventHandler(this.dataFileButton_Click);
            // 
            // SpelRegelsButton
            // 
            this.SpelRegelsButton.Location = new System.Drawing.Point(156, 155);
            this.SpelRegelsButton.Name = "SpelRegelsButton";
            this.SpelRegelsButton.Size = new System.Drawing.Size(197, 28);
            this.SpelRegelsButton.TabIndex = 8;
            this.SpelRegelsButton.Text = "Spelregels";
            this.SpelRegelsButton.UseVisualStyleBackColor = true;
            this.SpelRegelsButton.Click += new System.EventHandler(this.SpelRegelsButton_Click);
            // 
            // Spyfall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 402);
            this.Controls.Add(this.SpelRegelsButton);
            this.Controls.Add(this.dataFileButton);
            this.Controls.Add(this.dataFileLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aantalSpionnen);
            this.Controls.Add(this.labelSpelers);
            this.Controls.Add(this.aantalSpelers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Spyfall";
            this.Text = "Spyfall";
            this.Load += new System.EventHandler(this.Spyfall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aantalSpelers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalSpionnen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown aantalSpelers;
        private System.Windows.Forms.Label labelSpelers;
        private System.Windows.Forms.NumericUpDown aantalSpionnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dataFileLabel;
        private System.Windows.Forms.Button dataFileButton;
        private System.Windows.Forms.Button SpelRegelsButton;
    }
}

