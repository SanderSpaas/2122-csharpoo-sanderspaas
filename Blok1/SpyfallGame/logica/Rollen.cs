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
    private const String DEFAULTDATA = @"data\SpyfallData.csv";

    //public int id { get; set; }

    //constructor voor rollen classe
    //voorlopig nog overbodig
    //public Rollen(String naam)
    //{
    //    this.naam = naam;
    //}

    public String Naam { get => naam; set => naam = value; }

    public override string ToString()
    {
        return naam.ToString();
    }

    //logica gaan schrijven waarmee de rollen in een lijst gezet kunnen gaan worden 
    //eerst een random gaan genereren om te zien welke lijn we uitlezen en alleen die data gebruiken???

    private static String TestData(String filePath)
    {
        //eerst kijken of het bestand wel bestaat
        try
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Het bestand bestaat niet op de opgegeven locatie: {0}", filePath);
        }
        catch (FileNotFoundException)
        {
            return DEFAULTDATA;
        }


        //kijken of de data die er instaat een geldige opbouw heeft
        try
        {
            //alle lijnen in het document gaan lezen
            var lines = File.ReadAllLines(filePath);
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Het bestand bestaat niet op de opgegeven locatie: {0}", filePath);
        }
        catch (FileNotFoundException)
        {
            return DEFAULTDATA;
        }
        //kijken of er niets leeg is in de data 

        return filePath;

    }


    public static void KiesRandomRol(String filePath)
    {
        
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

        try
        {
            //de lijn gaan splitsen op basis van een delimiter in een tijdelijke arraylist
            rollenListString.AddRange(randomLijn.Split(';'));
        }
        catch (Exception)
        {
            throw new ArgumentException("Het bestand heeft een incorrecte data-opbouw");
        }
        //door de tijdelijke array gaan loopen en objecten gaan aanmaken met de data en in de echte array gaan zetten
        int counter = 0;
        foreach (String rol in rollenListString)
        {
            //eerste element als locatie gaan zetten
            if (counter++ == 0)
            {
                if (rol != "" && rol != null)
                {
                    locatie = rol;
                }
                else
                {
                    throw new ArgumentException("Het bestand heeft een incorrecte data-opbouw");
                }
                
            }
            else
            {
                ////object gaan aanmaken
                //Rollen rol = new Rollen(naam);
                //object in de lijst gaan zetten
                //gaan nakijken dat de rol niet leeg is voordat we ze toevoegen
                if (rol != "" && rol != null)
                {
                    rollenList.Add(rol);
                }
            }
        }
        //als er toenvallig lege elementen in de array geraakt zijn deze er uit gaan halen
        //een tijdelijke array gaan maken om de juiste data in te zetten we kunnen namelijk niet een array bewerken en er tegelijk doorloopen
        //ArrayList rollenListBewerkt = new ArrayList();
        //foreach (String  rol in rollenList)
        //{
        //    if (rol != "" && rol != null)
        //    {
        //        rollenListBewerkt.Add(rol);
        //    }
        //}
        ////de originele array gaan gelijkzetten met de bewerkte array
        //rollenList = rollenListBewerkt;

    }


    public static ArrayList RollenList { get; set; }
    public static string Locatie { get => locatie; set => locatie = value; }
}
