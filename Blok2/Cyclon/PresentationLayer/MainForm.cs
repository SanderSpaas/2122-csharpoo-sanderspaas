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
            textBox1.Clear();
            _bitmap = new Bitmap(_map.Height * 32, _map.Width * 32);
            _data = _main.GenerateNoise((int)HeightData.Value, (int)WidthData.Value, (float)ScaleData.Value / 100);
            _generated = true;
            _tile = (int)TileSizeData.Value;
            //using (var g = Graphics.FromImage(bitmap))
            //{
            //    for (int y = 0; y < map.Height; y++)
            //    {
            //        for (int x = 0; x < map.Width; x++)
            //        {
            //            Extensions.PrintTerrainCharacter(textBox1, map.Tiles[x, y].TerrainType);
            //            //g.DrawImage(grid[x, y].Image, x * 32, y * 32);
            //            g.DrawString(((int)datas[x, y]).ToString(), new Font("Arial", 25000), Brushes.Black, x, y);
            //            g.DrawRectangle(blackPen, x, y, 200, 200);
            //        }
            //        Extensions.AppendText(textBox1, "\r\n", Color.Blue);
            //    }
            //}

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
            Refresh();
        }
        //List<Rectangle> _rectangles = new List<Rectangle>();
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    locationX = locationX + 20;
        //    locationY = locationY + 20;
        //    var rectangle = new Rectangle(locationX, locationY, 50, 30));
        //    this._rectangles.Add(rectangle);
        //    this.Invalidate(); // force Redraw the form
        //}

        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    foreach (var rectangle in this._rectangles)
        //    {
        //        e.Graphics.DrawRectangle(Pens.Black, rectangle);
        //    }
        //}

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            //using (var g = Graphics.FromImage(bitmap))
            //{
            if (_generated)
            {
                for (int y = 0; y < _map.Height; y++)
                {
                    for (int x = 0; x < _map.Width; x++)
                    {
                        //g.DrawImage(grid[x, y].Image, x * 32, y * 32);
                        //e.Graphics.DrawString(((int)_data[x, y]).ToString(), new Font("Arial", 10), Brushes.Black, x * 32, y * 32);
                        Extensions.PrintTerrainCharacterGrid(e, _map.Tiles[x, y].TerrainType, x, y, _tile);
                    }
                    Extensions.AppendText(textBox1, "\r\n", Color.Blue);
                }
            }

            //}
        }
    }

    public static class Extensions
    {
        public static void PrintTerrainCharacter(this RichTextBox box, TerrainType terrainType)
        {
            switch (terrainType)
            {
                case TerrainType.DeepWater:
                    Extensions.AppendText(box, "█", Color.DarkBlue);
                    break;
                case TerrainType.Water:
                    Extensions.AppendText(box, "█", Color.Blue);
                    break;
                case TerrainType.Sand:
                    Extensions.AppendText(box, "▒", Color.Yellow);
                    break;
                case TerrainType.Grass:
                    Extensions.AppendText(box, "█", Color.Green);
                    break;
                case TerrainType.Hill:
                    Extensions.AppendText(box, "█", Color.DarkGreen);
                    break;
                case TerrainType.Mountain:
                    Extensions.AppendText(box, "█", Color.Gray);
                    break;
                default:
                    Extensions.AppendText(box, " ", Color.White);
                    break;
            }
        }
        public static void PrintTerrainCharacterGrid(this PaintEventArgs paint, TerrainType terrainType, int x, int y, int _tile)
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
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}