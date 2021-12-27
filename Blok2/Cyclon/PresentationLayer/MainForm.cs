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
        private float[,] _data;
        private bool _generated = false;
        private int _tile = 0;
        private Layer _laag = new();
        private Color[] _kleuren = new Color[] { Color.FromArgb(2, 72, 132), Color.FromArgb(3, 100, 184), Color.FromArgb(255, 203, 60), Color.Green, Color.DarkGreen, Color.Gray };
        private int[] _heights = new int[] { 40, 70, 120, 135, 220, 240 };
        private char[] _drawings = new char[] { '█', '█', '█', '█', '█', '█' };
        private List<Layer> _layers = new();
        public MainForm(ILogic logic)
        {
            _logic = logic;
            InitializeComponent();
            Icon = new Icon("Assets/Cyclon.ico");
            HeightData.Value = MapModern.Width;
            MapLegacy.Height = MapModern.Height;
            _layers = _main.MaakLagen(_kleuren, _heights, _drawings);
            foreach (var Terrain in Enum.GetValues(typeof(TerrainType)))
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
            _map = _main.Generate((int)HeightData.Value, (int)WidthData.Value, (float)ScaleData.Value / 100, DeapSeaData.Value, SeaData.Value, BeachData.Value, GrassData.Value, HillData.Value, seed, _layers, InvertCheckBox.Checked, SpatialOffsetCheckBox.Checked);
            _tile = (int)TileSizeData.Value;
            _bitmap = new Bitmap(_map.Height * _tile, _map.Width * _tile);
            _data = _main.GenerateNoise((int)HeightData.Value, (int)WidthData.Value, (float)ScaleData.Value / 100, seed, InvertCheckBox.Checked, SpatialOffsetCheckBox.Checked);
            _generated = true;

            if (MapModern.Visible)
            {
                Refresh();
                //Task drawTerrain = new Task(new Action(ModernDrawing));
                //drawTerrain.Start();
            }
            else if (MapLegacy.Visible)
            {
                MapLegacy.Clear();
                Task drawTerrain = new Task(new Action(LegacyDrawing));
                drawTerrain.Start();
            }

        }

        private void LegacyDrawing()
        {
            bool variatie = false;
            int sliderValue = 0;

            VariatieCheckBox.Invoke(new MethodInvoker(delegate
            {
                variatie = VariatieCheckBox.Checked;
            }));

            VariatieCheckBox.Invoke(new MethodInvoker(delegate
            {
                sliderValue = VariatieSlider.Value;
            }));

            for (int y = 0; y < _map.Height; y++)
            {
                for (int x = 0; x < _map.Width; x++)
                {
                    Extensions.PrintTerrainCharacter(MapLegacy, _tile, _map.Tiles[x, y].Laag, variatie, sliderValue);
                }
                Extensions.AppendText(MapLegacy, "\r\n", Color.Blue, _tile);
            }
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint |
            ControlStyles.DoubleBuffer, true);
            if (_generated)
            {
                for (int y = 0; y < _map.Height; y++)
                {
                    for (int x = 0; x < _map.Width; x++)
                    {
                        Extensions.PrintTerrainModern(e, _map.Tiles[x, y].Laag.NaamLaag, x, y, _tile, _map.Tiles[x, y].Laag, _data, ShowNumbersCheckbox, VariatieCheckBox, VariatieSlider.Value);
                    }
                    Application.DoEvents();
                }
            }
        }

        private void LegacyRadio_CheckedChanged(object sender, EventArgs e)
        {
            MapLegacy.Visible = true;
            MapModern.Visible = false;
        }

        private void ModernRadio_CheckedChanged(object sender, EventArgs e)
        {
            MapLegacy.Visible = false;
            MapModern.Visible = true;
        }

        private void RandomSeedButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            SeedData.Text = random.Next().ToString();
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

    }

    public static class Extensions
    {
        public static void PrintTerrainCharacter(this RichTextBox box, int fontSize, Layer laag, bool checkColorShift, int max)
        {
            Random random = new Random();
            if (checkColorShift)
            {
                Extensions.AppendText(box, laag.Teken.ToString(), ColorByShift(laag.Kleur, max, random), fontSize);
            }
            else
            {
                Extensions.AppendText(box, laag.Teken.ToString(), laag.Kleur, fontSize);
            }
        }
        public static void PrintTerrainModern(this PaintEventArgs paint, TerrainType terrainType, int x, int y, int tile, Layer laag, float[,] data, CheckBox check, CheckBox checkColorShift, int max)
        {
            Random random = new Random();
            if (checkColorShift.Checked)
            {
                paint.Graphics.DrawRectangle(new Pen(ColorByShift(laag.Kleur, max, random), tile), x * tile, y * tile, tile, tile);
            }
            else
            {
                paint.Graphics.DrawRectangle(new Pen(laag.Kleur, tile), x * tile, y * tile, tile, tile);
            }
            if (check.Checked)
            {
                paint.Graphics.DrawString(((int)data[x, y]).ToString(), new Font("Arial", tile / 6), new SolidBrush(Color.Black), x * tile, y * tile);
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

        public static Color ColorByShift(Color kleur, int max, Random random)
        {

            return Color.FromArgb(kleur.ToArgb() + random.Next(0, max));
        }
    }
}