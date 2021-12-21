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
        //people make some fking noise 
        public Map Generate(int width, int height, float scale, int DeepWater, int Water, int Sand, int Grass, int Hill)
        {
            var map = new Map(width, height);
            var noiseValues = GenerateNoise(width, height, scale);

            for (int x = 0; x < noiseValues.GetLength(0); x++)
            {
                for (int y = 0; y < noiseValues.GetLength(1); y++)
                {
                    map.Tiles[x, y].TerrainType = DetermineTerrain(noiseValues[x, y], DeepWater, Water, Sand, Grass, Hill);
                }
            }

            return map;
        }

        private TerrainType DetermineTerrain(float noiseValue, int DeepWater, int Water, int Sand, int Grass, int Hill)
        {
            switch (noiseValue)
            {
                case var noise when noise <= DeepWater:
                    return TerrainType.DeepWater;
                case var noise when noise <= Water:
                    return TerrainType.Water;
                case var noise when noise <= Sand:
                    return TerrainType.Sand;
                case var noise when noise <= Grass:
                    return TerrainType.Grass;
                case var noise when noise <= Hill:
                    return TerrainType.Hill;
                default:
                    return TerrainType.Mountain;
            }
        }

        public float[,] GenerateNoise(int width, int height, float scale)
        {
            var random = new Random();
            SimplexNoise.Noise.Seed = random.Next();
            float[,]? noiseValues = SimplexNoise.Noise.Calc2D(width, height, scale);

            return noiseValues;
        }
    }
}