using LogicLayer;

namespace DataAccessLayer
{
    public interface IData
    {
        void CheckOrCreate();
        void SaveSeed(Seed seed);
        List<Seed> ReadSeeds();

    }
}