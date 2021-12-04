namespace SpyfallGame.presentatie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // nextPlayerButton
            // 
            this.nextPlayerButton.Location = new System.Drawing.Point(104, 265);
            this.nextPlayerButton.Name = "nextPlayerButton";
            this.nextPlayerButton.Size = new System.Drawing.Size(238, 53);
            this.nextPlayerButton.TabIndex = 0;
            this.nextPlayerButton.Text = "Klik hier als je de info wilt zien";
            this.nextPlayerButton.UseVisualStyleBackColor = true;
            this.nextPlayerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // welkeSpelerLabel
            // 
            this.welkeSpelerLabel.AutoSize = true;
            this.welkeSpelerLabel.Location = new System.Drawing.Point(205, 73);
            this.welkeSpelerLabel.Name = "welkeSpelerLabel";
            this.welkeSpelerLabel.Size = new System.Drawing.Size(0, 16);
            this.welkeSpelerLabel.TabIndex = 1;
            // 
            // rolLabel1
            // 
            this.rolLabel1.AutoSize = true;
            this.rolLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolLabel1.Location = new System.Drawing.Point(151, 89);
            this.rolLabel1.Name = "rolLabel1";
            this.rolLabel1.Size = new System.Drawing.Size(141, 29);
            this.rolLabel1.TabIndex = 2;
            this.rolLabel1.Text = "placeholder";
            // 
            // rolLabel
            // 
            this.rolLabel.AutoSize = true;
            this.rolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolLabel.Location = new System.Drawing.Point(151, 118);
            this.rolLabel.Name = "rolLabel";
            this.rolLabel.Size = new System.Drawing.Size(141, 29);
            this.rolLabel.TabIndex = 3;
            this.rolLabel.Text = "placeholder";
            this.rolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rolLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // locatieLabel
            // 
            this.locatieLabel.AutoSize = true;
            this.locatieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locatieLabel.Location = new System.Drawing.Point(151, 210);
            this.locatieLabel.Name = "locatieLabel";
            this.locatieLabel.Size = new System.Drawing.Size(141, 29);
            this.locatieLabel.TabIndex = 5;
            this.locatieLabel.Text = "placeholder";
            this.locatieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.locatieLabel.Click += new System.EventHandler(this.locatieLabel_Click);
            // 
            // locatieLabel1
            // 
            this.locatieLabel1.AutoSize = true;
            this.locatieLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locatieLabel1.Location = new System.Drawing.Point(151, 181);
            this.locatieLabel1.Name = "locatieLabel1";
            this.locatieLabel1.Size = new System.Drawing.Size(141, 29);
            this.locatieLabel1.TabIndex = 6;
            this.locatieLabel1.Text = "placeholder";
            // 
            // ColorPanel
            // 
            this.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorPanel.Location = new System.Drawing.Point(12, 31);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(32, 346);
            this.ColorPanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(402, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 346);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // showRolesGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.locatieLabel1);
            this.Controls.Add(this.locatieLabel);
            this.Controls.Add(this.rolLabel);
            this.Controls.Add(this.rolLabel1);
            this.Controls.Add(this.welkeSpelerLabel);
            this.Controls.Add(this.nextPlayerButton);
            this.Controls.Add(this.ColorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "showRolesGui";
            this.Text = "showRolesGui";
            this.Load += new System.EventHandler(this.showRolesGui_Load);
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
        private System.Windows.Forms.Panel panel1;
    }
}