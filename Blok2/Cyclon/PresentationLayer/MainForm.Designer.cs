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
            this.MapProgress = new System.Windows.Forms.ProgressBar();
            this.TileSizeData = new System.Windows.Forms.NumericUpDown();
            this.LayersHeightData = new System.Windows.Forms.TrackBar();
            this.Tekenstijl = new System.Windows.Forms.GroupBox();
            this.MapSettings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModernRadio = new System.Windows.Forms.RadioButton();
            this.LegacyRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadSeedButton = new System.Windows.Forms.Button();
            this.SaveSeedButton = new System.Windows.Forms.Button();
            this.ShowModeCheckBox = new System.Windows.Forms.CheckBox();
            this.ProgressBarCheck = new System.Windows.Forms.CheckBox();
            this.RandomSeedButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SeedData = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CancelGenerateButton = new System.Windows.Forms.Button();
            this.ShowNumbersCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LayersListGrid = new System.Windows.Forms.DataGridView();
            this.LayersLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SpatialOffsetCounter = new System.Windows.Forms.NumericUpDown();
            this.IslandsCheckBox = new System.Windows.Forms.CheckBox();
            this.ShadingCheckBox = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.LayersHeightData)).BeginInit();
            this.Tekenstijl.SuspendLayout();
            this.MapSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayersListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpatialOffsetCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VariatieSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // MapLegacy
            // 
            this.MapLegacy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapLegacy.DetectUrls = false;
            this.MapLegacy.Location = new System.Drawing.Point(213, 0);
            this.MapLegacy.Margin = new System.Windows.Forms.Padding(0);
            this.MapLegacy.Name = "MapLegacy";
            this.MapLegacy.ReadOnly = true;
            this.MapLegacy.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MapLegacy.Size = new System.Drawing.Size(1474, 1055);
            this.MapLegacy.TabIndex = 1;
            this.MapLegacy.Text = "";
            this.MapLegacy.Visible = false;
            this.MapLegacy.WordWrap = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(16, 88);
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
            1000,
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
            1000,
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
            this.ScaleData.DecimalPlaces = 2;
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
            this.MapModern.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapModern.AutoSize = true;
            this.MapModern.Location = new System.Drawing.Point(216, 1);
            this.MapModern.Name = "MapModern";
            this.MapModern.Size = new System.Drawing.Size(1468, 1054);
            this.MapModern.TabIndex = 8;
            this.MapModern.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            // 
            // MapProgress
            // 
            this.MapProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MapProgress.Location = new System.Drawing.Point(215, 1028);
            this.MapProgress.Name = "MapProgress";
            this.MapProgress.Size = new System.Drawing.Size(1469, 27);
            this.MapProgress.Step = 1;
            this.MapProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.MapProgress.TabIndex = 20;
            // 
            // TileSizeData
            // 
            this.TileSizeData.Location = new System.Drawing.Point(12, 212);
            this.TileSizeData.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TileSizeData.Name = "TileSizeData";
            this.TileSizeData.Size = new System.Drawing.Size(150, 27);
            this.TileSizeData.TabIndex = 9;
            this.TileSizeData.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.TileSizeData.ValueChanged += new System.EventHandler(this.TileSizeData_ValueChanged);
            // 
            // LayersHeightData
            // 
            this.LayersHeightData.Location = new System.Drawing.Point(6, 231);
            this.LayersHeightData.Maximum = 255;
            this.LayersHeightData.Name = "LayersHeightData";
            this.LayersHeightData.Size = new System.Drawing.Size(161, 56);
            this.LayersHeightData.TabIndex = 10;
            this.LayersHeightData.TickStyle = System.Windows.Forms.TickStyle.None;
            this.LayersHeightData.Value = 40;
            this.LayersHeightData.Scroll += new System.EventHandler(this.LayersHeightData_Scroll);
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
            this.Tekenstijl.Size = new System.Drawing.Size(215, 1055);
            this.Tekenstijl.TabIndex = 15;
            this.Tekenstijl.TabStop = false;
            this.Tekenstijl.Text = "Tekenstijl";
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
            this.MapSettings.Location = new System.Drawing.Point(6, 95);
            this.MapSettings.Name = "MapSettings";
            this.MapSettings.Size = new System.Drawing.Size(204, 250);
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
            this.groupBox1.Controls.Add(this.LoadSeedButton);
            this.groupBox1.Controls.Add(this.SaveSeedButton);
            this.groupBox1.Controls.Add(this.ShowModeCheckBox);
            this.groupBox1.Controls.Add(this.ProgressBarCheck);
            this.groupBox1.Controls.Add(this.RandomSeedButton);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.SeedData);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.CancelGenerateButton);
            this.groupBox1.Controls.Add(this.ShowNumbersCheckbox);
            this.groupBox1.Controls.Add(this.GenerateButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 698);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map instellingen";
            // 
            // LoadSeedButton
            // 
            this.LoadSeedButton.Location = new System.Drawing.Point(16, 321);
            this.LoadSeedButton.Name = "LoadSeedButton";
            this.LoadSeedButton.Size = new System.Drawing.Size(150, 29);
            this.LoadSeedButton.TabIndex = 23;
            this.LoadSeedButton.Text = "Load seed";
            this.LoadSeedButton.UseVisualStyleBackColor = true;
            this.LoadSeedButton.Click += new System.EventHandler(this.LoadSeedButton_Click);
            // 
            // SaveSeedButton
            // 
            this.SaveSeedButton.Location = new System.Drawing.Point(16, 286);
            this.SaveSeedButton.Name = "SaveSeedButton";
            this.SaveSeedButton.Size = new System.Drawing.Size(150, 29);
            this.SaveSeedButton.TabIndex = 22;
            this.SaveSeedButton.Text = "Save seed";
            this.SaveSeedButton.UseVisualStyleBackColor = true;
            this.SaveSeedButton.Click += new System.EventHandler(this.SaveSeedButton_Click);
            // 
            // ShowModeCheckBox
            // 
            this.ShowModeCheckBox.AutoSize = true;
            this.ShowModeCheckBox.Location = new System.Drawing.Point(19, 256);
            this.ShowModeCheckBox.Name = "ShowModeCheckBox";
            this.ShowModeCheckBox.Size = new System.Drawing.Size(155, 24);
            this.ShowModeCheckBox.TabIndex = 21;
            this.ShowModeCheckBox.Text = "Enable Showmode";
            this.ShowModeCheckBox.UseVisualStyleBackColor = true;
            this.ShowModeCheckBox.CheckedChanged += new System.EventHandler(this.ShowModeCheckBox_CheckedChanged);
            // 
            // ProgressBarCheck
            // 
            this.ProgressBarCheck.AutoSize = true;
            this.ProgressBarCheck.Checked = true;
            this.ProgressBarCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProgressBarCheck.Location = new System.Drawing.Point(19, 226);
            this.ProgressBarCheck.Name = "ProgressBarCheck";
            this.ProgressBarCheck.Size = new System.Drawing.Size(150, 24);
            this.ProgressBarCheck.TabIndex = 20;
            this.ProgressBarCheck.Text = "Show progressbar";
            this.ProgressBarCheck.UseVisualStyleBackColor = true;
            this.ProgressBarCheck.CheckedChanged += new System.EventHandler(this.ProgressBarCheck_CheckedChanged);
            // 
            // RandomSeedButton
            // 
            this.RandomSeedButton.Location = new System.Drawing.Point(140, 55);
            this.RandomSeedButton.Name = "RandomSeedButton";
            this.RandomSeedButton.Size = new System.Drawing.Size(23, 27);
            this.RandomSeedButton.TabIndex = 19;
            this.RandomSeedButton.Text = "🔃";
            this.RandomSeedButton.UseVisualStyleBackColor = true;
            this.RandomSeedButton.Click += new System.EventHandler(this.RandomSeedButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(16, 158);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 29);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SeedData
            // 
            this.SeedData.Location = new System.Drawing.Point(14, 55);
            this.SeedData.Name = "SeedData";
            this.SeedData.Size = new System.Drawing.Size(125, 27);
            this.SeedData.TabIndex = 12;
            this.SeedData.Text = "2126844100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Map seed";
            // 
            // CancelGenerateButton
            // 
            this.CancelGenerateButton.Location = new System.Drawing.Point(16, 123);
            this.CancelGenerateButton.Name = "CancelGenerateButton";
            this.CancelGenerateButton.Size = new System.Drawing.Size(150, 29);
            this.CancelGenerateButton.TabIndex = 15;
            this.CancelGenerateButton.Text = "Cancel";
            this.CancelGenerateButton.UseVisualStyleBackColor = true;
            this.CancelGenerateButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ShowNumbersCheckbox
            // 
            this.ShowNumbersCheckbox.AutoSize = true;
            this.ShowNumbersCheckbox.Location = new System.Drawing.Point(19, 196);
            this.ShowNumbersCheckbox.Name = "ShowNumbersCheckbox";
            this.ShowNumbersCheckbox.Size = new System.Drawing.Size(167, 24);
            this.ShowNumbersCheckbox.TabIndex = 18;
            this.ShowNumbersCheckbox.Text = "Show number values";
            this.ShowNumbersCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LayersListGrid);
            this.groupBox2.Controls.Add(this.LayersLabel);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.SpatialOffsetCounter);
            this.groupBox2.Controls.Add(this.IslandsCheckBox);
            this.groupBox2.Controls.Add(this.ShadingCheckBox);
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
            this.groupBox2.Controls.Add(this.LayersHeightData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(1684, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 1055);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Map instellingen";
            // 
            // LayersListGrid
            // 
            this.LayersListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LayersListGrid.Location = new System.Drawing.Point(0, 607);
            this.LayersListGrid.Name = "LayersListGrid";
            this.LayersListGrid.RowHeadersWidth = 51;
            this.LayersListGrid.RowTemplate.Height = 29;
            this.LayersListGrid.Size = new System.Drawing.Size(240, 422);
            this.LayersListGrid.TabIndex = 28;
            // 
            // LayersLabel
            // 
            this.LayersLabel.AutoSize = true;
            this.LayersLabel.Location = new System.Drawing.Point(13, 203);
            this.LayersLabel.Name = "LayersLabel";
            this.LayersLabel.Size = new System.Drawing.Size(96, 20);
            this.LayersLabel.TabIndex = 27;
            this.LayersLabel.Text = "Layers height";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(74, 492);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Aantal spatial offset";
            // 
            // SpatialOffsetCounter
            // 
            this.SpatialOffsetCounter.Location = new System.Drawing.Point(13, 490);
            this.SpatialOffsetCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpatialOffsetCounter.Name = "SpatialOffsetCounter";
            this.SpatialOffsetCounter.Size = new System.Drawing.Size(53, 27);
            this.SpatialOffsetCounter.TabIndex = 11;
            this.SpatialOffsetCounter.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // IslandsCheckBox
            // 
            this.IslandsCheckBox.AutoSize = true;
            this.IslandsCheckBox.Checked = true;
            this.IslandsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IslandsCheckBox.Location = new System.Drawing.Point(13, 562);
            this.IslandsCheckBox.Name = "IslandsCheckBox";
            this.IslandsCheckBox.Size = new System.Drawing.Size(140, 24);
            this.IslandsCheckBox.TabIndex = 25;
            this.IslandsCheckBox.Text = "Generate islands";
            this.IslandsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShadingCheckBox
            // 
            this.ShadingCheckBox.AutoSize = true;
            this.ShadingCheckBox.Checked = true;
            this.ShadingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShadingCheckBox.Location = new System.Drawing.Point(13, 532);
            this.ShadingCheckBox.Name = "ShadingCheckBox";
            this.ShadingCheckBox.Size = new System.Drawing.Size(221, 24);
            this.ShadingCheckBox.TabIndex = 24;
            this.ShadingCheckBox.Text = "Shading based on tile height";
            this.ShadingCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpatialOffsetCheckBox
            // 
            this.SpatialOffsetCheckBox.AutoSize = true;
            this.SpatialOffsetCheckBox.Location = new System.Drawing.Point(13, 456);
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
            this.ColorPickerButton.Location = new System.Drawing.Point(173, 104);
            this.ColorPickerButton.Name = "ColorPickerButton";
            this.ColorPickerButton.Size = new System.Drawing.Size(31, 29);
            this.ColorPickerButton.TabIndex = 22;
            this.ColorPickerButton.UseVisualStyleBackColor = true;
            this.ColorPickerButton.Click += new System.EventHandler(this.ColorPickerButton_Click);
            // 
            // InvertCheckBox
            // 
            this.InvertCheckBox.AutoSize = true;
            this.InvertCheckBox.Location = new System.Drawing.Point(13, 426);
            this.InvertCheckBox.Name = "InvertCheckBox";
            this.InvertCheckBox.Size = new System.Drawing.Size(102, 24);
            this.InvertCheckBox.TabIndex = 20;
            this.InvertCheckBox.Text = "Invert data";
            this.InvertCheckBox.UseVisualStyleBackColor = true;
            // 
            // KleurToner
            // 
            this.KleurToner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.KleurToner.Location = new System.Drawing.Point(13, 104);
            this.KleurToner.Name = "KleurToner";
            this.KleurToner.Size = new System.Drawing.Size(154, 29);
            this.KleurToner.TabIndex = 23;
            // 
            // VariatieSlider
            // 
            this.VariatieSlider.Location = new System.Drawing.Point(13, 394);
            this.VariatieSlider.Maximum = 100;
            this.VariatieSlider.Name = "VariatieSlider";
            this.VariatieSlider.Size = new System.Drawing.Size(185, 56);
            this.VariatieSlider.TabIndex = 15;
            this.VariatieSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VariatieSlider.Value = 70;
            // 
            // LayersComboBox
            // 
            this.LayersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LayersComboBox.FormattingEnabled = true;
            this.LayersComboBox.Location = new System.Drawing.Point(13, 50);
            this.LayersComboBox.Name = "LayersComboBox";
            this.LayersComboBox.Size = new System.Drawing.Size(191, 28);
            this.LayersComboBox.TabIndex = 21;
            this.LayersComboBox.SelectedIndexChanged += new System.EventHandler(this.LayersComboBox_SelectedIndexChanged);
            // 
            // VariatieCheckBox
            // 
            this.VariatieCheckBox.AutoSize = true;
            this.VariatieCheckBox.Location = new System.Drawing.Point(13, 335);
            this.VariatieCheckBox.Name = "VariatieCheckBox";
            this.VariatieCheckBox.Size = new System.Drawing.Size(176, 24);
            this.VariatieCheckBox.TabIndex = 19;
            this.VariatieCheckBox.Text = "Voeg kleurvariatie toe";
            this.VariatieCheckBox.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 368);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(146, 20);
            this.label19.TabIndex = 8;
            this.label19.Text = "Hoeveelheid variatie";
            // 
            // ResetLagenButton
            // 
            this.ResetLagenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResetLagenButton.Location = new System.Drawing.Point(12, 293);
            this.ResetLagenButton.Name = "ResetLagenButton";
            this.ResetLagenButton.Size = new System.Drawing.Size(125, 27);
            this.ResetLagenButton.TabIndex = 19;
            this.ResetLagenButton.Text = "Reset lagen 🔃";
            this.ResetLagenButton.UseVisualStyleBackColor = true;
            this.ResetLagenButton.Click += new System.EventHandler(this.ResetLagenButton_Click);
            // 
            // LetterLaagData
            // 
            this.LetterLaagData.Location = new System.Drawing.Point(13, 167);
            this.LetterLaagData.MaxLength = 1;
            this.LetterLaagData.Name = "LetterLaagData";
            this.LetterLaagData.Size = new System.Drawing.Size(124, 27);
            this.LetterLaagData.TabIndex = 12;
            this.LetterLaagData.TextChanged += new System.EventHandler(this.LetterLaagData_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Reset lagen";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Letter van de laag";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Kleur van de laag";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 23);
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
            this.Controls.Add(this.MapProgress);
            this.Controls.Add(this.groupBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.LayersHeightData)).EndInit();
            this.Tekenstijl.ResumeLayout(false);
            this.Tekenstijl.PerformLayout();
            this.MapSettings.ResumeLayout(false);
            this.MapSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayersListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpatialOffsetCounter)).EndInit();
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
        private TrackBar LayersHeightData;
        private GroupBox Tekenstijl;
        private RadioButton ModernRadio;
        private RadioButton LegacyRadio;
        private GroupBox MapSettings;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
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
        private CheckBox ShadingCheckBox;
        private Button CancelGenerateButton;
        private Button ClearButton;
        private ProgressBar MapProgress;
        private CheckBox ProgressBarCheck;
        private CheckBox ShowModeCheckBox;
        private CheckBox IslandsCheckBox;
        private Label label12;
        private NumericUpDown SpatialOffsetCounter;
        private Button SaveSeedButton;
        private Button LoadSeedButton;
        private Label LayersLabel;
        private DataGridView LayersListGrid;
    }
}