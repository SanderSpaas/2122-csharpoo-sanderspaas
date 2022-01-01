using Globals.Interfaces;
using LogicLayer;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        private readonly ILogic _logic;
        private Map _map = new();
        private CyclonMain _main = new();
        private Bitmap _bitmap;
        private bool _generated = false;
        private int _tileSize = 0;
        private Color[] _kleuren = new Color[] { Color.FromArgb(2, 72, 132), Color.FromArgb(3, 100, 184), Color.FromArgb(255, 203, 60), Color.Green, Color.DarkGreen, Color.Gray };
        private int[] _heights = new int[] { 40, 70, 120, 135, 220, 240 };
        private char[] _drawings = new char[] { '█', '█', '█', '█', '█', '█' };
        private List<Layer> _layers = new();
        private CancellationTokenSource _cancellationSource;

        public MainForm(ILogic logic)
        {
            _logic = logic;
            InitializeComponent();
            Icon = new Icon("Assets/Cyclon.ico");
            HeightData.Value = MapModern.Width / (int)TileSizeData.Value;
            WidthData.Value = MapModern.Height / (int)TileSizeData.Value;
            _layers = _main.MaakLagen(_kleuren, _heights, _drawings);
            foreach (object? Terrain in Enum.GetValues(typeof(TerrainType)))
            {
                if (Terrain.ToString() != "Undefined")
                {
                    LayersComboBox.Items.Add(Terrain);
                }
            }
            LayersComboBox.SelectedIndex = 0;
        }

        private async void GenerateButton_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(SeedData.Text, out int seed))
            {
                //als de seed text is dan veranderen we het naar een hascode aka een getal
                seed = SeedData.Text.GetHashCode();
            }
            _map = _main.Generate((int)HeightData.Value, (int)WidthData.Value, (float)ScaleData.Value / 100, DeapSeaData.Value, SeaData.Value, BeachData.Value, GrassData.Value, HillData.Value, SeedData.Text, _layers);
            _tileSize = (int)TileSizeData.Value;
            _bitmap = new Bitmap(_map.Height, _map.Width, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            if (SpatialOffsetCheckBox.Checked)
            {
                _main.SpatialOffset(_map.NoiseValues, _map);
            }
            if (InvertCheckBox.Checked)
            {
                _main.Invert(_map.NoiseValues, _map);
            }
            if (VariatieCheckBox.Checked)
            {
                _main.ColorShift(_map, VariatieSlider.Value);
            }
            if (ShadingCheckBox.Checked)
            {
                _main.Shading(_map);
            }
            _generated = true;

            if (MapModern.Visible)
            {
                Refresh();
            }
            else if (MapLegacy.Visible)
            {
                MapLegacy.Clear();
                _cancellationSource = new();
                GenerateButton.Enabled = false;
                var taskDone = await Task.Run(() => LegacyDrawing()); if (taskDone == TaskStatus.RanToCompletion || taskDone == TaskStatus.Canceled)
                {
                    GenerateButton.Enabled = true;
                }
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
                var taskDone = await Task.Run(() => ModernDrawing()); if (taskDone == TaskStatus.RanToCompletion || taskDone == TaskStatus.Canceled)
                {
                    GenerateButton.Enabled = true;
                }
            }
        }
        public TaskStatus LegacyDrawing()
        {
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
                        return TaskStatus.Canceled;
                    }
                    MapExtensions.PrintTerrainOld(_map, MapLegacy, x, y, _tileSize);
                }
                MapExtensions.AppendText(_map, MapLegacy, _tileSize, 0, 0, true);
            }
            _generated = false;
            return TaskStatus.RanToCompletion;
        }
        public TaskStatus ModernDrawing()
        {
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
                        return TaskStatus.Canceled;
                    }
                    MapExtensions.PrintTerrainModern(_map, MapModern.CreateGraphics(), x, y, _tileSize, ShowNumbersCheckbox);
                }
            }
            _generated = false;
            return TaskStatus.RanToCompletion;
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
                }
            }
        }
        private void ResetLagenButton_Click(object sender, EventArgs e)
        {
            _layers = _main.MaakLagen(_kleuren, _heights, _drawings);
            foreach (var layer in _layers)
            {
                if (LayersComboBox.SelectedItem.ToString() == layer.NaamLaag.ToString())
                {
                    KleurToner.BackColor = layer.Kleur;
                    LetterLaagData.Text = layer.Teken.ToString();
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
                    }
                }
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            _cancellationSource.Cancel();
            _generated = false;
            MapLegacy.Clear();
            Refresh();
            GenerateButton.Enabled = true;
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
            if (_cancellationSource is not null)
            {
                _cancellationSource.Cancel();
            }
        }
        private void RandomSeedButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            SeedData.Text = random.Next().ToString();
        }
        private void ClearButton_Click(object sender, EventArgs e)
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
    }
}