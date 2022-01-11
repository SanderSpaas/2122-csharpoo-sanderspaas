namespace LogicLayer
{
    public class Map : ICyclonMain
    {
        public Map()
        {
        }

        public Map(int width, int height, float scale, string seed, float[,] noiseValues)
        {
            Width = width;
            Height = height;
            Scale = scale;
            Tiles = new Tile[width, height];
            Seed = seed;
            NoiseValues = noiseValues;
            SetMap();
        }

        //copy constructor
        //public Map(Map map, float[,] noiseValues)
        //{
        //    Width = map.Width;
        //    Height = map.Height;
        //    Scale = map.Scale;
        //    Tiles = map.Tiles;
        //    Seed = map.Seed;
        //    NoiseValues = noiseValues;
        //}

        public int Width { get; set; }
        public int Height { get; set; }
        public float Scale { get; set; }
        public float[,] NoiseValues { get; set; }
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

        public Map Generate(int width, int height, float scale, string seed, List<Layer> layers)
        {
            var map = new Map(width, height, scale, seed, GenerateNoise(seed, width, height, scale));
            for (int x = 0; x < map.Width; x++)
            {
                for (int y = 0; y < map.Height; y++)
                {
                    map.Tiles[x, y].Laag = DetermineTerrain(map.NoiseValues[x, y], layers);
                    map.Tiles[x, y].Color = map.Tiles[x, y].Laag.Kleur;
                }
            }
            return map;
        }

        public List<Layer> MaakLagen(Color[] kleuren, int[] hoogtes, char[] drawings)
        {
            var layers = new List<Layer>();
            int index = 0;
            foreach (TerrainType Terrain in Enum.GetValues(typeof(TerrainType)))
            {
                if (Terrain != TerrainType.Undefined)
                {
                    var laag = new Layer(Terrain, kleuren[index], hoogtes[index], drawings[index]);
                    layers.Add(laag);
                    index++;
                }
            }
            return layers;
        }

        private Layer DetermineTerrain(float noiseValue, List<Layer> layers)
        {
            return noiseValue switch
            {
                var noise when noise <= layers[0].Height => layers[0],
                var noise when noise <= layers[1].Height => layers[1],
                var noise when noise <= layers[2].Height => layers[2],
                var noise when noise <= layers[3].Height => layers[3],
                var noise when noise <= layers[4].Height => layers[4],
                _ => layers[5],
            };
        }

        public float[,] GenerateNoise(string seed, int widht, int height, float scale)
        {
            if (!Int32.TryParse(seed, out int seedNumber))
            {
                //als de seed text is dan veranderen we het naar een getal
                seedNumber = seed.GetHashCode();
            }
            SimplexNoise.Noise.Seed = seedNumber;
            return SimplexNoise.Noise.Calc2D(widht, height, scale);
        }
        public void SpatialOffset(float[,] data, Map map, List<Layer> layers, int aantalKeer)
        {
            Random random = new Random();
            for (int i = 0; i < aantalKeer; i++)
            {
                SimplexNoise.Noise.Seed = random.Next();
                float[,]? noiseValues = SimplexNoise.Noise.Calc2D(map.Width, map.Height, map.Scale);
                for (int y = 0; y < map.Height; y++)
                {
                    for (int x = 0; x < map.Width; x++)
                    {
                        data[x, y] += +noiseValues[x, y];
                    }
                }
            }
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    data[x, y] = (data[x, y] / aantalKeer);
                    map.Tiles[x, y].Laag = DetermineTerrain(data[x, y], layers);
                    map.Tiles[x, y].Color = map.Tiles[x, y].Laag.Kleur;
                }
            }
            map.NoiseValues = data;

        }
        public void Invert(float[,] data, Map map)
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    data[x, y] = 255 - data[x, y];
                }
            }
            map.NoiseValues = data;
        }

        public void ColorShift(Map map, int max)
        {
            Random random = new Random();
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    map.Tiles[x, y].Color = Color.FromArgb(map.Tiles[x, y].Laag.Kleur.ToArgb() + random.Next(0, max));
                }
            }
        }
        public void Shading(Map map)
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    map.Tiles[x, y].Color = ControlPaint.Light(ControlPaint.Dark(map.Tiles[x, y].Color, (255 - map.NoiseValues[x, y]) / (255 * 2)), (float)0.20);
                }
            }
        }
        public void Islands(Map map, List<Layer> layers)
        {
            float[,] tempArray = CircleGradient(map);
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    map.NoiseValues[x, y] = map.NoiseValues[x, y] - tempArray[x, y];
                    if (map.NoiseValues[x, y] < -255)
                    {
                        map.NoiseValues[x, y] = -250;
                    }
                    map.Tiles[x, y].Laag = DetermineTerrain(map.NoiseValues[x, y], layers);
                    map.Tiles[x, y].Color = map.Tiles[x, y].Laag.Kleur;
                }
            }
        }
        public float[,] CircleGradient(Map map)
        {
            float[,] data = new float[map.Width, map.Height];
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    float distanceX = (float)Math.Pow(map.Width / 2 - x, 2);
                    float distanceY = (float)Math.Pow(map.Height / 2 - y, 2);
                    data[x, y] = (float)Math.Sqrt(distanceX + distanceY) / map.Width * 510;
                }
            }
            return data;
        }
    }
}
