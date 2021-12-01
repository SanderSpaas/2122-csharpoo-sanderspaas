using System;

public class Speler
{
    private const String spelerNummer;
    private const String naam;
    private const KleurSpeler kleur;
    private const Rollen rol;
    private String locatie;
    public static List<Speler> spelerList = new ArrayList<>();


    public Speler(String spelerNummer, String naam, KleurSpeler kleur, Rollen rol, String locatie)
    {
        this.spelerNummer = spelerNummer;
        this.naam = naam;
        this.kleur = kleur;
        this.rol = rol;
        this.locatie = locatie;
    }
}
