using System.Collections;

public class Rollen
{
    private static string _Locatie;
    public static ArrayList rollenList = new ArrayList();

    public static void KiesRandomRol(String filePath)
    {
        //tijdelijke arraylist
        ArrayList rollenListString = new ArrayList();
        Random random = new Random();
        int randomGetal = random.Next(0, File.ReadLines(filePath).Count());
        //alle lijnen in het document gaan lezen
        var lines = File.ReadAllLines(filePath);

        //de random gekozen lijn gaan splitsen op basis van een delimiter in een tijdelijke arraylist
        rollenListString.AddRange(lines[randomGetal].Split(';'));

        //de locatie gaan vastzetten en daarna verwijderen uit de array
        _Locatie = rollenListString[0].ToString();
        rollenListString.RemoveAt(0);

        //door de tijdelijke array gaan loopen en objecten gaan aanmaken met de data en in de echte array gaan zetten
        foreach (String rol in rollenListString)
        {
            //object in de lijst gaan zetten
            rollenList.Add(rol);
        }
    }

    public static ArrayList RollenList { get => rollenList; set => rollenList = value; }
    public static string Locatie { get => _Locatie; set => _Locatie = value; }
}
