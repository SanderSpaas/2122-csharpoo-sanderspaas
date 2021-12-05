namespace SpyfallGame.presentatie
{
    partial class SpelMaker
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
            this.LocatieLabel = new System.Windows.Forms.Label();
            this.RolLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.LocatieTextbox = new System.Windows.Forms.TextBox();
            this.RolTextBox = new System.Windows.Forms.TextBox();
            this.GenereerBestand = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LaadBestandButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LocatieLabel
            // 
            this.LocatieLabel.AutoSize = true;
            this.LocatieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocatieLabel.Location = new System.Drawing.Point(66, 48);
            this.LocatieLabel.Name = "LocatieLabel";
            this.LocatieLabel.Size = new System.Drawing.Size(82, 26);
            this.LocatieLabel.TabIndex = 0;
            this.LocatieLabel.Text = "Locatie";
            this.LocatieLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RolLabel
            // 
            this.RolLabel.AutoSize = true;
            this.RolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolLabel.Location = new System.Drawing.Point(194, 49);
            this.RolLabel.Name = "RolLabel";
            this.RolLabel.Size = new System.Drawing.Size(45, 26);
            this.RolLabel.TabIndex = 1;
            this.RolLabel.Text = "Rol";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(329, 78);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // LocatieTextbox
            // 
            this.LocatieTextbox.Location = new System.Drawing.Point(71, 77);
            this.LocatieTextbox.Name = "LocatieTextbox";
            this.LocatieTextbox.Size = new System.Drawing.Size(100, 22);
            this.LocatieTextbox.TabIndex = 3;
            // 
            // RolTextBox
            // 
            this.RolTextBox.Location = new System.Drawing.Point(199, 78);
            this.RolTextBox.Name = "RolTextBox";
            this.RolTextBox.Size = new System.Drawing.Size(100, 22);
            this.RolTextBox.TabIndex = 4;
            // 
            // GenereerBestand
            // 
            this.GenereerBestand.Location = new System.Drawing.Point(71, 281);
            this.GenereerBestand.Name = "GenereerBestand";
            this.GenereerBestand.Size = new System.Drawing.Size(333, 23);
            this.GenereerBestand.TabIndex = 5;
            this.GenereerBestand.Text = "Genereer bestand";
            this.GenereerBestand.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 139);
            this.textBox1.TabIndex = 6;
            // 
            // LaadBestandButton
            // 
            this.LaadBestandButton.Location = new System.Drawing.Point(71, 252);
            this.LaadBestandButton.Name = "LaadBestandButton";
            this.LaadBestandButton.Size = new System.Drawing.Size(333, 23);
            this.LaadBestandButton.TabIndex = 7;
            this.LaadBestandButton.Text = "Laad een bestand om te bewerken";
            this.LaadBestandButton.UseVisualStyleBackColor = true;
            // 
            // SpelMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 334);
            this.Controls.Add(this.LaadBestandButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GenereerBestand);
            this.Controls.Add(this.RolTextBox);
            this.Controls.Add(this.LocatieTextbox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RolLabel);
            this.Controls.Add(this.LocatieLabel);
            this.Name = "SpelMaker";
            this.Text = "SpelMaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LocatieLabel;
        private System.Windows.Forms.Label RolLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox LocatieTextbox;
        private System.Windows.Forms.TextBox RolTextBox;
        private System.Windows.Forms.Button GenereerBestand;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LaadBestandButton;
    }
}