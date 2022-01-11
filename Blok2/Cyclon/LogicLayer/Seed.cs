namespace LogicLayer;

public class Seed
{
    public Seed()
    {

    }
    public Seed(string seedName, string name, string description)
    {
        SeedName = seedName;
        Name = name;
        Description = description;
    }
    public string SeedName { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

}
