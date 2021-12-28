﻿namespace LogicLayer
{
    public class Map
    {
        public Map()
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

        public int Width { get; set; }
        public int Height { get; set; }
        public float Scale { get; set; }
        public float[,]? NoiseValues { get; set; }
        public string Seed { get; set; }
        public Tile[,] Tiles { get; set; }

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
