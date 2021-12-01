using System;

public class Rollen
{
    //private const int id;
    private const String naam;
    public static List<Rollen> rollenList = new ArrayList<>();

    //public int id { get; set; }

    public String naam { get; set; }

    //logica gaan schrijven waarmee de rollen in een lijst gezet kunnen gaan worden 
    //eerst een random gaan genereren om te zien welke lijn we uitlezen en alleen die data gebruiken???


    //een random gaan genereren met als upper limit het aantal lijnen in ons data document
    //de lijnen gaan tellen
    int lineCount = File.ReadLines(@"data\SpyfallData.csv").Count();
    Random random = new Random();
    //random gaan genereren
    int randomGetal = random.Next(0, lineCount);

    var lines = System.IO.File.ReadAllLines(@"data\SpyfallData.csv");
    String line = lines[randomGetal];
    public String line { get; set; }
}
