using System;

public class SpyfallMain
{
    public SpyfallMain()
    {

    }
    private static int aantalspelers;
    private static int aantalspionnen;

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
