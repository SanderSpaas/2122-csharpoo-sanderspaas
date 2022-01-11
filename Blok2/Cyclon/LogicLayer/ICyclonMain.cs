namespace LogicLayer
{
    public interface ICyclonMain
    {
        Map Generate(int width, int height, float scale, string seed, List<Layer> layers);
        void SetMap();
        List<Layer> MakeLayers(Color[] kleuren, int[] hoogtes, char[] drawings);
        float[,] GenerateNoise(string seed, int width, int height, float scale);
        void SpatialOffset(float[,] data, Map map, List<Layer> layers, int aantalKeer);
        void Invert(float[,] data, Map map);
        void ColorShift(Map map, int max);
        void Shading(Map map);
        void Islands(Map map, List<Layer> layers);
    }
}