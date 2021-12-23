namespace LogicLayer
{
    public class Tile
    {
        public TerrainType TerrainType;

        public Tile() : this(TerrainType.Undefined)
        {
        }
        public Tile(TerrainType terrainType)
        {
            TerrainType = terrainType;
        }
    }
}
