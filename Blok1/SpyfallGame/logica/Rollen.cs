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
    private const String DEFAULTDATA = @"data\SpyfallData.csv";

    public static bool TestData(String filePath)
    {
        //een tijdelijke arraylist om data om na te kijken in te zetten
        ArrayList checkList = new ArrayList();
        //eerst kijken of het bestand wel bestaat
        try
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Het bestand bestaat niet op de opgegeven locatie: {0}", filePath);
        }
        catch (FileNotFoundException)
        {
            return false;
        }

        //kijken of de data die er instaat een geldige opbouw heeft
        try
        {
            //alle lijnen in het document gaan lezen
            var lines = File.ReadAllLines(filePath);
            foreach (String line in lines)
            {
                checkList.AddRange(line.Split(';'));
                if (checkList == null)
                {
                    throw new ArgumentException("Het bestand heeft een incorrecte data-opbouw");
                }
                //lijst gaan clearen zodat we de volgende lijn kunnen gaan checken
                checkList.Clear();
            }
        }
        catch (ArgumentException)
        {
            return false;
        }
        //kijken of er geen lege velden zijn in de data
        try
        {
            //alle lijnen in het document gaan lezen
            var lines = File.ReadAllLines(filePath);
            foreach (String line in lines)
            {
                checkList.AddRange(line.Split(';'));
                foreach (String rol in checkList)
                {
                    //gaan checken of de elementen leeg zijn
                    if (rol == "" || rol == null)
                    {
                        throw new ArgumentException("Het bestand heeft een incorrecte data-opbouw, de locatie of rol kan niet leeg zijn");
                    }
                }
                //lijst gaan clearen zodat we de volgende lijn kunnen gaan checken
                checkList.Clear();
            }
        }
        catch (ArgumentException)
        {
            return false;
        }
        return true;
    }


    public static void KiesRandomRol(String filePath)
    {
        //tijdelijke arraylist
        ArrayList rollenListString = new ArrayList();

        Random random = new Random();
        //een random gaan genereren met als upper limit het aantal lijnen in ons data document
        int randomGetal = random.Next(0, File.ReadLines(filePath).Count());
        //alle lijnen in het document gaan lezen
        var lines = File.ReadAllLines(filePath);
        //random lijn gaan opslaan in variable randomLijn 
        String randomLijn = lines[randomGetal];

        //de lijn gaan splitsen op basis van een delimiter in een tijdelijke arraylist
        rollenListString.AddRange(randomLijn.Split(';'));

        //door de tijdelijke array gaan loopen en objecten gaan aanmaken met de data en in de echte array gaan zetten
        int counter = 0;
        foreach (String rol in rollenListString)
        {
            //eerste element als locatie gaan zetten
            if (counter++ == 0)
            {
                locatie = rol;
            }
            else
            {
                //object in de lijst gaan zetten
                rollenList.Add(rol);
            }
        }
    }


    public static ArrayList RollenList { get; set; }
    public static string Locatie { get => locatie; set => locatie = value; }
}
