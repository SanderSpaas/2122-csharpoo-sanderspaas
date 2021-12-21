namespace LogicLayer
{
    public class Tile
    {
        public TerrainType TerrainType;

        public Tile() : this(TerrainType.None)
        {
        }
        public Tile(TerrainType terrainType)
        {
            TerrainType = terrainType;
        }
    }
}
