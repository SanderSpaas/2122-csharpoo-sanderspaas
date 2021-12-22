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
        public MainForm(ILogic logic)
        {
            _logic = logic;
            InitializeComponent();
            Icon = new Icon("Assets/Cyclon.ico");
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            _map = _main.Generate((int)HeightData.Value, (int)WidthData.Value, (float)ScaleData.Value / 100, DeapSeaData.Value, SeaData.Value, BeachData.Value, GrassData.Value, HillData.Value);
            _bitmap = new Bitmap(_map.Height * 32, _map.Width * 32);
            _data = _main.GenerateNoise((int)HeightData.Value, (int)WidthData.Value, (float)ScaleData.Value / 100);
            _generated = true;
            _tile = (int)TileSizeData.Value;

            if (MapModern.Visible)
            {
                Refresh();
            }
            else if (MapLegacy.Visible)
            {
                MapLegacy.Clear();
                for (int y = 0; y < _map.Height; y++)
                {
                    for (int x = 0; x < _map.Width; x++)
                    {
                        Extensions.PrintTerrainCharacter(MapLegacy, _map.Tiles[x, y].TerrainType, _tile / 4);
                    }
                    Extensions.AppendText(MapLegacy, "\r\n", Color.Blue, _tile / 4);
                }
            }

            //var bitmap = new Bitmap(grid.GetLength(0) * 32, grid.GetLength(1) * 32);

            //using (var g = Graphics.FromImage(bitmap))
            //{
            //    for (int x = 0; x < grid.GetLength(0); x++)
            //    {
            //        for (int y = 0; y < grid.GetLength(1); y++)
            //        {
            //            g.DrawImage(grid[x, y].Image, x * 32, y * 32);
            //            //g.DrawString(((int)noiseValues[x, y]).ToString(), new Font("Arial", 10), Brushes.White, x * 32, y * 32);
            //        }
            //    }
            //}

        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            if (_generated)
            {
                for (int y = 0; y < _map.Height; y++)
                {
                    for (int x = 0; x < _map.Width; x++)
                    {
                        Extensions.PrintTerrainModern(e, _map.Tiles[x, y].TerrainType, x, y, _tile);
                    }
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

    }

    public static class Extensions
    {
        public static void PrintTerrainCharacter(this RichTextBox box, TerrainType terrainType, int fontSize)
        {
            switch (terrainType)
            {
                case TerrainType.DeepWater:
                    Extensions.AppendText(box, "██", Color.DarkBlue, fontSize);
                    break;
                case TerrainType.Water:
                    Extensions.AppendText(box, "🌊", Color.Blue, fontSize);
                    break;
                case TerrainType.Sand:
                    Extensions.AppendText(box, "▒▒", Color.Yellow, fontSize);
                    break;
                case TerrainType.Grass:
                    Extensions.AppendText(box, "██", Color.Green, fontSize);
                    break;
                case TerrainType.Hill:
                    Extensions.AppendText(box, "██", Color.DarkGreen, fontSize);
                    break;
                case TerrainType.Mountain:
                    Extensions.AppendText(box, "██", Color.Gray, fontSize);
                    break;
                default:
                    Extensions.AppendText(box, "  ", Color.White, fontSize);
                    break;
            }
        }
        public static void PrintTerrainModern(this PaintEventArgs paint, TerrainType terrainType, int x, int y, int _tile)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 32);
            Pen greenPen = new Pen(Color.Green, 32);
            Pen yellowPen = new Pen(Color.Yellow, 32);
            Pen DarkGreenPen = new Pen(Color.DarkGreen, 32);
            Pen DarkBluePen = new Pen(Color.DarkBlue, 32);
            Pen BluePen = new Pen(Color.Blue, 32);
            Pen GrayPen = new Pen(Color.Gray, 32);
            switch (terrainType)
            {
                case TerrainType.DeepWater:
                    //paint.Graphics.DrawString(((int)datas[x, y]).ToString(), new Font("Arial", 10), Brushes.Black, x * 32, y * 32);
                    paint.Graphics.DrawRectangle(DarkBluePen, x * _tile, y * _tile, _tile, _tile);
                    break;
                case TerrainType.Water:
                    paint.Graphics.DrawRectangle(BluePen, x * _tile, y * _tile, _tile, _tile);
                    break;
                case TerrainType.Sand:
                    paint.Graphics.DrawRectangle(yellowPen, x * _tile, y * _tile, _tile, _tile);
                    break;
                case TerrainType.Grass:
                    paint.Graphics.DrawRectangle(greenPen, x * _tile, y * _tile, _tile, _tile);
                    break;
                case TerrainType.Hill:
                    paint.Graphics.DrawRectangle(DarkGreenPen, x * _tile, y * _tile, _tile, _tile);
                    break;
                case TerrainType.Mountain:
                    paint.Graphics.DrawRectangle(GrayPen, x * _tile, y * _tile, _tile, _tile);
                    break;
                default:
                    paint.Graphics.DrawRectangle(blackPen, x * _tile, y * _tile, _tile, _tile);
                    break;
            }
        }
        public static void AppendText(this RichTextBox box, string text, Color color, int fontSize)
        {
            Font currentFont = box.SelectionFont;
            FontStyle newFontStyle = (FontStyle)(currentFont.Style | FontStyle.Bold);
            box.SelectionFont = new Font(currentFont.FontFamily, fontSize, newFontStyle);
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}