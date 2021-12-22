namespace PresentationLayer
{
    partial class MainForm
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
            this.MapLegacy = new System.Windows.Forms.RichTextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.HeightData = new System.Windows.Forms.NumericUpDown();
            this.WidthData = new System.Windows.Forms.NumericUpDown();
            this.ScaleData = new System.Windows.Forms.NumericUpDown();
            this.MapModern = new System.Windows.Forms.Panel();
            this.TileSizeData = new System.Windows.Forms.NumericUpDown();
            this.DeapSeaData = new System.Windows.Forms.TrackBar();
            this.SeaData = new System.Windows.Forms.TrackBar();
            this.BeachData = new System.Windows.Forms.TrackBar();
            this.GrassData = new System.Windows.Forms.TrackBar();
            this.HillData = new System.Windows.Forms.TrackBar();
            this.Tekenstijl = new System.Windows.Forms.GroupBox();
            this.ModernRadio = new System.Windows.Forms.RadioButton();
            this.LegacyRadio = new System.Windows.Forms.RadioButton();
            this.MapSettings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ShowNumbersCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.HeightData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileSizeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeapSeaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeachData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrassData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HillData)).BeginInit();
            this.Tekenstijl.SuspendLayout();
            this.MapSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapLegacy
            // 
            this.MapLegacy.DetectUrls = false;
            this.MapLegacy.Location = new System.Drawing.Point(191, 0);
            this.MapLegacy.Margin = new System.Windows.Forms.Padding(0);
            this.MapLegacy.Name = "MapLegacy";
            this.MapLegacy.ReadOnly = true;
            this.MapLegacy.Size = new System.Drawing.Size(1733, 1055);
            this.MapLegacy.TabIndex = 1;
            this.MapLegacy.Text = "";
            this.MapLegacy.Visible = false;
            this.MapLegacy.WordWrap = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(12, 334);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(150, 29);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // HeightData
            // 
            this.HeightData.Location = new System.Drawing.Point(12, 51);
            this.HeightData.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.HeightData.Name = "HeightData";
            this.HeightData.Size = new System.Drawing.Size(150, 27);
            this.HeightData.TabIndex = 5;
            this.HeightData.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // WidthData
            // 
            this.WidthData.Location = new System.Drawing.Point(12, 106);
            this.WidthData.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.WidthData.Name = "WidthData";
            this.WidthData.Size = new System.Drawing.Size(150, 27);
            this.WidthData.TabIndex = 6;
            this.WidthData.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // ScaleData
            // 
            this.ScaleData.Location = new System.Drawing.Point(12, 159);
            this.ScaleData.Name = "ScaleData";
            this.ScaleData.Size = new System.Drawing.Size(150, 27);
            this.ScaleData.TabIndex = 7;
            this.ScaleData.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // MapModern
            // 
            this.MapModern.Location = new System.Drawing.Point(191, 0);
            this.MapModern.Name = "MapModern";
            this.MapModern.Size = new System.Drawing.Size(1730, 1055);
            this.MapModern.TabIndex = 8;
            this.MapModern.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            // 
            // TileSizeData
            // 
            this.TileSizeData.Location = new System.Drawing.Point(12, 212);
            this.TileSizeData.Name = "TileSizeData";
            this.TileSizeData.Size = new System.Drawing.Size(150, 27);
            this.TileSizeData.TabIndex = 9;
            this.TileSizeData.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // DeapSeaData
            // 
            this.DeapSeaData.Location = new System.Drawing.Point(6, 51);
            this.DeapSeaData.Maximum = 500;
            this.DeapSeaData.Name = "DeapSeaData";
            this.DeapSeaData.Size = new System.Drawing.Size(161, 56);
            this.DeapSeaData.TabIndex = 10;
            this.DeapSeaData.TickStyle = System.Windows.Forms.TickStyle.None;
            this.DeapSeaData.Value = 40;
            // 
            // SeaData
            // 
            this.SeaData.Location = new System.Drawing.Point(6, 104);
            this.SeaData.Maximum = 500;
            this.SeaData.Name = "SeaData";
            this.SeaData.Size = new System.Drawing.Size(161, 56);
            this.SeaData.TabIndex = 11;
            this.SeaData.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SeaData.Value = 70;
            // 
            // BeachData
            // 
            this.BeachData.Location = new System.Drawing.Point(6, 153);
            this.BeachData.Maximum = 500;
            this.BeachData.Name = "BeachData";
            this.BeachData.Size = new System.Drawing.Size(161, 56);
            this.BeachData.TabIndex = 12;
            this.BeachData.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BeachData.Value = 120;
            // 
            // GrassData
            // 
            this.GrassData.Location = new System.Drawing.Point(6, 215);
            this.GrassData.Maximum = 500;
            this.GrassData.Name = "GrassData";
            this.GrassData.Size = new System.Drawing.Size(161, 56);
            this.GrassData.TabIndex = 13;
            this.GrassData.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GrassData.Value = 160;
            // 
            // HillData
            // 
            this.HillData.Location = new System.Drawing.Point(12, 277);
            this.HillData.Maximum = 500;
            this.HillData.Name = "HillData";
            this.HillData.Size = new System.Drawing.Size(150, 56);
            this.HillData.TabIndex = 14;
            this.HillData.TickStyle = System.Windows.Forms.TickStyle.None;
            this.HillData.Value = 240;
            // 
            // Tekenstijl
            // 
            this.Tekenstijl.Controls.Add(this.ModernRadio);
            this.Tekenstijl.Controls.Add(this.LegacyRadio);
            this.Tekenstijl.Location = new System.Drawing.Point(12, 12);
            this.Tekenstijl.Name = "Tekenstijl";
            this.Tekenstijl.Size = new System.Drawing.Size(173, 99);
            this.Tekenstijl.TabIndex = 15;
            this.Tekenstijl.TabStop = false;
            this.Tekenstijl.Text = "Tekenstijl";
            // 
            // ModernRadio
            // 
            this.ModernRadio.AutoSize = true;
            this.ModernRadio.Checked = true;
            this.ModernRadio.Location = new System.Drawing.Point(12, 56);
            this.ModernRadio.Name = "ModernRadio";
            this.ModernRadio.Size = new System.Drawing.Size(82, 24);
            this.ModernRadio.TabIndex = 1;
            this.ModernRadio.TabStop = true;
            this.ModernRadio.Text = "Modern";
            this.ModernRadio.UseVisualStyleBackColor = true;
            this.ModernRadio.CheckedChanged += new System.EventHandler(this.ModernRadio_CheckedChanged);
            // 
            // LegacyRadio
            // 
            this.LegacyRadio.AutoSize = true;
            this.LegacyRadio.Location = new System.Drawing.Point(12, 26);
            this.LegacyRadio.Name = "LegacyRadio";
            this.LegacyRadio.Size = new System.Drawing.Size(76, 24);
            this.LegacyRadio.TabIndex = 0;
            this.LegacyRadio.Text = "Legacy";
            this.LegacyRadio.UseVisualStyleBackColor = true;
            this.LegacyRadio.CheckedChanged += new System.EventHandler(this.LegacyRadio_CheckedChanged);
            // 
            // MapSettings
            // 
            this.MapSettings.Controls.Add(this.label4);
            this.MapSettings.Controls.Add(this.label3);
            this.MapSettings.Controls.Add(this.label2);
            this.MapSettings.Controls.Add(this.label1);
            this.MapSettings.Controls.Add(this.HeightData);
            this.MapSettings.Controls.Add(this.WidthData);
            this.MapSettings.Controls.Add(this.ScaleData);
            this.MapSettings.Controls.Add(this.TileSizeData);
            this.MapSettings.Location = new System.Drawing.Point(12, 117);
            this.MapSettings.Name = "MapSettings";
            this.MapSettings.Size = new System.Drawing.Size(173, 253);
            this.MapSettings.TabIndex = 16;
            this.MapSettings.TabStop = false;
            this.MapSettings.Text = "Map instellingen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pixel size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Map scale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Map width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Map length";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.HillData);
            this.groupBox1.Controls.Add(this.GenerateButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.GrassData);
            this.groupBox1.Controls.Add(this.DeapSeaData);
            this.groupBox1.Controls.Add(this.BeachData);
            this.groupBox1.Controls.Add(this.SeaData);
            this.groupBox1.Location = new System.Drawing.Point(12, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 396);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map instellingen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Grassy hill height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grass height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sand height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Water height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Deep water height";
            // 
            // ShowNumbersCheckbox
            // 
            this.ShowNumbersCheckbox.AutoSize = true;
            this.ShowNumbersCheckbox.Location = new System.Drawing.Point(18, 778);
            this.ShowNumbersCheckbox.Name = "ShowNumbersCheckbox";
            this.ShowNumbersCheckbox.Size = new System.Drawing.Size(167, 24);
            this.ShowNumbersCheckbox.TabIndex = 18;
            this.ShowNumbersCheckbox.Text = "Show number values";
            this.ShowNumbersCheckbox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.ShowNumbersCheckbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MapSettings);
            this.Controls.Add(this.Tekenstijl);
            this.Controls.Add(this.MapModern);
            this.Controls.Add(this.MapLegacy);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cyclon Map Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.HeightData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileSizeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeapSeaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeachData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrassData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HillData)).EndInit();
            this.Tekenstijl.ResumeLayout(false);
            this.Tekenstijl.PerformLayout();
            this.MapSettings.ResumeLayout(false);
            this.MapSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox MapLegacy;
        private Button GenerateButton;
        private NumericUpDown HeightData;
        private NumericUpDown WidthData;
        private NumericUpDown ScaleData;
        private Panel MapModern;
        private NumericUpDown TileSizeData;
        private TrackBar DeapSeaData;
        private TrackBar SeaData;
        private TrackBar BeachData;
        private TrackBar GrassData;
        private TrackBar HillData;
        private GroupBox Tekenstijl;
        private RadioButton ModernRadio;
        private RadioButton LegacyRadio;
        private GroupBox MapSettings;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox ShowNumbersCheckbox;
    }
}