namespace PresentationLayer;

partial class SaveSeed
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
            this.SeedInput = new System.Windows.Forms.TextBox();
            this.SeedNameInput = new System.Windows.Forms.TextBox();
            this.SeedDescInput = new System.Windows.Forms.TextBox();
            this.SeedLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SaveSeedButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SeedInput
            // 
            this.SeedInput.BackColor = System.Drawing.Color.Lavender;
            this.SeedInput.Location = new System.Drawing.Point(21, 38);
            this.SeedInput.Name = "SeedInput";
            this.SeedInput.Size = new System.Drawing.Size(134, 27);
            this.SeedInput.TabIndex = 0;
            // 
            // SeedNameInput
            // 
            this.SeedNameInput.BackColor = System.Drawing.Color.Lavender;
            this.SeedNameInput.Location = new System.Drawing.Point(161, 38);
            this.SeedNameInput.Name = "SeedNameInput";
            this.SeedNameInput.Size = new System.Drawing.Size(125, 27);
            this.SeedNameInput.TabIndex = 1;
            // 
            // SeedDescInput
            // 
            this.SeedDescInput.BackColor = System.Drawing.Color.Lavender;
            this.SeedDescInput.Location = new System.Drawing.Point(305, 38);
            this.SeedDescInput.Multiline = true;
            this.SeedDescInput.Name = "SeedDescInput";
            this.SeedDescInput.Size = new System.Drawing.Size(307, 63);
            this.SeedDescInput.TabIndex = 2;
            // 
            // SeedLabel
            // 
            this.SeedLabel.AutoSize = true;
            this.SeedLabel.Location = new System.Drawing.Point(21, 15);
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(42, 20);
            this.SeedLabel.TabIndex = 3;
            this.SeedLabel.Text = "Seed";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(161, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 20);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(305, 15);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(85, 20);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Description";
            // 
            // SaveSeedButton
            // 
            this.SaveSeedButton.BackColor = System.Drawing.Color.Honeydew;
            this.SaveSeedButton.Location = new System.Drawing.Point(21, 72);
            this.SaveSeedButton.Name = "SaveSeedButton";
            this.SaveSeedButton.Size = new System.Drawing.Size(265, 29);
            this.SaveSeedButton.TabIndex = 6;
            this.SaveSeedButton.Text = "Save";
            this.SaveSeedButton.UseVisualStyleBackColor = false;
            this.SaveSeedButton.Click += new System.EventHandler(this.SaveSeedButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(21, 104);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 7;
            // 
            // SaveSeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(630, 132);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SaveSeedButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SeedLabel);
            this.Controls.Add(this.SeedDescInput);
            this.Controls.Add(this.SeedNameInput);
            this.Controls.Add(this.SeedInput);
            this.Name = "SaveSeed";
            this.Text = "SaveSeed";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox SeedInput;
    private TextBox SeedNameInput;
    private TextBox SeedDescInput;
    private Label SeedLabel;
    private Label NameLabel;
    private Label DescriptionLabel;
    private Button SaveSeedButton;
    private Label ErrorLabel;
}
