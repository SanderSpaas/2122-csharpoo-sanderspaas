using System;

public class SpyfallMain
{
    public SpyfallMain()
    {

    }
    private int aantalspelers;
    private int aantalspionnen;
    private String locatie;

    public SpyfallMain(int aantalspelers, int aantalspionnen, string locatie)
    {
        this.aantalspelers = aantalspelers;
        this.aantalspionnen = aantalspionnen;
        this.locatie = locatie;
    }

    public int Aantalspelers { get; set; }
    public int Aantalspionnen { get; set; }

}
