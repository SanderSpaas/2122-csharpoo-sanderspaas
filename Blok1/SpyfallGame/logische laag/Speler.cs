using System;
using System.Collections;

public class Speler
{
    private String rol;
    private String locatie;
    private static int aantalspelers;
    private static int aantalspionnen;
    public static ArrayList Spelers = new ArrayList();

    public Speler(String rol, String locatie)
    {
        this.rol = rol;
        this.locatie = locatie;
    }

    public String Rol
    {
        get { return rol; }
        set { rol = value; }
    }

    public static void addSpeler(Speler speler)
    {
        Spelers.Add(speler);
    }
    public String GetRol()
    {
        return this.rol;
    }
    public String GetLocatie()
    {
        return this.locatie;
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
