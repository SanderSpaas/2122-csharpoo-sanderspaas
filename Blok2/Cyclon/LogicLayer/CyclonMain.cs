using Globals.Interfaces;

namespace LogicLayer
{
    public class CyclonMain : ILogic
    {
        private readonly IData _data;
        public CyclonMain(/*IData data*/)
        {
            //_data = data;
        }
        public Map Generate(int width, int height, float scale, int deepWater, int water, int sand, int grass, int hill, int seed, List<Layer> layers, bool inverted, bool spatialOffset)
        {
            var map = new Map(width, height);
            float[,]? noiseValues = GenerateNoise(width, height, scale, seed, inverted, spatialOffset);
            for (int x = 0; x < noiseValues.GetLength(0); x++)
            {
                for (int y = 0; y < noiseValues.GetLength(1); y++)
                {
                    map.Tiles[x, y].Laag = DetermineTerrain(noiseValues[x, y], deepWater, water, sand, grass, hill, layers);
                }
            }
            return map;
        }

        public List<Layer> MaakLagen(Color[] kleuren, int[] hoogtes, char[] drawings)
        {
            var layers = new List<Layer>();
            int index = 0;
            foreach (var Terrain in Enum.GetValues(typeof(TerrainType)))
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

        public float[,] GenerateNoise(int width, int height, float scale, int seed, bool inverted, bool spatialOffset)
        {
            SimplexNoise.Noise.Seed = seed;
            float[,]? noiseValues = SimplexNoise.Noise.Calc2D(width, height, scale);
            if (inverted)
            {
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        noiseValues[x, y] = 255 - noiseValues[x, y];
                    }
                }
            }
            if (spatialOffset)
            {
                SimplexNoise.Noise.Seed = seed + 1;
                float[,]? noiseValues2 = SimplexNoise.Noise.Calc2D(width, height, scale);
                SimplexNoise.Noise.Seed = seed + 2;
                float[,]? noiseValues3 = SimplexNoise.Noise.Calc2D(width, height, scale);
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        noiseValues[x, y] = (noiseValues[x, y] + noiseValues2[x, y] + noiseValues3[x, y]) / 3;
                    }
                }
            }
            return noiseValues;
        }
    }
}