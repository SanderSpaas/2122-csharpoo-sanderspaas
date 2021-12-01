using System;
using System.Collections;

public class Speler
{
    private String spelerNummer;
    private String naam;
    private Colors kleur;
    private Rollen rol;
    private String locatie;
    public static ArrayList Spelers = new ArrayList();


    public Speler(String spelerNummer, String naam, Colors kleur, Rollen rol, String locatie)
    {
        this.spelerNummer = spelerNummer;
        this.naam = naam;
        this.kleur = kleur;
        this.rol = rol;
        this.locatie = locatie;
    }

    public void addSpeler(Speler speler)
    {
        Spelers.Add (speler);
    }
}
