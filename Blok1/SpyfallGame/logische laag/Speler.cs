using System;
using System.Collections;

public class Speler
{
    private String rol;
    private String locatie;
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

}
