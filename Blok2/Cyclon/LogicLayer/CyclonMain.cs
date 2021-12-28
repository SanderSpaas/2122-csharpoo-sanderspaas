using Globals.Interfaces;

namespace LogicLayer
{
    public class CyclonMain : ILogic
    {
        private readonly IData _data;
        private Random _random = new Random();
        public CyclonMain(/*IData data*/)
        {
            //_data = data;
        }
        public Map Generate(int width, int height, float scale, int deepWater, int water, int sand, int grass, int hill, string seed, List<Layer> layers, bool inverted, bool spatialOffset)
        {
            var map = new Map(width, height, scale, seed);
            map.NoiseValues = GenerateNoise(map);
            for (int x = 0; x < map.NoiseValues.GetLength(0); x++)
            {
                for (int y = 0; y < map.NoiseValues.GetLength(1); y++)
                {
                    map.Tiles[x, y].Laag = DetermineTerrain(map.NoiseValues[x, y], deepWater, water, sand, grass, hill, layers);
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
                    var laag = new Layer((TerrainType)Terrain, kleuren[index], hoogtes[index], drawings[index]);
                    layers.Add(laag);
                    index++;
                }
            }
            return layers;
        }

        private Layer DetermineTerrain(float noiseValue, int deepWater, int water, int sand, int grass, int hill, List<Layer> layers)
        {
            switch (noiseValue)
            {
                case var noise when noise <= deepWater:
                    return layers[0];
                case var noise when noise <= water:
                    return layers[1];
                case var noise when noise <= sand:
                    return layers[2];
                case var noise when noise <= grass:
                    return layers[3];
                case var noise when noise <= hill:
                    return layers[4];
                default:
                    return layers[5];
            }
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
        public void SpatialOffset(float[,] data, Map map)
        {
            SimplexNoise.Noise.Seed = _random.Next();
            float[,]? noiseValues = SimplexNoise.Noise.Calc2D(map.Width, map.Height, map.Scale);
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    data[x, y] = (data[x, y] + noiseValues[x, y]) / 2;
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
                    map.Tiles[x, y].Color = ControlPaint.Dark(map.Tiles[x, y].Color, map.NoiseValues[x, y] / (255 * 2));
                }
            }
        }
    }
}