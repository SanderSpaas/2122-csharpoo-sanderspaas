namespace LogicLayer
{
    public abstract class CircleGradient
    {
        public float[,] MakeCircleGradient(Map map)
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
