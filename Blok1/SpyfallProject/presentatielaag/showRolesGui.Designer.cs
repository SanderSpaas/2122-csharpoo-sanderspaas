namespace SpyfallProject.presentatielaag
{
    partial class showRolesGui
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
            this.nextPlayerButton = new System.Windows.Forms.Button();
            this.welkeSpelerLabel = new System.Windows.Forms.Label();
            this.rolLabel1 = new System.Windows.Forms.Label();
            this.rolLabel = new System.Windows.Forms.Label();
            this.locatieLabel = new System.Windows.Forms.Label();
            this.locatieLabel1 = new System.Windows.Forms.Label();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.ColorPanel1 = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextPlayerButton
            // 
            this.nextPlayerButton.Location = new System.Drawing.Point(104, 331);
            this.nextPlayerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nextPlayerButton.Name = "nextPlayerButton";
            this.nextPlayerButton.Size = new System.Drawing.Size(238, 66);
            this.nextPlayerButton.TabIndex = 0;
            this.nextPlayerButton.Text = "Klik hier als je de info wilt zien";
            this.nextPlayerButton.UseVisualStyleBackColor = true;
            this.nextPlayerButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // welkeSpelerLabel
            // 
            this.welkeSpelerLabel.AutoSize = true;
            this.welkeSpelerLabel.Location = new System.Drawing.Point(205, 91);
            this.welkeSpelerLabel.Name = "welkeSpelerLabel";
            this.welkeSpelerLabel.Size = new System.Drawing.Size(0, 20);
            this.welkeSpelerLabel.TabIndex = 1;
            // 
            // rolLabel1
            // 
            this.rolLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rolLabel1.Location = new System.Drawing.Point(50, 111);
            this.rolLabel1.Name = "rolLabel1";
            this.rolLabel1.Size = new System.Drawing.Size(346, 36);
            this.rolLabel1.TabIndex = 2;
            this.rolLabel1.Text = "placeholder";
            this.rolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rolLabel
            // 
            this.rolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rolLabel.Location = new System.Drawing.Point(50, 148);
            this.rolLabel.Name = "rolLabel";
            this.rolLabel.Size = new System.Drawing.Size(346, 36);
            this.rolLabel.TabIndex = 3;
            this.rolLabel.Text = "placeholder";
            this.rolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locatieLabel
            // 
            this.locatieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locatieLabel.Location = new System.Drawing.Point(50, 262);
            this.locatieLabel.Name = "locatieLabel";
            this.locatieLabel.Size = new System.Drawing.Size(346, 36);
            this.locatieLabel.TabIndex = 5;
            this.locatieLabel.Text = "placeholder";
            this.locatieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locatieLabel1
            // 
            this.locatieLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locatieLabel1.Location = new System.Drawing.Point(50, 226);
            this.locatieLabel1.Name = "locatieLabel1";
            this.locatieLabel1.Size = new System.Drawing.Size(346, 36);
            this.locatieLabel1.TabIndex = 6;
            this.locatieLabel1.Text = "placeholder";
            this.locatieLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorPanel
            // 
            this.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorPanel.Location = new System.Drawing.Point(12, 39);
            this.ColorPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(32, 432);
            this.ColorPanel.TabIndex = 7;
            // 
            // ColorPanel1
            // 
            this.ColorPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorPanel1.Location = new System.Drawing.Point(402, 39);
            this.ColorPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorPanel1.Name = "ColorPanel1";
            this.ColorPanel1.Size = new System.Drawing.Size(32, 432);
            this.ColorPanel1.TabIndex = 9;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(104, 331);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(238, 66);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start het spel";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Visible = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // showRolesGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 501);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ColorPanel1);
            this.Controls.Add(this.locatieLabel1);
            this.Controls.Add(this.locatieLabel);
            this.Controls.Add(this.rolLabel);
            this.Controls.Add(this.rolLabel1);
            this.Controls.Add(this.welkeSpelerLabel);
            this.Controls.Add(this.nextPlayerButton);
            this.Controls.Add(this.ColorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "showRolesGui";
            this.Text = "showRolesGui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextPlayerButton;
        private System.Windows.Forms.Label welkeSpelerLabel;
        private System.Windows.Forms.Label rolLabel1;
        private System.Windows.Forms.Label rolLabel;
        private System.Windows.Forms.Label locatieLabel;
        private System.Windows.Forms.Label locatieLabel1;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Panel ColorPanel1;
        private Button StartButton;
    }
}