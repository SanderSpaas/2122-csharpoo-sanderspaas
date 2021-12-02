using System;
using System.Collections;
using System.IO;
using System.Linq;

public class Rollen
{
    //private const int id;
    private string naam;
    private static string locatie;
    public static ArrayList rollenList = new ArrayList();
    public static ArrayList rollenListString = new ArrayList();
 

    //public int id { get; set; }

    //constructor voor rollen classe
    public Rollen(String naam)
    {
        this.naam = naam;
    }

    public String Naam { get => naam; set => naam = value; }

    public override string ToString()
    {
        return naam.ToString();
    }

    //logica gaan schrijven waarmee de rollen in een lijst gezet kunnen gaan worden 
    //eerst een random gaan genereren om te zien welke lijn we uitlezen en alleen die data gebruiken???




    public static void KiesRandomRol(String filePath)
    {
        //gaan kijken of het filePath bestaat anders een exception gaan thrownen
        if (!File.Exists(filePath))
        {
            throw new ArgumentException("File does not exist at given location: {0}", filePath);
        }
        //een random gaan genereren met als upper limit het aantal lijnen in ons data document
        //de lijnen gaan tellen
        int lineCount = File.ReadLines(filePath).Count();
        Random random = new Random();
        //random gaan genereren
        int randomGetal = random.Next(0, lineCount);
        //alle lijnen in het document gaan lezen
        var lines = File.ReadAllLines(filePath);
        //random lijn gaan opslaan in variable randomLijn 
        String randomLijn = lines[randomGetal];
        //de lijn gaan splitsen op basis van een delimiter in een tijdelijke arraylist
        rollenListString.AddRange(randomLijn.Split(';'));
        //door de tijdelijke array gaan loopen en objecten gaan aanmaken met de data en in de echte array gaan zetten
        int counter = 0;
        foreach (String naam in rollenListString)
        {
            //eerste element als locatie gaan zetten
            if (counter++ == 0)
            {
                locatie = naam;
            }
            else
            {
                ////object gaan aanmaken
                //Rollen rol = new Rollen(naam);
                //object in de lijst gaan zetten
                rollenList.Add(naam);
            }


        }


    }


    public static ArrayList RollenList { get; set; }
    public static string Locatie { get => locatie; set => locatie = value; }
}
