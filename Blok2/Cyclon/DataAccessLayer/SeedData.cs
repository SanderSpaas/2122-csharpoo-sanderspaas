using LogicLayer;
using System.Diagnostics;
using System.Text.Json;

namespace DataAccessLayer
{
    public class SeedData
    {
        private static List<Seed> _seedData = new();
        private const string _filename = @"Assets/CyclonSeeds.json";
        public static void CheckOrCreate()
        {
            try
            {
                if (!File.Exists(_filename))
                {
                    File.Create(_filename);
                }
            }
            catch (IOException e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                Debug.WriteLine($"The file at location: {_filename} exists.");
            }
        }

        public void SaveSeed(Seed seed)
        {
            CheckOrCreate();
            Debug.WriteLine("JSON: " + JsonSerializer.Serialize(seed));
            File.AppendAllText(_filename, JsonSerializer.Serialize(seed) + Environment.NewLine);
        }

        public List<Seed> ReadSeeds()
        {
            _seedData.Clear();
            if (new FileInfo(_filename).Length > 0)
            {
                try
                {
                    CheckOrCreate();
                    using var reader = new StreamReader(_filename);
                    while (!reader.EndOfStream)
                    {
                        string seedData = reader.ReadLine();
                        Debug.WriteLine("JSON: " + seedData);
                        Seed seed = JsonSerializer.Deserialize<Seed>(seedData);
                        _seedData.Add(seed);
                    }
                    return _seedData;
                }
                catch (IOException e)
                {
                    Debug.WriteLine($"Error reading the file: {_filename}");
                    Debug.WriteLine(e.Message);
                    return null;
                }
            }
            return null;
        }
    }
}
