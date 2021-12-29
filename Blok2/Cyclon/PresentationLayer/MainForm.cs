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
        private int _tile = 0;
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
            HeightData.Value = MapModern.Width;
            WidthData.Value = MapModern.Height;
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

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(SeedData.Text, out int seed))
            {
                //als de seed text is dan veranderen we het naar een getal
                seed = SeedData.Text.GetHashCode();
            }
            _map = _main.Generate((int)HeightData.Value, (int)WidthData.Value, (float)ScaleData.Value / 100, DeapSeaData.Value, SeaData.Value, BeachData.Value, GrassData.Value, HillData.Value, SeedData.Text, _layers);
            _tile = (int)TileSizeData.Value;
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
                var drawTerrain = Task.Run(() => LegacyDrawing(2));
            }
        }
        public static void Update(DateTime previousDateTime)
        {
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
                var drawTerrainModern = Task.Run(() => ModernDrawing(2));
                if (drawTerrainModern.IsCompleted)
                {
                    GenerateButton.Enabled = true;
                }
            }
        }
        public async Task LegacyDrawing(int pollingIntervalSeconds)
        {
            var ct = _cancellationSource.Token;
            Update(DateTime.MinValue);
            await Task.Delay(pollingIntervalSeconds * 1000, ct);
            for (int y = 0; y < _map.Height; y++)
            {
                for (int x = 0; x < _map.Width; x++)
                {
                    ct.ThrowIfCancellationRequested();
                    Extensions.PrintTerrainCharacter(MapLegacy, x, y, _tile, _map);
                }
                Extensions.AppendText(MapLegacy, "\r\n", Color.Blue, _tile);
            }
        }
        public async Task<TaskStatus> ModernDrawing(int pollingIntervalSeconds)
        {
            var ct = _cancellationSource.Token;
            Update(DateTime.MinValue);
            await Task.Delay(pollingIntervalSeconds * 1000, ct);
            for (int y = 0; y < _map.Height; y++)
            {
                for (int x = 0; x < _map.Width; x++)
                {
                    ct.ThrowIfCancellationRequested();
                    Extensions.PrintTerrainModern(MapModern.CreateGraphics(), x, y, _tile, ShowNumbersCheckbox, _map);
                }
            }
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
            GenerateButton.Enabled = true;
        }
        private void LegacyRadio_CheckedChanged(object sender, EventArgs e)
        {
            MapLegacy.Visible = true;
            MapModern.Visible = false;
            _cancellationSource.Cancel();
        }
        private void ModernRadio_CheckedChanged(object sender, EventArgs e)
        {
            MapLegacy.Visible = false;
            MapModern.Visible = true;
            _cancellationSource.Cancel();
        }
        private void RandomSeedButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            SeedData.Text = random.Next().ToString();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
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

    public static class Extensions
    {
        public static void PrintTerrainCharacter(this RichTextBox box, int x, int y, int fontSize, Map map)
        {
            AppendText(box, map.Tiles[x, y].Laag.Teken.ToString(), map.Tiles[x, y].Color, fontSize);
        }
        public static void PrintTerrainModern(Graphics paint, int x, int y, int tile, CheckBox checkDebug, Map map)
        {
            paint.DrawRectangle(new Pen(map.Tiles[x, y].Color, tile), x * tile, y * tile, tile, tile);
            if (checkDebug.Checked)
            {
                paint.DrawString(((int)map.NoiseValues[x, y]).ToString(), new Font("Arial", tile / 6), new SolidBrush(Color.Black), x * tile, y * tile);
                //paint.Graphics.DrawRectangle(new Pen(Color.Red, 3), x * tile, y * tile, tile, tile);   
            }
        }
        public static void AppendText(this RichTextBox box, string text, Color color, int fontSize)
        {
            if (box.InvokeRequired)
            {
                box.Invoke(new MethodInvoker(delegate
                {
                    Font currentFont = box.SelectionFont;
                    FontStyle newFontStyle = (FontStyle)(currentFont.Style | FontStyle.Bold);
                    box.SelectionFont = new Font(currentFont.FontFamily, fontSize, newFontStyle);
                    box.SelectionStart = box.TextLength;
                    box.SelectionLength = 0;
                    box.SelectionColor = color;
                    box.AppendText(text);
                    box.SelectionColor = box.ForeColor;
                }));
            }
        }
    }
}