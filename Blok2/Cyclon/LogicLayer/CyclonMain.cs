using Globals.Interfaces;

namespace LogicLayer
{
    public class CyclonMain : ILogic
    {
        private readonly IData _data;
        private readonly Random _random = new Random();
        public CyclonMain(IData data)
        {
            _data = data;
        }
        public CyclonMain()
        {
        }
        public Map Generate(int width, int height, float scale, string seed, List<Layer> layers)
        {
            var map = new Map(width, height, scale, seed);
            map.NoiseValues = GenerateNoise(map);
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
                if (Terrain.ToString() != "Undefined")
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

        public float[,] GenerateNoise(Map map)
        {
            if (!Int32.TryParse(map.Seed, out int seedNumber))
            {
                //als de seed text is dan veranderen we het naar een getal
                seedNumber = map.Seed.GetHashCode();
            }
            SimplexNoise.Noise.Seed = seedNumber;
            return SimplexNoise.Noise.Calc2D(map.Width, map.Height, map.Scale);
        }
        public void SpatialOffset(float[,] data, Map map, List<Layer> layers, int aantalKeer)
        {
            for (int i = 0; i < aantalKeer; i++)
            {
                SimplexNoise.Noise.Seed = _random.Next();
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
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    map.Tiles[x, y].Color = Color.FromArgb(map.Tiles[x, y].Laag.Kleur.ToArgb() + _random.Next(0, max));
                }
            }
        }
        public void Shading(Map map)
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    map.Tiles[x, y].Color = ControlPaint.Light(ControlPaint.Dark(map.Tiles[x, y].Color, (255 - map.NoiseValues[x, y]) / (255 * 2)), (float)0.15);
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
            for (int x = 0; x < map.NoiseValues.GetLength(0); x++)
            {
                for (int y = 0; y < map.NoiseValues.GetLength(1); y++)
                {

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