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

    public static void addSpeler(Speler speler)
    {
        Spelers.Add (speler);
    }
    public String getRol()
    {
        return this.rol;
    }

}
