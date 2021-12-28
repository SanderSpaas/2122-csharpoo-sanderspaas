namespace LogicLayer
{
    public class Map
    {
        public Tile[,] Tiles;

        private int _width;
        private int _height;
        private float _scale;
        private float[,]? _noiseValues;
        private string _seed;

        public Map() /*: this(15, 15)*/
        {
        }

        public Map(int width, int height, float scale, string seed)
        {
            Width = width;
            Height = height;
            Scale = scale;
            Tiles = new Tile[width, height];
            Seed = seed;
            SetMap();
        }

        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }
        public float Scale { get => _scale; set => _scale = value; }
        public float[,]? NoiseValues { get => _noiseValues; set => _noiseValues = value; }
        public string Seed { get => _seed; set => _seed = value; }

        public void SetMap()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Tiles[x, y] = new Tile();
                }
            }
        }
    }
}
