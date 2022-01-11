using DataAccessLayer;
using LogicLayer;
using System.Diagnostics;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        private Map _map = new();
        private SeedData _seedData = new();
        private Bitmap _bitmap;
        private ICyclonMain _cyclonMain;
        private bool _generated = false;
        private bool _taskWorking = false;
        private int _tileSize = 0;
        private readonly Color[] _kleuren = new Color[] { Color.FromArgb(2, 72, 132), Color.FromArgb(3, 100, 184), Color.FromArgb(255, 203, 60), Color.Green, Color.DarkGreen, Color.FromArgb(104, 104, 104) };
        private readonly int[] _heights = new int[] { 40, 70, 120, 135, 220, 233 };
        private readonly char[] _drawings = new char[] { '█', '█', '█', '█', '█', '█' };
        private List<Layer> _layers = new();
        private CancellationTokenSource _cancellationSource;
        private readonly Random _random = new();

        public MainForm(ICyclonMain cyclonMain)
        {
            _cyclonMain = cyclonMain;
            InitializeComponent();
            Icon = new Icon("Assets/Cyclon.ico");
            _layers = _map.MaakLagen(_kleuren, _heights, _drawings);
            SeedData.Text = _random.Next().ToString();

            foreach (TerrainType Terrain in Enum.GetValues(typeof(TerrainType)))
            {
                if (Terrain != TerrainType.Undefined)
                {
                    LayersComboBox.Items.Add(Terrain);
                }
            }
            LayersComboBox.SelectedIndex = 0;

            //dingen gaan juist zetten voor de gridview
            LayersListGrid.DataSource = _layers;
            LayersListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LayersListGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            LayersListGrid.BackgroundColor = Color.White;
            LayersListGrid.RowHeadersVisible = false;
            LayersListGrid.ReadOnly = true;

            //de map juist gaan sizen
            HeightData.Value = MapModern.Width / (int)TileSizeData.Value;
            WidthData.Value = MapModern.Height / (int)TileSizeData.Value;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            SetupData();
            StartDrawing();
        }
        private void SetupData()
        {
            if (!Int32.TryParse(SeedData.Text, out int seed))
            {
                //als de seed text is dan veranderen we het naar een hascode aka een getal
                seed = SeedData.Text.GetHashCode();
            }
            _map = _map.Generate((int)HeightData.Value, (int)WidthData.Value, (float)ScaleData.Value / 100, SeedData.Text, _layers);
            _tileSize = (int)TileSizeData.Value;
            _bitmap = new Bitmap(_map.Height, _map.Width, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            if (SpatialOffsetCheckBox.Checked)
            {
                _map.SpatialOffset(_map.NoiseValues, _map, _layers, (int)SpatialOffsetCounter.Value);
            }
            if (IslandsCheckBox.Checked)
            {
                _map.Islands(_map, _layers);
            }
            if (InvertCheckBox.Checked)
            {
                _map.Invert(_map.NoiseValues, _map);
            }
            if (VariatieCheckBox.Checked)
            {
                _map.ColorShift(_map, VariatieSlider.Value);
            }
            if (ShadingCheckBox.Checked)
            {
                _map.Shading(_map);
            }
            _generated = true;
        }
        private async void StartDrawing()
        {
            if (MapModern.Visible)
            {
                Refresh();
            }
            else if (MapLegacy.Visible)
            {
                MapLegacy.Clear();
                _cancellationSource = new();
                GenerateButton.Enabled = false;
                _taskWorking = true;
                await Task.Run(() => LegacyDrawing());
                GenerateButton.Enabled = true;
                _taskWorking = false;
            }
        }
        private async void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint |
            ControlStyles.DoubleBuffer, true);
            if (_generated)
            {
                GenerateButton.Enabled = false;
                _cancellationSource = new();
                _taskWorking = true;
                await Task.Run(() => ModernDrawing());
                GenerateButton.Enabled = true;
                _taskWorking = false;
            }
        }
        public void LegacyDrawing()
        {

            if (_taskWorking)
            {
                Debug.WriteLine("LegacyDrawing started");
                MapProgress.Invoke(new MethodInvoker(delegate
                {
                    MapProgress.Maximum = _map.Height * _map.Width;
                }));
                int counter = 0;
                for (int y = 0; y < _map.Height; y++)
                {
                    for (int x = 0; x < _map.Width; x++)
                    {
                        try
                        {
                            _cancellationSource.Token.ThrowIfCancellationRequested();
                        }
                        catch (OperationCanceledException)
                        {
                            _generated = false;
                            break;
                        }
                        MapExtensions.PrintTerrainOld(_map, MapLegacy, x, y, _tileSize);
                        MapProgress.Invoke(new MethodInvoker(delegate
                        {
                            MapProgress.Value = counter++;
                        }));
                    }
                    MapExtensions.AppendText(_map, MapLegacy, _tileSize, 0, 0, true);
                }
                _generated = false;
            }
        }
        public void ModernDrawing()
        {
            if (_taskWorking)
            {
                Debug.WriteLine("ModernDrawing started");
                MapProgress.Invoke(new MethodInvoker(delegate
                {
                    MapProgress.Maximum = _map.Height * _map.Width;
                }));
                int counter = 0;
                for (int y = 0; y < _map.Height; y++)
                {
                    for (int x = 0; x < _map.Width; x++)
                    {
                        try
                        {
                            _cancellationSource.Token.ThrowIfCancellationRequested();
                        }
                        catch (OperationCanceledException)
                        {
                            _generated = false;
                            break;
                        }
                        MapExtensions.PrintTerrainModern(_map, MapModern.CreateGraphics(), x, y, _tileSize, ShowNumbersCheckbox);
                        MapProgress.Invoke(new MethodInvoker(delegate
                        {
                            MapProgress.Value = counter++;
                        }));
                    }
                }
                _generated = false;
            }
        }

        private void ColorPickerButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                KleurToner.BackColor = colorDialog1.Color;
                //data van die laag gaan updaten
                foreach (var layer in _layers)
                {
                    if (LayersComboBox.SelectedItem.ToString() == layer.NaamLaag.ToString())
                    {
                        layer.Kleur = KleurToner.BackColor;
                        LayersListGrid.Update();
                        LayersListGrid.Refresh();
                    }
                }
            }
        }

        private void LayersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //data gaan tonen van die laag
            foreach (var layer in _layers)
            {
                if (LayersComboBox.SelectedItem.ToString() == layer.NaamLaag.ToString())
                {
                    KleurToner.BackColor = layer.Kleur;
                    LetterLaagData.Text = layer.Teken.ToString();
                    LayersLabel.Text = layer.NaamLaag.ToString() + " height";
                    LayersHeightData.Value = layer.Height;
                }
            }
        }

        private void LetterLaagData_TextChanged(object sender, EventArgs e)
        {
            if (LetterLaagData.Text.Length > 0)
            {
                //data van die laag gaan updaten
                foreach (var layer in _layers)
                {
                    if (LayersComboBox.SelectedItem.ToString() == layer.NaamLaag.ToString())
                    {
                        layer.Teken = LetterLaagData.Text.ToCharArray()[0];
                        LayersListGrid.Update();
                        LayersListGrid.Refresh();
                    }
                }
            }
        }
        private void LayersHeightData_Scroll(object sender, EventArgs e)
        {
            //data van die laag gaan updaten
            foreach (var layer in _layers)
            {
                if (LayersComboBox.SelectedItem.ToString() == layer.NaamLaag.ToString())
                {
                    layer.Height = LayersHeightData.Value;
                    LayersListGrid.Update();
                    LayersListGrid.Refresh();
                }
            }
        }
        private void ResetLagenButton_Click(object sender, EventArgs e)
        {
            _layers = _map.MaakLagen(_kleuren, _heights, _drawings);
            LayersListGrid.DataSource = _layers;
            LayersListGrid.Update();
            LayersListGrid.Refresh();
            foreach (var layer in _layers)
            {
                if (LayersComboBox.SelectedItem.ToString() == layer.NaamLaag.ToString())
                {
                    KleurToner.BackColor = layer.Kleur;
                    LetterLaagData.Text = layer.Teken.ToString();
                }
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (_cancellationSource != null)
            {
                Debug.WriteLine("Task Canceled");
                _cancellationSource.Cancel();
                _generated = false;
                MapProgress.Value = 0;
                GenerateButton.Enabled = true;
                ShowModeCheckBox.Checked = false;
            }
        }
        private void LegacyRadio_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCheck(true, false);
        }
        private void ModernRadio_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCheck(false, true);
        }
        private void ChangeCheck(bool legacy, bool modern)
        {
            MapLegacy.Visible = legacy;
            MapModern.Visible = modern;
            MapLegacy.Clear();
            Refresh();
            MapProgress.Value = 0;
            SetSize();
            ShowModeCheckBox.Checked = false;
            if (_cancellationSource is not null)
            {
                _cancellationSource.Cancel();
            }
        }
        private void RandomSeedButton_Click(object sender, EventArgs e)
        {

            SeedData.Text = _random.Next().ToString();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearMaps();
        }
        private void ClearMaps()
        {
            _generated = false;
            if (MapLegacy.Visible)
            {
                MapLegacy.Clear();
            }
            else if (MapModern.Visible)
            {
                MapModern.Refresh();
            }
        }

        private void TileSizeData_ValueChanged(object sender, EventArgs e)
        {
            SetSize();
        }
        private void SetSize()
        {
            if (MapModern.Visible)
            {
                HeightData.Maximum = MapModern.Width / TileSizeData.Value;
                WidthData.Maximum = MapModern.Height / TileSizeData.Value;
                HeightData.Value = MapModern.Width / TileSizeData.Value;
                WidthData.Value = MapModern.Height / TileSizeData.Value;
            }
            else
            {
                HeightData.Maximum = MapModern.Width / (TileSizeData.Value * 2);
                WidthData.Maximum = MapModern.Height / (TileSizeData.Value * 2);
                HeightData.Value = MapModern.Width / (TileSizeData.Value * 2);
                WidthData.Value = MapModern.Height / (TileSizeData.Value * 2);
            }
        }

        private async void ShowModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ClearMaps();
            if (_cancellationSource is not null)
            {
                _cancellationSource.Cancel();
            }
            for (int i = 0; i < 100; i++)
            {
                if (ShowModeCheckBox.Checked)
                {
                    SeedData.Text = _random.Next().ToString();
                    ScaleData.Value = (decimal)((_random.NextDouble() * (10 - 0.1)) + 0.01);
                    TileSizeData.Value = _random.Next(8, 20);
                    IslandsCheckBox.Checked = !IslandsCheckBox.Checked;
                    SetupData();
                    if (MapModern.Visible)
                    {
                        _cancellationSource = new();
                        await Task.Run(() => ModernDrawing());
                        GenerateButton.Enabled = true;
                    }
                    else if (MapLegacy.Visible)
                    {
                        MapLegacy.Clear();
                        _cancellationSource = new();
                        GenerateButton.Enabled = false;
                        await Task.Run(() => LegacyDrawing());
                        GenerateButton.Enabled = true;
                    }
                }
            }
        }

        private void SaveSeedButton_Click(object sender, EventArgs e)
        {
            new SaveSeed(SeedData.Text, _seedData).ShowDialog();
        }

        private void LoadSeedButton_Click(object sender, EventArgs e)
        {
            new LoadSeed(_seedData).ShowDialog();
        }
    }
}