using System;
using System.Collections;
using System.IO;
using System.Linq;

public class Rollen
{
    private static string locatie;
    public static ArrayList rollenList = new ArrayList();

    public static void KiesRandomRol(String filePath)
    {
        //tijdelijke arraylist
        ArrayList rollenListString = new ArrayList();

        Random random = new Random();
        //een random gaan genereren met als maximum het aantal lijnen in ons data document
        int randomGetal = random.Next(0, File.ReadLines(filePath).Count());
        //alle lijnen in het document gaan lezen
        var lines = File.ReadAllLines(filePath);

        //de random gekozen lijn gaan splitsen op basis van een delimiter in een tijdelijke arraylist
        rollenListString.AddRange(lines[randomGetal].Split(';'));

        //de locatie gaan vastzetten en daarna verwijderen uit de array
        locatie = rollenListString[0].ToString();
        rollenListString.RemoveAt(0);

        //door de tijdelijke array gaan loopen en objecten gaan aanmaken met de data en in de echte array gaan zetten
        foreach (String rol in rollenListString)
        {
            //object in de lijst gaan zetten
            rollenList.Add(rol);
        }
    }

    public static ArrayList RollenList { get; set; }
    public static string Locatie { get => locatie; set => locatie = value; }
}
