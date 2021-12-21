namespace LogicLayer
{
    public class Map
    {
        public Tile[,] Tiles;

        public int Width;

        public int Height;

        public Map() : this(15, 15)
        {
        }

        public Map(int width, int height)
        {
            Width = width;
            Height = height;

            Tiles = new Tile[width, height];
            SetDefaultMap();
        }

        private void SetDefaultMap()
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
