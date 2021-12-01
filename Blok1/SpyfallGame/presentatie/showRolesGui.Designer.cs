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
            this.button1 = new System.Windows.Forms.Button();
            this.welkeSpelerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rolLabel = new System.Windows.Forms.Label();
            this.locatieLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "klik hier als je de info wilt zien";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // welkeSpelerLabel
            // 
            this.welkeSpelerLabel.AutoSize = true;
            this.welkeSpelerLabel.Location = new System.Drawing.Point(205, 73);
            this.welkeSpelerLabel.Name = "welkeSpelerLabel";
            this.welkeSpelerLabel.Size = new System.Drawing.Size(0, 16);
            this.welkeSpelerLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jouw rol";
            // 
            // rolLabel
            // 
            this.rolLabel.AutoSize = true;
            this.rolLabel.Location = new System.Drawing.Point(205, 149);
            this.rolLabel.Name = "rolLabel";
            this.rolLabel.Size = new System.Drawing.Size(0, 16);
            this.rolLabel.TabIndex = 3;
            this.rolLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // locatieLabel
            // 
            this.locatieLabel.AutoSize = true;
            this.locatieLabel.Location = new System.Drawing.Point(205, 207);
            this.locatieLabel.Name = "locatieLabel";
            this.locatieLabel.Size = new System.Drawing.Size(0, 16);
            this.locatieLabel.TabIndex = 5;
            this.locatieLabel.Click += new System.EventHandler(this.locatieLabel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "De locatie";
            // 
            // showRolesGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.locatieLabel);
            this.Controls.Add(this.rolLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welkeSpelerLabel);
            this.Controls.Add(this.button1);
            this.Name = "showRolesGui";
            this.Text = "showRolesGui";
            this.Load += new System.EventHandler(this.showRolesGui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label welkeSpelerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rolLabel;
        private System.Windows.Forms.Label locatieLabel;
        private System.Windows.Forms.Label label6;
    }
}