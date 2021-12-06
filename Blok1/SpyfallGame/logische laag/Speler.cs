using System.Collections;

public class Speler
{
    private string rol;
    private string locatie;
    private static int aantalspelers;
    private static int aantalspionnen;
    public static ArrayList Spelers = new ArrayList();

    public Speler(string rol, string locatie)
    {
        this.rol = rol;
        this.locatie = locatie;
    }

    public string Rol
    {
        get { return rol; }
        set { rol = value; }
    }

    public static void addSpeler(Speler speler)
    {
        Spelers.Add(speler);
    }
    public string GetRol()
    {
        return rol;
    }
    public string GetLocatie()
    {
        return locatie;
    }

    public static int GetAantalspelers()
    {
        return aantalspelers;
    }

    public static void SetAantalspelers(int value)
    {
        aantalspelers = value;
    }

    public static int GetAantalspionnen()
    {
        return aantalspionnen;
    }

    public static void SetAantalspionnen(int value)
    {
        aantalspionnen = value;
    }
}
