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
        public Map Generate(int width, int height, float scale, int deepWater, int water, int sand, int grass, int hill)
        {
            var map = new Map(width, height);
            var noiseValues = GenerateNoise(width, height, scale);

            for (int x = 0; x < noiseValues.GetLength(0); x++)
            {
                for (int y = 0; y < noiseValues.GetLength(1); y++)
                {
                    map.Tiles[x, y].TerrainType = DetermineTerrain(noiseValues[x, y], deepWater, water, sand, grass, hill);
                }
            }

            return map;
        }

        private TerrainType DetermineTerrain(float noiseValue, int deepWater, int water, int sand, int grass, int hill)
        {
            switch (noiseValue)
            {
                case var noise when noise <= deepWater:
                    return TerrainType.DeepWater;
                case var noise when noise <= water:
                    return TerrainType.Water;
                case var noise when noise <= sand:
                    return TerrainType.Sand;
                case var noise when noise <= grass:
                    return TerrainType.Grass;
                case var noise when noise <= hill:
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