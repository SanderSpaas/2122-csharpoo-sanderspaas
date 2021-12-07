using System.Collections;

public class Speler
{
    private string _Rol;
    private string _Locatie;
    private static int _Aantalspelers;
    private static int _Aantalspionnen;
    public static ArrayList Spelers = new ArrayList();

    public Speler(string rol, string locatie)
    {
        _Rol = rol;
        _Locatie = locatie;
    }

    public string Rol
    {
        get { return _Rol; }
        set { _Rol = value; }
    }

    public static void addSpeler(Speler speler)
    {
        Spelers.Add(speler);
    }
    public string GetRol()
    {
        return _Rol;
    }
    public string GetLocatie()
    {
        return _Locatie;
    }

    public static int GetAantalspelers()
    {
        return _Aantalspelers;
    }

    public static void SetAantalspelers(int value)
    {
        _Aantalspelers = value;
        try
        {
            if (value > 10)
            {
                throw new ArgumentException("Het aantal spelers kan niet groter dan 10 en niet kleiner dan 4 zijn");
            }
            if (value <= 4)
            {
                throw new ArgumentException("Het aantal spelers kan niet groter dan 10 en niet kleiner dan 4 zijn");
            }

        }
        finally { _Aantalspelers = value; };
    }

    public static int GetAantalspionnen()
    {
        return _Aantalspionnen;
    }

    public static void SetAantalspionnen(int value)
    {
        try
        {
            if (value == 0)
            {
                throw new ArgumentException("Het aantal spionnen kan niet 0 zijn");
            }
        }
        finally { _Aantalspionnen = value; };
    }
}
