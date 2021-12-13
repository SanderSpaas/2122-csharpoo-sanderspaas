namespace SpyfallProject.presentatielaag
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
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.LaadBestandButton = new System.Windows.Forms.Button();
            this.VoegToeButton = new System.Windows.Forms.Button();
            this.GeselecteerdBestandLabel = new System.Windows.Forms.Label();
            this.GeselecteerdeBestandTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LocatieLabel
            // 
            this.LocatieLabel.AutoSize = true;
            this.LocatieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocatieLabel.Location = new System.Drawing.Point(67, 64);
            this.LocatieLabel.Name = "LocatieLabel";
            this.LocatieLabel.Size = new System.Drawing.Size(68, 22);
            this.LocatieLabel.TabIndex = 0;
            this.LocatieLabel.Text = "Locatie";
            // 
            // RolLabel
            // 
            this.RolLabel.AutoSize = true;
            this.RolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RolLabel.Location = new System.Drawing.Point(195, 64);
            this.RolLabel.Name = "RolLabel";
            this.RolLabel.Size = new System.Drawing.Size(37, 22);
            this.RolLabel.TabIndex = 1;
            this.RolLabel.Text = "Rol";
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(314, 88);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 39);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LocatieTextbox
            // 
            this.LocatieTextbox.Enabled = false;
            this.LocatieTextbox.Location = new System.Drawing.Point(71, 92);
            this.LocatieTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LocatieTextbox.Name = "LocatieTextbox";
            this.LocatieTextbox.Size = new System.Drawing.Size(100, 27);
            this.LocatieTextbox.TabIndex = 3;
            // 
            // RolTextBox
            // 
            this.RolTextBox.Enabled = false;
            this.RolTextBox.Location = new System.Drawing.Point(199, 92);
            this.RolTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RolTextBox.Name = "RolTextBox";
            this.RolTextBox.Size = new System.Drawing.Size(100, 27);
            this.RolTextBox.TabIndex = 4;
            // 
            // GenereerBestand
            // 
            this.GenereerBestand.Location = new System.Drawing.Point(350, 315);
            this.GenereerBestand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenereerBestand.Name = "GenereerBestand";
            this.GenereerBestand.Size = new System.Drawing.Size(284, 60);
            this.GenereerBestand.TabIndex = 5;
            this.GenereerBestand.Text = "Maak een bestand aan";
            this.GenereerBestand.UseVisualStyleBackColor = true;
            this.GenereerBestand.Click += new System.EventHandler(this.GenereerBestand_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(71, 134);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTextBox.Size = new System.Drawing.Size(563, 173);
            this.OutputTextBox.TabIndex = 6;
            // 
            // LaadBestandButton
            // 
            this.LaadBestandButton.Location = new System.Drawing.Point(71, 315);
            this.LaadBestandButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LaadBestandButton.Name = "LaadBestandButton";
            this.LaadBestandButton.Size = new System.Drawing.Size(273, 60);
            this.LaadBestandButton.TabIndex = 7;
            this.LaadBestandButton.Text = "Laad een bestand om te bewerken";
            this.LaadBestandButton.UseVisualStyleBackColor = true;
            this.LaadBestandButton.Click += new System.EventHandler(this.LaadBestandButton_Click);
            // 
            // VoegToeButton
            // 
            this.VoegToeButton.Enabled = false;
            this.VoegToeButton.Location = new System.Drawing.Point(71, 382);
            this.VoegToeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VoegToeButton.Name = "VoegToeButton";
            this.VoegToeButton.Size = new System.Drawing.Size(273, 60);
            this.VoegToeButton.TabIndex = 8;
            this.VoegToeButton.Text = "Voeg toe aan geselecteerd bestand";
            this.VoegToeButton.UseVisualStyleBackColor = true;
            this.VoegToeButton.Click += new System.EventHandler(this.VoegToeButton_Click);
            // 
            // GeselecteerdBestandLabel
            // 
            this.GeselecteerdBestandLabel.AutoSize = true;
            this.GeselecteerdBestandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GeselecteerdBestandLabel.Location = new System.Drawing.Point(350, 382);
            this.GeselecteerdBestandLabel.Name = "GeselecteerdBestandLabel";
            this.GeselecteerdBestandLabel.Size = new System.Drawing.Size(201, 22);
            this.GeselecteerdBestandLabel.TabIndex = 9;
            this.GeselecteerdBestandLabel.Text = "Geselecteerde bestand:";
            // 
            // GeselecteerdeBestandTextBox
            // 
            this.GeselecteerdeBestandTextBox.Location = new System.Drawing.Point(350, 415);
            this.GeselecteerdeBestandTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GeselecteerdeBestandTextBox.Name = "GeselecteerdeBestandTextBox";
            this.GeselecteerdeBestandTextBox.ReadOnly = true;
            this.GeselecteerdeBestandTextBox.Size = new System.Drawing.Size(284, 27);
            this.GeselecteerdeBestandTextBox.TabIndex = 10;
            // 
            // SpelMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 515);
            this.Controls.Add(this.GeselecteerdeBestandTextBox);
            this.Controls.Add(this.GeselecteerdBestandLabel);
            this.Controls.Add(this.VoegToeButton);
            this.Controls.Add(this.LaadBestandButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.GenereerBestand);
            this.Controls.Add(this.RolTextBox);
            this.Controls.Add(this.LocatieTextbox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RolLabel);
            this.Controls.Add(this.LocatieLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SpelMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button LaadBestandButton;
        private System.Windows.Forms.Button VoegToeButton;
        private System.Windows.Forms.Label GeselecteerdBestandLabel;
        private System.Windows.Forms.TextBox GeselecteerdeBestandTextBox;
    }
}