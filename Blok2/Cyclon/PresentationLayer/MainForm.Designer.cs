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
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.HeightData = new System.Windows.Forms.NumericUpDown();
            this.WidthData = new System.Windows.Forms.NumericUpDown();
            this.ScaleData = new System.Windows.Forms.NumericUpDown();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.TileSizeData = new System.Windows.Forms.NumericUpDown();
            this.DeapSeaData = new System.Windows.Forms.TrackBar();
            this.SeaData = new System.Windows.Forms.TrackBar();
            this.BeachData = new System.Windows.Forms.TrackBar();
            this.GrassData = new System.Windows.Forms.TrackBar();
            this.HillData = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.HeightData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileSizeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeapSeaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeachData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrassData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HillData)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DetectUrls = false;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Location = new System.Drawing.Point(165, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1759, 1055);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "";
            this.textBox1.WordWrap = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(12, 175);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(150, 29);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // HeightData
            // 
            this.HeightData.Location = new System.Drawing.Point(12, 12);
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
            this.WidthData.Location = new System.Drawing.Point(12, 54);
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
            this.ScaleData.Location = new System.Drawing.Point(12, 100);
            this.ScaleData.Name = "ScaleData";
            this.ScaleData.Size = new System.Drawing.Size(150, 27);
            this.ScaleData.TabIndex = 7;
            this.ScaleData.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Location = new System.Drawing.Point(168, 0);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(1756, 1055);
            this.DrawingPanel.TabIndex = 8;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            // 
            // TileSizeData
            // 
            this.TileSizeData.Location = new System.Drawing.Point(12, 142);
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
            this.DeapSeaData.Location = new System.Drawing.Point(12, 227);
            this.DeapSeaData.Maximum = 500;
            this.DeapSeaData.Name = "DeapSeaData";
            this.DeapSeaData.Size = new System.Drawing.Size(130, 56);
            this.DeapSeaData.TabIndex = 10;
            // 
            // SeaData
            // 
            this.SeaData.Location = new System.Drawing.Point(12, 289);
            this.SeaData.Maximum = 500;
            this.SeaData.Name = "SeaData";
            this.SeaData.Size = new System.Drawing.Size(130, 56);
            this.SeaData.TabIndex = 11;
            // 
            // BeachData
            // 
            this.BeachData.Location = new System.Drawing.Point(12, 351);
            this.BeachData.Maximum = 500;
            this.BeachData.Name = "BeachData";
            this.BeachData.Size = new System.Drawing.Size(130, 56);
            this.BeachData.TabIndex = 12;
            // 
            // GrassData
            // 
            this.GrassData.Location = new System.Drawing.Point(12, 413);
            this.GrassData.Maximum = 500;
            this.GrassData.Name = "GrassData";
            this.GrassData.Size = new System.Drawing.Size(130, 56);
            this.GrassData.TabIndex = 13;
            // 
            // HillData
            // 
            this.HillData.Location = new System.Drawing.Point(12, 475);
            this.HillData.Maximum = 500;
            this.HillData.Name = "HillData";
            this.HillData.Size = new System.Drawing.Size(130, 56);
            this.HillData.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.HillData);
            this.Controls.Add(this.GrassData);
            this.Controls.Add(this.BeachData);
            this.Controls.Add(this.SeaData);
            this.Controls.Add(this.DeapSeaData);
            this.Controls.Add(this.TileSizeData);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.ScaleData);
            this.Controls.Add(this.WidthData);
            this.Controls.Add(this.HeightData);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.textBox1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox textBox1;
        private Button GenerateButton;
        private NumericUpDown HeightData;
        private NumericUpDown WidthData;
        private NumericUpDown ScaleData;
        private Panel DrawingPanel;
        private NumericUpDown TileSizeData;
        private TrackBar DeapSeaData;
        private TrackBar SeaData;
        private TrackBar BeachData;
        private TrackBar GrassData;
        private TrackBar HillData;
    }
}