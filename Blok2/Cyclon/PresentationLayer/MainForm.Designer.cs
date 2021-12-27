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
            this.MapSettings = new System.Windows.Forms.GroupBox();
            this.RandomSeedButton = new System.Windows.Forms.Button();
            this.SeedData = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModernRadio = new System.Windows.Forms.RadioButton();
            this.LegacyRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ShowNumbersCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SpatialOffsetCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorPickerButton = new System.Windows.Forms.Button();
            this.InvertCheckBox = new System.Windows.Forms.CheckBox();
            this.KleurToner = new System.Windows.Forms.Panel();
            this.VariatieSlider = new System.Windows.Forms.TrackBar();
            this.LayersComboBox = new System.Windows.Forms.ComboBox();
            this.VariatieCheckBox = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ResetLagenButton = new System.Windows.Forms.Button();
            this.LetterLaagData = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariatieSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // MapLegacy
            // 
            this.MapLegacy.DetectUrls = false;
            this.MapLegacy.Location = new System.Drawing.Point(213, 0);
            this.MapLegacy.Margin = new System.Windows.Forms.Padding(0);
            this.MapLegacy.Name = "MapLegacy";
            this.MapLegacy.ReadOnly = true;
            this.MapLegacy.Size = new System.Drawing.Size(1474, 1055);
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
            1000000,
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
            1000000,
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
            4,
            0,
            0,
            0});
            // 
            // MapModern
            // 
            this.MapModern.AutoSize = true;
            this.MapModern.Location = new System.Drawing.Point(213, 0);
            this.MapModern.Name = "MapModern";
            this.MapModern.Size = new System.Drawing.Size(1471, 1055);
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
            16,
            0,
            0,
            0});
            // 
            // DeapSeaData
            // 
            this.DeapSeaData.Location = new System.Drawing.Point(6, 51);
            this.DeapSeaData.Maximum = 255;
            this.DeapSeaData.Name = "DeapSeaData";
            this.DeapSeaData.Size = new System.Drawing.Size(161, 56);
            this.DeapSeaData.TabIndex = 10;
            this.DeapSeaData.TickStyle = System.Windows.Forms.TickStyle.None;
            this.DeapSeaData.Value = 40;
            // 
            // SeaData
            // 
            this.SeaData.Location = new System.Drawing.Point(6, 104);
            this.SeaData.Maximum = 255;
            this.SeaData.Name = "SeaData";
            this.SeaData.Size = new System.Drawing.Size(161, 56);
            this.SeaData.TabIndex = 11;
            this.SeaData.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SeaData.Value = 70;
            // 
            // BeachData
            // 
            this.BeachData.Location = new System.Drawing.Point(6, 153);
            this.BeachData.Maximum = 255;
            this.BeachData.Name = "BeachData";
            this.BeachData.Size = new System.Drawing.Size(161, 56);
            this.BeachData.TabIndex = 12;
            this.BeachData.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BeachData.Value = 120;
            // 
            // GrassData
            // 
            this.GrassData.Location = new System.Drawing.Point(6, 215);
            this.GrassData.Maximum = 255;
            this.GrassData.Name = "GrassData";
            this.GrassData.Size = new System.Drawing.Size(161, 56);
            this.GrassData.TabIndex = 13;
            this.GrassData.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GrassData.Value = 160;
            // 
            // HillData
            // 
            this.HillData.Location = new System.Drawing.Point(12, 277);
            this.HillData.Maximum = 255;
            this.HillData.Name = "HillData";
            this.HillData.Size = new System.Drawing.Size(150, 56);
            this.HillData.TabIndex = 14;
            this.HillData.TickStyle = System.Windows.Forms.TickStyle.None;
            this.HillData.Value = 240;
            // 
            // Tekenstijl
            // 
            this.Tekenstijl.Controls.Add(this.MapSettings);
            this.Tekenstijl.Controls.Add(this.ModernRadio);
            this.Tekenstijl.Controls.Add(this.LegacyRadio);
            this.Tekenstijl.Controls.Add(this.groupBox1);
            this.Tekenstijl.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tekenstijl.Location = new System.Drawing.Point(0, 0);
            this.Tekenstijl.Name = "Tekenstijl";
            this.Tekenstijl.Size = new System.Drawing.Size(210, 1055);
            this.Tekenstijl.TabIndex = 15;
            this.Tekenstijl.TabStop = false;
            this.Tekenstijl.Text = "Tekenstijl";
            // 
            // MapSettings
            // 
            this.MapSettings.Controls.Add(this.RandomSeedButton);
            this.MapSettings.Controls.Add(this.SeedData);
            this.MapSettings.Controls.Add(this.label10);
            this.MapSettings.Controls.Add(this.label4);
            this.MapSettings.Controls.Add(this.label3);
            this.MapSettings.Controls.Add(this.label2);
            this.MapSettings.Controls.Add(this.label1);
            this.MapSettings.Controls.Add(this.HeightData);
            this.MapSettings.Controls.Add(this.WidthData);
            this.MapSettings.Controls.Add(this.ScaleData);
            this.MapSettings.Controls.Add(this.TileSizeData);
            this.MapSettings.Location = new System.Drawing.Point(6, 95);
            this.MapSettings.Name = "MapSettings";
            this.MapSettings.Size = new System.Drawing.Size(204, 301);
            this.MapSettings.TabIndex = 16;
            this.MapSettings.TabStop = false;
            this.MapSettings.Text = "Map instellingen";
            // 
            // RandomSeedButton
            // 
            this.RandomSeedButton.Location = new System.Drawing.Point(139, 265);
            this.RandomSeedButton.Name = "RandomSeedButton";
            this.RandomSeedButton.Size = new System.Drawing.Size(23, 27);
            this.RandomSeedButton.TabIndex = 19;
            this.RandomSeedButton.Text = "🔃";
            this.RandomSeedButton.UseVisualStyleBackColor = true;
            this.RandomSeedButton.Click += new System.EventHandler(this.RandomSeedButton_Click);
            // 
            // SeedData
            // 
            this.SeedData.Location = new System.Drawing.Point(13, 265);
            this.SeedData.Name = "SeedData";
            this.SeedData.Size = new System.Drawing.Size(125, 27);
            this.SeedData.TabIndex = 12;
            this.SeedData.Text = "2126844100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Map seed";
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
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Map y axis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Map x axis";
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
            this.groupBox1.Location = new System.Drawing.Point(3, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 396);
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
            this.ShowNumbersCheckbox.Location = new System.Drawing.Point(17, 826);
            this.ShowNumbersCheckbox.Name = "ShowNumbersCheckbox";
            this.ShowNumbersCheckbox.Size = new System.Drawing.Size(167, 24);
            this.ShowNumbersCheckbox.TabIndex = 18;
            this.ShowNumbersCheckbox.Text = "Show number values";
            this.ShowNumbersCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SpatialOffsetCheckBox);
            this.groupBox2.Controls.Add(this.ColorPickerButton);
            this.groupBox2.Controls.Add(this.InvertCheckBox);
            this.groupBox2.Controls.Add(this.KleurToner);
            this.groupBox2.Controls.Add(this.VariatieSlider);
            this.groupBox2.Controls.Add(this.LayersComboBox);
            this.groupBox2.Controls.Add(this.VariatieCheckBox);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.ResetLagenButton);
            this.groupBox2.Controls.Add(this.LetterLaagData);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(1684, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 1055);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Map instellingen";
            // 
            // SpatialOffsetCheckBox
            // 
            this.SpatialOffsetCheckBox.AutoSize = true;
            this.SpatialOffsetCheckBox.Location = new System.Drawing.Point(12, 424);
            this.SpatialOffsetCheckBox.Name = "SpatialOffsetCheckBox";
            this.SpatialOffsetCheckBox.Size = new System.Drawing.Size(189, 24);
            this.SpatialOffsetCheckBox.TabIndex = 21;
            this.SpatialOffsetCheckBox.Text = "Spatial offset gebruiken";
            this.SpatialOffsetCheckBox.UseVisualStyleBackColor = true;
            // 
            // ColorPickerButton
            // 
            this.ColorPickerButton.BackgroundImage = global::PresentationLayer.Properties.Resources.colorPicker;
            this.ColorPickerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColorPickerButton.Location = new System.Drawing.Point(166, 104);
            this.ColorPickerButton.Name = "ColorPickerButton";
            this.ColorPickerButton.Size = new System.Drawing.Size(31, 29);
            this.ColorPickerButton.TabIndex = 22;
            this.ColorPickerButton.UseVisualStyleBackColor = true;
            this.ColorPickerButton.Click += new System.EventHandler(this.ColorPickerButton_Click);
            // 
            // InvertCheckBox
            // 
            this.InvertCheckBox.AutoSize = true;
            this.InvertCheckBox.Location = new System.Drawing.Point(12, 394);
            this.InvertCheckBox.Name = "InvertCheckBox";
            this.InvertCheckBox.Size = new System.Drawing.Size(102, 24);
            this.InvertCheckBox.TabIndex = 20;
            this.InvertCheckBox.Text = "Invert data";
            this.InvertCheckBox.UseVisualStyleBackColor = true;
            // 
            // KleurToner
            // 
            this.KleurToner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.KleurToner.Location = new System.Drawing.Point(6, 104);
            this.KleurToner.Name = "KleurToner";
            this.KleurToner.Size = new System.Drawing.Size(154, 29);
            this.KleurToner.TabIndex = 23;
            // 
            // VariatieSlider
            // 
            this.VariatieSlider.Location = new System.Drawing.Point(12, 362);
            this.VariatieSlider.Maximum = 100;
            this.VariatieSlider.Name = "VariatieSlider";
            this.VariatieSlider.Size = new System.Drawing.Size(185, 56);
            this.VariatieSlider.TabIndex = 15;
            this.VariatieSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VariatieSlider.Value = 70;
            // 
            // LayersComboBox
            // 
            this.LayersComboBox.FormattingEnabled = true;
            this.LayersComboBox.Location = new System.Drawing.Point(6, 50);
            this.LayersComboBox.Name = "LayersComboBox";
            this.LayersComboBox.Size = new System.Drawing.Size(191, 28);
            this.LayersComboBox.TabIndex = 21;
            this.LayersComboBox.SelectedIndexChanged += new System.EventHandler(this.LayersComboBox_SelectedIndexChanged);
            // 
            // VariatieCheckBox
            // 
            this.VariatieCheckBox.AutoSize = true;
            this.VariatieCheckBox.Location = new System.Drawing.Point(12, 306);
            this.VariatieCheckBox.Name = "VariatieCheckBox";
            this.VariatieCheckBox.Size = new System.Drawing.Size(176, 24);
            this.VariatieCheckBox.TabIndex = 19;
            this.VariatieCheckBox.Text = "Voeg kleurvariatie toe";
            this.VariatieCheckBox.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 336);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(146, 20);
            this.label19.TabIndex = 8;
            this.label19.Text = "Hoeveelheid variatie";
            // 
            // ResetLagenButton
            // 
            this.ResetLagenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResetLagenButton.Location = new System.Drawing.Point(6, 224);
            this.ResetLagenButton.Name = "ResetLagenButton";
            this.ResetLagenButton.Size = new System.Drawing.Size(125, 27);
            this.ResetLagenButton.TabIndex = 19;
            this.ResetLagenButton.Text = "Reset lagen 🔃";
            this.ResetLagenButton.UseVisualStyleBackColor = true;
            this.ResetLagenButton.Click += new System.EventHandler(this.ResetLagenButton_Click);
            // 
            // LetterLaagData
            // 
            this.LetterLaagData.Location = new System.Drawing.Point(12, 167);
            this.LetterLaagData.MaxLength = 1;
            this.LetterLaagData.Name = "LetterLaagData";
            this.LetterLaagData.Size = new System.Drawing.Size(33, 27);
            this.LetterLaagData.TabIndex = 12;
            this.LetterLaagData.TextChanged += new System.EventHandler(this.LetterLaagData_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Reset lagen";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Letter van de laag";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Kleur van de laag";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(0, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Bewerk";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ShowNumbersCheckbox);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariatieSlider)).EndInit();
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
        private Label label10;
        private TextBox SeedData;
        private Button RandomSeedButton;
        private GroupBox groupBox2;
        private Button ResetLagenButton;
        private TextBox LetterLaagData;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private ComboBox LayersComboBox;
        private Button ColorPickerButton;
        private Panel KleurToner;
        private ColorDialog colorDialog1;
        private Label label19;
        private CheckBox VariatieCheckBox;
        private TrackBar VariatieSlider;
        private CheckBox InvertCheckBox;
        private CheckBox SpatialOffsetCheckBox;
    }
}